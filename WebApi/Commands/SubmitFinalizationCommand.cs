using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WebApi.Commands
{

    public struct SubmitFinalizationMessage
    {
        public int BatcthId;
    }

    public class SubmitFinalizationCommand
    {
        private const string EXCHANGE_NAME = "";
        private const string QUEUE_NAME = "FinalizeBatchQueue";
        private const string RABBIT_HOST = "localhost";

        public void Submit(int batchId)
        {
            var factory = new ConnectionFactory() { HostName = RABBIT_HOST };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: QUEUE_NAME,
                                     durable: true,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var message = new SubmitFinalizationMessage {BatcthId = batchId};

                var properties = channel.CreateBasicProperties();
                properties.Persistent = true;

                channel.BasicPublish(exchange: EXCHANGE_NAME,
                                     routingKey: QUEUE_NAME,
                                     basicProperties: properties,
                                     body: message.ToJson().GetBytes());

                Console.WriteLine(" [x] Sent {0}", message.ToJson());
            }
        }
    }

    public static class JsonExtensions
    {
        public static string ToJson(this object o)
        {
            return JsonConvert.SerializeObject(o);
        }
    }

    public static class StringExtensions
    {
        public static Byte[] GetBytes(this string s)
        {
            return Encoding.UTF8.GetBytes(s);
        }
    }
}