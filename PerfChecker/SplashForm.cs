using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfChecker
{
    public partial class SplashForm : Form
    {
        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static SplashForm splashForm;

        static public void ShowSplashScreen()
        {
            // Make sure it is only launched once.    
            if (splashForm != null) return;
            splashForm = new SplashForm
            {
                MaximizeBox = false,
                MinimizeBox = false,
                ControlBox = false,
                ShowIcon = false,
                StartPosition = FormStartPosition.CenterScreen,
                Size = new Size(200, 75)
            };
            Label lbl = new Label
            {
                Size = new Size(100, 50),
                Name = "lblSplashScreen",
                Text = "Loading PerfChecker...",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.None,
                Width = splashForm.Width                
            };

            splashForm.Controls.Add(lbl);            

            Thread thread = new Thread(new ThreadStart(ShowForm))
            {
                IsBackground = true
            };
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            if (splashForm != null) Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm?.Invoke(new CloseDelegate(CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            if (splashForm != null)
            {
                splashForm.Close();
                splashForm = null;
            };
        }
    }
}
