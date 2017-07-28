using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollClient.Ninject;
using PayrollClient.Notifications;
using Ninject;

namespace PayrollClient
{
    static class Program
    {
        public const string SERVER_URL = "http://localhost:8080/signalr";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //var k = KernelFactory.GetKernel();
            //var mainForm = k.Get<MainForm>();
            Application.Run(new BatchesForm());
        }
    }
}
