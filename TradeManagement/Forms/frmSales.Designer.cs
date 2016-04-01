namespace TradeManagement.Forms
{
    partial class frmSales
    {
        private System.ComponentModel.IContainer components = null;

        private static frmSales sForm = null;

        public static frmSales Instance()
        {
            if (sForm == null) { sForm = new frmSales(); }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barOptions = new DevExpress.XtraBars.Bar();
            this.bbtnNew = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnCancel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnDelete = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnPrint = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bmnuSearch = new DevExpress.XtraBars.BarSubItem();
            this.bbtnByCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnByDate = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnExit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.sitmStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.grpMaster = new DevExpress.XtraEditors.GroupControl();
            this.dtpSalesDate = new DevExpress.XtraEditors.DateEdit();
            this.cmbCustomerName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtInvoiceNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.grpDetails = new DevExpress.XtraEditors.GroupControl();
            this.gclStatus = new DevExpress.XtraEditors.GroupControl();
            this.lblLastInvoice = new DevExpress.XtraEditors.LabelControl();
            this.lblLastSaleAmount = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSaleAmount = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSaleCount = new DevExpress.XtraEditors.LabelControl();
            this.pnlSales = new DevExpress.XtraEditors.PanelControl();
            this.rgpPaymentType = new DevExpress.XtraEditors.RadioGroup();
            this.txtDue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmountPaid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtFinalDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.grdProducts = new DevExpress.XtraGrid.GridControl();
            this.gvwProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPPackageUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPStockQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnProductList = new DevExpress.XtraEditors.SimpleButton();
            this.grdSales = new DevExpress.XtraGrid.GridControl();
            this.gvwSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackageUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtUnitPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hlBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.grpSearch = new DevExpress.XtraEditors.GroupControl();
            this.grpSearchByCustomer = new DevExpress.XtraEditors.GroupControl();
            this.cmbSearchCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSearchByCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.grpSearchByDate = new DevExpress.XtraEditors.GroupControl();
            this.btnSearchByDate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.dtpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gvwSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVATSearch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDiscount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).BeginInit();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDetails)).BeginInit();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclStatus)).BeginInit();
            this.gclStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSales)).BeginInit();
            this.pnlSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgpPaymentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchByCustomer)).BeginInit();
            this.grpSearchByCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchByDate)).BeginInit();
            this.grpSearchByDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
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
            this.bbtnPrint,
            this.bbtnSave,
            this.bbtnCancel,
            this.sitmStatus,
            this.barStaticItem1,
            this.bmnuSearch,
            this.barSubItem2,
            this.barSubItem3,
            this.bbtnByCustomer,
            this.bbtnByDate,
            this.bbtnExit});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.bmnuSearch),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnExit)});
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
            // bbtnPrint
            // 
            this.bbtnPrint.Caption = "&Print";
            this.bbtnPrint.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnPrint.Id = 13;
            this.bbtnPrint.LargeGlyph = global::TradeManagement.Properties.Resources.Print;
            this.bbtnPrint.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnPrint.Name = "bbtnPrint";
            this.bbtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPrint_ItemClick);
            // 
            // bmnuSearch
            // 
            this.bmnuSearch.Caption = "&Search";
            this.bmnuSearch.Glyph = global::TradeManagement.Properties.Resources.Search;
            this.bmnuSearch.Id = 25;
            this.bmnuSearch.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnByCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnByDate)});
            this.bmnuSearch.Name = "bmnuSearch";
            this.bmnuSearch.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbtnByCustomer
            // 
            this.bbtnByCustomer.Caption = "By Customer";
            this.bbtnByCustomer.Id = 28;
            this.bbtnByCustomer.Name = "bbtnByCustomer";
            this.bbtnByCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnByCustomer_ItemClick);
            // 
            // bbtnByDate
            // 
            this.bbtnByDate.Caption = "By Date";
            this.bbtnByDate.Id = 29;
            this.bbtnByDate.Name = "bbtnByDate";
            this.bbtnByDate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnByDate_ItemClick);
            // 
            // bbtnExit
            // 
            this.bbtnExit.Caption = "E&xit";
            this.bbtnExit.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnExit.Glyph")));
            this.bbtnExit.Id = 30;
            this.bbtnExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbtnExit.LargeGlyph")));
            this.bbtnExit.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnExit.Name = "bbtnExit";
            this.bbtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnExit_ItemClick);
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.sitmStatus)});
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
            this.sitmStatus.Size = new System.Drawing.Size(32, 0);
            this.sitmStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.sitmStatus.Width = 32;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1025, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 601);
            this.barDockControlBottom.Size = new System.Drawing.Size(1025, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1025, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 22;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "By Supplier";
            this.barSubItem2.Id = 26;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "By Date";
            this.barSubItem3.Id = 27;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // grpMaster
            // 
            this.grpMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMaster.Controls.Add(this.dtpSalesDate);
            this.grpMaster.Controls.Add(this.cmbCustomerName);
            this.grpMaster.Controls.Add(this.labelControl3);
            this.grpMaster.Controls.Add(this.labelControl2);
            this.grpMaster.Controls.Add(this.txtInvoiceNo);
            this.grpMaster.Controls.Add(this.labelControl1);
            this.grpMaster.Enabled = false;
            this.grpMaster.Location = new System.Drawing.Point(12, 109);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.ShowCaption = false;
            this.grpMaster.Size = new System.Drawing.Size(1001, 30);
            this.grpMaster.TabIndex = 1;
            // 
            // dtpSalesDate
            // 
            this.dtpSalesDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpSalesDate.EditValue = null;
            this.dtpSalesDate.EnterMoveNextControl = true;
            this.dtpSalesDate.Location = new System.Drawing.Point(391, 5);
            this.dtpSalesDate.Name = "dtpSalesDate";
            this.dtpSalesDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSalesDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpSalesDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpSalesDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpSalesDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpSalesDate.Properties.ReadOnly = true;
            this.dtpSalesDate.Size = new System.Drawing.Size(112, 20);
            this.dtpSalesDate.TabIndex = 3;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCustomerName.Location = new System.Drawing.Point(591, 5);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomerName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cstCustomerName", "Customer Name")});
            this.cmbCustomerName.Properties.DisplayMember = "cstCustomerName";
            this.cmbCustomerName.Properties.NullText = "";
            this.cmbCustomerName.Properties.ValueMember = "cstCustomerID";
            this.cmbCustomerName.Size = new System.Drawing.Size(236, 20);
            this.cmbCustomerName.TabIndex = 5;
            this.cmbCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomerName_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Location = new System.Drawing.Point(509, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Customer Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(334, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Sales Date";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoiceNo.EnterMoveNextControl = true;
            this.txtInvoiceNo.Location = new System.Drawing.Point(230, 5);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Properties.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(98, 20);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(173, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Invoice No";
            // 
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 53);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(1001, 50);
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
            this.lblCaption.Size = new System.Drawing.Size(997, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Sales";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.gclStatus);
            this.grpDetails.Controls.Add(this.pnlSales);
            this.grpDetails.Controls.Add(this.grdProducts);
            this.grpDetails.Controls.Add(this.btnProductList);
            this.grpDetails.Controls.Add(this.grdSales);
            this.grpDetails.Controls.Add(this.txtBarcode);
            this.grpDetails.Controls.Add(this.labelControl7);
            this.grpDetails.Controls.Add(this.txtUserName);
            this.grpDetails.Controls.Add(this.labelControl8);
            this.grpDetails.Enabled = false;
            this.grpDetails.Location = new System.Drawing.Point(12, 145);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.ShowCaption = false;
            this.grpDetails.Size = new System.Drawing.Size(1001, 450);
            this.grpDetails.TabIndex = 2;
            // 
            // gclStatus
            // 
            this.gclStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gclStatus.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gclStatus.AppearanceCaption.Options.UseFont = true;
            this.gclStatus.AppearanceCaption.Options.UseTextOptions = true;
            this.gclStatus.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gclStatus.Controls.Add(this.lblLastInvoice);
            this.gclStatus.Controls.Add(this.lblLastSaleAmount);
            this.gclStatus.Controls.Add(this.lblTotalSaleAmount);
            this.gclStatus.Controls.Add(this.lblTotalSaleCount);
            this.gclStatus.Location = new System.Drawing.Point(5, 321);
            this.gclStatus.Name = "gclStatus";
            this.gclStatus.Size = new System.Drawing.Size(223, 123);
            this.gclStatus.TabIndex = 6;
            this.gclStatus.Text = "Today\'s Status";
            // 
            // lblLastInvoice
            // 
            this.lblLastInvoice.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastInvoice.Location = new System.Drawing.Point(6, 95);
            this.lblLastInvoice.Name = "lblLastInvoice";
            this.lblLastInvoice.Size = new System.Drawing.Size(0, 16);
            this.lblLastInvoice.TabIndex = 3;
            // 
            // lblLastSaleAmount
            // 
            this.lblLastSaleAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastSaleAmount.Location = new System.Drawing.Point(6, 73);
            this.lblLastSaleAmount.Name = "lblLastSaleAmount";
            this.lblLastSaleAmount.Size = new System.Drawing.Size(0, 16);
            this.lblLastSaleAmount.TabIndex = 2;
            // 
            // lblTotalSaleAmount
            // 
            this.lblTotalSaleAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaleAmount.Location = new System.Drawing.Point(6, 51);
            this.lblTotalSaleAmount.Name = "lblTotalSaleAmount";
            this.lblTotalSaleAmount.Size = new System.Drawing.Size(0, 16);
            this.lblTotalSaleAmount.TabIndex = 1;
            // 
            // lblTotalSaleCount
            // 
            this.lblTotalSaleCount.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaleCount.Location = new System.Drawing.Point(6, 29);
            this.lblTotalSaleCount.Name = "lblTotalSaleCount";
            this.lblTotalSaleCount.Size = new System.Drawing.Size(0, 16);
            this.lblTotalSaleCount.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSales.Controls.Add(this.rgpPaymentType);
            this.pnlSales.Controls.Add(this.txtDue);
            this.pnlSales.Controls.Add(this.labelControl5);
            this.pnlSales.Controls.Add(this.txtAmountPaid);
            this.pnlSales.Controls.Add(this.labelControl6);
            this.pnlSales.Controls.Add(this.txtNetTotal);
            this.pnlSales.Controls.Add(this.labelControl12);
            this.pnlSales.Controls.Add(this.txtFinalDiscount);
            this.pnlSales.Controls.Add(this.labelControl11);
            this.pnlSales.Location = new System.Drawing.Point(718, 320);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(278, 124);
            this.pnlSales.TabIndex = 5;
            // 
            // rgpPaymentType
            // 
            this.rgpPaymentType.Location = new System.Drawing.Point(2, 0);
            this.rgpPaymentType.MenuManager = this.barManager;
            this.rgpPaymentType.Name = "rgpPaymentType";
            this.rgpPaymentType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgpPaymentType.Properties.Appearance.Options.UseBackColor = true;
            this.rgpPaymentType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgpPaymentType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cash"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Visa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "MasterCard"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "American Express"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Maestro"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Others")});
            this.rgpPaymentType.Size = new System.Drawing.Size(111, 124);
            this.rgpPaymentType.TabIndex = 12;
            // 
            // txtDue
            // 
            this.txtDue.EditValue = "";
            this.txtDue.EnterMoveNextControl = true;
            this.txtDue.Location = new System.Drawing.Point(197, 104);
            this.txtDue.Name = "txtDue";
            this.txtDue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDue.Properties.DisplayFormat.FormatString = "n2";
            this.txtDue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDue.Properties.Mask.EditMask = "f";
            this.txtDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDue.Properties.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(81, 20);
            this.txtDue.TabIndex = 9;
            this.txtDue.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(169, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Due";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.EditValue = "";
            this.txtAmountPaid.EnterMoveNextControl = true;
            this.txtAmountPaid.Location = new System.Drawing.Point(197, 78);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAmountPaid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmountPaid.Properties.Mask.EditMask = "f";
            this.txtAmountPaid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmountPaid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(81, 20);
            this.txtAmountPaid.TabIndex = 7;
            this.txtAmountPaid.EditValueChanged += new System.EventHandler(this.txtAmountPaid_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(119, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 13);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Amount Paid";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.EditValue = "";
            this.txtNetTotal.EnterMoveNextControl = true;
            this.txtNetTotal.Location = new System.Drawing.Point(197, 52);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNetTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNetTotal.Properties.DisplayFormat.FormatString = "n2";
            this.txtNetTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtNetTotal.Properties.Mask.EditMask = "f";
            this.txtNetTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNetTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNetTotal.Properties.ReadOnly = true;
            this.txtNetTotal.Size = new System.Drawing.Size(81, 20);
            this.txtNetTotal.TabIndex = 5;
            this.txtNetTotal.TabStop = false;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Location = new System.Drawing.Point(140, 55);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(51, 13);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Net Total";
            // 
            // txtFinalDiscount
            // 
            this.txtFinalDiscount.EditValue = "";
            this.txtFinalDiscount.EnterMoveNextControl = true;
            this.txtFinalDiscount.Location = new System.Drawing.Point(197, 26);
            this.txtFinalDiscount.Name = "txtFinalDiscount";
            this.txtFinalDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtFinalDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtFinalDiscount.Properties.Mask.EditMask = "f";
            this.txtFinalDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFinalDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtFinalDiscount.Size = new System.Drawing.Size(81, 20);
            this.txtFinalDiscount.TabIndex = 3;
            this.txtFinalDiscount.EditValueChanged += new System.EventHandler(this.txtFinalDiscount_EditValueChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Location = new System.Drawing.Point(142, 29);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(49, 13);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Discount";
            // 
            // grdProducts
            // 
            this.grdProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdProducts.Location = new System.Drawing.Point(97, 100);
            this.grdProducts.MainView = this.gvwProducts;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.Size = new System.Drawing.Size(808, 321);
            this.grdProducts.TabIndex = 4;
            this.grdProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwProducts});
            this.grdProducts.Visible = false;
            // 
            // gvwProducts
            // 
            this.gvwProducts.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwProducts.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwProducts.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwProducts.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwProducts.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwProducts.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPName,
            this.colPBrand,
            this.colPModel,
            this.colPPackageUnit,
            this.colPStockQuantity});
            this.gvwProducts.GridControl = this.grdProducts;
            this.gvwProducts.Name = "gvwProducts";
            this.gvwProducts.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvwProducts.OptionsBehavior.Editable = false;
            this.gvwProducts.OptionsCustomization.AllowColumnMoving = false;
            this.gvwProducts.OptionsCustomization.AllowFilter = false;
            this.gvwProducts.OptionsCustomization.AllowGroup = false;
            this.gvwProducts.OptionsMenu.EnableColumnMenu = false;
            this.gvwProducts.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwProducts.OptionsView.EnableAppearanceOddRow = true;
            this.gvwProducts.OptionsView.ShowAutoFilterRow = true;
            this.gvwProducts.OptionsView.ShowGroupPanel = false;
            this.gvwProducts.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvwProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvwProducts_KeyPress);
            this.gvwProducts.DoubleClick += new System.EventHandler(this.gvwProducts_DoubleClick);
            // 
            // colPName
            // 
            this.colPName.AppearanceHeader.Options.UseTextOptions = true;
            this.colPName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPName.Caption = "Product Name";
            this.colPName.FieldName = "pdtProductName";
            this.colPName.Name = "colPName";
            this.colPName.Visible = true;
            this.colPName.VisibleIndex = 0;
            this.colPName.Width = 210;
            // 
            // colPBrand
            // 
            this.colPBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.colPBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPBrand.Caption = "Brand";
            this.colPBrand.FieldName = "bndBrandName";
            this.colPBrand.Name = "colPBrand";
            this.colPBrand.Visible = true;
            this.colPBrand.VisibleIndex = 1;
            this.colPBrand.Width = 175;
            // 
            // colPModel
            // 
            this.colPModel.AppearanceHeader.Options.UseTextOptions = true;
            this.colPModel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPModel.Caption = "Model";
            this.colPModel.FieldName = "pdtModel";
            this.colPModel.Name = "colPModel";
            this.colPModel.Visible = true;
            this.colPModel.VisibleIndex = 2;
            this.colPModel.Width = 145;
            // 
            // colPPackageUnit
            // 
            this.colPPackageUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colPPackageUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPPackageUnit.Caption = "Package Unit";
            this.colPPackageUnit.FieldName = "pdtPackageUnit";
            this.colPPackageUnit.Name = "colPPackageUnit";
            this.colPPackageUnit.Visible = true;
            this.colPPackageUnit.VisibleIndex = 3;
            this.colPPackageUnit.Width = 137;
            // 
            // colPStockQuantity
            // 
            this.colPStockQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colPStockQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPStockQuantity.Caption = "Stock Quantity";
            this.colPStockQuantity.FieldName = "pdtStockQuantity";
            this.colPStockQuantity.Name = "colPStockQuantity";
            this.colPStockQuantity.Visible = true;
            this.colPStockQuantity.VisibleIndex = 4;
            this.colPStockQuantity.Width = 108;
            // 
            // btnProductList
            // 
            this.btnProductList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnProductList.Location = new System.Drawing.Point(542, 5);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(124, 20);
            this.btnProductList.TabIndex = 2;
            this.btnProductList.Text = "Show Product List";
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // grdSales
            // 
            this.grdSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSales.Location = new System.Drawing.Point(5, 31);
            this.grdSales.MainView = this.gvwSales;
            this.grdSales.Name = "grdSales";
            this.grdSales.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.hlBarcode,
            this.txtQuantity,
            this.txtUnitPrice,
            this.txtDiscount});
            this.grdSales.Size = new System.Drawing.Size(991, 284);
            this.grdSales.TabIndex = 3;
            this.grdSales.TabStop = false;
            this.grdSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwSales});
            // 
            // gvwSales
            // 
            this.gvwSales.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSales.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwSales.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSales.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwSales.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSales.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colProductName,
            this.colBrand,
            this.colModel,
            this.colPackageUnit,
            this.colUnitPrice,
            this.colVAT,
            this.colQuantity,
            this.colDiscount,
            this.colTotal});
            this.gvwSales.GridControl = this.grdSales;
            this.gvwSales.Name = "gvwSales";
            this.gvwSales.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwSales.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwSales.OptionsCustomization.AllowColumnMoving = false;
            this.gvwSales.OptionsCustomization.AllowFilter = false;
            this.gvwSales.OptionsCustomization.AllowGroup = false;
            this.gvwSales.OptionsMenu.EnableColumnMenu = false;
            this.gvwSales.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwSales.OptionsView.EnableAppearanceOddRow = true;
            this.gvwSales.OptionsView.ShowFooter = true;
            this.gvwSales.OptionsView.ShowGroupPanel = false;
            this.gvwSales.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvwSales_CellValueChanged);
            // 
            // colProductId
            // 
            this.colProductId.Caption = "Product Id";
            this.colProductId.FieldName = "sldProductId";
            this.colProductId.Name = "colProductId";
            // 
            // colProductName
            // 
            this.colProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.colProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colProductName.Caption = "Product Name";
            this.colProductName.FieldName = "pdtProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 181;
            // 
            // colBrand
            // 
            this.colBrand.AppearanceHeader.Options.UseTextOptions = true;
            this.colBrand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBrand.Caption = "Brand";
            this.colBrand.FieldName = "bndBrandName";
            this.colBrand.Name = "colBrand";
            this.colBrand.OptionsColumn.AllowEdit = false;
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 1;
            this.colBrand.Width = 129;
            // 
            // colModel
            // 
            this.colModel.AppearanceHeader.Options.UseTextOptions = true;
            this.colModel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "pdtModel";
            this.colModel.Name = "colModel";
            this.colModel.OptionsColumn.AllowEdit = false;
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 2;
            this.colModel.Width = 145;
            // 
            // colPackageUnit
            // 
            this.colPackageUnit.AppearanceHeader.Options.UseTextOptions = true;
            this.colPackageUnit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPackageUnit.Caption = "Package Unit";
            this.colPackageUnit.FieldName = "pdtPackageUnit";
            this.colPackageUnit.Name = "colPackageUnit";
            this.colPackageUnit.OptionsColumn.AllowEdit = false;
            this.colPackageUnit.Visible = true;
            this.colPackageUnit.VisibleIndex = 3;
            this.colPackageUnit.Width = 91;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUnitPrice.Caption = "Unit Price";
            this.colUnitPrice.ColumnEdit = this.txtUnitPrice;
            this.colUnitPrice.DisplayFormat.FormatString = "f";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "sldSalesPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            this.colUnitPrice.Width = 69;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoHeight = false;
            this.txtUnitPrice.Mask.EditMask = "f";
            this.txtUnitPrice.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUnitPrice.Mask.UseMaskAsDisplayFormat = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            // 
            // colVAT
            // 
            this.colVAT.AppearanceCell.Options.UseTextOptions = true;
            this.colVAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colVAT.AppearanceHeader.Options.UseTextOptions = true;
            this.colVAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colVAT.Caption = "VAT(%)";
            this.colVAT.DisplayFormat.FormatString = "n2";
            this.colVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVAT.FieldName = "sldVAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Visible = true;
            this.colVAT.VisibleIndex = 5;
            this.colVAT.Width = 55;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.ColumnEdit = this.txtQuantity;
            this.colQuantity.FieldName = "sldQuantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 6;
            this.colQuantity.Width = 61;
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoHeight = false;
            this.txtQuantity.Mask.EditMask = "n0";
            this.txtQuantity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantity.Name = "txtQuantity";
            // 
            // colTotal
            // 
            this.colTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "f";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "sldTotal";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sldTotal", "{0:f}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 8;
            this.colTotal.Width = 103;
            // 
            // hlBarcode
            // 
            this.hlBarcode.AutoHeight = false;
            this.hlBarcode.Name = "hlBarcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBarcode.Location = new System.Drawing.Point(379, 5);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(157, 20);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl7.Location = new System.Drawing.Point(334, 8);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Barcode";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(318, 321);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(396, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(234, 324);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Sales Person: ";
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.grpSearchByCustomer);
            this.grpSearch.Controls.Add(this.grpSearchByDate);
            this.grpSearch.Controls.Add(this.grdSearch);
            this.grpSearch.Location = new System.Drawing.Point(12, 109);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.ShowCaption = false;
            this.grpSearch.Size = new System.Drawing.Size(1001, 486);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.Visible = false;
            // 
            // grpSearchByCustomer
            // 
            this.grpSearchByCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpSearchByCustomer.Controls.Add(this.cmbSearchCustomer);
            this.grpSearchByCustomer.Controls.Add(this.btnSearchByCustomer);
            this.grpSearchByCustomer.Controls.Add(this.labelControl14);
            this.grpSearchByCustomer.Location = new System.Drawing.Point(293, 5);
            this.grpSearchByCustomer.Name = "grpSearchByCustomer";
            this.grpSearchByCustomer.ShowCaption = false;
            this.grpSearchByCustomer.Size = new System.Drawing.Size(414, 35);
            this.grpSearchByCustomer.TabIndex = 1;
            // 
            // cmbSearchCustomer
            // 
            this.cmbSearchCustomer.EnterMoveNextControl = true;
            this.cmbSearchCustomer.Location = new System.Drawing.Point(90, 8);
            this.cmbSearchCustomer.Name = "cmbSearchCustomer";
            this.cmbSearchCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSearchCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cstCustomerName", "Customer Name")});
            this.cmbSearchCustomer.Properties.DisplayMember = "cstCustomerName";
            this.cmbSearchCustomer.Properties.NullText = "";
            this.cmbSearchCustomer.Properties.ValueMember = "cstCustomerID";
            this.cmbSearchCustomer.Size = new System.Drawing.Size(237, 20);
            this.cmbSearchCustomer.TabIndex = 1;
            // 
            // btnSearchByCustomer
            // 
            this.btnSearchByCustomer.Location = new System.Drawing.Point(333, 6);
            this.btnSearchByCustomer.Name = "btnSearchByCustomer";
            this.btnSearchByCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByCustomer.TabIndex = 2;
            this.btnSearchByCustomer.Text = "Search";
            this.btnSearchByCustomer.Click += new System.EventHandler(this.btnSearchByCustomer_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(8, 11);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(76, 13);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "Customer Name";
            // 
            // grpSearchByDate
            // 
            this.grpSearchByDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpSearchByDate.Controls.Add(this.btnSearchByDate);
            this.grpSearchByDate.Controls.Add(this.dtpEndDate);
            this.grpSearchByDate.Controls.Add(this.labelControl13);
            this.grpSearchByDate.Controls.Add(this.dtpStartDate);
            this.grpSearchByDate.Controls.Add(this.labelControl15);
            this.grpSearchByDate.Location = new System.Drawing.Point(285, 5);
            this.grpSearchByDate.Name = "grpSearchByDate";
            this.grpSearchByDate.ShowCaption = false;
            this.grpSearchByDate.Size = new System.Drawing.Size(430, 35);
            this.grpSearchByDate.TabIndex = 0;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(349, 6);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByDate.TabIndex = 4;
            this.btnSearchByDate.Text = "Search";
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.EditValue = null;
            this.dtpEndDate.EnterMoveNextControl = true;
            this.dtpEndDate.Location = new System.Drawing.Point(231, 8);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEndDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpEndDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpEndDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpEndDate.Size = new System.Drawing.Size(112, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(181, 11);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(44, 13);
            this.labelControl13.TabIndex = 2;
            this.labelControl13.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.EditValue = null;
            this.dtpStartDate.EnterMoveNextControl = true;
            this.dtpStartDate.Location = new System.Drawing.Point(63, 8);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStartDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpStartDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpStartDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpStartDate.Size = new System.Drawing.Size(112, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(7, 11);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(50, 13);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "Start Date";
            // 
            // grdSearch
            // 
            this.grdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(5, 46);
            this.grdSearch.MainView = this.gvwSearch;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1});
            this.grdSearch.Size = new System.Drawing.Size(991, 435);
            this.grdSearch.TabIndex = 2;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwSearch});
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
            this.colInvoiceNo,
            this.colSalesDate,
            this.colCustomerId,
            this.colCustomerName,
            this.colTotalAmount,
            this.colVATSearch,
            this.colSDiscount,
            this.colNetTotal});
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
            this.gvwSearch.OptionsView.ShowFooter = true;
            this.gvwSearch.OptionsView.ShowGroupPanel = false;
            this.gvwSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvwSearch_KeyPress);
            this.gvwSearch.DoubleClick += new System.EventHandler(this.gvwSearch_DoubleClick);
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvoiceNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvoiceNo.Caption = "Invoice No";
            this.colInvoiceNo.FieldName = "slsInvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 0;
            this.colInvoiceNo.Width = 78;
            // 
            // colSalesDate
            // 
            this.colSalesDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalesDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSalesDate.Caption = "Sales Date";
            this.colSalesDate.DisplayFormat.FormatString = "MMM dd, yyyy";
            this.colSalesDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSalesDate.FieldName = "slsSalesDate";
            this.colSalesDate.Name = "colSalesDate";
            this.colSalesDate.Visible = true;
            this.colSalesDate.VisibleIndex = 1;
            this.colSalesDate.Width = 79;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Caption = "Customer Id";
            this.colCustomerId.FieldName = "slsCustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Width = 132;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AppearanceHeader.Options.UseTextOptions = true;
            this.colCustomerName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCustomerName.Caption = "Customer Name";
            this.colCustomerName.FieldName = "cstCustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 251;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotalAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalAmount.Caption = "Total Amount";
            this.colTotalAmount.DisplayFormat.FormatString = "f";
            this.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAmount.FieldName = "slsTotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 3;
            this.colTotalAmount.Width = 92;
            // 
            // colVATSearch
            // 
            this.colVATSearch.AppearanceCell.Options.UseTextOptions = true;
            this.colVATSearch.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colVATSearch.AppearanceHeader.Options.UseTextOptions = true;
            this.colVATSearch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVATSearch.Caption = "VAT";
            this.colVATSearch.DisplayFormat.FormatString = "f";
            this.colVATSearch.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVATSearch.FieldName = "slsVAT";
            this.colVATSearch.Name = "colVATSearch";
            this.colVATSearch.Visible = true;
            this.colVATSearch.VisibleIndex = 4;
            this.colVATSearch.Width = 49;
            // 
            // colSDiscount
            // 
            this.colSDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.colSDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.colSDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSDiscount.Caption = "Discount";
            this.colSDiscount.DisplayFormat.FormatString = "f";
            this.colSDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSDiscount.FieldName = "slsDiscount";
            this.colSDiscount.Name = "colSDiscount";
            this.colSDiscount.Visible = true;
            this.colSDiscount.VisibleIndex = 5;
            this.colSDiscount.Width = 56;
            // 
            // colNetTotal
            // 
            this.colNetTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colNetTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNetTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colNetTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNetTotal.Caption = "Net Total";
            this.colNetTotal.DisplayFormat.FormatString = "f";
            this.colNetTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNetTotal.FieldName = "slsNetTotal";
            this.colNetTotal.Name = "colNetTotal";
            this.colNetTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "slsNetTotal", "{0:f}")});
            this.colNetTotal.Visible = true;
            this.colNetTotal.VisibleIndex = 6;
            this.colNetTotal.Width = 80;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // colDiscount
            // 
            this.colDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.colDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiscount.Caption = "Discount";
            this.colDiscount.ColumnEdit = this.txtDiscount;
            this.colDiscount.DisplayFormat.FormatString = "f";
            this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscount.FieldName = "sldDiscount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 7;
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoHeight = false;
            this.txtDiscount.Name = "txtDiscount";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 626);
            this.Controls.Add(this.grcCaption);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSales";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).EndInit();
            this.grpMaster.ResumeLayout(false);
            this.grpMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDetails)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclStatus)).EndInit();
            this.gclStatus.ResumeLayout(false);
            this.gclStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSales)).EndInit();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgpPaymentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchByCustomer)).EndInit();
            this.grpSearchByCustomer.ResumeLayout(false);
            this.grpSearchByCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchByDate)).EndInit();
            this.grpSearchByDate.ResumeLayout(false);
            this.grpSearchByDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barOptions;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnNew;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnEdit;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnSave;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnCancel;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnDelete;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnPrint;
        private DevExpress.XtraBars.BarSubItem bmnuSearch;
        private DevExpress.XtraBars.BarButtonItem bbtnByCustomer;
        private DevExpress.XtraBars.BarButtonItem bbtnByDate;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem sitmStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraEditors.GroupControl grpMaster;
        private DevExpress.XtraEditors.DateEdit dtpSalesDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtInvoiceNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.GroupControl grpDetails;
        private DevExpress.XtraGrid.GridControl grdSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwSales;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit hlBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.LookUpEdit cmbCustomerName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtQuantity;
        private DevExpress.XtraEditors.GroupControl grpSearch;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colVATSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colNetTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.GroupControl grpSearchByCustomer;
        private DevExpress.XtraEditors.SimpleButton btnSearchByCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.GroupControl grpSearchByDate;
        private DevExpress.XtraEditors.SimpleButton btnSearchByDate;
        private DevExpress.XtraEditors.DateEdit dtpEndDate;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.DateEdit dtpStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LookUpEdit cmbSearchCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraEditors.SimpleButton btnProductList;
        private DevExpress.XtraGrid.GridControl grdProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colPName;
        private DevExpress.XtraGrid.Columns.GridColumn colPBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colPModel;
        private DevExpress.XtraGrid.Columns.GridColumn colPPackageUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colPStockQuantity;
        private DevExpress.XtraEditors.PanelControl pnlSales;
        private DevExpress.XtraEditors.TextEdit txtDue;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtAmountPaid;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtNetTotal;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtFinalDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtUnitPrice;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnExit;
        private DevExpress.XtraEditors.GroupControl gclStatus;
        private DevExpress.XtraEditors.LabelControl lblLastInvoice;
        private DevExpress.XtraEditors.LabelControl lblLastSaleAmount;
        private DevExpress.XtraEditors.LabelControl lblTotalSaleAmount;
        private DevExpress.XtraEditors.LabelControl lblTotalSaleCount;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.RadioGroup rgpPaymentType;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtDiscount;
    }
}