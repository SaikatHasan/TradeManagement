namespace TradeManagement.Forms
{
    partial class frmSaleReturns
    {
        private System.ComponentModel.IContainer components = null;

        private static frmSaleReturns sForm = null;

        public static frmSaleReturns Instance()
        {
            if (sForm == null) { sForm = new frmSaleReturns(); }
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
            this.grpDetails = new DevExpress.XtraEditors.GroupControl();
            this.grdSalesReturn = new DevExpress.XtraGrid.GridControl();
            this.gvwSalesReturn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackageUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtReturnQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.hlBarcode = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.txtAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.grpMaster = new DevExpress.XtraEditors.GroupControl();
            this.cmbInvoiceNo = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbCustomerName = new DevExpress.XtraEditors.LookUpEdit();
            this.txtReturnId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpReturnDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
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
            this.colReturnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReturnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDetails)).BeginInit();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSalesReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).BeginInit();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReturnDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReturnDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(884, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 547);
            this.barDockControlBottom.Size = new System.Drawing.Size(884, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 500);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(884, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 500);
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
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.grdSalesReturn);
            this.grpDetails.Enabled = false;
            this.grpDetails.Location = new System.Drawing.Point(12, 145);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.ShowCaption = false;
            this.grpDetails.Size = new System.Drawing.Size(860, 396);
            this.grpDetails.TabIndex = 2;
            // 
            // grdSalesReturn
            // 
            this.grdSalesReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSalesReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSalesReturn.Location = new System.Drawing.Point(5, 5);
            this.grdSalesReturn.MainView = this.gvwSalesReturn;
            this.grdSalesReturn.Name = "grdSalesReturn";
            this.grdSalesReturn.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.hlBarcode,
            this.txtReturnQuantity,
            this.txtAmount});
            this.grdSalesReturn.Size = new System.Drawing.Size(850, 386);
            this.grdSalesReturn.TabIndex = 0;
            this.grdSalesReturn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwSalesReturn});
            // 
            // gvwSalesReturn
            // 
            this.gvwSalesReturn.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSalesReturn.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwSalesReturn.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSalesReturn.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwSalesReturn.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSalesReturn.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwSalesReturn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colProductName,
            this.colBrand,
            this.colModel,
            this.colPackageUnit,
            this.colSaleQuantity,
            this.colReturnQuantity});
            this.gvwSalesReturn.GridControl = this.grdSalesReturn;
            this.gvwSalesReturn.Name = "gvwSalesReturn";
            this.gvwSalesReturn.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwSalesReturn.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwSalesReturn.OptionsCustomization.AllowColumnMoving = false;
            this.gvwSalesReturn.OptionsCustomization.AllowFilter = false;
            this.gvwSalesReturn.OptionsCustomization.AllowGroup = false;
            this.gvwSalesReturn.OptionsMenu.EnableColumnMenu = false;
            this.gvwSalesReturn.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwSalesReturn.OptionsView.EnableAppearanceOddRow = true;
            this.gvwSalesReturn.OptionsView.ShowGroupPanel = false;
            this.gvwSalesReturn.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvwSalesReturn_CellValueChanged);
            // 
            // colProductId
            // 
            this.colProductId.Caption = "Product Id";
            this.colProductId.FieldName = "sldProductId";
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
            this.colProductName.Width = 244;
            // 
            // colBrand
            // 
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
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "pdtModel";
            this.colModel.Name = "colModel";
            this.colModel.OptionsColumn.AllowEdit = false;
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 2;
            this.colModel.Width = 147;
            // 
            // colPackageUnit
            // 
            this.colPackageUnit.Caption = "Package Unit";
            this.colPackageUnit.FieldName = "pdtPackageUnit";
            this.colPackageUnit.Name = "colPackageUnit";
            this.colPackageUnit.OptionsColumn.AllowEdit = false;
            this.colPackageUnit.Visible = true;
            this.colPackageUnit.VisibleIndex = 3;
            this.colPackageUnit.Width = 84;
            // 
            // colSaleQuantity
            // 
            this.colSaleQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colSaleQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSaleQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaleQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSaleQuantity.Caption = "Sale Qty";
            this.colSaleQuantity.FieldName = "srdSaleQuantity";
            this.colSaleQuantity.Name = "colSaleQuantity";
            this.colSaleQuantity.OptionsColumn.AllowEdit = false;
            this.colSaleQuantity.Visible = true;
            this.colSaleQuantity.VisibleIndex = 4;
            this.colSaleQuantity.Width = 56;
            // 
            // colReturnQuantity
            // 
            this.colReturnQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colReturnQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colReturnQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colReturnQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colReturnQuantity.Caption = "Ret Qty";
            this.colReturnQuantity.ColumnEdit = this.txtReturnQuantity;
            this.colReturnQuantity.FieldName = "srdReturnQuantity";
            this.colReturnQuantity.Name = "colReturnQuantity";
            this.colReturnQuantity.Visible = true;
            this.colReturnQuantity.VisibleIndex = 5;
            this.colReturnQuantity.Width = 82;
            // 
            // txtReturnQuantity
            // 
            this.txtReturnQuantity.AutoHeight = false;
            this.txtReturnQuantity.Mask.EditMask = "f0";
            this.txtReturnQuantity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtReturnQuantity.Name = "txtReturnQuantity";
            // 
            // hlBarcode
            // 
            this.hlBarcode.AutoHeight = false;
            this.hlBarcode.Name = "hlBarcode";
            // 
            // txtAmount
            // 
            this.txtAmount.AutoHeight = false;
            this.txtAmount.Mask.EditMask = "f";
            this.txtAmount.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmount.Name = "txtAmount";
            // 
            // grpMaster
            // 
            this.grpMaster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMaster.Controls.Add(this.cmbInvoiceNo);
            this.grpMaster.Controls.Add(this.cmbCustomerName);
            this.grpMaster.Controls.Add(this.txtReturnId);
            this.grpMaster.Controls.Add(this.labelControl1);
            this.grpMaster.Controls.Add(this.dtpReturnDate);
            this.grpMaster.Controls.Add(this.labelControl2);
            this.grpMaster.Controls.Add(this.labelControl8);
            this.grpMaster.Controls.Add(this.labelControl3);
            this.grpMaster.Enabled = false;
            this.grpMaster.Location = new System.Drawing.Point(12, 109);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.ShowCaption = false;
            this.grpMaster.Size = new System.Drawing.Size(860, 30);
            this.grpMaster.TabIndex = 1;
            // 
            // cmbInvoiceNo
            // 
            this.cmbInvoiceNo.EnterMoveNextControl = true;
            this.cmbInvoiceNo.Location = new System.Drawing.Point(733, 5);
            this.cmbInvoiceNo.Name = "cmbInvoiceNo";
            this.cmbInvoiceNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInvoiceNo.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("slsInvoiceNo", "Invoice No")});
            this.cmbInvoiceNo.Properties.DisplayMember = "slsInvoiceNo";
            this.cmbInvoiceNo.Properties.NullText = "";
            this.cmbInvoiceNo.Properties.ValueMember = "slsInvoiceNo";
            this.cmbInvoiceNo.Size = new System.Drawing.Size(122, 20);
            this.cmbInvoiceNo.TabIndex = 7;
            this.cmbInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbInvoiceNo_KeyPress);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.EnterMoveNextControl = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(426, 5);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomerName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cstCustomerName", "Customer Name")});
            this.cmbCustomerName.Properties.DisplayMember = "cstCustomerName";
            this.cmbCustomerName.Properties.NullText = "";
            this.cmbCustomerName.Properties.ValueMember = "cstCustomerID";
            this.cmbCustomerName.Size = new System.Drawing.Size(244, 20);
            this.cmbCustomerName.TabIndex = 5;
            this.cmbCustomerName.EditValueChanged += new System.EventHandler(this.cmbCustomerName_EditValueChanged);
            // 
            // txtReturnId
            // 
            this.txtReturnId.EnterMoveNextControl = true;
            this.txtReturnId.Location = new System.Drawing.Point(57, 5);
            this.txtReturnId.Name = "txtReturnId";
            this.txtReturnId.Properties.ReadOnly = true;
            this.txtReturnId.Size = new System.Drawing.Size(98, 20);
            this.txtReturnId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Return Id";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.EditValue = null;
            this.dtpReturnDate.EnterMoveNextControl = true;
            this.dtpReturnDate.Location = new System.Drawing.Point(226, 5);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpReturnDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpReturnDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpReturnDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpReturnDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpReturnDate.Size = new System.Drawing.Size(112, 20);
            this.dtpReturnDate.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(161, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Return Date";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(676, 8);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Invoice No";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(344, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Customer Name";
            // 
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 53);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(860, 50);
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
            this.lblCaption.Size = new System.Drawing.Size(856, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Sales Return";
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.grpSearchByCustomer);
            this.grpSearch.Controls.Add(this.grpSearchByDate);
            this.grpSearch.Controls.Add(this.grdSearch);
            this.grpSearch.Location = new System.Drawing.Point(12, 109);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.ShowCaption = false;
            this.grpSearch.Size = new System.Drawing.Size(860, 432);
            this.grpSearch.TabIndex = 7;
            this.grpSearch.Visible = false;
            // 
            // grpSearchByCustomer
            // 
            this.grpSearchByCustomer.Controls.Add(this.cmbSearchCustomer);
            this.grpSearchByCustomer.Controls.Add(this.btnSearchByCustomer);
            this.grpSearchByCustomer.Controls.Add(this.labelControl14);
            this.grpSearchByCustomer.Location = new System.Drawing.Point(223, 5);
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
            this.grpSearchByDate.Controls.Add(this.btnSearchByDate);
            this.grpSearchByDate.Controls.Add(this.dtpEndDate);
            this.grpSearchByDate.Controls.Add(this.labelControl13);
            this.grpSearchByDate.Controls.Add(this.dtpStartDate);
            this.grpSearchByDate.Controls.Add(this.labelControl15);
            this.grpSearchByDate.Location = new System.Drawing.Point(215, 5);
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
            this.grdSearch.Size = new System.Drawing.Size(850, 381);
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
            this.colReturnId,
            this.colReturnDate,
            this.colCustomerId,
            this.colCustomerName,
            this.colInvoiceNo});
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
            this.gvwSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvwSearch_KeyPress);
            this.gvwSearch.DoubleClick += new System.EventHandler(this.gvwSearch_DoubleClick);
            // 
            // colReturnId
            // 
            this.colReturnId.Caption = "Return Id";
            this.colReturnId.FieldName = "srtReturnId";
            this.colReturnId.Name = "colReturnId";
            this.colReturnId.Visible = true;
            this.colReturnId.VisibleIndex = 0;
            this.colReturnId.Width = 87;
            // 
            // colReturnDate
            // 
            this.colReturnDate.Caption = "Return Date";
            this.colReturnDate.DisplayFormat.FormatString = "MMM dd, yyyy";
            this.colReturnDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colReturnDate.FieldName = "srtReturnDate";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.Visible = true;
            this.colReturnDate.VisibleIndex = 1;
            this.colReturnDate.Width = 99;
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
            this.colCustomerName.Caption = "Customer Name";
            this.colCustomerName.FieldName = "cstCustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            this.colCustomerName.Width = 258;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "Invoice No";
            this.colInvoiceNo.FieldName = "srtInvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 3;
            this.colInvoiceNo.Width = 128;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // frmSaleReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 572);
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
            this.Name = "frmSaleReturns";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Return";
            this.Load += new System.EventHandler(this.frmSaleReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDetails)).EndInit();
            this.grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSalesReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hlBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).EndInit();
            this.grpMaster.ResumeLayout(false);
            this.grpMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReturnDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReturnDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
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
        private DevExpress.XtraEditors.GroupControl grpDetails;
        private DevExpress.XtraGrid.GridControl grdSalesReturn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwSalesReturn;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtReturnQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit hlBarcode;
        private DevExpress.XtraEditors.GroupControl grpMaster;
        private DevExpress.XtraEditors.TextEdit txtReturnId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpReturnDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtAmount;
        private DevExpress.XtraEditors.GroupControl grpSearch;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnId;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
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
        private DevExpress.XtraEditors.LookUpEdit cmbCustomerName;
        private DevExpress.XtraEditors.LookUpEdit cmbInvoiceNo;
    }
}