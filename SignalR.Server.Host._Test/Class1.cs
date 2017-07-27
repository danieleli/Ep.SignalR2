using NUnit.Framework;
using SignalR.Server.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Server.Host._Test
{
    [TestFixture]
    public class HubLoggerFixture
    {
        [Test]
        public void Log()
        {
            // arrange
            var logger = new HubLogger();
            var mainForm = new MainForm(logger);

            // act


            // assert
        }
    }
}
