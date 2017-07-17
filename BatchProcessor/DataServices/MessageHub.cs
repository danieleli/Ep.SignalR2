using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;

namespace BatchProcessor.DataServices
{
    public class MessageHub
    {
        private const string HUB_NAME = "BatchUpdatedHub";
        private const string EVENT_NAME = "BatchUpdated";
        private const string HUB_URL = "http://localhost:8080/signalr";

        private bool _disposed = false;
        private IHubProxy _hubProxy;
        private HubConnection _connection;
        
        public event EventHandler ConnectionChanged;

        public bool IsConnected { get; private set; }

        public MessageHub()
        {
            IsConnected = false;
        }

        public async void ConnectAsync()
        {
            InitializeConnection();
            SetupProxy();

            try
            {
                await _connection.Start();
                OnConnectionChanged(true);
            }
            catch (HttpRequestException)
            {
                OnConnectionChanged(false);
                throw;
            }
        }

        public void UpdateBatchStatus(int id, string status)
        {
            _hubProxy.Invoke("UpdatePayrollBatchStatus", id, status);
        }

        private void InitializeConnection()
        {
            _connection = new HubConnection(HUB_URL);
            _connection.Closed += Connection_Closed;
            _disposed = false;
        }

        private void SetupProxy()
        {
            _hubProxy = _connection.CreateHubProxy(HUB_NAME);
            _hubProxy.On<int, string>(EVENT_NAME, (id, status) =>
                Console.WriteLine($"Batch {id} status updated to: {status}")
            );
        }



        protected virtual void OnConnectionChanged(bool isConnected)
        {
            IsConnected = isConnected;
            if (ConnectionChanged != null)
                ConnectionChanged(this, new EventArgs());
        }

        private void Connection_Closed()
        {
            OnConnectionChanged(false);
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

                _disposed = true;
            }
        }
    }
}
