using System;
using Ninject.Activation;
using PayrollClient.Notifications;

namespace PayrollClient.Ninject
{
    internal class NotifierProvider : Provider<IBatchUpdatedNotifier>
    {
        protected override IBatchUpdatedNotifier CreateInstance(IContext context)
        {
            var connectionFactory = new HubConnectionFactory(Program.SERVER_URL);
            var listner           = new SignalRBatchUpdatedListner(connectionFactory);
            return listner;
        }
    }
}