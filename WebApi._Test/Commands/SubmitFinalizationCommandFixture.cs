using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Commands;

namespace WebApi._Test.Commands
{
    [TestFixture]
    public class SubmitFinalizationCommandFixture
    {
        [Test]
        public void Send()
        {
            // arrange
            var batchId = 6;
            var cmd = new SubmitFinalizationCommand();

            // act
            cmd.Submit(batchId);

            // assert
        }

        [Test]
        public void SendMany()
        {
            // arrange
            
            var cmd = new SubmitFinalizationCommand();

            // act
            for (int i = 0; i < 12; i++)
            {
                var batchId = i;
                cmd.Submit(batchId);
            }
            

            // assert
        }

    }
}
