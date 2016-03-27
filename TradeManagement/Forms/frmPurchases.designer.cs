namespace TradeManagement.Forms
{
    partial class frmPurchases
    {
        private System.ComponentModel.IContainer components = null;

        private static frmPurchases sForm = null;

        public static frmPurchases Instance()
        {
            if (sForm == null) { sForm = new frmPurchases(); }
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
            this.bbtnBySupplier = new DevExpress.XtraBars.BarButtonItem();
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
            this.grpMaster = new DevExpress.XtraEditors.GroupControl();
            this.dtpPurchaseDate = new DevExpress.XtraEditors.DateEdit();
            this.txtVoucherNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSupplierName = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPurchaseId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdPurchases = new DevExpress.XtraGrid.GridControl();
            this.gvwPurchases = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackageUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.grpDetails = new DevExpress.XtraEditors.GroupControl();
            this.txtDue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmountPaid = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtNetTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnModify = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtPackageUnit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtModel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBrand = new DevExpress.XtraEditors.TextEdit();
            this.cmbProduct = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolPackageUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.grpSearch = new DevExpress.XtraEditors.GroupControl();
            this.grpSearchBySupplier = new DevExpress.XtraEditors.GroupControl();
            this.cmbSearchSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSearchBySupplier = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gvwSearch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPurchaseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoucherNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.grpSearchByDate = new DevExpress.XtraEditors.GroupControl();
            this.btnSearchByDate = new DevExpress.XtraEditors.SimpleButton();
            this.dtpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.dtpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).BeginInit();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPurchaseDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPurchaseDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDetails)).BeginInit();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackageUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchBySupplier)).BeginInit();
            this.grpSearchBySupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchByDate)).BeginInit();
            this.grpSearchByDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
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
            this.bbtnBySupplier,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnBySupplier),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnByDate)});
            this.bmnuSearch.Name = "bmnuSearch";
            this.bmnuSearch.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbtnBySupplier
            // 
            this.bbtnBySupplier.Caption = "By Supplier";
            this.bbtnBySupplier.Id = 28;
            this.bbtnBySupplier.Name = "bbtnBySupplier";
            this.bbtnBySupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnBySupplier_ItemClick);
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
            this.sitmStatus.Size = new System.Drawing.Size(32, 0);
            this.sitmStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(890, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 601);
            this.barDockControlBottom.Size = new System.Drawing.Size(890, 25);
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
            this.barDockControlRight.Location = new System.Drawing.Point(890, 47);
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
            this.grpMaster.Controls.Add(this.dtpPurchaseDate);
            this.grpMaster.Controls.Add(this.txtVoucherNo);
            this.grpMaster.Controls.Add(this.labelControl8);
            this.grpMaster.Controls.Add(this.cmbSupplierName);
            this.grpMaster.Controls.Add(this.labelControl3);
            this.grpMaster.Controls.Add(this.labelControl2);
            this.grpMaster.Controls.Add(this.txtPurchaseId);
            this.grpMaster.Controls.Add(this.labelControl1);
            this.grpMaster.Enabled = false;
            this.grpMaster.Location = new System.Drawing.Point(12, 109);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.ShowCaption = false;
            this.grpMaster.Size = new System.Drawing.Size(866, 30);
            this.grpMaster.TabIndex = 1;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.EditValue = null;
            this.dtpPurchaseDate.EnterMoveNextControl = true;
            this.dtpPurchaseDate.Location = new System.Drawing.Point(249, 5);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpPurchaseDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpPurchaseDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpPurchaseDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpPurchaseDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpPurchaseDate.Size = new System.Drawing.Size(112, 20);
            this.dtpPurchaseDate.TabIndex = 3;
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(744, 5);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Properties.MaxLength = 15;
            this.txtVoucherNo.Size = new System.Drawing.Size(117, 20);
            this.txtVoucherNo.TabIndex = 7;
            this.txtVoucherNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoucherNo_KeyPress);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(683, 8);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 6;
            this.labelControl8.Text = "Voucher No";
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.EnterMoveNextControl = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(441, 5);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSupplierName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supSupplierName", "Supplier Name")});
            this.cmbSupplierName.Properties.DisplayMember = "supSupplierName";
            this.cmbSupplierName.Properties.NullText = "";
            this.cmbSupplierName.Properties.ValueMember = "supSupplierId";
            this.cmbSupplierName.Size = new System.Drawing.Size(236, 20);
            this.cmbSupplierName.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(367, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Supplier Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(173, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Purchase Date";
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.EnterMoveNextControl = true;
            this.txtPurchaseId.Location = new System.Drawing.Point(68, 5);
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.Properties.ReadOnly = true;
            this.txtPurchaseId.Size = new System.Drawing.Size(99, 20);
            this.txtPurchaseId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Purchase Id";
            // 
            // grdPurchases
            // 
            this.grdPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPurchases.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdPurchases.Location = new System.Drawing.Point(5, 86);
            this.grdPurchases.MainView = this.gvwPurchases;
            this.grdPurchases.Name = "grdPurchases";
            this.grdPurchases.Size = new System.Drawing.Size(856, 256);
            this.grdPurchases.TabIndex = 17;
            this.grdPurchases.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwPurchases});
            // 
            // gvwPurchases
            // 
            this.gvwPurchases.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwPurchases.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwPurchases.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwPurchases.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwPurchases.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwPurchases.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwPurchases.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductId,
            this.colProductName,
            this.colBrand,
            this.colModel,
            this.colPackageUnit,
            this.colUnitPrice,
            this.colQuantity,
            this.colTotal});
            this.gvwPurchases.GridControl = this.grdPurchases;
            this.gvwPurchases.Name = "gvwPurchases";
            this.gvwPurchases.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwPurchases.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvwPurchases.OptionsBehavior.Editable = false;
            this.gvwPurchases.OptionsCustomization.AllowColumnMoving = false;
            this.gvwPurchases.OptionsCustomization.AllowFilter = false;
            this.gvwPurchases.OptionsCustomization.AllowGroup = false;
            this.gvwPurchases.OptionsMenu.EnableColumnMenu = false;
            this.gvwPurchases.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwPurchases.OptionsView.EnableAppearanceOddRow = true;
            this.gvwPurchases.OptionsView.ShowFooter = true;
            this.gvwPurchases.OptionsView.ShowGroupPanel = false;
            this.gvwPurchases.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvwPurchase_MouseDown);
            // 
            // colProductId
            // 
            this.colProductId.Caption = "Product Id";
            this.colProductId.FieldName = "prdProductId";
            this.colProductId.Name = "colProductId";
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product Name";
            this.colProductName.FieldName = "pdtProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 184;
            // 
            // colBrand
            // 
            this.colBrand.Caption = "Brand";
            this.colBrand.FieldName = "bndBrandName";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 1;
            this.colBrand.Width = 132;
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "pdtModel";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 2;
            this.colModel.Width = 149;
            // 
            // colPackageUnit
            // 
            this.colPackageUnit.Caption = "Package Unit";
            this.colPackageUnit.FieldName = "pdtPackageUnit";
            this.colPackageUnit.Name = "colPackageUnit";
            this.colPackageUnit.Visible = true;
            this.colPackageUnit.VisibleIndex = 3;
            this.colPackageUnit.Width = 88;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceCell.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUnitPrice.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnitPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUnitPrice.Caption = "Unit Price";
            this.colUnitPrice.DisplayFormat.FormatString = "{0:f}";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "prdPurchasePrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            this.colUnitPrice.Width = 63;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantity.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "prdQuantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            this.colQuantity.Width = 63;
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
            this.colTotal.FieldName = "prdTotal";
            this.colTotal.Name = "colTotal";
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "prdTotal", "{0:f}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            this.colTotal.Width = 84;
            // 
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 53);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(866, 50);
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
            this.lblCaption.Size = new System.Drawing.Size(862, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Purchase";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.txtBarcode);
            this.grpDetails.Controls.Add(this.labelControl18);
            this.grpDetails.Controls.Add(this.txtDue);
            this.grpDetails.Controls.Add(this.labelControl16);
            this.grpDetails.Controls.Add(this.txtAmountPaid);
            this.grpDetails.Controls.Add(this.labelControl17);
            this.grpDetails.Controls.Add(this.txtNetTotal);
            this.grpDetails.Controls.Add(this.labelControl12);
            this.grpDetails.Controls.Add(this.txtDiscount);
            this.grpDetails.Controls.Add(this.labelControl11);
            this.grpDetails.Controls.Add(this.btnRemove);
            this.grpDetails.Controls.Add(this.btnModify);
            this.grpDetails.Controls.Add(this.btnAdd);
            this.grpDetails.Controls.Add(this.txtQuantity);
            this.grpDetails.Controls.Add(this.labelControl10);
            this.grpDetails.Controls.Add(this.txtUnitPrice);
            this.grpDetails.Controls.Add(this.grdPurchases);
            this.grpDetails.Controls.Add(this.labelControl9);
            this.grpDetails.Controls.Add(this.txtPackageUnit);
            this.grpDetails.Controls.Add(this.labelControl6);
            this.grpDetails.Controls.Add(this.txtModel);
            this.grpDetails.Controls.Add(this.labelControl5);
            this.grpDetails.Controls.Add(this.txtBrand);
            this.grpDetails.Controls.Add(this.cmbProduct);
            this.grpDetails.Controls.Add(this.labelControl4);
            this.grpDetails.Controls.Add(this.labelControl7);
            this.grpDetails.Enabled = false;
            this.grpDetails.Location = new System.Drawing.Point(12, 146);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.ShowCaption = false;
            this.grpDetails.Size = new System.Drawing.Size(866, 449);
            this.grpDetails.TabIndex = 2;
            // 
            // txtDue
            // 
            this.txtDue.EditValue = "";
            this.txtDue.EnterMoveNextControl = true;
            this.txtDue.Location = new System.Drawing.Point(767, 424);
            this.txtDue.Name = "txtDue";
            this.txtDue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDue.Properties.DisplayFormat.FormatString = "n2";
            this.txtDue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDue.Properties.Mask.EditMask = "f";
            this.txtDue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDue.Properties.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(90, 20);
            this.txtDue.TabIndex = 25;
            this.txtDue.TabStop = false;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl16.Location = new System.Drawing.Point(739, 427);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(22, 13);
            this.labelControl16.TabIndex = 24;
            this.labelControl16.Text = "Due";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.EditValue = "";
            this.txtAmountPaid.EnterMoveNextControl = true;
            this.txtAmountPaid.Location = new System.Drawing.Point(767, 398);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAmountPaid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmountPaid.Properties.Mask.EditMask = "f";
            this.txtAmountPaid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmountPaid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(90, 20);
            this.txtAmountPaid.TabIndex = 23;
            this.txtAmountPaid.EditValueChanged += new System.EventHandler(this.txtAmountPaid_EditValueChanged);
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Location = new System.Drawing.Point(689, 401);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(72, 13);
            this.labelControl17.TabIndex = 22;
            this.labelControl17.Text = "Amount Paid";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.EditValue = "";
            this.txtNetTotal.EnterMoveNextControl = true;
            this.txtNetTotal.Location = new System.Drawing.Point(767, 372);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNetTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNetTotal.Properties.Mask.EditMask = "f";
            this.txtNetTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNetTotal.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNetTotal.Properties.ReadOnly = true;
            this.txtNetTotal.Size = new System.Drawing.Size(90, 20);
            this.txtNetTotal.TabIndex = 21;
            this.txtNetTotal.TabStop = false;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl12.Location = new System.Drawing.Point(715, 375);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(46, 13);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = "Net Toal";
            // 
            // txtDiscount
            // 
            this.txtDiscount.EditValue = "";
            this.txtDiscount.EnterMoveNextControl = true;
            this.txtDiscount.Location = new System.Drawing.Point(767, 346);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDiscount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDiscount.Properties.Mask.EditMask = "f";
            this.txtDiscount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDiscount.Size = new System.Drawing.Size(90, 20);
            this.txtDiscount.TabIndex = 19;
            this.txtDiscount.EditValueChanged += new System.EventHandler(this.txtDiscount_EditValueChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Location = new System.Drawing.Point(712, 349);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(49, 13);
            this.labelControl11.TabIndex = 18;
            this.labelControl11.Text = "Discount";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(541, 57);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(396, 57);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = "";
            this.txtQuantity.Location = new System.Drawing.Point(818, 31);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQuantity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtQuantity.Properties.Mask.EditMask = "f0";
            this.txtQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantity.Size = new System.Drawing.Size(43, 20);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(770, 34);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(42, 13);
            this.labelControl10.TabIndex = 12;
            this.labelControl10.Text = "Quantity";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.EditValue = "";
            this.txtUnitPrice.EnterMoveNextControl = true;
            this.txtUnitPrice.Location = new System.Drawing.Point(706, 31);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Properties.Appearance.Options.UseTextOptions = true;
            this.txtUnitPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtUnitPrice.Properties.Mask.EditMask = "f";
            this.txtUnitPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUnitPrice.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(58, 20);
            this.txtUnitPrice.TabIndex = 11;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(655, 34);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 13);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Unit Price";
            // 
            // txtPackageUnit
            // 
            this.txtPackageUnit.EnterMoveNextControl = true;
            this.txtPackageUnit.Location = new System.Drawing.Point(608, 31);
            this.txtPackageUnit.Name = "txtPackageUnit";
            this.txtPackageUnit.Properties.ReadOnly = true;
            this.txtPackageUnit.Size = new System.Drawing.Size(41, 20);
            this.txtPackageUnit.TabIndex = 9;
            this.txtPackageUnit.TabStop = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(540, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Package Unit";
            // 
            // txtModel
            // 
            this.txtModel.EnterMoveNextControl = true;
            this.txtModel.Location = new System.Drawing.Point(427, 31);
            this.txtModel.Name = "txtModel";
            this.txtModel.Properties.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(107, 20);
            this.txtModel.TabIndex = 7;
            this.txtModel.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(393, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Model";
            // 
            // txtBrand
            // 
            this.txtBrand.EnterMoveNextControl = true;
            this.txtBrand.Location = new System.Drawing.Point(270, 31);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Properties.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(117, 20);
            this.txtBrand.TabIndex = 5;
            this.txtBrand.TabStop = false;
            // 
            // cmbProduct
            // 
            this.cmbProduct.EditValue = "";
            this.cmbProduct.EnterMoveNextControl = true;
            this.cmbProduct.Location = new System.Drawing.Point(48, 31);
            this.cmbProduct.MenuManager = this.barManager;
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProduct.Properties.DisplayMember = "pdtProductName";
            this.cmbProduct.Properties.ImmediatePopup = true;
            this.cmbProduct.Properties.NullText = "";
            this.cmbProduct.Properties.PopupFormSize = new System.Drawing.Size(450, 0);
            this.cmbProduct.Properties.ValueMember = "pdtProductId";
            this.cmbProduct.Properties.View = this.gridLookUpEdit1View;
            this.cmbProduct.Size = new System.Drawing.Size(182, 20);
            this.cmbProduct.TabIndex = 3;
            this.cmbProduct.EditValueChanged += new System.EventHandler(this.cmbProduct_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolProductName,
            this.gcolBrandName,
            this.gcolModel,
            this.gcolPackageUnit});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gcolProductName
            // 
            this.gcolProductName.Caption = "Product";
            this.gcolProductName.FieldName = "pdtProductName";
            this.gcolProductName.Name = "gcolProductName";
            this.gcolProductName.Visible = true;
            this.gcolProductName.VisibleIndex = 0;
            // 
            // gcolBrandName
            // 
            this.gcolBrandName.Caption = "Brand";
            this.gcolBrandName.FieldName = "bndBrandName";
            this.gcolBrandName.Name = "gcolBrandName";
            this.gcolBrandName.Visible = true;
            this.gcolBrandName.VisibleIndex = 1;
            // 
            // gcolModel
            // 
            this.gcolModel.Caption = "Model";
            this.gcolModel.FieldName = "pdtModel";
            this.gcolModel.Name = "gcolModel";
            this.gcolModel.Visible = true;
            this.gcolModel.VisibleIndex = 2;
            // 
            // gcolPackageUnit
            // 
            this.gcolPackageUnit.Caption = "Package Unit";
            this.gcolPackageUnit.FieldName = "pdtPackageUnit";
            this.gcolPackageUnit.Name = "gcolPackageUnit";
            this.gcolPackageUnit.Visible = true;
            this.gcolPackageUnit.VisibleIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(236, 34);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Brand";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 34);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Product";
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.grpSearchBySupplier);
            this.grpSearch.Controls.Add(this.grdSearch);
            this.grpSearch.Controls.Add(this.grpSearchByDate);
            this.grpSearch.Location = new System.Drawing.Point(12, 109);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.ShowCaption = false;
            this.grpSearch.Size = new System.Drawing.Size(866, 486);
            this.grpSearch.TabIndex = 3;
            this.grpSearch.Visible = false;
            // 
            // grpSearchBySupplier
            // 
            this.grpSearchBySupplier.Controls.Add(this.cmbSearchSupplier);
            this.grpSearchBySupplier.Controls.Add(this.btnSearchBySupplier);
            this.grpSearchBySupplier.Controls.Add(this.labelControl14);
            this.grpSearchBySupplier.Location = new System.Drawing.Point(230, 5);
            this.grpSearchBySupplier.Name = "grpSearchBySupplier";
            this.grpSearchBySupplier.ShowCaption = false;
            this.grpSearchBySupplier.Size = new System.Drawing.Size(406, 35);
            this.grpSearchBySupplier.TabIndex = 1;
            // 
            // cmbSearchSupplier
            // 
            this.cmbSearchSupplier.EnterMoveNextControl = true;
            this.cmbSearchSupplier.Location = new System.Drawing.Point(82, 8);
            this.cmbSearchSupplier.Name = "cmbSearchSupplier";
            this.cmbSearchSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSearchSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supSupplierName", "Supplier Name")});
            this.cmbSearchSupplier.Properties.DisplayMember = "supSupplierName";
            this.cmbSearchSupplier.Properties.NullText = "";
            this.cmbSearchSupplier.Properties.ValueMember = "supSupplierId";
            this.cmbSearchSupplier.Size = new System.Drawing.Size(236, 20);
            this.cmbSearchSupplier.TabIndex = 1;
            // 
            // btnSearchBySupplier
            // 
            this.btnSearchBySupplier.Location = new System.Drawing.Point(324, 6);
            this.btnSearchBySupplier.Name = "btnSearchBySupplier";
            this.btnSearchBySupplier.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBySupplier.TabIndex = 2;
            this.btnSearchBySupplier.Text = "Search";
            this.btnSearchBySupplier.Click += new System.EventHandler(this.btnSearchBySupplier_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(8, 11);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(68, 13);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "Supplier Name";
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
            this.grdSearch.Size = new System.Drawing.Size(856, 435);
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
            this.colPurchaseId,
            this.colPurchaseDate,
            this.colSupplierId,
            this.colSupplierName,
            this.colVoucherNo,
            this.colTotalAmount,
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
            // colPurchaseId
            // 
            this.colPurchaseId.Caption = "Purchase Id";
            this.colPurchaseId.FieldName = "purPurchaseId";
            this.colPurchaseId.Name = "colPurchaseId";
            this.colPurchaseId.Visible = true;
            this.colPurchaseId.VisibleIndex = 0;
            this.colPurchaseId.Width = 87;
            // 
            // colPurchaseDate
            // 
            this.colPurchaseDate.Caption = "Purchase Date";
            this.colPurchaseDate.DisplayFormat.FormatString = "MMM dd, yyyy";
            this.colPurchaseDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colPurchaseDate.FieldName = "purPurchaseDate";
            this.colPurchaseDate.Name = "colPurchaseDate";
            this.colPurchaseDate.Visible = true;
            this.colPurchaseDate.VisibleIndex = 1;
            this.colPurchaseDate.Width = 99;
            // 
            // colSupplierId
            // 
            this.colSupplierId.Caption = "Supplier Id";
            this.colSupplierId.FieldName = "purSupplierId";
            this.colSupplierId.Name = "colSupplierId";
            this.colSupplierId.Width = 132;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier Name";
            this.colSupplierName.FieldName = "supSupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 2;
            this.colSupplierName.Width = 258;
            // 
            // colVoucherNo
            // 
            this.colVoucherNo.Caption = "Voucher No";
            this.colVoucherNo.FieldName = "purVoucherNo";
            this.colVoucherNo.Name = "colVoucherNo";
            this.colVoucherNo.Visible = true;
            this.colVoucherNo.VisibleIndex = 3;
            this.colVoucherNo.Width = 128;
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
            this.colTotalAmount.FieldName = "purTotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 4;
            this.colTotalAmount.Width = 93;
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
            this.colDiscount.FieldName = "purDiscount";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = true;
            this.colDiscount.VisibleIndex = 5;
            this.colDiscount.Width = 83;
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
            this.colNetTotal.FieldName = "purNetTotal";
            this.colNetTotal.Name = "colNetTotal";
            this.colNetTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "purNetTotal", "{0:f}")});
            this.colNetTotal.Visible = true;
            this.colNetTotal.VisibleIndex = 6;
            this.colNetTotal.Width = 90;
            // 
            // repositoryItemHyperLinkEdit1
            // 
            this.repositoryItemHyperLinkEdit1.AutoHeight = false;
            this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
            // 
            // grpSearchByDate
            // 
            this.grpSearchByDate.Controls.Add(this.btnSearchByDate);
            this.grpSearchByDate.Controls.Add(this.dtpEndDate);
            this.grpSearchByDate.Controls.Add(this.labelControl13);
            this.grpSearchByDate.Controls.Add(this.dtpStartDate);
            this.grpSearchByDate.Controls.Add(this.labelControl15);
            this.grpSearchByDate.Location = new System.Drawing.Point(218, 5);
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
            // txtBarcode
            // 
            this.txtBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBarcode.Location = new System.Drawing.Point(377, 5);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(157, 20);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // labelControl18
            // 
            this.labelControl18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl18.Location = new System.Drawing.Point(332, 8);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(39, 13);
            this.labelControl18.TabIndex = 0;
            this.labelControl18.Text = "Barcode";
            // 
            // frmPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 626);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpMaster);
            this.Controls.Add(this.grcCaption);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPurchases";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).EndInit();
            this.grpMaster.ResumeLayout(false);
            this.grpMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPurchaseDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpPurchaseDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchaseId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDetails)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackageUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchBySupplier)).EndInit();
            this.grpSearchBySupplier.ResumeLayout(false);
            this.grpSearchBySupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSearchSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchByDate)).EndInit();
            this.grpSearchByDate.ResumeLayout(false);
            this.grpSearchByDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
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
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem sitmStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.GroupControl grpMaster;
        private DevExpress.XtraEditors.TextEdit txtVoucherNo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit cmbSupplierName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grdPurchases;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwPurchases;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colPackageUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.DateEdit dtpPurchaseDate;
        private DevExpress.XtraEditors.GroupControl grpDetails;
        private DevExpress.XtraEditors.GridLookUpEdit cmbProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.TextEdit txtPackageUnit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtModel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBrand;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtUnitPrice;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnModify;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn gcolProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gcolBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn gcolModel;
        private DevExpress.XtraGrid.Columns.GridColumn gcolPackageUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraBars.BarSubItem bmnuSearch;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem bbtnBySupplier;
        private DevExpress.XtraBars.BarButtonItem bbtnByDate;
        private DevExpress.XtraEditors.GroupControl grpSearch;
        private DevExpress.XtraEditors.DateEdit dtpStartDate;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.GroupControl grpSearchByDate;
        private DevExpress.XtraEditors.DateEdit dtpEndDate;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseId;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierId;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colVoucherNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscount;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSearchByDate;
        private DevExpress.XtraEditors.GroupControl grpSearchBySupplier;
        private DevExpress.XtraEditors.SimpleButton btnSearchBySupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colNetTotal;
        private DevExpress.XtraEditors.TextEdit txtNetTotal;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LookUpEdit cmbSearchSupplier;
        private DevExpress.XtraEditors.TextEdit txtPurchaseId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDue;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtAmountPaid;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl18;
    }
}