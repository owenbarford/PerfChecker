using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfChecker
{
    public partial class PerfChecker : Form
    {
        public PerfChecker(string start)
        {
            InitializeComponent();
            txtBoxSystemInfo.Text = SystemInfo.AllSysInfo();
            SystemInfo.OnOutputResults += SystemInfo_OnOutputResults;
            test.sorting.OnResults += Sorting_OnResults;
            SystemInfo.CancelT += SystemInfo_CancelT;
            txtBoxArraySize.Text = "1000";
            if (start == "StartTests")
            {
                btn_Execute_Click(new object(), new EventArgs());
            }
            else
            {
                SplashForm.CloseForm();                
            }
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Sorting_OnResults(string result)
        {
            txtBoxConsoleOutput.Invoke((Action)delegate
            {
                txtBoxConsoleOutput.AppendText(result);
                HelperClass.Wait(1);
            });
        }

        private void SystemInfo_OnOutputResults(string timeTaken, long totalCPUTicksUsed)
        {
            txtBoxTimeTaken.Text = timeTaken;
            txtBoxCpuTicks.Text = Convert.ToString(totalCPUTicksUsed);
            EnableFormControls();
        }

        private void SystemInfo_CancelT()
        {
            EnableFormControls();
            ResetForm();
        }

        public void EnableFormControls()
        {
            grpBoxPerfChecker.Enabled = true;
            btn_Execute.Enabled = true;
            Application.UseWaitCursor = false;
            txtBoxEndTime.Text = DateTime.Now.ToString();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtBoxArraySize.Text) && HelperClass.IsNumeric(txtBoxArraySize.Text))
                {
                    if (grpBoxPerfChecker.Enabled == true)
                    {
                        grpBoxPerfChecker.Enabled = false;
                    }
                    Application.UseWaitCursor = true;
                    btn_Execute.Enabled = false;
                    ResetForm();
                    txtBoxStartTime.Text = DateTime.Now.ToString();

                    SystemInfo.RunTests(Convert.ToInt32(txtBoxArraySize.Text));
                }
                else
                {
                    MessageBox.Show("Please enter a valid value for Array Size", VariablesAndConstants.strAppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ResetForm()
        {
            txtBoxStartTime.Text = "";
            txtBoxEndTime.Text = "";
            txtBoxConsoleOutput.Text = "";
            txtBoxTimeTaken.Text = "";
            txtBoxCpuTicks.Text = "";           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(!grpBoxPerfChecker.Enabled)
            {
                SystemInfo.CancelTask();
            }            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help helpForm = new Help();
            helpForm.Show();
        }

        private void lblTimeTaken_Click(object sender, EventArgs e)
        {

        }
    }
}
