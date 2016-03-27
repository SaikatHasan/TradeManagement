namespace TradeManagement.Forms
{
    partial class frmSuppliers
    {
        private System.ComponentModel.IContainer components = null;

        private static frmSuppliers sForm = null;

        public static frmSuppliers Instance()
        {
            if (sForm == null) { sForm = new frmSuppliers(); }
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
            this.bbtnRefresh = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnPrint = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.sitmStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtContactPerson = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMobile2 = new DevExpress.XtraEditors.TextEdit();
            this.txtLandPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtMobile1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplierName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSupplierID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdSuppliers = new DevExpress.XtraGrid.GridControl();
            this.gvwSuppliers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLandPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLandPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
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
            this.bbtnRefresh,
            this.bbtnPrint,
            this.bbtnSave,
            this.bbtnCancel,
            this.sitmStatus,
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barStaticItem1});
            this.barManager.MaxItemId = 23;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnPrint)});
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
            // bbtnRefresh
            // 
            this.bbtnRefresh.Caption = "&Refresh";
            this.bbtnRefresh.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnRefresh.Id = 12;
            this.bbtnRefresh.LargeGlyph = global::TradeManagement.Properties.Resources.Refresh;
            this.bbtnRefresh.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnRefresh.Name = "bbtnRefresh";
            this.bbtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRefresh_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(726, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 482);
            this.barDockControlBottom.Size = new System.Drawing.Size(726, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 435);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(726, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 435);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Id = 20;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Id = 21;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 22;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtContactPerson);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtMobile2);
            this.groupControl1.Controls.Add(this.txtLandPhone);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.chkActive);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Controls.Add(this.txtMobile1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSupplierName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSupplierID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 109);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(702, 83);
            this.groupControl1.TabIndex = 1;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.EnterMoveNextControl = true;
            this.txtContactPerson.Location = new System.Drawing.Point(85, 58);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(198, 20);
            this.txtContactPerson.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 61);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Contact Person";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(505, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Mobile 2";
            // 
            // txtMobile2
            // 
            this.txtMobile2.EnterMoveNextControl = true;
            this.txtMobile2.Location = new System.Drawing.Point(550, 31);
            this.txtMobile2.Name = "txtMobile2";
            this.txtMobile2.Size = new System.Drawing.Size(147, 20);
            this.txtMobile2.TabIndex = 11;
            // 
            // txtLandPhone
            // 
            this.txtLandPhone.EnterMoveNextControl = true;
            this.txtLandPhone.Location = new System.Drawing.Point(351, 57);
            this.txtLandPhone.Name = "txtLandPhone";
            this.txtLandPhone.Size = new System.Drawing.Size(146, 20);
            this.txtLandPhone.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(306, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Mobile 1";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(548, 57);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "";
            this.chkActive.Size = new System.Drawing.Size(26, 19);
            this.chkActive.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(512, 60);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Active";
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(351, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(346, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtMobile1
            // 
            this.txtMobile1.EnterMoveNextControl = true;
            this.txtMobile1.Location = new System.Drawing.Point(351, 31);
            this.txtMobile1.Name = "txtMobile1";
            this.txtMobile1.Size = new System.Drawing.Size(146, 20);
            this.txtMobile1.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(289, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Land Phone";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(306, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Address";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.EnterMoveNextControl = true;
            this.txtSupplierName.Location = new System.Drawing.Point(85, 32);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(198, 20);
            this.txtSupplierName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Supplier Name";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.EnterMoveNextControl = true;
            this.txtSupplierID.Location = new System.Drawing.Point(85, 6);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Properties.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(98, 20);
            this.txtSupplierID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Supplier Id";
            // 
            // grdSuppliers
            // 
            this.grdSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSuppliers.Location = new System.Drawing.Point(12, 198);
            this.grdSuppliers.MainView = this.gvwSuppliers;
            this.grdSuppliers.Name = "grdSuppliers";
            this.grdSuppliers.Size = new System.Drawing.Size(702, 278);
            this.grdSuppliers.TabIndex = 2;
            this.grdSuppliers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwSuppliers});
            this.grdSuppliers.Click += new System.EventHandler(this.grdSuppliers_Click);
            // 
            // gvwSuppliers
            // 
            this.gvwSuppliers.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSuppliers.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwSuppliers.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSuppliers.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwSuppliers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwSuppliers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwSuppliers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSupplierName,
            this.colAddress,
            this.colContactPerson,
            this.colMobile1,
            this.colMobile2,
            this.colLandPhone,
            this.colActive});
            this.gvwSuppliers.GridControl = this.grdSuppliers;
            this.gvwSuppliers.Name = "gvwSuppliers";
            this.gvwSuppliers.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvwSuppliers.OptionsBehavior.Editable = false;
            this.gvwSuppliers.OptionsCustomization.AllowColumnMoving = false;
            this.gvwSuppliers.OptionsCustomization.AllowFilter = false;
            this.gvwSuppliers.OptionsCustomization.AllowGroup = false;
            this.gvwSuppliers.OptionsMenu.EnableColumnMenu = false;
            this.gvwSuppliers.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwSuppliers.OptionsView.EnableAppearanceOddRow = true;
            this.gvwSuppliers.OptionsView.ShowAutoFilterRow = true;
            this.gvwSuppliers.OptionsView.ShowGroupPanel = false;
            this.gvwSuppliers.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSupplierName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier Name";
            this.colSupplierName.FieldName = "supSupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 0;
            this.colSupplierName.Width = 126;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "supAddress";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 1;
            this.colAddress.Width = 182;
            // 
            // colContactPerson
            // 
            this.colContactPerson.Caption = "Contact Person";
            this.colContactPerson.FieldName = "supContactPerson";
            this.colContactPerson.Name = "colContactPerson";
            this.colContactPerson.Visible = true;
            this.colContactPerson.VisibleIndex = 2;
            this.colContactPerson.Width = 93;
            // 
            // colMobile1
            // 
            this.colMobile1.Caption = "Mobile 1";
            this.colMobile1.FieldName = "supMobile1";
            this.colMobile1.Name = "colMobile1";
            this.colMobile1.Visible = true;
            this.colMobile1.VisibleIndex = 3;
            this.colMobile1.Width = 83;
            // 
            // colMobile2
            // 
            this.colMobile2.Caption = "Mobile 2";
            this.colMobile2.FieldName = "supMobile2";
            this.colMobile2.Name = "colMobile2";
            this.colMobile2.Visible = true;
            this.colMobile2.VisibleIndex = 4;
            this.colMobile2.Width = 77;
            // 
            // colLandPhone
            // 
            this.colLandPhone.Caption = "Land Phone";
            this.colLandPhone.FieldName = "supLandPhone";
            this.colLandPhone.Name = "colLandPhone";
            this.colLandPhone.Visible = true;
            this.colLandPhone.VisibleIndex = 5;
            this.colLandPhone.Width = 72;
            // 
            // colActive
            // 
            this.colActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.Caption = "Active";
            this.colActive.FieldName = "supIsActive";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 6;
            this.colActive.Width = 51;
            // 
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 53);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(702, 50);
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
            this.lblCaption.Size = new System.Drawing.Size(698, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Suppliers";
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 507);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdSuppliers);
            this.Controls.Add(this.grcCaption);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSuppliers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContactPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLandPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplierID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
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
        private DevExpress.XtraBars.BarLargeButtonItem bbtnRefresh;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnPrint;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem sitmStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtLandPhone;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtMobile1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSupplierName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSupplierID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdSuppliers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwSuppliers;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colLandPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.TextEdit txtContactPerson;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMobile2;
        private DevExpress.XtraGrid.Columns.GridColumn colContactPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile1;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile2;
    }
}