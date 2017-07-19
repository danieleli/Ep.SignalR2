using System;

namespace PayrollClient.Notifications
{
    public interface IBatchUpdatedNotifier
    {
        event EventHandler<BatchUpdatedEventArgs> BatchUpdated;
    }
}