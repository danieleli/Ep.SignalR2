using System;
using System.Windows.Forms;
using Ninject;
using SignalR.Server.Host.DependencyInjection;

namespace SignalR.Server.Host
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var kernel = KernelFactory.GetKernel();
            Application.Run(kernel.Get<MainForm>());
        }
    }
}
