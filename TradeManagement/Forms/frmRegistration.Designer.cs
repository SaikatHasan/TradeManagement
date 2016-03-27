namespace TradeManagement.Forms
{
    partial class frmRegistration
    {
        private System.ComponentModel.IContainer components = null;

        private static frmRegistration sForm = null;

        public static frmRegistration Instance()
        {
            if (sForm == null) { sForm = new frmRegistration(); }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMachineCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSerialNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(328, 52);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = resources.GetString("labelControl1.Text");
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Machine Code";
            // 
            // txtMachineCode
            // 
            this.txtMachineCode.Location = new System.Drawing.Point(85, 77);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.Properties.ReadOnly = true;
            this.txtMachineCode.Size = new System.Drawing.Size(255, 20);
            this.txtMachineCode.TabIndex = 2;
            this.txtMachineCode.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Serial Number";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(85, 108);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(255, 20);
            this.txtSerialNumber.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(76, 139);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 175);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtMachineCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegistration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMachineCode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSerialNumber;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}