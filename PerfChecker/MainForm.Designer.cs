
namespace PerfChecker
{
    partial class PerfChecker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Execute = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.grpBoxPerfChecker = new System.Windows.Forms.GroupBox();
            this.txtBoxCpuTicks = new System.Windows.Forms.TextBox();
            this.lblCpuTicks = new System.Windows.Forms.Label();
            this.txtBoxTimeTaken = new System.Windows.Forms.TextBox();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.txtBoxEndTime = new System.Windows.Forms.TextBox();
            this.txtBoxStartTime = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.txtBoxConsoleOutput = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBoxSystemInfo = new System.Windows.Forms.GroupBox();
            this.txtBoxSystemInfo = new System.Windows.Forms.TextBox();
            this.backgroundWorkerPerfChecker = new System.ComponentModel.BackgroundWorker();
            this.resultLabel = new System.Windows.Forms.Label();
            this.grpBoxPerfChecker.SuspendLayout();
            this.grpBoxSystemInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Execute
            // 
            this.btn_Execute.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Execute.Location = new System.Drawing.Point(154, 411);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(103, 23);
            this.btn_Execute.TabIndex = 10;
            this.btn_Execute.Text = "Execute Test";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(9, 30);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 13);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start Time:";
            // 
            // grpBoxPerfChecker
            // 
            this.grpBoxPerfChecker.Controls.Add(this.resultLabel);
            this.grpBoxPerfChecker.Controls.Add(this.txtBoxCpuTicks);
            this.grpBoxPerfChecker.Controls.Add(this.lblCpuTicks);
            this.grpBoxPerfChecker.Controls.Add(this.txtBoxTimeTaken);
            this.grpBoxPerfChecker.Controls.Add(this.lblTimeTaken);
            this.grpBoxPerfChecker.Controls.Add(this.txtBoxEndTime);
            this.grpBoxPerfChecker.Controls.Add(this.txtBoxStartTime);
            this.grpBoxPerfChecker.Controls.Add(this.lblEndTime);
            this.grpBoxPerfChecker.Controls.Add(this.lblStartTime);
            this.grpBoxPerfChecker.Location = new System.Drawing.Point(3, 2);
            this.grpBoxPerfChecker.Name = "grpBoxPerfChecker";
            this.grpBoxPerfChecker.Size = new System.Drawing.Size(373, 244);
            this.grpBoxPerfChecker.TabIndex = 2;
            this.grpBoxPerfChecker.TabStop = false;
            // 
            // txtBoxCpuTicks
            // 
            this.txtBoxCpuTicks.Location = new System.Drawing.Point(82, 127);
            this.txtBoxCpuTicks.MaximumSize = new System.Drawing.Size(162, 20);
            this.txtBoxCpuTicks.MinimumSize = new System.Drawing.Size(162, 20);
            this.txtBoxCpuTicks.Name = "txtBoxCpuTicks";
            this.txtBoxCpuTicks.Size = new System.Drawing.Size(162, 20);
            this.txtBoxCpuTicks.TabIndex = 8;
            // 
            // lblCpuTicks
            // 
            this.lblCpuTicks.AutoSize = true;
            this.lblCpuTicks.Location = new System.Drawing.Point(9, 130);
            this.lblCpuTicks.Name = "lblCpuTicks";
            this.lblCpuTicks.Size = new System.Drawing.Size(61, 13);
            this.lblCpuTicks.TabIndex = 7;
            this.lblCpuTicks.Text = "CPU Ticks:";
            // 
            // txtBoxTimeTaken
            // 
            this.txtBoxTimeTaken.Location = new System.Drawing.Point(82, 96);
            this.txtBoxTimeTaken.Name = "txtBoxTimeTaken";
            this.txtBoxTimeTaken.Size = new System.Drawing.Size(162, 20);
            this.txtBoxTimeTaken.TabIndex = 6;
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Location = new System.Drawing.Point(9, 99);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(67, 13);
            this.lblTimeTaken.TabIndex = 5;
            this.lblTimeTaken.Text = "Time Taken:";
            // 
            // txtBoxEndTime
            // 
            this.txtBoxEndTime.Location = new System.Drawing.Point(82, 63);
            this.txtBoxEndTime.Name = "txtBoxEndTime";
            this.txtBoxEndTime.Size = new System.Drawing.Size(162, 20);
            this.txtBoxEndTime.TabIndex = 4;
            // 
            // txtBoxStartTime
            // 
            this.txtBoxStartTime.Location = new System.Drawing.Point(82, 27);
            this.txtBoxStartTime.Name = "txtBoxStartTime";
            this.txtBoxStartTime.Size = new System.Drawing.Size(162, 20);
            this.txtBoxStartTime.TabIndex = 2;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(9, 66);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(55, 13);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "End Time:";
            // 
            // txtBoxConsoleOutput
            // 
            this.txtBoxConsoleOutput.Location = new System.Drawing.Point(382, 12);
            this.txtBoxConsoleOutput.Multiline = true;
            this.txtBoxConsoleOutput.Name = "txtBoxConsoleOutput";
            this.txtBoxConsoleOutput.Size = new System.Drawing.Size(161, 234);
            this.txtBoxConsoleOutput.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.Location = new System.Drawing.Point(292, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel Test";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpBoxSystemInfo
            // 
            this.grpBoxSystemInfo.Controls.Add(this.txtBoxSystemInfo);
            this.grpBoxSystemInfo.Location = new System.Drawing.Point(3, 252);
            this.grpBoxSystemInfo.Name = "grpBoxSystemInfo";
            this.grpBoxSystemInfo.Size = new System.Drawing.Size(540, 153);
            this.grpBoxSystemInfo.TabIndex = 12;
            this.grpBoxSystemInfo.TabStop = false;
            this.grpBoxSystemInfo.Text = "System Information";
            // 
            // txtBoxSystemInfo
            // 
            this.txtBoxSystemInfo.Location = new System.Drawing.Point(12, 20);
            this.txtBoxSystemInfo.Multiline = true;
            this.txtBoxSystemInfo.Name = "txtBoxSystemInfo";
            this.txtBoxSystemInfo.Size = new System.Drawing.Size(522, 127);
            this.txtBoxSystemInfo.TabIndex = 0;
            this.txtBoxSystemInfo.WordWrap = false;
            // 
            // backgroundWorkerPerfChecker
            // 
            this.backgroundWorkerPerfChecker.WorkerReportsProgress = true;
            this.backgroundWorkerPerfChecker.WorkerSupportsCancellation = true;
            //this.backgroundWorkerPerfChecker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPerfChecker_DoWork);
            //this.backgroundWorkerPerfChecker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerPerfChecker_ProgressChanged);
            //this.backgroundWorkerPerfChecker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerPerfChecker_RunWorkerCompleted);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(278, 63);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(13, 13);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "0";
            // 
            // PerfChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 460);
            this.Controls.Add(this.grpBoxSystemInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpBoxPerfChecker);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.txtBoxConsoleOutput);
            this.Name = "PerfChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Checker";
            this.grpBoxPerfChecker.ResumeLayout(false);
            this.grpBoxPerfChecker.PerformLayout();
            this.grpBoxSystemInfo.ResumeLayout(false);
            this.grpBoxSystemInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Execute;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.GroupBox grpBoxPerfChecker;
        private System.Windows.Forms.TextBox txtBoxEndTime;
        private System.Windows.Forms.TextBox txtBoxStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.TextBox txtBoxConsoleOutput;
        private System.Windows.Forms.TextBox txtBoxTimeTaken;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.TextBox txtBoxCpuTicks;
        private System.Windows.Forms.Label lblCpuTicks;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpBoxSystemInfo;
        private System.Windows.Forms.TextBox txtBoxSystemInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPerfChecker;
        private System.Windows.Forms.Label resultLabel;
    }
}

