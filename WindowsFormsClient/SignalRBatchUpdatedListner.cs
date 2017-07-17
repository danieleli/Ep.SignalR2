using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClient
{
    
    public class SignalRBatchUpdatedListner : BatchUpdatedListner, IDisposable
    {
        private const string HUB_NAME = "BatchUpdatedHub";
        private const string EVENT_NAME = "BatchUpdated";

        private bool _disposed = false;
        private IHubProxy _hubProxy;
        private HubConnection _connection;
        private ISignalRConfig _config;

        public event EventHandler ConnectionChanged;

        public bool IsConnected { get; private set; }

        public SignalRBatchUpdatedListner(ISignalRConfig config)
        {
            _config = config;
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

        private void InitializeConnection()
        {
            var serverURI = _config.GetSignalRUri();
            if (_connection != null)
            {
                if (_connection.State != ConnectionState.Disconnected)
                {
                    _connection.Stop();
                }
                _connection.Dispose();
            }

            
            _connection = new HubConnection(serverURI);
            _connection.Closed += Connection_Closed;
            _disposed = false;
        }

        private void SetupProxy()
        {
            _hubProxy = _connection.CreateHubProxy(HUB_NAME);
            _hubProxy.On<int, string>(EVENT_NAME, (id, status) =>
                base.UpdateBatch(id, status)
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