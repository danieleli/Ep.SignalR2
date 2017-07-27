using System;
using System.Windows.Forms;
using Ninject;
using SignalR.Server.Hubs;

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

    public class KernelFactory
    {
        private static StandardKernel _kernel;

        public static StandardKernel GetKernel()
        {
            _kernel = _kernel ?? CreateKernel();

            return _kernel;
        }

        private static StandardKernel CreateKernel()
        {
            var k = new StandardKernel();

            k.Bind<IHubLogger>().To<HubLogger>().InSingletonScope();
            k.Bind<MainForm>().To<MainForm>();

            return k;
        }

    }
}
