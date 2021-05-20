using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfChecker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0 && args[0].Contains("StartTests"))
            {                
                Application.Run(new PerfChecker(args[0].ToString()));             
            }
            else
            {
                SplashForm.ShowSplashScreen();
                Application.Run(new PerfChecker("normal"));
            }           
        }
    }
}
