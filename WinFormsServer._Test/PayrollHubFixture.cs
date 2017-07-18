using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNet.SignalR.Client;
using NUnit.Framework;

namespace WinFormsServer._Test
{
    [TestFixture]
    public class PayrollHubFixture
    {
        private const string SERVER_URI = "http://localhost:8080";
        private const string HUB_NAME = "PayrollHub";

        [Test]
        public void Logging()
        {
            _log.Debug("test");
        }

        [Test]
        public void BatchUpdatedListner()
        {
            var conn = new HubConnection(SERVER_URI);
            var proxy = conn.CreateHubProxy(HUB_NAME);
            var eventName = "BatchUpdated";
            
            proxy.On<int, string>(eventName, (id, status) =>
            {
                Console.WriteLine($"ID: {id}, Status: {status}");
            });
           
            var task = conn.Start();
            while (!task.IsCompleted)
            {
                Thread.Sleep(100);
                Console.WriteLine("Sleep..");
            }

            proxy.Invoke(eventName, 1, "somestatus");
            proxy.Invoke(eventName, 2, "other");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(10);
                Console.WriteLine($"wait {i}");
            }
            
        }

        private static readonly ILog _log = LogManager.GetLogger(typeof(PayrollHubFixture));

    }


}
