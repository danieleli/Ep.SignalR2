﻿using Microsoft.AspNet.SignalR.Client;
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
        private const string HUB_NAME = "PayrollHub";
        private const string EVENT_NAME = "BatchUpdated";

        private bool _disposed = false;
        private IHubProxy _hubProxy;
        private HubConnection _connection;
        private readonly IHubConnectionFactory _connectionFactory;

        
        public SignalRBatchUpdatedListner(IHubConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async void ConnectAsync()
        {
            _connection = _connectionFactory.Create();
            _hubProxy = _connection.CreateHubProxy(HUB_NAME);

            _hubProxy.On<int, string>(EVENT_NAME, (id, status) =>
                base.UpdateBatch(id, status)
            );
            
            await _connection.Start();
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

                if (this.ConnectionChanged != null)
                {
                    try
                    {

                        var list = this.ConnectionChanged.GetInvocationList();
                        foreach (var del in list)
                        {
                            this.ConnectionChanged -= (EventHandler) del;
                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }

                _disposed = true;
            }
        }
   }
}