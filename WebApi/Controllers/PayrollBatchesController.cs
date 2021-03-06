﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;
using WebApi.Models.Dal;

namespace WebApi.Controllers
{
    public class PayrollBatchesController : ApiController
    {
        private PayrollContext db = new PayrollContext();

        // GET: api/PayrollBatches
        public IList<PayrollBatch> GetPayrollBatches()
        {
            return db.PayrollBatches.ToList();
        }

        // GET: api/PayrollBatches/5
        [ResponseType(typeof(PayrollBatch))]
        public async Task<IHttpActionResult> GetPayrollBatch(int id)
        {
            PayrollBatch payrollBatch = await db.PayrollBatches.FindAsync(id);
            if (payrollBatch == null)
            {
                return NotFound();
            }

            return Ok(payrollBatch);
        }

        // PUT: api/PayrollBatches/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPayrollBatch(int id, PayrollBatch payrollBatch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != payrollBatch.PayrollBatchId)
            {
                return BadRequest();
            }

            db.Entry(payrollBatch).State = EntityState.Modified;

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

        // POST: api/PayrollBatches
        [ResponseType(typeof(PayrollBatch))]
        public async Task<IHttpActionResult> PostPayrollBatch(PayrollBatch payrollBatch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PayrollBatches.Add(payrollBatch);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = payrollBatch.PayrollBatchId }, payrollBatch);
        }

        // DELETE: api/PayrollBatches/5
        [ResponseType(typeof(PayrollBatch))]
        public async Task<IHttpActionResult> DeletePayrollBatch(int id)
        {
            PayrollBatch payrollBatch = await db.PayrollBatches.FindAsync(id);
            if (payrollBatch == null)
            {
                return NotFound();
            }

            db.PayrollBatches.Remove(payrollBatch);
            await db.SaveChangesAsync();

            return Ok(payrollBatch);
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