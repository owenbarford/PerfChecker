
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfChecker));
            this.btn_Execute = new System.Windows.Forms.Button();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.grpBoxPerfChecker = new System.Windows.Forms.GroupBox();
            this.txtBoxArraySize = new System.Windows.Forms.TextBox();
            this.lbl_ArraySize = new System.Windows.Forms.Label();
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
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxPerfChecker.SuspendLayout();
            this.grpBoxSystemInfo.SuspendLayout();
            this.mnuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Execute
            // 
            this.btn_Execute.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Execute.Location = new System.Drawing.Point(154, 411);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Size = new System.Drawing.Size(103, 23);
            this.btn_Execute.TabIndex = 10;
            this.btn_Execute.Text = "&Execute Test";
            this.btn_Execute.UseVisualStyleBackColor = true;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(9, 35);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(58, 13);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start Time:";
            // 
            // grpBoxPerfChecker
            // 
            this.grpBoxPerfChecker.Controls.Add(this.txtBoxArraySize);
            this.grpBoxPerfChecker.Controls.Add(this.lbl_ArraySize);
            this.grpBoxPerfChecker.Controls.Add(this.txtBoxCpuTicks);
            this.grpBoxPerfChecker.Controls.Add(this.lblCpuTicks);
            this.grpBoxPerfChecker.Controls.Add(this.txtBoxTimeTaken);
            this.grpBoxPerfChecker.Controls.Add(this.lblTimeTaken);
            this.grpBoxPerfChecker.Controls.Add(this.txtBoxEndTime);
            this.grpBoxPerfChecker.Controls.Add(this.txtBoxStartTime);
            this.grpBoxPerfChecker.Controls.Add(this.lblEndTime);
            this.grpBoxPerfChecker.Controls.Add(this.lblStartTime);
            this.grpBoxPerfChecker.Location = new System.Drawing.Point(3, 27);
            this.grpBoxPerfChecker.Name = "grpBoxPerfChecker";
            this.grpBoxPerfChecker.Size = new System.Drawing.Size(373, 184);
            this.grpBoxPerfChecker.TabIndex = 2;
            this.grpBoxPerfChecker.TabStop = false;
            // 
            // txtBoxArraySize
            // 
            this.txtBoxArraySize.Location = new System.Drawing.Point(139, 136);
            this.txtBoxArraySize.MaximumSize = new System.Drawing.Size(162, 20);
            this.txtBoxArraySize.MinimumSize = new System.Drawing.Size(162, 20);
            this.txtBoxArraySize.Name = "txtBoxArraySize";
            this.txtBoxArraySize.Size = new System.Drawing.Size(162, 20);
            this.txtBoxArraySize.TabIndex = 10;
            // 
            // lbl_ArraySize
            // 
            this.lbl_ArraySize.AutoSize = true;
            this.lbl_ArraySize.Location = new System.Drawing.Point(9, 139);
            this.lbl_ArraySize.Name = "lbl_ArraySize";
            this.lbl_ArraySize.Size = new System.Drawing.Size(57, 13);
            this.lbl_ArraySize.TabIndex = 9;
            this.lbl_ArraySize.Text = "Array Size:";
            // 
            // txtBoxCpuTicks
            // 
            this.txtBoxCpuTicks.Location = new System.Drawing.Point(139, 110);
            this.txtBoxCpuTicks.MaximumSize = new System.Drawing.Size(162, 20);
            this.txtBoxCpuTicks.MinimumSize = new System.Drawing.Size(162, 20);
            this.txtBoxCpuTicks.Name = "txtBoxCpuTicks";
            this.txtBoxCpuTicks.Size = new System.Drawing.Size(162, 20);
            this.txtBoxCpuTicks.TabIndex = 8;
            // 
            // lblCpuTicks
            // 
            this.lblCpuTicks.AutoSize = true;
            this.lblCpuTicks.Location = new System.Drawing.Point(9, 113);
            this.lblCpuTicks.Name = "lblCpuTicks";
            this.lblCpuTicks.Size = new System.Drawing.Size(61, 13);
            this.lblCpuTicks.TabIndex = 7;
            this.lblCpuTicks.Text = "CPU Ticks:";
            // 
            // txtBoxTimeTaken
            // 
            this.txtBoxTimeTaken.Location = new System.Drawing.Point(139, 84);
            this.txtBoxTimeTaken.Name = "txtBoxTimeTaken";
            this.txtBoxTimeTaken.Size = new System.Drawing.Size(162, 20);
            this.txtBoxTimeTaken.TabIndex = 6;
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.Location = new System.Drawing.Point(9, 87);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(124, 13);
            this.lblTimeTaken.TabIndex = 5;
            this.lblTimeTaken.Text = "Time Taken (all threads):";
            this.lblTimeTaken.Click += new System.EventHandler(this.lblTimeTaken_Click);
            // 
            // txtBoxEndTime
            // 
            this.txtBoxEndTime.Location = new System.Drawing.Point(139, 58);
            this.txtBoxEndTime.Name = "txtBoxEndTime";
            this.txtBoxEndTime.Size = new System.Drawing.Size(162, 20);
            this.txtBoxEndTime.TabIndex = 4;
            // 
            // txtBoxStartTime
            // 
            this.txtBoxStartTime.Location = new System.Drawing.Point(139, 32);
            this.txtBoxStartTime.Name = "txtBoxStartTime";
            this.txtBoxStartTime.Size = new System.Drawing.Size(162, 20);
            this.txtBoxStartTime.TabIndex = 2;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(9, 61);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(55, 13);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "End Time:";
            // 
            // txtBoxConsoleOutput
            // 
            this.txtBoxConsoleOutput.Location = new System.Drawing.Point(382, 37);
            this.txtBoxConsoleOutput.Multiline = true;
            this.txtBoxConsoleOutput.Name = "txtBoxConsoleOutput";
            this.txtBoxConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxConsoleOutput.Size = new System.Drawing.Size(161, 174);
            this.txtBoxConsoleOutput.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.Location = new System.Drawing.Point(292, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel Test";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpBoxSystemInfo
            // 
            this.grpBoxSystemInfo.Controls.Add(this.txtBoxSystemInfo);
            this.grpBoxSystemInfo.Location = new System.Drawing.Point(3, 217);
            this.grpBoxSystemInfo.Name = "grpBoxSystemInfo";
            this.grpBoxSystemInfo.Size = new System.Drawing.Size(540, 188);
            this.grpBoxSystemInfo.TabIndex = 12;
            this.grpBoxSystemInfo.TabStop = false;
            this.grpBoxSystemInfo.Text = "System Information";
            // 
            // txtBoxSystemInfo
            // 
            this.txtBoxSystemInfo.Location = new System.Drawing.Point(12, 20);
            this.txtBoxSystemInfo.Multiline = true;
            this.txtBoxSystemInfo.Name = "txtBoxSystemInfo";
            this.txtBoxSystemInfo.Size = new System.Drawing.Size(522, 162);
            this.txtBoxSystemInfo.TabIndex = 0;
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // mnuStrip1
            // 
            this.mnuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip1.Name = "mnuStrip1";
            this.mnuStrip1.Size = new System.Drawing.Size(555, 24);
            this.mnuStrip1.TabIndex = 13;
            this.mnuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
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
            this.Controls.Add(this.mnuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PerfChecker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Checker";
            this.grpBoxPerfChecker.ResumeLayout(false);
            this.grpBoxPerfChecker.PerformLayout();
            this.grpBoxSystemInfo.ResumeLayout(false);
            this.grpBoxSystemInfo.PerformLayout();
            this.mnuStrip1.ResumeLayout(false);
            this.mnuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtBoxArraySize;
        private System.Windows.Forms.Label lbl_ArraySize;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

