using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;

namespace RabbitMQ.Worker._Test
{
    [TestFixture]
    public class PayrollBatchWorkerFixture
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [Test]
        public void First()
        {
            // arrange
            var cmd = new TestCommand();
            using (var worker = new RabbitAsyncListner(cmd))
            {
                // act
                worker.Start();

                Thread.Sleep(3000);

                worker.Stop();

                Thread.Sleep(3000);

            }

            for (int i = 0; i < 3; i++)
            {
                _log.Debug("waiting");
                Thread.Sleep(1000);
            }

            Assert.That(true, Is.True);
        }
    }

    public class TestCommand : ICommand<string>
    {

        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void Execute(string input)
        {
            _log.Info(" [x] Message: " + input);

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(100);
                _log.Info(" Working on message.");
            }

            _log.Info(" [x] Done");
        }
    }
}
