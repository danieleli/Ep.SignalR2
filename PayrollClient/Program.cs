using System;
using System.Windows.Forms;
using PayrollClient.Ninject;
using Ninject;

namespace PayrollClient
{
    static class Program
    {
        public const string SERVER_URL = "http://localhost:8080/signalr";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var f = GetStartForm();
            Application.Run(f);
        }

        private static Form GetStartForm()
        {
            return new BatchesForm();
            
            var k = KernelFactory.GetKernel();
            var mainForm = k.Get<MainForm>();
            return mainForm;
        }
    }
}
