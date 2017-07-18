using System;
using System.Reflection;
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

        [Test(Description = "Manual test.  Requires manually running WinFormsServer.exe")]
        public void BatchUpdatedListner()
        {
            var conn = new HubConnection(SERVER_URI);
            var proxy = conn.CreateHubProxy(HUB_NAME);
            var eventName = "BatchUpdated";
            var eventHeard = false;
            
            proxy.On<int, string>(eventName, (id, status) =>
            {
                _log.Debug($"Proxy.On listner delegate. EventName: {eventName}, ID: {id}, Status: {status}");
                eventHeard = true;
            });
           
            StartConnection(conn);

            _log.Debug($"proxy.Invoke({HUB_NAME}, 1, somestatus)");
            proxy.Invoke(eventName, 1, "somestatus");

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(10);
                Console.WriteLine($"waiting to hear event. {i}");
                if (eventHeard) return;
            }

            Assert.Fail("Event not fired");
            
        }

        private static void StartConnection(HubConnection conn)
        {
            var task = conn.Start();
            var counter = 0;
            while (!task.IsCompleted)
            {
                counter++;
                Thread.Sleep(100);
                _log.Debug($"waiting for connection.start...{counter}");
            }
        }

        private static readonly ILog _log = LogManager.GetLogger(typeof(PayrollHubFixture));

    }
}
