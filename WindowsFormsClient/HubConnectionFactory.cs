using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;

namespace WinFormsClient
{
    public interface IHubConnectionFactory
    {
        HubConnection Create();
    }


    public class HubConnectionFactory : IHubConnectionFactory
    {
        private readonly string _serverUrl;

        public HubConnectionFactory(string serverUrl)
        {
            _serverUrl = serverUrl;
        }

        public HubConnectionFactory(ISignalRConfig config)
        {
            _serverUrl = config.GetSignalRUri();
        }

        public HubConnection Create()
        {
            return new HubConnection(_serverUrl);
        }
    }
}
