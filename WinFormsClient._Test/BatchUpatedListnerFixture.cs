using NUnit.Framework;

namespace WinFormsClient._Test
{
    [TestFixture]
    public class BatchUpatedListnerFixture
    {
        [Test]
        public void First()
        {
            var listner = new BatchUpdatedListner();
            BatchUpdatedEventArgs returnArgs = null;
            listner.BatchUpdated += delegate(object o, BatchUpdatedEventArgs args)
            {
                returnArgs = args;
            };

            var batchId = 1234;
            var batchStatus = "Pending";

            listner.UpdateBatch(batchId,batchStatus);
            Assert.That(returnArgs.BatchId, Is.EqualTo(batchId));
            Assert.That(returnArgs.BatchStatus, Is.EqualTo(batchStatus));
        }
    }


}
