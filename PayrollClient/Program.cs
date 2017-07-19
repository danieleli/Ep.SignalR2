using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollClient.Notifications;

namespace PayrollClient
{
    static class Program
    {
        const string SERVER_URL = "http://localhost:8080/signalr";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var connectionFactory = new HubConnectionFactory(SERVER_URL);
            var listner = new SignalRBatchUpdatedListner(connectionFactory);

            Application.Run(new Main(listner));
        }
    }
}
