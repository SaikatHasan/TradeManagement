namespace TradeManagement.Forms
{
    partial class frmReports
    {
        private System.ComponentModel.IContainer components = null;

        private static frmReports sForm = null;

        public static frmReports Instance()
        {
            if (sForm == null) { sForm = new frmReports(); }
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
            this.grpSingleDate = new DevExpress.XtraEditors.GroupControl();
            this.dtpSingleDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.chkSingleDate = new DevExpress.XtraEditors.CheckEdit();
            this.chkDateRange = new DevExpress.XtraEditors.CheckEdit();
            this.grpDateRange = new DevExpress.XtraEditors.GroupControl();
            this.dtpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnShow = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpSingleDate)).BeginInit();
            this.grpSingleDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSingleDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSingleDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSingleDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDateRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDateRange)).BeginInit();
            this.grpDateRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSingleDate
            // 
            this.grpSingleDate.Controls.Add(this.dtpSingleDate);
            this.grpSingleDate.Controls.Add(this.labelControl15);
            this.grpSingleDate.Location = new System.Drawing.Point(12, 23);
            this.grpSingleDate.Name = "grpSingleDate";
            this.grpSingleDate.ShowCaption = false;
            this.grpSingleDate.Size = new System.Drawing.Size(260, 48);
            this.grpSingleDate.TabIndex = 1;
            // 
            // dtpSingleDate
            // 
            this.dtpSingleDate.EditValue = null;
            this.dtpSingleDate.EnterMoveNextControl = true;
            this.dtpSingleDate.Location = new System.Drawing.Point(76, 14);
            this.dtpSingleDate.Name = "dtpSingleDate";
            this.dtpSingleDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSingleDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpSingleDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpSingleDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpSingleDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpSingleDate.Size = new System.Drawing.Size(170, 20);
            this.dtpSingleDate.TabIndex = 1;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(15, 17);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(55, 13);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "Select Date";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkSingleDate
            // 
            this.chkSingleDate.EditValue = true;
            this.chkSingleDate.Location = new System.Drawing.Point(17, 12);
            this.chkSingleDate.Name = "chkSingleDate";
            this.chkSingleDate.Properties.Caption = "By Single Date";
            this.chkSingleDate.Size = new System.Drawing.Size(93, 19);
            this.chkSingleDate.TabIndex = 0;
            this.chkSingleDate.CheckedChanged += new System.EventHandler(this.chkSingleDate_CheckedChanged);
            // 
            // chkDateRange
            // 
            this.chkDateRange.Location = new System.Drawing.Point(17, 77);
            this.chkDateRange.Name = "chkDateRange";
            this.chkDateRange.Properties.Caption = "By Date Range";
            this.chkDateRange.Size = new System.Drawing.Size(93, 19);
            this.chkDateRange.TabIndex = 2;
            this.chkDateRange.CheckedChanged += new System.EventHandler(this.chkDateRange_CheckedChanged);
            // 
            // grpDateRange
            // 
            this.grpDateRange.Controls.Add(this.dtpEndDate);
            this.grpDateRange.Controls.Add(this.labelControl1);
            this.grpDateRange.Controls.Add(this.dtpStartDate);
            this.grpDateRange.Controls.Add(this.labelControl2);
            this.grpDateRange.Enabled = false;
            this.grpDateRange.Location = new System.Drawing.Point(12, 88);
            this.grpDateRange.Name = "grpDateRange";
            this.grpDateRange.ShowCaption = false;
            this.grpDateRange.Size = new System.Drawing.Size(260, 77);
            this.grpDateRange.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.EditValue = null;
            this.dtpEndDate.EnterMoveNextControl = true;
            this.dtpEndDate.Location = new System.Drawing.Point(76, 43);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEndDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpEndDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpEndDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpEndDate.Size = new System.Drawing.Size(170, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.EditValue = null;
            this.dtpStartDate.EnterMoveNextControl = true;
            this.dtpStartDate.Location = new System.Drawing.Point(76, 14);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStartDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpStartDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpStartDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpStartDate.Size = new System.Drawing.Size(170, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Start Date";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(116, 171);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmReports
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 206);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.chkDateRange);
            this.Controls.Add(this.grpDateRange);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkSingleDate);
            this.Controls.Add(this.grpSingleDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReports";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpSingleDate)).EndInit();
            this.grpSingleDate.ResumeLayout(false);
            this.grpSingleDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSingleDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSingleDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSingleDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDateRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDateRange)).EndInit();
            this.grpDateRange.ResumeLayout(false);
            this.grpDateRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpSingleDate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.DateEdit dtpSingleDate;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.CheckEdit chkSingleDate;
        private DevExpress.XtraEditors.CheckEdit chkDateRange;
        private DevExpress.XtraEditors.GroupControl grpDateRange;
        private DevExpress.XtraEditors.DateEdit dtpEndDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnShow;
    }
}