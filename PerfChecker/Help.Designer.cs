
namespace PerfChecker
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.txtBoxHelpDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxHelpDesc
            // 
            this.txtBoxHelpDesc.Location = new System.Drawing.Point(13, 13);
            this.txtBoxHelpDesc.MinimumSize = new System.Drawing.Size(487, 364);
            this.txtBoxHelpDesc.Multiline = true;
            this.txtBoxHelpDesc.Name = "txtBoxHelpDesc";
            this.txtBoxHelpDesc.ReadOnly = true;
            this.txtBoxHelpDesc.Size = new System.Drawing.Size(487, 364);
            this.txtBoxHelpDesc.TabIndex = 0;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 388);
            this.Controls.Add(this.txtBoxHelpDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(528, 427);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(528, 427);
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxHelpDesc;
    }
}