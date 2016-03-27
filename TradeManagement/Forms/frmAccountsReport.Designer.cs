namespace TradeManagement.Forms
{
    partial class frmAccountsReport
    {
        private System.ComponentModel.IContainer components = null;

        private static frmAccountsReport sForm = null;

        public static frmAccountsReport Instance()
        {
            if (sForm == null) { sForm = new frmAccountsReport(); }
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
            this.grpOptions = new DevExpress.XtraEditors.GroupControl();
            this.cmbVoucherNo = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbInvoiceNo = new DevExpress.XtraEditors.LookUpEdit();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.cmbSuppliers = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbCustomers = new DevExpress.XtraEditors.LookUpEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.chkAllDues = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOptions)).BeginInit();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuppliers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDues.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.cmbVoucherNo);
            this.grpOptions.Controls.Add(this.cmbInvoiceNo);
            this.grpOptions.Controls.Add(this.lblType);
            this.grpOptions.Controls.Add(this.cmbSuppliers);
            this.grpOptions.Controls.Add(this.cmbCustomers);
            this.grpOptions.Controls.Add(this.lblName);
            this.grpOptions.Location = new System.Drawing.Point(12, 12);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.ShowCaption = false;
            this.grpOptions.Size = new System.Drawing.Size(301, 81);
            this.grpOptions.TabIndex = 0;
            // 
            // cmbVoucherNo
            // 
            this.cmbVoucherNo.EnterMoveNextControl = true;
            this.cmbVoucherNo.Location = new System.Drawing.Point(98, 46);
            this.cmbVoucherNo.Name = "cmbVoucherNo";
            this.cmbVoucherNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVoucherNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("purVoucherNo", "Voucher No")});
            this.cmbVoucherNo.Properties.DisplayMember = "purVoucherNo";
            this.cmbVoucherNo.Properties.NullText = "";
            this.cmbVoucherNo.Properties.ValueMember = "purPurchaseId";
            this.cmbVoucherNo.Size = new System.Drawing.Size(187, 20);
            this.cmbVoucherNo.TabIndex = 5;
            this.cmbVoucherNo.Visible = false;
            // 
            // cmbInvoiceNo
            // 
            this.cmbInvoiceNo.EnterMoveNextControl = true;
            this.cmbInvoiceNo.Location = new System.Drawing.Point(98, 46);
            this.cmbInvoiceNo.Name = "cmbInvoiceNo";
            this.cmbInvoiceNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInvoiceNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("slsInvoiceNo", "Invoice No")});
            this.cmbInvoiceNo.Properties.DisplayMember = "slsInvoiceNo";
            this.cmbInvoiceNo.Properties.NullText = "";
            this.cmbInvoiceNo.Properties.ValueMember = "slsInvoiceNo";
            this.cmbInvoiceNo.Size = new System.Drawing.Size(187, 20);
            this.cmbInvoiceNo.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(16, 49);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(51, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Invoice No";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.EnterMoveNextControl = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(98, 15);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSuppliers.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supSupplierName", "Supplier Name")});
            this.cmbSuppliers.Properties.DisplayMember = "supSupplierName";
            this.cmbSuppliers.Properties.NullText = "";
            this.cmbSuppliers.Properties.ValueMember = "supSupplierId";
            this.cmbSuppliers.Size = new System.Drawing.Size(187, 20);
            this.cmbSuppliers.TabIndex = 2;
            this.cmbSuppliers.Visible = false;
            this.cmbSuppliers.EditValueChanged += new System.EventHandler(this.cmbSuppliers_EditValueChanged);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.EnterMoveNextControl = true;
            this.cmbCustomers.Location = new System.Drawing.Point(98, 15);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomers.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cstCustomerName", "Customer Name")});
            this.cmbCustomers.Properties.DisplayMember = "cstCustomerName";
            this.cmbCustomers.Properties.NullText = "";
            this.cmbCustomers.Properties.ValueMember = "cstCustomerID";
            this.cmbCustomers.Size = new System.Drawing.Size(186, 20);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.EditValueChanged += new System.EventHandler(this.cmbCustomers_EditValueChanged);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(15, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Customer Name";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(157, 99);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(238, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkAllDues
            // 
            this.chkAllDues.Location = new System.Drawing.Point(12, 101);
            this.chkAllDues.Name = "chkAllDues";
            this.chkAllDues.Properties.Caption = "Show All Dues";
            this.chkAllDues.Size = new System.Drawing.Size(91, 19);
            this.chkAllDues.TabIndex = 3;
            this.chkAllDues.CheckedChanged += new System.EventHandler(this.chkAllDues_CheckedChanged);
            // 
            // frmAccountsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(325, 134);
            this.Controls.Add(this.chkAllDues);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAccountsReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmAccountsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpOptions)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuppliers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDues.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpOptions;
        private DevExpress.XtraEditors.SimpleButton btnShow;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.LookUpEdit cmbSuppliers;
        public DevExpress.XtraEditors.LookUpEdit cmbCustomers;
        public DevExpress.XtraEditors.LabelControl lblName;
        public DevExpress.XtraEditors.LabelControl lblType;
        public DevExpress.XtraEditors.LookUpEdit cmbInvoiceNo;
        public DevExpress.XtraEditors.LookUpEdit cmbVoucherNo;
        private DevExpress.XtraEditors.CheckEdit chkAllDues;
    }
}