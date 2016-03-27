namespace TradeManagement.Forms
{
    partial class frmCustomers
    {
        private System.ComponentModel.IContainer components = null;

        private static frmCustomers sForm = null;

        public static frmCustomers Instance()
        {
            if (sForm == null) { sForm = new frmCustomers(); }
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
            this.txtLandPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.gvwCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLandPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLandPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwCustomers)).BeginInit();
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
            this.groupControl1.Controls.Add(this.txtLandPhone);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.chkActive);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Controls.Add(this.txtMobile);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtCustomerName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCustomerID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 109);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(702, 56);
            this.groupControl1.TabIndex = 1;
            // 
            // txtLandPhone
            // 
            this.txtLandPhone.EnterMoveNextControl = true;
            this.txtLandPhone.Location = new System.Drawing.Point(353, 31);
            this.txtLandPhone.Name = "txtLandPhone";
            this.txtLandPhone.Size = new System.Drawing.Size(117, 20);
            this.txtLandPhone.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(476, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Mobile";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(671, 31);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "";
            this.chkActive.Size = new System.Drawing.Size(26, 19);
            this.chkActive.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(635, 34);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 13);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Active";
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(353, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(344, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtMobile
            // 
            this.txtMobile.EnterMoveNextControl = true;
            this.txtMobile.Location = new System.Drawing.Point(512, 30);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(117, 20);
            this.txtMobile.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(291, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Land Phone";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(308, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.EnterMoveNextControl = true;
            this.txtCustomerName.Location = new System.Drawing.Point(87, 31);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(198, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Customer Name";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.EnterMoveNextControl = true;
            this.txtCustomerID.Location = new System.Drawing.Point(87, 5);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Properties.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(98, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Customer Id";
            // 
            // grdCustomers
            // 
            this.grdCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCustomers.Location = new System.Drawing.Point(12, 171);
            this.grdCustomers.MainView = this.gvwCustomers;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(702, 305);
            this.grdCustomers.TabIndex = 2;
            this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwCustomers});
            this.grdCustomers.Click += new System.EventHandler(this.grdCustomers_Click);
            // 
            // gvwCustomers
            // 
            this.gvwCustomers.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwCustomers.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwCustomers.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwCustomers.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwCustomers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwCustomers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colAddress,
            this.colLandPhone,
            this.colMobile,
            this.colActive});
            this.gvwCustomers.GridControl = this.grdCustomers;
            this.gvwCustomers.Name = "gvwCustomers";
            this.gvwCustomers.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvwCustomers.OptionsBehavior.Editable = false;
            this.gvwCustomers.OptionsCustomization.AllowColumnMoving = false;
            this.gvwCustomers.OptionsCustomization.AllowFilter = false;
            this.gvwCustomers.OptionsCustomization.AllowGroup = false;
            this.gvwCustomers.OptionsMenu.EnableColumnMenu = false;
            this.gvwCustomers.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwCustomers.OptionsView.EnableAppearanceOddRow = true;
            this.gvwCustomers.OptionsView.ShowAutoFilterRow = true;
            this.gvwCustomers.OptionsView.ShowGroupPanel = false;
            this.gvwCustomers.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomerName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Customer Name";
            this.colCustomerName.FieldName = "cstCustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            this.colCustomerName.Width = 158;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "cstAddress";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 1;
            this.colAddress.Width = 265;
            // 
            // colLandPhone
            // 
            this.colLandPhone.Caption = "Land Phone";
            this.colLandPhone.FieldName = "cstLandPhone";
            this.colLandPhone.Name = "colLandPhone";
            this.colLandPhone.Visible = true;
            this.colLandPhone.VisibleIndex = 2;
            this.colLandPhone.Width = 113;
            // 
            // colMobile
            // 
            this.colMobile.Caption = "Mobile";
            this.colMobile.FieldName = "cstMobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 3;
            this.colMobile.Width = 98;
            // 
            // colActive
            // 
            this.colActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.Caption = "Active";
            this.colActive.FieldName = "cstIsActive";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            this.colActive.Width = 50;
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
            this.lblCaption.Text = "Customers";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 507);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.grcCaption);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCustomers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLandPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwCustomers)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtMobile;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCustomerID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colLandPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
    }
}