namespace TradeManagement.Forms
{
    partial class frmLicenseStatus
    {
        private System.ComponentModel.IContainer components = null;

        private static frmLicenseStatus sForm = null;

        public static frmLicenseStatus Instance()
        {
            if (sForm == null) { sForm = new frmLicenseStatus(); }
            return sForm;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            sForm = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseStatus));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblStatus.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.lblStatus.Location = new System.Drawing.Point(118, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(177, 64);
            this.lblStatus.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(220, 89);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmLicenseStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 124);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLicenseStatus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Status";
            this.Load += new System.EventHandler(this.frmLicenseStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}