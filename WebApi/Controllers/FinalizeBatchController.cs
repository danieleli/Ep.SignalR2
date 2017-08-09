using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Commands;
using WebApi.Models;
using WebApi.Models.Dal;

namespace WebApi.Controllers
{
    public class FinalizeBatchController : ApiController
    {
        private PayrollContext db = new PayrollContext();
        



        // PUT: api/FinalizeBatch/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPayrollBatch(int id)
        {
            try
            {
                UpdateStatus(id, "NeedsFinalization");
            }
            catch (ObjectNotFoundException)
            {
                return NotFound();
            }
            
        
            var cmd = new SubmitFinalizationCommand();
            cmd.Submit(id);

            return StatusCode(HttpStatusCode.NoContent);
        }

        private void UpdateStatus(int id, string status)
        {
            var batch = db.PayrollBatches.Find(id);
            if (id != batch.PayrollBatchId)
            {
                throw new ObjectNotFoundException();
            }

            batch.Status = status;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PayrollBatchExists(id))
                {
                    throw new ObjectNotFoundException();
                }
                else
                {
                    throw;
                }
            }
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PayrollBatchExists(int id)
        {
            return db.PayrollBatches.Count(e => e.PayrollBatchId == id) > 0;
        }
    }
}