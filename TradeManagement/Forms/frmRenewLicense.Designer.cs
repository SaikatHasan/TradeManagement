namespace TradeManagement.Forms
{
    partial class frmRenewLicense
    {
        private System.ComponentModel.IContainer components = null;

        private static frmRenewLicense sForm = null;

        public static frmRenewLicense Instance()
        {
            if (sForm == null) { sForm = new frmRenewLicense(); }
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
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.grcContent = new DevExpress.XtraEditors.GroupControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtSerialNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.txtMachineCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcContent)).BeginInit();
            this.grcContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Location = new System.Drawing.Point(2, 2);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(291, 36);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Renew License";
            // 
            // grcContent
            // 
            this.grcContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcContent.Controls.Add(this.txtMachineCode);
            this.grcContent.Controls.Add(this.labelControl1);
            this.grcContent.Controls.Add(this.btnOK);
            this.grcContent.Controls.Add(this.btnCancel);
            this.grcContent.Controls.Add(this.txtSerialNumber);
            this.grcContent.Controls.Add(this.labelControl2);
            this.grcContent.Location = new System.Drawing.Point(12, 58);
            this.grcContent.Name = "grcContent";
            this.grcContent.ShowCaption = false;
            this.grcContent.Size = new System.Drawing.Size(295, 85);
            this.grcContent.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(134, 57);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(215, 57);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.EnterMoveNextControl = true;
            this.txtSerialNumber.Location = new System.Drawing.Point(78, 31);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(212, 20);
            this.txtSerialNumber.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Serial Number";
            // 
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 12);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(295, 40);
            this.grcCaption.TabIndex = 0;
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.Location = new System.Drawing.Point(78, 5);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.Properties.ReadOnly = true;
            this.txtMachineCode.Size = new System.Drawing.Size(212, 20);
            this.txtMachineCode.TabIndex = 1;
            this.txtMachineCode.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Machine Code";
            // 
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 155);
            this.Controls.Add(this.grcContent);
            this.Controls.Add(this.grcCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRenewLicense";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renew License";
            this.Load += new System.EventHandler(this.frmRenewLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcContent)).EndInit();
            this.grcContent.ResumeLayout(false);
            this.grcContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.GroupControl grcContent;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtSerialNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.TextEdit txtMachineCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}