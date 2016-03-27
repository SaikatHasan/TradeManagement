namespace TradeManagement.Forms
{
    partial class frmQuotations
    {
        private System.ComponentModel.IContainer components = null;

        private static frmQuotations sForm = null;

        public static frmQuotations Instance()
        {
            if (sForm == null) { sForm = new frmQuotations(); }
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
            this.bbtnPrint = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bmnuSearch = new DevExpress.XtraBars.BarSubItem();
            this.bbtnByCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnByDate = new DevExpress.XtraBars.BarButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.sitmStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.grpMaster = new DevExpress.XtraEditors.GroupControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.dtpQuotationDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuotationNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grpDetails = new DevExpress.XtraEditors.GroupControl();
            this.pnlSales = new DevExpress.XtraEditors.PanelControl();
            this.txtVAT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.grdProducts = new DevExpress.XtraGrid.GridControl();
            this.gvwProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPPackageUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPStockQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnProductList = new DevExpress.XtraEditors.SimpleButton();
            this.grdQuotations = new DevExpress.XtraGrid.GridControl();
            this.gvwQuotations = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackageUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtUnitPrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hlBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
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
            this.colQuotationNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuotationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).BeginInit();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpQuotationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpQuotationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuotationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDetails)).BeginInit();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSales)).BeginInit();
            this.pnlSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuotations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwQuotations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
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
            this.bbtnByDate});
            this.barManager.MaxItemId = 30;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bmnuSearch)});
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
            this.sitmStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            this.sitmStatus.Width = 32;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(886, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            this.barDockControlBottom.Size = new System.Drawing.Size(886, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(886, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
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
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 53);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(862, 50);
            this.grcCaption.TabIndex = 4;
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Location = new System.Drawing.Point(2, 2);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(858, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Quotations";
            // 
            // grpMaster
            // 
            this.grpMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMaster.Controls.Add(this.txtPhone);
            this.grpMaster.Controls.Add(this.labelControl5);
            this.grpMaster.Controls.Add(this.txtAddress);
            this.grpMaster.Controls.Add(this.labelControl4);
            this.grpMaster.Controls.Add(this.txtCustomerName);
            this.grpMaster.Controls.Add(this.dtpQuotationDate);
            this.grpMaster.Controls.Add(this.labelControl3);
            this.grpMaster.Controls.Add(this.labelControl2);
            this.grpMaster.Controls.Add(this.txtQuotationNo);
            this.grpMaster.Controls.Add(this.labelControl1);
            this.grpMaster.Enabled = false;
            this.grpMaster.Location = new System.Drawing.Point(12, 109);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.ShowCaption = false;
            this.grpMaster.Size = new System.Drawing.Size(862, 56);
            this.grpMaster.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(614, 31);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(113, 20);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(538, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Phone Number";
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(205, 31);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(327, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(160, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.EnterMoveNextControl = true;
            this.txtCustomerName.Location = new System.Drawing.Point(538, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(189, 20);
            this.txtCustomerName.TabIndex = 5;
            // 
            // dtpQuotationDate
            // 
            this.dtpQuotationDate.EditValue = null;
            this.dtpQuotationDate.EnterMoveNextControl = true;
            this.dtpQuotationDate.Location = new System.Drawing.Point(338, 5);
            this.dtpQuotationDate.Name = "dtpQuotationDate";
            this.dtpQuotationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpQuotationDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpQuotationDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpQuotationDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpQuotationDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpQuotationDate.Properties.ReadOnly = true;
            this.dtpQuotationDate.Size = new System.Drawing.Size(112, 20);
            this.dtpQuotationDate.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(456, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Customer Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(309, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Date";
            // 
            // txtQuotationNo
            // 
            this.txtQuotationNo.EnterMoveNextControl = true;
            this.txtQuotationNo.Location = new System.Drawing.Point(205, 5);
            this.txtQuotationNo.Name = "txtQuotationNo";
            this.txtQuotationNo.Properties.ReadOnly = true;
            this.txtQuotationNo.Size = new System.Drawing.Size(98, 20);
            this.txtQuotationNo.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(135, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quotation No";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.pnlSales);
            this.grpDetails.Controls.Add(this.grdProducts);
            this.grpDetails.Controls.Add(this.btnProductList);
            this.grpDetails.Controls.Add(this.grdQuotations);
            this.grpDetails.Controls.Add(this.txtBarcode);
            this.grpDetails.Controls.Add(this.labelControl9);
            this.grpDetails.Enabled = false;
            this.grpDetails.Location = new System.Drawing.Point(12, 171);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.ShowCaption = false;
            this.grpDetails.Size = new System.Drawing.Size(862, 359);
            this.grpDetails.TabIndex = 6;
            // 
            // pnlSales
            // 
            this.pnlSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSales.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSales.Controls.Add(this.txtVAT);
            this.pnlSales.Controls.Add(this.labelControl8);
            this.pnlSales.Controls.Add(this.txtNetTotal);
            this.pnlSales.Controls.Add(this.labelControl12);
            this.pnlSales.Controls.Add(this.txtDiscount);
            this.pnlSales.Controls.Add(this.labelControl11);
            this.pnlSales.Location = new System.Drawing.Point(681, 281);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(173, 72);
            this.pnlSales.TabIndex = 5;
            // 
            // txtVAT
            // 
            this.txtVAT.EditValue = "";
            this.txtVAT.EnterMoveNextControl = true;
            this.txtVAT.Location = new System.Drawing.Point(92, 0);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Properties.Appearance.Options.UseTextOptions = true;
            this.txtVAT.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtVAT.Properties.Mask.EditMask = "f";
            this.txtVAT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtVAT.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtVAT.Properties.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(81, 20);
            this.txtVAT.TabIndex = 1;
            this.txtVAT.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(64, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "VAT";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.EditValue = "";
            this.txtNetTotal.EnterMoveNextControl = true;
            this.txtNetTotal.Location = new System.Drawing.Point(92, 52);
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
            this.labelControl12.Location = new System.Drawing.Point(35, 55);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(51, 13);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Net Total";
            // 
            // txtDiscount
            // 
            this.txtDiscount.EditValue = "";
            this.txtDiscount.EnterMoveNextControl = true;
            this.txtDiscount.Location = new System.Drawing.Point(92, 26);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDiscount.Properties.Mask.EditMask = "f";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Size = new System.Drawing.Size(81, 20);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.EditValueChanged += new System.EventHandler(this.txtDiscount_EditValueChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Location = new System.Drawing.Point(37, 29);
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
            this.grdProducts.Location = new System.Drawing.Point(97, 31);
            this.grdProducts.MainView = this.gvwProducts;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.Size = new System.Drawing.Size(669, 302);
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
            this.colPName.Caption = "Product Name";
            this.colPName.FieldName = "pdtProductName";
            this.colPName.Name = "colPName";
            this.colPName.Visible = true;
            this.colPName.VisibleIndex = 0;
            this.colPName.Width = 210;
            // 
            // colPBrand
            // 
            this.colPBrand.Caption = "Brand";
            this.colPBrand.FieldName = "bndBrandName";
            this.colPBrand.Name = "colPBrand";
            this.colPBrand.Visible = true;
            this.colPBrand.VisibleIndex = 1;
            this.colPBrand.Width = 175;
            // 
            // colPModel
            // 
            this.colPModel.Caption = "Model";
            this.colPModel.FieldName = "pdtModel";
            this.colPModel.Name = "colPModel";
            this.colPModel.Visible = true;
            this.colPModel.VisibleIndex = 2;
            this.colPModel.Width = 145;
            // 
            // colPPackageUnit
            // 
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
            this.colPStockQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
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
            this.btnProductList.Location = new System.Drawing.Point(473, 5);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(124, 20);
            this.btnProductList.TabIndex = 2;
            this.btnProductList.Text = "Show Product List";
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // grdQuotations
            // 
            this.grdQuotations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdQuotations.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdQuotations.Location = new System.Drawing.Point(5, 31);
            this.grdQuotations.MainView = this.gvwQuotations;
            this.grdQuotations.Name = "grdQuotations";
            this.grdQuotations.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.hlBarcode,
            this.txtQuantity,
            this.txtUnitPrice});
            this.grdQuotations.Size = new System.Drawing.Size(852, 244);
            this.grdQuotations.TabIndex = 3;
            this.grdQuotations.TabStop = false;
            this.grdQuotations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwQuotations});
            // 
            // gvwQuotations
            // 
            this.gvwQuotations.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwQuotations.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwQuotations.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwQuotations.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwQuotations.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwQuotations.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwQuotations.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colProductName,
            this.colBrand,
            this.colModel,
            this.colPackageUnit,
            this.colUnitPrice,
            this.colQuantity,
            this.colTotal});
            this.gvwQuotations.GridControl = this.grdQuotations;
            this.gvwQuotations.Name = "gvwQuotations";
            this.gvwQuotations.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwQuotations.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwQuotations.OptionsCustomization.AllowColumnMoving = false;
            this.gvwQuotations.OptionsCustomization.AllowFilter = false;
            this.gvwQuotations.OptionsCustomization.AllowGroup = false;
            this.gvwQuotations.OptionsMenu.EnableColumnMenu = false;
            this.gvwQuotations.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwQuotations.OptionsView.EnableAppearanceOddRow = true;
            this.gvwQuotations.OptionsView.ShowFooter = true;
            this.gvwQuotations.OptionsView.ShowGroupPanel = false;
            this.gvwQuotations.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvwQuotations_CellValueChanged);
            // 
            // colProductId
            // 
            this.colProductId.Caption = "Product Id";
            this.colProductId.FieldName = "qodProductId";
            this.colProductId.Name = "colProductId";
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product Name";
            this.colProductName.FieldName = "pdtProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 165;
            // 
            // colBrand
            // 
            this.colBrand.Caption = "Brand";
            this.colBrand.FieldName = "bndBrandName";
            this.colBrand.Name = "colBrand";
            this.colBrand.OptionsColumn.AllowEdit = false;
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 1;
            this.colBrand.Width = 118;
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "pdtModel";
            this.colModel.Name = "colModel";
            this.colModel.OptionsColumn.AllowEdit = false;
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 2;
            this.colModel.Width = 133;
            // 
            // colPackageUnit
            // 
            this.colPackageUnit.Caption = "Package Unit";
            this.colPackageUnit.FieldName = "pdtPackageUnit";
            this.colPackageUnit.Name = "colPackageUnit";
            this.colPackageUnit.OptionsColumn.AllowEdit = false;
            this.colPackageUnit.Visible = true;
            this.colPackageUnit.VisibleIndex = 3;
            this.colPackageUnit.Width = 83;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUnitPrice.Caption = "Unit Price";
            this.colUnitPrice.ColumnEdit = this.txtUnitPrice;
            this.colUnitPrice.DisplayFormat.FormatString = "f";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "qodQuotationPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            this.colUnitPrice.Width = 63;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoHeight = false;
            this.txtUnitPrice.Mask.EditMask = "n2";
            this.txtUnitPrice.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUnitPrice.Mask.UseMaskAsDisplayFormat = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.ColumnEdit = this.txtQuantity;
            this.colQuantity.FieldName = "qodQuantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            this.colQuantity.Width = 56;
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
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "f";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "qodTotal";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "qodTotal", "{0:f}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            this.colTotal.Width = 67;
            // 
            // hlBarcode
            // 
            this.hlBarcode.AutoHeight = false;
            this.hlBarcode.Name = "hlBarcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBarcode.Location = new System.Drawing.Point(310, 5);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(157, 20);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Location = new System.Drawing.Point(265, 8);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(39, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Barcode";
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
            this.grpSearch.Size = new System.Drawing.Size(862, 421);
            this.grpSearch.TabIndex = 11;
            this.grpSearch.Visible = false;
            // 
            // grpSearchByCustomer
            // 
            this.grpSearchByCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpSearchByCustomer.Controls.Add(this.cmbSearchCustomer);
            this.grpSearchByCustomer.Controls.Add(this.btnSearchByCustomer);
            this.grpSearchByCustomer.Controls.Add(this.labelControl14);
            this.grpSearchByCustomer.Location = new System.Drawing.Point(224, 5);
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("qotCustomerName", "Customer Name")});
            this.cmbSearchCustomer.Properties.DisplayMember = "qotCustomerName";
            this.cmbSearchCustomer.Properties.NullText = "";
            this.cmbSearchCustomer.Properties.ValueMember = "qotCustomerName";
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
            this.grpSearchByDate.Location = new System.Drawing.Point(216, 5);
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
            this.grdSearch.Size = new System.Drawing.Size(852, 370);
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
            this.colQuotationNo,
            this.colQuotationDate,
            this.colCustomerName,
            this.colPhone,
            this.colTotalAmount,
            this.colVAT,
            this.colDiscount,
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
            // colQuotationNo
            // 
            this.colQuotationNo.Caption = "Quotation No";
            this.colQuotationNo.FieldName = "qotQuotationNo";
            this.colQuotationNo.Name = "colQuotationNo";
            this.colQuotationNo.Visible = true;
            this.colQuotationNo.VisibleIndex = 0;
            this.colQuotationNo.Width = 85;
            // 
            // colQuotationDate
            // 
            this.colQuotationDate.Caption = "Quotation Date";
            this.colQuotationDate.DisplayFormat.FormatString = "MMM dd, yyyy";
            this.colQuotationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colQuotationDate.FieldName = "qotQuotationDate";
            this.colQuotationDate.Name = "colQuotationDate";
            this.colQuotationDate.Visible = true;
            this.colQuotationDate.VisibleIndex = 1;
            this.colQuotationDate.Width = 97;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Customer Name";
            this.colCustomerName.FieldName = "qotCustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 246;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone Number";
            this.colPhone.FieldName = "qotPhone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 94;
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
            this.colTotalAmount.FieldName = "qotTotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 4;
            this.colTotalAmount.Width = 99;
            // 
            // colVAT
            // 
            this.colVAT.AppearanceCell.Options.UseTextOptions = true;
            this.colVAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colVAT.AppearanceHeader.Options.UseTextOptions = true;
            this.colVAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colVAT.Caption = "VAT";
            this.colVAT.DisplayFormat.FormatString = "f";
            this.colVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVAT.FieldName = "qotVAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Visible = true;
            this.colVAT.VisibleIndex = 5;
            this.colVAT.Width = 53;
            // 
            // colDiscount
            // 
            this.colDiscount.AppearanceCell.Options.UseTextOptions = true;
            this.colDiscount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDiscount.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiscount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDiscount.Caption = "Discount";
            this.colDiscount.DisplayFormat.FormatString = "f";
            this.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscount.FieldName = "qotDiscount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 6;
            this.colDiscount.Width = 60;
            // 
            // colNetTotal
            // 
            this.colNetTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colNetTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNetTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colNetTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colNetTotal.Caption = "Net Total";
            this.colNetTotal.DisplayFormat.FormatString = "f";
            this.colNetTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNetTotal.FieldName = "qotNetTotal";
            this.colNetTotal.Name = "colNetTotal";
            this.colNetTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "slsNetTotal", "{0:f}")});
            this.colNetTotal.Visible = true;
            this.colNetTotal.VisibleIndex = 7;
            this.colNetTotal.Width = 100;
            // 
            // frmQuotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 561);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.grcCaption);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuotations";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quotations";
            this.Load += new System.EventHandler(this.frmQuotations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).EndInit();
            this.grpMaster.ResumeLayout(false);
            this.grpMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpQuotationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpQuotationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuotationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDetails)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSales)).EndInit();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuotations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwQuotations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.GroupControl grpMaster;
        private DevExpress.XtraEditors.DateEdit dtpQuotationDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtQuotationNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl grpDetails;
        private DevExpress.XtraEditors.PanelControl pnlSales;
        private DevExpress.XtraEditors.TextEdit txtVAT;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNetTotal;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraGrid.GridControl grdProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colPName;
        private DevExpress.XtraGrid.Columns.GridColumn colPBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colPModel;
        private DevExpress.XtraGrid.Columns.GridColumn colPPackageUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colPStockQuantity;
        private DevExpress.XtraEditors.SimpleButton btnProductList;
        private DevExpress.XtraGrid.GridControl grdQuotations;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwQuotations;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit hlBarcode;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl grpSearch;
        private DevExpress.XtraEditors.GroupControl grpSearchByCustomer;
        private DevExpress.XtraEditors.LookUpEdit cmbSearchCustomer;
        private DevExpress.XtraEditors.SimpleButton btnSearchByCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.GroupControl grpSearchByDate;
        private DevExpress.XtraEditors.SimpleButton btnSearchByDate;
        private DevExpress.XtraEditors.DateEdit dtpEndDate;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.DateEdit dtpStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationNo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuotationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colNetTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtUnitPrice;
    }
}