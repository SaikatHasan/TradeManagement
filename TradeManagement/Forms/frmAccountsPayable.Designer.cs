namespace TradeManagement.Forms
{
    partial class frmAccountsPayable
    {
        private System.ComponentModel.IContainer components = null;

        private static frmAccountsPayable sForm = null;

        public static frmAccountsPayable Instance()
        {
            if (sForm == null) { sForm = new frmAccountsPayable(); }
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
            this.components = new System.ComponentModel.Container();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barOptions = new DevExpress.XtraBars.Bar();
            this.bbtnNew = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnCancel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnDelete = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.sitmStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.txtAmountPaying = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtDue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtRemarks = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cmbVoucherNo = new DevExpress.XtraEditors.LookUpEdit();
            this.dtpPayableDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSupplierName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPayableId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grpSearch = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gvwSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPayableDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoucherNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmountPaying = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSearchSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.colDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sitmTotalDue = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountPaying.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPayableDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPayableDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayableId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchSupplier.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barOptions,
            this.barStatus});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.HideBarsWhenMerging = false;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtnNew,
            this.bbtnEdit,
            this.bbtnDelete,
            this.bbtnSave,
            this.bbtnCancel,
            this.sitmStatus,
            this.sitmTotalDue});
            this.barManager.MaxItemId = 31;
            this.barManager.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Never;
            this.barManager.StatusBar = this.barStatus;
            // 
            // barOptions
            // 
            this.barOptions.BarItemHorzIndent = 10;
            this.barOptions.BarName = "Options";
            this.barOptions.DockCol = 0;
            this.barOptions.DockRow = 0;
            this.barOptions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barOptions.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnDelete)});
            this.barOptions.OptionsBar.DrawDragBorder = false;
            this.barOptions.Text = "Options";
            // 
            // bbtnNew
            // 
            this.bbtnNew.Caption = "&New";
            this.bbtnNew.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnNew.Id = 9;
            this.bbtnNew.LargeGlyph = global::TradeManagement.Properties.Resources.New;
            this.bbtnNew.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnNew.Name = "bbtnNew";
            this.bbtnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnNew_ItemClick);
            // 
            // bbtnEdit
            // 
            this.bbtnEdit.Caption = "&Edit";
            this.bbtnEdit.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnEdit.Id = 10;
            this.bbtnEdit.LargeGlyph = global::TradeManagement.Properties.Resources.Edit;
            this.bbtnEdit.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnEdit.Name = "bbtnEdit";
            this.bbtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnEdit_ItemClick);
            // 
            // bbtnSave
            // 
            this.bbtnSave.Caption = "&Save";
            this.bbtnSave.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnSave.Enabled = false;
            this.bbtnSave.Id = 14;
            this.bbtnSave.LargeGlyph = global::TradeManagement.Properties.Resources.Save;
            this.bbtnSave.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnSave.Name = "bbtnSave";
            this.bbtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSave_ItemClick);
            // 
            // bbtnCancel
            // 
            this.bbtnCancel.Caption = "&Cancel";
            this.bbtnCancel.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnCancel.Enabled = false;
            this.bbtnCancel.Id = 15;
            this.bbtnCancel.LargeGlyph = global::TradeManagement.Properties.Resources.Cancel;
            this.bbtnCancel.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnCancel.Name = "bbtnCancel";
            this.bbtnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnCancel_ItemClick);
            // 
            // bbtnDelete
            // 
            this.bbtnDelete.Caption = "&Delete";
            this.bbtnDelete.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnDelete.Id = 11;
            this.bbtnDelete.LargeGlyph = global::TradeManagement.Properties.Resources.Delete;
            this.bbtnDelete.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnDelete.Name = "bbtnDelete";
            this.bbtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDelete_ItemClick);
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.sitmStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.sitmTotalDue)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status";
            // 
            // sitmStatus
            // 
            this.sitmStatus.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.sitmStatus.Id = 16;
            this.sitmStatus.Name = "sitmStatus";
            this.sitmStatus.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.sitmStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.sitmStatus.Width = 32;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(699, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 491);
            this.barDockControlBottom.Size = new System.Drawing.Size(699, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(699, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
            // 
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 53);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(675, 50);
            this.grcCaption.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Location = new System.Drawing.Point(2, 2);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(671, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Accounts Payable";
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.txtAmountPaying);
            this.grpMain.Controls.Add(this.labelControl13);
            this.grpMain.Controls.Add(this.txtDue);
            this.grpMain.Controls.Add(this.labelControl12);
            this.grpMain.Controls.Add(this.txtDiscount);
            this.grpMain.Controls.Add(this.labelControl6);
            this.grpMain.Controls.Add(this.txtRemarks);
            this.grpMain.Controls.Add(this.labelControl4);
            this.grpMain.Controls.Add(this.txtTotalAmount);
            this.grpMain.Controls.Add(this.labelControl9);
            this.grpMain.Controls.Add(this.cmbVoucherNo);
            this.grpMain.Controls.Add(this.dtpPayableDate);
            this.grpMain.Controls.Add(this.labelControl2);
            this.grpMain.Controls.Add(this.labelControl8);
            this.grpMain.Controls.Add(this.cmbSupplierName);
            this.grpMain.Controls.Add(this.labelControl3);
            this.grpMain.Controls.Add(this.txtPayableId);
            this.grpMain.Controls.Add(this.labelControl1);
            this.grpMain.Enabled = false;
            this.grpMain.Location = new System.Drawing.Point(12, 109);
            this.grpMain.Name = "grpMain";
            this.grpMain.ShowCaption = false;
            this.grpMain.Size = new System.Drawing.Size(675, 82);
            this.grpMain.TabIndex = 1;
            // 
            // txtAmountPaying
            // 
            this.txtAmountPaying.EditValue = "";
            this.txtAmountPaying.EnterMoveNextControl = true;
            this.txtAmountPaying.Location = new System.Drawing.Point(83, 57);
            this.txtAmountPaying.Name = "txtAmountPaying";
            this.txtAmountPaying.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAmountPaying.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmountPaying.Properties.Mask.EditMask = "f";
            this.txtAmountPaying.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmountPaying.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmountPaying.Size = new System.Drawing.Size(91, 20);
            this.txtAmountPaying.TabIndex = 15;
            this.txtAmountPaying.EditValueChanged += new System.EventHandler(this.txtAmountPaying_EditValueChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(5, 60);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(72, 13);
            this.labelControl13.TabIndex = 14;
            this.labelControl13.Text = "Amount Paying";
            // 
            // txtDue
            // 
            this.txtDue.EditValue = "";
            this.txtDue.EnterMoveNextControl = true;
            this.txtDue.Location = new System.Drawing.Point(579, 31);
            this.txtDue.Name = "txtDue";
            this.txtDue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDue.Properties.Mask.EditMask = "f";
            this.txtDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDue.Properties.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(91, 20);
            this.txtDue.TabIndex = 13;
            this.txtDue.TabStop = false;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(554, 34);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(19, 13);
            this.labelControl12.TabIndex = 12;
            this.labelControl12.Text = "Due";
            // 
            // txtDiscount
            // 
            this.txtDiscount.EditValue = "";
            this.txtDiscount.EnterMoveNextControl = true;
            this.txtDiscount.Location = new System.Drawing.Point(421, 31);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDiscount.Properties.Mask.EditMask = "f";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Properties.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(91, 20);
            this.txtDiscount.TabIndex = 11;
            this.txtDiscount.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(374, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Discount";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(250, 57);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Properties.MaxLength = 15;
            this.txtRemarks.Size = new System.Drawing.Size(420, 20);
            this.txtRemarks.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(203, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Remarks";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.EditValue = "";
            this.txtTotalAmount.EnterMoveNextControl = true;
            this.txtTotalAmount.Location = new System.Drawing.Point(250, 31);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotalAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtTotalAmount.Properties.Mask.EditMask = "f";
            this.txtTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtTotalAmount.Properties.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(91, 20);
            this.txtTotalAmount.TabIndex = 9;
            this.txtTotalAmount.TabStop = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(180, 34);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 13);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Total Amount";
            // 
            // cmbVoucherNo
            // 
            this.cmbVoucherNo.EnterMoveNextControl = true;
            this.cmbVoucherNo.Location = new System.Drawing.Point(83, 31);
            this.cmbVoucherNo.Name = "cmbVoucherNo";
            this.cmbVoucherNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVoucherNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("purVoucherNo", "Voucher No")});
            this.cmbVoucherNo.Properties.DisplayMember = "purVoucherNo";
            this.cmbVoucherNo.Properties.NullText = "";
            this.cmbVoucherNo.Properties.ValueMember = "purPurchaseId";
            this.cmbVoucherNo.Size = new System.Drawing.Size(91, 20);
            this.cmbVoucherNo.TabIndex = 7;
            this.cmbVoucherNo.EditValueChanged += new System.EventHandler(this.cmbVoucherNo_EditValueChanged);
            // 
            // dtpPayableDate
            // 
            this.dtpPayableDate.EditValue = null;
            this.dtpPayableDate.EnterMoveNextControl = true;
            this.dtpPayableDate.Location = new System.Drawing.Point(250, 5);
            this.dtpPayableDate.Name = "dtpPayableDate";
            this.dtpPayableDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPayableDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpPayableDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpPayableDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpPayableDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpPayableDate.Size = new System.Drawing.Size(91, 20);
            this.dtpPayableDate.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(180, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Payable Date";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(22, 34);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Voucher No";
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.EnterMoveNextControl = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(421, 5);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSupplierName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supSupplierName", "Supplier Name")});
            this.cmbSupplierName.Properties.DisplayMember = "supSupplierName";
            this.cmbSupplierName.Properties.NullText = "";
            this.cmbSupplierName.Properties.ValueMember = "supSupplierId";
            this.cmbSupplierName.Size = new System.Drawing.Size(249, 20);
            this.cmbSupplierName.TabIndex = 5;
            this.cmbSupplierName.EditValueChanged += new System.EventHandler(this.cmbSupplierName_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(347, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Supplier Name";
            // 
            // txtPayableId
            // 
            this.txtPayableId.EditValue = "";
            this.txtPayableId.EnterMoveNextControl = true;
            this.txtPayableId.Location = new System.Drawing.Point(83, 5);
            this.txtPayableId.Name = "txtPayableId";
            this.txtPayableId.Properties.ReadOnly = true;
            this.txtPayableId.Size = new System.Drawing.Size(91, 20);
            this.txtPayableId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Payable Id";
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.grdSearch);
            this.grpSearch.Controls.Add(this.dtpEndDate);
            this.grpSearch.Controls.Add(this.labelControl5);
            this.grpSearch.Controls.Add(this.dtpStartDate);
            this.grpSearch.Controls.Add(this.labelControl7);
            this.grpSearch.Controls.Add(this.cmbSearchSupplier);
            this.grpSearch.Controls.Add(this.labelControl11);
            this.grpSearch.Location = new System.Drawing.Point(12, 197);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.ShowCaption = false;
            this.grpSearch.Size = new System.Drawing.Size(675, 288);
            this.grpSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(608, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 20);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdSearch
            // 
            this.grdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(5, 31);
            this.grdSearch.MainView = this.gvwSearch;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(665, 252);
            this.grdSearch.TabIndex = 7;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwSearch});
            this.grdSearch.Click += new System.EventHandler(this.grdSearch_Click);
            // 
            // gvwSearch
            // 
            this.gvwSearch.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSearch.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwSearch.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSearch.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwSearch.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSearch.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPayableDate,
            this.colSupplierName,
            this.colVoucherNo,
            this.colTotalAmount,
            this.colAmountPaying,
            this.colDue});
            this.gvwSearch.GridControl = this.grdSearch;
            this.gvwSearch.Name = "gvwSearch";
            this.gvwSearch.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwSearch.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwSearch.OptionsBehavior.Editable = false;
            this.gvwSearch.OptionsCustomization.AllowColumnMoving = false;
            this.gvwSearch.OptionsCustomization.AllowFilter = false;
            this.gvwSearch.OptionsCustomization.AllowGroup = false;
            this.gvwSearch.OptionsMenu.EnableColumnMenu = false;
            this.gvwSearch.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwSearch.OptionsView.EnableAppearanceOddRow = true;
            this.gvwSearch.OptionsView.ShowGroupPanel = false;
            // 
            // colPayableDate
            // 
            this.colPayableDate.Caption = "Payable Date";
            this.colPayableDate.DisplayFormat.FormatString = "MMM dd, yyyy";
            this.colPayableDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPayableDate.FieldName = "acpPayableDate";
            this.colPayableDate.Name = "colPayableDate";
            this.colPayableDate.Visible = true;
            this.colPayableDate.VisibleIndex = 0;
            this.colPayableDate.Width = 85;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier Name";
            this.colSupplierName.FieldName = "supSupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 1;
            this.colSupplierName.Width = 212;
            // 
            // colVoucherNo
            // 
            this.colVoucherNo.Caption = "Voucher No";
            this.colVoucherNo.FieldName = "acpVoucherNo";
            this.colVoucherNo.Name = "colVoucherNo";
            this.colVoucherNo.Visible = true;
            this.colVoucherNo.VisibleIndex = 2;
            this.colVoucherNo.Width = 93;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalAmount.Caption = "Total Amount";
            this.colTotalAmount.DisplayFormat.FormatString = "f";
            this.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAmount.FieldName = "acpTotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 3;
            this.colTotalAmount.Width = 90;
            // 
            // colAmountPaying
            // 
            this.colAmountPaying.AppearanceCell.Options.UseTextOptions = true;
            this.colAmountPaying.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAmountPaying.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmountPaying.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAmountPaying.Caption = "Amount Paying";
            this.colAmountPaying.DisplayFormat.FormatString = "f";
            this.colAmountPaying.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmountPaying.FieldName = "acpAmountPaying";
            this.colAmountPaying.Name = "colAmountPaying";
            this.colAmountPaying.Visible = true;
            this.colAmountPaying.VisibleIndex = 4;
            this.colAmountPaying.Width = 95;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.EditValue = null;
            this.dtpEndDate.EnterMoveNextControl = true;
            this.dtpEndDate.Location = new System.Drawing.Point(505, 5);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEndDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpEndDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpEndDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpEndDate.Size = new System.Drawing.Size(97, 20);
            this.dtpEndDate.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(455, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.EditValue = null;
            this.dtpStartDate.EnterMoveNextControl = true;
            this.dtpStartDate.Location = new System.Drawing.Point(352, 5);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStartDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpStartDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpStartDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpStartDate.Size = new System.Drawing.Size(97, 20);
            this.dtpStartDate.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(296, 8);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Start Date";
            // 
            // cmbSearchSupplier
            // 
            this.cmbSearchSupplier.EnterMoveNextControl = true;
            this.cmbSearchSupplier.Location = new System.Drawing.Point(79, 5);
            this.cmbSearchSupplier.Name = "cmbSearchSupplier";
            this.cmbSearchSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSearchSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supSupplierName", "Supplier Name")});
            this.cmbSearchSupplier.Properties.DisplayMember = "supSupplierName";
            this.cmbSearchSupplier.Properties.NullText = "";
            this.cmbSearchSupplier.Properties.ValueMember = "supSupplierId";
            this.cmbSearchSupplier.Size = new System.Drawing.Size(211, 20);
            this.cmbSearchSupplier.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(5, 8);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(68, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Supplier Name";
            // 
            // colDue
            // 
            this.colDue.AppearanceCell.Options.UseTextOptions = true;
            this.colDue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDue.AppearanceHeader.Options.UseTextOptions = true;
            this.colDue.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDue.Caption = "Due";
            this.colDue.DisplayFormat.FormatString = "f";
            this.colDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDue.FieldName = "acpDue";
            this.colDue.Name = "colDue";
            this.colDue.Visible = true;
            this.colDue.VisibleIndex = 5;
            this.colDue.Width = 72;
            // 
            // sitmTotalDue
            // 
            this.sitmTotalDue.Id = 30;
            this.sitmTotalDue.Name = "sitmTotalDue";
            this.sitmTotalDue.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // frmAccountsPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 516);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grcCaption);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAccountsPayable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts Payable";
            this.Load += new System.EventHandler(this.frmAccountsPayable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountPaying.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPayableDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPayableDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPayableId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchSupplier.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barOptions;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnNew;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnEdit;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnSave;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnCancel;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnDelete;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem sitmStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.GroupControl grpMain;
        private DevExpress.XtraEditors.TextEdit txtPayableId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbVoucherNo;
        private DevExpress.XtraEditors.DateEdit dtpPayableDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit cmbSupplierName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTotalAmount;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtRemarks;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl grpSearch;
        private DevExpress.XtraEditors.DateEdit dtpEndDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dtpStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit cmbSearchSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colPayableDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucherNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtDue;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtAmountPaying;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraGrid.Columns.GridColumn colAmountPaying;
        private DevExpress.XtraGrid.Columns.GridColumn colDue;
        private DevExpress.XtraBars.BarStaticItem sitmTotalDue;
    }
}