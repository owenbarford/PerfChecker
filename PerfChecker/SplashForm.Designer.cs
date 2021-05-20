
namespace PerfChecker
{
    partial class SplashForm
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
            this.lblSplashScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSplashScreen
            // 
            this.lblSplashScreen.AutoSize = true;
            this.lblSplashScreen.Location = new System.Drawing.Point(210, 142);
            this.lblSplashScreen.Name = "lblSplashScreen";
            this.lblSplashScreen.Size = new System.Drawing.Size(54, 13);
            this.lblSplashScreen.TabIndex = 0;
            this.lblSplashScreen.Text = "Loading...";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 317);
            this.ControlBox = false;
            this.Controls.Add(this.lblSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(474, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(474, 317);
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplashScreen;
    }
}