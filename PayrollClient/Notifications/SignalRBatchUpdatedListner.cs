using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;

namespace PayrollClient.Notifications
{
    public class SignalRBatchUpdatedListner : IDisposable, IBatchUpdatedNotifier
    {
        public event EventHandler<BatchUpdatedEventArgs> BatchUpdated;
        
        private const string HUB_NAME = "PayrollHub";
        private const string EVENT_NAME = "BatchUpdated";

        private bool _disposed = false;
        private IHubProxy _hubProxy;
        private HubConnection _connection;
        private readonly IHubConnectionFactory _connectionFactory;

        
        public SignalRBatchUpdatedListner(IHubConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            Task.Run(() => ConnectAsync());
        }

        public async void ConnectAsync()
        {
            _connection = _connectionFactory.Create();
            _hubProxy = _connection.CreateHubProxy(HUB_NAME);

            _hubProxy.On<int, string>(EVENT_NAME, UpdateBatch);

            await _connection.Start();
        }
        

        public void UpdateBatch(int batchId, string status)
        {
            var args = new BatchUpdatedEventArgs()
            {
                BatchId = batchId,
                BatchStatus = status
            };

            OnBatchUpdated(args);
        }

        protected virtual void OnBatchUpdated(BatchUpdatedEventArgs e)
        {
            BatchUpdated?.Invoke(this, e);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && !_disposed)
            {
                if (_connection != null)
                {
                    try
                    {
                        _connection.Stop();
                    }
                    finally
                    {
                        _connection.Dispose();
                    }
                }
            }
        }
   }
}