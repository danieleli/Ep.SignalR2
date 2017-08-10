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
            using (var listner = new RabbitAsyncListner(cmd))
            {
                // act
                listner.Start();

                Thread.Sleep(3000);

                listner.Stop();

                Thread.Sleep(3000);

            }

            for (int i = 0; i < 3; i++)
            {
                _log.Debug("waiting");
                Thread.Sleep(1000);
            }

            Assert.That(true, Is.True);
        }

        [Test]
        public void AckTest()
        {
            // arrange
            var cmd1 = new TestCommand("Cmd1", 1);
            var cmd2 = new TestCommand("Cmd2", 5);
            using (var listner1 = new RabbitAsyncListner(cmd1))
            using (var listner2 = new RabbitAsyncListner(cmd2))
            {
                // act
                listner1.Start();
                listner2.Start();

                for (int i = 0; i < 50; i++)
                {
                   // _log.Debug("waiting");
                    Thread.Sleep(500);
                }


            }
        }

        [Test]
        public void AckTestWithDroppedListner()
        {
            // arrange
            var cmd1 = new TestCommand("Cmd1", 1);
            var cmd2 = new TestCommand("Cmd2", 5);
            using (var listner1 = new RabbitAsyncListner(cmd1))
            using (var listner2 = new RabbitAsyncListner(cmd2))
            {
                // act
                listner1.Start();
                listner2.Start();

                for (int i = 0; i < 5; i++)
                {
                    // _log.Debug("waiting");
                    Thread.Sleep(500);
                }

                listner2.Stop();
                listner2.Dispose();

                Thread.Sleep(20000);
            }
        }
    }

    public class TestCommand : ICommand<string>
    {
        private readonly string _name;
        private readonly int _workSeconds;

        public TestCommand(string name = null, int workSeconds = 2)
        {
            _name = name;
            _workSeconds = workSeconds;
        }

        public void Execute(string input)
        {
            
            for (int i = 0; i < _workSeconds * 5; i++)
            {
                Thread.Sleep(200);
                _log.InfoFormat("{0} WORKING - {1}", _name, input);
            }

            _log.InfoFormat("{0} COMPLETE - {1}", _name, input);
        }

        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    }
}
