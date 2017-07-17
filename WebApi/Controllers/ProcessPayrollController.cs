using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;
using WebApi.Models.Dal;

namespace WebApi.Controllers
{
    public class ProcessPayrollController : ApiController
    {
        private PayrollContext db = new PayrollContext();
        
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPayrollBatch(int id)
        {
            var payrollBatch = await db.PayrollBatches.FindAsync(id);
            if (payrollBatch == null)
            {
                return NotFound();
            }
            payrollBatch.Status = "Submitted";
            
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PayrollBatchExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool PayrollBatchExists(int id)
        {
            return db.PayrollBatches.Count(e => e.PayrollBatchId == id) > 0;
        }
    }
}
