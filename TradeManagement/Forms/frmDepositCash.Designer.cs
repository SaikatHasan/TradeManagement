namespace TradeManagement.Forms
{
    partial class frmDepositCash
    {
        private System.ComponentModel.IContainer components = null;

        private static frmDepositCash sForm = null;

        public static frmDepositCash Instance()
        {
            if (sForm == null) { sForm = new frmDepositCash(); }
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
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.sitmStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.bbtnCancel = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnNew = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barOptions = new DevExpress.XtraBars.Bar();
            this.bbtnEdit = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bbtnDelete = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.grdDepositCash = new DevExpress.XtraGrid.GridControl();
            this.gvwDepositCash = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).BeginInit();
            this.grcCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepositCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDepositCash)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.EditValue = null;
            this.dtpDate.EnterMoveNextControl = true;
            this.dtpDate.Location = new System.Drawing.Point(34, 6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.EditFormat.FormatString = "MMM dd, yyyy";
            this.dtpDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDate.Properties.Mask.EditMask = "MMM dd, yyyy";
            this.dtpDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpDate.Size = new System.Drawing.Size(112, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.EnterMoveNextControl = true;
            this.txtAmount.Location = new System.Drawing.Point(449, 6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Mask.EditMask = "f";
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmount.Size = new System.Drawing.Size(66, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(406, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Amount";
            // 
            // txtDescription
            // 
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(211, 6);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(189, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(152, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Description";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Date";
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.dtpDate);
            this.grpMain.Controls.Add(this.txtAmount);
            this.grpMain.Controls.Add(this.labelControl3);
            this.grpMain.Controls.Add(this.txtDescription);
            this.grpMain.Controls.Add(this.labelControl2);
            this.grpMain.Controls.Add(this.labelControl1);
            this.grpMain.Enabled = false;
            this.grpMain.Location = new System.Drawing.Point(12, 109);
            this.grpMain.Name = "grpMain";
            this.grpMain.ShowCaption = false;
            this.grpMain.Size = new System.Drawing.Size(520, 32);
            this.grpMain.TabIndex = 1;
            // 
            // lblCaption
            // 
            this.lblCaption.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblCaption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Location = new System.Drawing.Point(2, 2);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(516, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Deposit Cash";
            // 
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 53);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(520, 50);
            this.grcCaption.TabIndex = 0;
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Id = 21;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Id = 20;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 357);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(544, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 357);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 404);
            this.barDockControlBottom.Size = new System.Drawing.Size(544, 25);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(544, 47);
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
            // bbtnEdit
            // 
            this.bbtnEdit.Caption = "&Edit";
            this.bbtnEdit.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnEdit.Id = 23;
            this.bbtnEdit.LargeGlyph = global::TradeManagement.Properties.Resources.Edit;
            this.bbtnEdit.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnEdit.Name = "bbtnEdit";
            this.bbtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnEdit_ItemClick);
            // 
            // bbtnDelete
            // 
            this.bbtnDelete.Caption = "&Delete";
            this.bbtnDelete.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.bbtnDelete.Id = 24;
            this.bbtnDelete.LargeGlyph = global::TradeManagement.Properties.Resources.Delete;
            this.bbtnDelete.MinSize = new System.Drawing.Size(80, 0);
            this.bbtnDelete.Name = "bbtnDelete";
            this.bbtnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDelete_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 22;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
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
            this.bbtnSave,
            this.bbtnCancel,
            this.sitmStatus,
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barStaticItem1,
            this.bbtnEdit,
            this.bbtnDelete});
            this.barManager.MaxItemId = 25;
            this.barManager.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Never;
            this.barManager.StatusBar = this.barStatus;
            // 
            // grdDepositCash
            // 
            this.grdDepositCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDepositCash.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdDepositCash.Location = new System.Drawing.Point(12, 147);
            this.grdDepositCash.MainView = this.gvwDepositCash;
            this.grdDepositCash.Name = "grdDepositCash";
            this.grdDepositCash.Size = new System.Drawing.Size(520, 250);
            this.grdDepositCash.TabIndex = 7;
            this.grdDepositCash.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwDepositCash});
            this.grdDepositCash.Click += new System.EventHandler(this.grdDepositCash_Click);
            // 
            // gvwDepositCash
            // 
            this.gvwDepositCash.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwDepositCash.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwDepositCash.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwDepositCash.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwDepositCash.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwDepositCash.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwDepositCash.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colDescription,
            this.colAmount});
            this.gvwDepositCash.GridControl = this.grdDepositCash;
            this.gvwDepositCash.Name = "gvwDepositCash";
            this.gvwDepositCash.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvwDepositCash.OptionsBehavior.Editable = false;
            this.gvwDepositCash.OptionsCustomization.AllowColumnMoving = false;
            this.gvwDepositCash.OptionsCustomization.AllowFilter = false;
            this.gvwDepositCash.OptionsCustomization.AllowGroup = false;
            this.gvwDepositCash.OptionsMenu.EnableColumnMenu = false;
            this.gvwDepositCash.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwDepositCash.OptionsView.EnableAppearanceOddRow = true;
            this.gvwDepositCash.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.DisplayFormat.FormatString = "MMM dd, yyyy";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "dpcDate";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "dpcDescription";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 158;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAmount.Caption = "Amount";
            this.colAmount.DisplayFormat.FormatString = "n2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "dpcAmount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 50;
            // 
            // frmDepositCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 429);
            this.Controls.Add(this.grdDepositCash);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grcCaption);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDepositCash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit Cash";
            this.Load += new System.EventHandler(this.frmDepositCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcCaption)).EndInit();
            this.grcCaption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepositCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwDepositCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtpDate;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl grpMain;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarStaticItem sitmStatus;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnCancel;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnSave;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnNew;
        private DevExpress.XtraBars.Bar barOptions;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraGrid.GridControl grdDepositCash;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwDepositCash;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnEdit;
        private DevExpress.XtraBars.BarLargeButtonItem bbtnDelete;

    }
}