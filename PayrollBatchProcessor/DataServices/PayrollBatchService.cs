using System;
using System.Net.Http;
using System.Net.Http.Headers;
using PayrollBatchProcessor.Models;

namespace PayrollBatchProcessor.DataServices
{
    public class PayrollBatchService
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

        public PayrollBatch GetNext()
        {
            var response = _client.GetAsync($"ProcessPayroll/Next").Result;
            if (response.IsSuccessStatusCode)
            {
                var batch = response.Content.ReadAsAsync<PayrollBatch>().Result;
                return batch;
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

        public void Update(PayrollBatch batch)
        {
            var response = _client.PutAsJsonAsync($"PayrollBatches/{batch.PayrollBatchId}", batch).Result;
            if (response.IsSuccessStatusCode)
            {
                return;
            }
            throw new ApplicationException(response.ReasonPhrase);
        }


    }
}
