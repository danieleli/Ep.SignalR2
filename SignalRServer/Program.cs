using System;
using System.Windows.Forms;

namespace SignalRServer
{
    public static class Program
    {
        internal static MainForm MainForm { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();
            Application.Run(MainForm);
        }
    }
}
