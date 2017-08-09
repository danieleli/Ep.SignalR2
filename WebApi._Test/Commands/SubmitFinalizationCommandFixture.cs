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
            var batchId = 5;
            var cmd = new SubmitFinalizationCommand();

            // act
            cmd.Submit(batchId);

            // assert
        }

    }
}
