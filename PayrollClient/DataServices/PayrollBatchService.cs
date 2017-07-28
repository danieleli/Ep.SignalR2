using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using PayrollClient.Models;

namespace PayrollClient.DataServices
{
    public interface IPayrollBatchService
    {
        IList<PayrollBatch> GetBatches();
        void UpdateStatus(int id, string status);
        void SubmitBatch(int id);
    }

    public class PayrollBatchService : IPayrollBatchService
    {
        private static HttpClient _client = null;

        public PayrollBatchService()
        {
            if (_client == null)
            {
                _client=GetClient();
            }
        }

        private static HttpClient GetClient()
        {
            var c = new HttpClient()
            {
                BaseAddress = new Uri(@"http://localhost:1765/api/")
            };
            c.DefaultRequestHeaders.Accept.Clear();
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return c;
        }

        public IList<PayrollBatch> GetBatches()
        {
            var response = _client.GetAsync("PayrollBatches").Result;
            if (response.IsSuccessStatusCode)
            {
                var batches = response.Content.ReadAsAsync<List<PayrollBatch>>().Result;
                return batches;
            }

            return null;
        }

        public void UpdateStatus(int id, string status)
        {
            var response = _client.PostAsJsonAsync($"ProcessPayroll/UpdateStatus/{id}?status={status}", id).Result;

            if (response.IsSuccessStatusCode)
            {
                return;
            }
            throw new ApplicationException(response.ReasonPhrase);
        }

        public void SubmitBatch(int id)
        {
          UpdateStatus(id, "Submitted");
        }


    }
}
