using System;
using System.Reflection;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using log4net;
using System.Threading.Tasks;


public class RabbitAsyncListner : IDisposable
{
    private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    private const string EXCHANGE_NAME = "";
    private const string QUEUE_NAME = "FinalizeBatchQueue";
    private const string RABBIT_HOST = "localhost";
    
    private bool isDisposed = false;
    private IModel _channel;
    private EventingBasicConsumer _consumer;
    private IConnection _connection;
    private readonly ICommand<string> _command;

    public WorkerStatus Status { get; private set; } = WorkerStatus.Initial;

    public RabbitAsyncListner(ICommand<string> command)
    {
        _command = command;
    }

    public void Start()
    {
        _log.Debug("Starting main thread.");
        var t = new Task(() => this.Initialize());
        t.Start();
    }
    
    private void Initialize()
    {
        SetStatus(WorkerStatus.Starting);

        var factory = new ConnectionFactory() {HostName = RABBIT_HOST};
        _connection = factory.CreateConnection();
        _channel = CreateChannel(_connection, QUEUE_NAME);
        _consumer = new EventingBasicConsumer(_channel);
        _consumer.Received += ConsumerOnReceived;
        _channel.BasicConsume(queue: QUEUE_NAME, autoAck: false, consumer: _consumer);

        SetStatus(WorkerStatus.Started); 
    }

    public void Stop()
    {
        if (Status == WorkerStatus.Started)
        {
            try
            {
                SetStatus(WorkerStatus.Stopping);

                _channel.Close();
                _consumer.Received -= ConsumerOnReceived;
                _connection.Close();

                SetStatus(WorkerStatus.Stopped);
            }
            catch (Exception e)
            {
                _log.Error("Invalid attempt to stop listner.", e);
                throw;
            }
        }
    }

    private void ConsumerOnReceived(object sender, BasicDeliverEventArgs args)
    {
        var body = args.Body;
        var message = Encoding.UTF8.GetString(body);

        _command.Execute(message);
        
        _channel.BasicAck(deliveryTag: args.DeliveryTag, multiple: false);
    }
    
    private static IModel CreateChannel(IConnection connection, string queueName)
    {
        var channel = connection.CreateModel();

        channel.QueueDeclare(queue: queueName,
            durable: true,
            exclusive: false,
            autoDelete: false,
            arguments: null);

        channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

        return channel;
    }

    private void SetStatus(WorkerStatus status)
    {
        this.Status = status;
        _log.Info("Status: " + status.ToString());
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!isDisposed)
        {
            if (disposing)
            {
                _log.Debug("Disposing");
                try
                {
                    this.Stop();
                }
                catch
                {
                    // no action in dispose
                }

                if(_channel != null) _channel.Dispose();
                if(_connection != null) _connection.Dispose();
            }

            isDisposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
    }

}