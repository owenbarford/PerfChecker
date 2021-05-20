using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfChecker
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            txtBoxHelpDesc.AppendText("Performance Checker is a program designed to test the performance of a particular environment");
            txtBoxHelpDesc.AppendText(" by performing an asynchronous set of sorting methods across an array of a specified size.");
            txtBoxHelpDesc.AppendText(" A single instance of Performance Checker will stream the results of the sorting methods");
            txtBoxHelpDesc.AppendText(" to the text box on the right of the program screen. The default value of the array size");
            txtBoxHelpDesc.AppendText(" is 1000 but this can be altered to either increase or reduce the time taken to perform the test.");
            txtBoxHelpDesc.AppendText(Environment.NewLine + Environment.NewLine);
            txtBoxHelpDesc.AppendText("Performance Checker also displays system information of the enviroment in which it is running.");
            txtBoxHelpDesc.AppendText(Environment.NewLine + Environment.NewLine);
            txtBoxHelpDesc.AppendText("In its default configuration Performance Checker will run for a couple of minutes in a performant");
            txtBoxHelpDesc.AppendText(" environment and will generate around a 20% load on the processor during this time.");
            txtBoxHelpDesc.AppendText(Environment.NewLine + Environment.NewLine);
            txtBoxHelpDesc.AppendText("Multiple instances of Performance Checker can be run at the same time but this will increase the time");
            txtBoxHelpDesc.AppendText(" taken to perform the test and will divide the single process impact by the number of Performance");
            txtBoxHelpDesc.AppendText(" Checker processes executed concurrently. It is therefore recommended that the test be performed");
            txtBoxHelpDesc.AppendText(" with only a single instance of Performance Checker utilised for the purpose of testing an environment.");
            txtBoxHelpDesc.AppendText(Environment.NewLine + Environment.NewLine);
            txtBoxHelpDesc.AppendText("Performance Checker can also be launched using the argument StartTests. For example:");
            txtBoxHelpDesc.AppendText(Environment.NewLine + Environment.NewLine);
            txtBoxHelpDesc.AppendText(" PerfChecker.exe StartTests");
            txtBoxHelpDesc.AppendText(Environment.NewLine + Environment.NewLine);
            txtBoxHelpDesc.AppendText("which will launch the program and start the test immediately. This is useful if wishing to launch");
            txtBoxHelpDesc.AppendText(" the program with the default 1000 array size.");
            txtBoxHelpDesc.ReadOnly = true;            
        }
    }
}
