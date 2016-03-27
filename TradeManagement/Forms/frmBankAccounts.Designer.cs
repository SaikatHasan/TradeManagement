namespace TradeManagement.Forms
{
    partial class frmBankAccounts
    {
        private System.ComponentModel.IContainer components = null;

        private static frmBankAccounts sForm = null;

        public static frmBankAccounts Instance()
        {
            if (sForm == null) { sForm = new frmBankAccounts(); }
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
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdBankAccounts = new DevExpress.XtraGrid.GridControl();
            this.gvwBankAccountss = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwBankAccountss)).BeginInit();
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
            this.bbtnPrint.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.barDockControlTop.Size = new System.Drawing.Size(706, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 415);
            this.barDockControlBottom.Size = new System.Drawing.Size(706, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 368);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(706, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 368);
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
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 53);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(682, 50);
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
            this.lblCaption.Size = new System.Drawing.Size(678, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Bank Accounts";
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.chkActive);
            this.grpMain.Controls.Add(this.labelControl7);
            this.grpMain.Controls.Add(this.txtAccountNo);
            this.grpMain.Controls.Add(this.labelControl3);
            this.grpMain.Controls.Add(this.txtBankName);
            this.grpMain.Controls.Add(this.labelControl2);
            this.grpMain.Controls.Add(this.txtBankID);
            this.grpMain.Controls.Add(this.labelControl1);
            this.grpMain.Enabled = false;
            this.grpMain.Location = new System.Drawing.Point(12, 109);
            this.grpMain.Name = "grpMain";
            this.grpMain.ShowCaption = false;
            this.grpMain.Size = new System.Drawing.Size(682, 30);
            this.grpMain.TabIndex = 1;
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(663, 5);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "";
            this.chkActive.Size = new System.Drawing.Size(26, 19);
            this.chkActive.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(627, 8);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Active";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.EnterMoveNextControl = true;
            this.txtAccountNo.Location = new System.Drawing.Point(492, 5);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(129, 20);
            this.txtAccountNo.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(448, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "A/C No.";
            // 
            // txtBankName
            // 
            this.txtBankName.EnterMoveNextControl = true;
            this.txtBankName.Location = new System.Drawing.Point(206, 5);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(236, 20);
            this.txtBankName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(147, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Bank Name";
            // 
            // txtBankID
            // 
            this.txtBankID.EnterMoveNextControl = true;
            this.txtBankID.Location = new System.Drawing.Point(42, 5);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.Properties.ReadOnly = true;
            this.txtBankID.Size = new System.Drawing.Size(99, 20);
            this.txtBankID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "A/C Id";
            // 
            // grdBankAccounts
            // 
            this.grdBankAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdBankAccounts.Location = new System.Drawing.Point(12, 145);
            this.grdBankAccounts.MainView = this.gvwBankAccountss;
            this.grdBankAccounts.Name = "grdBankAccounts";
            this.grdBankAccounts.Size = new System.Drawing.Size(682, 264);
            this.grdBankAccounts.TabIndex = 2;
            this.grdBankAccounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwBankAccountss});
            this.grdBankAccounts.Click += new System.EventHandler(this.grdBanks_Click);
            // 
            // gvwBankAccountss
            // 
            this.gvwBankAccountss.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwBankAccountss.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwBankAccountss.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwBankAccountss.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwBankAccountss.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwBankAccountss.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwBankAccountss.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBankName,
            this.colAccNo,
            this.colActive});
            this.gvwBankAccountss.GridControl = this.grdBankAccounts;
            this.gvwBankAccountss.Name = "gvwBankAccountss";
            this.gvwBankAccountss.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvwBankAccountss.OptionsBehavior.Editable = false;
            this.gvwBankAccountss.OptionsCustomization.AllowColumnMoving = false;
            this.gvwBankAccountss.OptionsCustomization.AllowFilter = false;
            this.gvwBankAccountss.OptionsCustomization.AllowGroup = false;
            this.gvwBankAccountss.OptionsMenu.EnableColumnMenu = false;
            this.gvwBankAccountss.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwBankAccountss.OptionsView.EnableAppearanceOddRow = true;
            this.gvwBankAccountss.OptionsView.ShowAutoFilterRow = true;
            this.gvwBankAccountss.OptionsView.ShowGroupPanel = false;
            this.gvwBankAccountss.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBankName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colBankName
            // 
            this.colBankName.AppearanceHeader.Options.UseTextOptions = true;
            this.colBankName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBankName.Caption = "Bank Name";
            this.colBankName.FieldName = "bacBankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 0;
            this.colBankName.Width = 367;
            // 
            // colAccNo
            // 
            this.colAccNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colAccNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAccNo.Caption = "Account No";
            this.colAccNo.FieldName = "bacAccountNo";
            this.colAccNo.Name = "colAccNo";
            this.colAccNo.Visible = true;
            this.colAccNo.VisibleIndex = 1;
            this.colAccNo.Width = 246;
            // 
            // colActive
            // 
            this.colActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.Caption = "Active";
            this.colActive.FieldName = "bacIsActive";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            // 
            // frmBankAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 440);
            this.Controls.Add(this.grdBankAccounts);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grcCaption);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBankAccounts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Accounts";
            this.Load += new System.EventHandler(this.frmBanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwBankAccountss)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.GroupControl grpMain;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBankID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtAccountNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl grdBankAccounts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwBankAccountss;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccNo;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
    }
}