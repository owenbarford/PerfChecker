
namespace PerfChecker
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.tblLayoutPanelAbout = new System.Windows.Forms.TableLayoutPanel();
            this.picBoxAbout = new System.Windows.Forms.PictureBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtBoxAboutDesc = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tblLayoutPanelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutPanelAbout
            // 
            this.tblLayoutPanelAbout.ColumnCount = 2;
            this.tblLayoutPanelAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.62561F));
            this.tblLayoutPanelAbout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.37439F));
            this.tblLayoutPanelAbout.Controls.Add(this.picBoxAbout, 0, 0);
            this.tblLayoutPanelAbout.Controls.Add(this.lblProductName, 1, 0);
            this.tblLayoutPanelAbout.Controls.Add(this.lblVersion, 1, 1);
            this.tblLayoutPanelAbout.Controls.Add(this.lblCopyRight, 1, 2);
            this.tblLayoutPanelAbout.Controls.Add(this.lblCompanyName, 1, 3);
            this.tblLayoutPanelAbout.Controls.Add(this.txtBoxAboutDesc, 1, 4);
            this.tblLayoutPanelAbout.Controls.Add(this.btnAbout, 1, 5);
            this.tblLayoutPanelAbout.Location = new System.Drawing.Point(3, 2);
            this.tblLayoutPanelAbout.Name = "tblLayoutPanelAbout";
            this.tblLayoutPanelAbout.RowCount = 6;
            this.tblLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tblLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tblLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tblLayoutPanelAbout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblLayoutPanelAbout.Size = new System.Drawing.Size(406, 311);
            this.tblLayoutPanelAbout.TabIndex = 0;
            // 
            // picBoxAbout
            // 
            this.picBoxAbout.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAbout.Image")));
            this.picBoxAbout.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxAbout.InitialImage")));
            this.picBoxAbout.Location = new System.Drawing.Point(3, 3);
            this.picBoxAbout.Name = "picBoxAbout";
            this.tblLayoutPanelAbout.SetRowSpan(this.picBoxAbout, 6);
            this.picBoxAbout.Size = new System.Drawing.Size(161, 305);
            this.picBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAbout.TabIndex = 0;
            this.picBoxAbout.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(171, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Performance Checker";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(171, 29);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(78, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version 1.0.0.0";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(171, 57);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(108, 13);
            this.lblCopyRight.TabIndex = 3;
            this.lblCopyRight.Text = "© The Support Team";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(171, 85);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(138, 13);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "Wolters Kluwer (UK) Limited";
            // 
            // txtBoxAboutDesc
            // 
            this.txtBoxAboutDesc.Location = new System.Drawing.Point(171, 131);
            this.txtBoxAboutDesc.Multiline = true;
            this.txtBoxAboutDesc.Name = "txtBoxAboutDesc";
            this.txtBoxAboutDesc.ReadOnly = true;
            this.txtBoxAboutDesc.Size = new System.Drawing.Size(232, 140);
            this.txtBoxAboutDesc.TabIndex = 5;
            this.txtBoxAboutDesc.Text = resources.GetString("txtBoxAboutDesc.Text");
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAbout.Location = new System.Drawing.Point(328, 281);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "&OK";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 316);
            this.Controls.Add(this.tblLayoutPanelAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.tblLayoutPanelAbout.ResumeLayout(false);
            this.tblLayoutPanelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPanelAbout;
        private System.Windows.Forms.PictureBox picBoxAbout;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtBoxAboutDesc;
        private System.Windows.Forms.Button btnAbout;
    }
}