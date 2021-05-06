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
        public PerfChecker()
        {
            InitializeComponent();
            txtBoxSystemInfo.Text = SystemInfo.AllSysInfo();
            SystemInfo.OnOutputResults += SystemInfo_OnOutputResults;
        }

        private void SystemInfo_OnOutputResults(string timeTaken, long totalCPUTicksUsed, string resultsOutput)
        {
            txtBoxTimeTaken.Text = timeTaken;
            txtBoxCpuTicks.Text = Convert.ToString(totalCPUTicksUsed);
            txtBoxConsoleOutput.Text = resultsOutput;
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            if (grpBoxPerfChecker.Enabled == true)
            {
                grpBoxPerfChecker.Enabled = false;
            }
            Application.UseWaitCursor = true;
            btn_Execute.Enabled = false;
            ResetForm();
            txtBoxStartTime.Text = DateTime.Now.ToString();

            //TextWriter _writer = new ControlWriter(txtBoxConsoleOutput);
            //Console.SetOut(_writer);
            SystemInfo.RunTests();

            grpBoxPerfChecker.Enabled = true;
            btn_Execute.Enabled = true;
            Application.UseWaitCursor = false;
            txtBoxEndTime.Text = DateTime.Now.ToString();


            //if (backgroundWorkerPerfChecker.IsBusy != true)
            //{
            //    // Start the asynchronous operation.
            //    backgroundWorkerPerfChecker.RunWorkerAsync();
            //}           
        }

        private void ResetForm()
        {
            txtBoxStartTime.Text = "";
            txtBoxEndTime.Text = "";
            txtBoxConsoleOutput.Text = "";
            txtBoxTimeTaken.Text = "";
            txtBoxCpuTicks.Text = "";
        }

        //    private void backgroundWorkerPerfChecker_DoWork(object sender, DoWorkEventArgs e)
        //    {
        //        BackgroundWorker worker = sender as BackgroundWorker;

        //        for (int i = 1; i <= 10; i++)
        //        {
        //            if (worker.CancellationPending == true)
        //            {
        //                e.Cancel = true;
        //                break;
        //            }
        //            else
        //            {
        //                // Perform a time consuming operation and report progress.
        //                Thread.Sleep(500);
        //                //TextWriter _writer = new ControlWriter(txtBoxConsoleOutput);
        //                //Console.SetOut(_writer);
        //                AppendTextBox("Oops...");                    

        //                (string timeTaken, long totalCPUTicksUsed) t1 = SystemInfo.RunTests();                    
        //                //txtBoxTimeTaken.Text = t1.timeTaken;
        //                //txtBoxCpuTicks.Text = t1.totalCPUTicksUsed.ToString();
        //                worker.ReportProgress(i * 10);
        //            }
        //        }
        //    }

        //    public void AppendTextBox(string value)
        //    {
        //        if (InvokeRequired)
        //        {
        //            BeginInvoke(new Action<string>(AppendTextBox), new object[] { value });
        //            return;
        //        }
        //        txtBoxConsoleOutput.Text += value;
        //    }

        //    private void backgroundWorkerPerfChecker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //    {
        //        resultLabel.Text = (e.ProgressPercentage.ToString() + "%");            
        //    }

        //    private void backgroundWorkerPerfChecker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //    {
        //        if (e.Cancelled == true)
        //        {
        //            resultLabel.Text = "Cancelled!";
        //        }
        //        else if (e.Error != null)
        //        {
        //            resultLabel.Text = "Error: " + e.Error.Message;
        //        }
        //        else
        //        {
        //            resultLabel.Text = "Done!";
        //        }
        //        grpBoxPerfChecker.Enabled = true;
        //        btn_Execute.Enabled = true;
        //        Application.UseWaitCursor = false;
        //        txtBoxEndTime.Text = DateTime.Now.ToString();
        //    }

        //    private void btnCancel_Click(object sender, EventArgs e)
        //    {
        //        try
        //        {
        //            btn_Execute.Enabled = true;
        //            if (backgroundWorkerPerfChecker.WorkerSupportsCancellation == true)
        //            {
        //                backgroundWorkerPerfChecker.CancelAsync();
        //            }                
        //            grpBoxPerfChecker.Enabled = true;                
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString(), VariablesAndConstants.strAppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SystemInfo.CancelTack();
        }
    }
}
