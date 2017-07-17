using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollClient
{
    public partial class Main : Form
    {
        private HttpClient _client;

        public Main()
        {
            InitializeComponent();
            _client = new HttpClient()
            {
                BaseAddress = new Uri(@"http://localhost:1765/")
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        private void ButtonGetBatches_Click(object sender, EventArgs e)
        {
            var response =  _client.GetAsync("api/PayrollBatches").Result;
            if (response.IsSuccessStatusCode)
            {
                Listdynamic> rtn  =  response.Content.ReadAsAsync<object>().Result;
                Console.WriteLine(rtn);
            }
        }

        private void ButtonSubmitBatch_Click(object sender, EventArgs e)
        {

        }
    }
}
