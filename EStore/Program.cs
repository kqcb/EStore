using EStore.Auth;
using System;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace EStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["language"]);             
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["language"]);             
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}