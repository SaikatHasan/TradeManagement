namespace TradeManagement.Forms
{
    partial class frmUsers
    {
        private System.ComponentModel.IContainer components = null;

        private static frmUsers sForm = null;

        public static frmUsers Instance()
        {
            if (sForm == null) { sForm = new frmUsers(); }
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
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.grdUsers = new DevExpress.XtraGrid.GridControl();
            this.gvwUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkActive = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUserGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.grcCaption = new DevExpress.XtraEditors.GroupControl();
            this.lblCaption = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserGroup.Properties)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(494, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 407);
            this.barDockControlBottom.Size = new System.Drawing.Size(494, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 360);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(494, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 360);
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
            // grdUsers
            // 
            this.grdUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsers.Location = new System.Drawing.Point(12, 171);
            this.grdUsers.MainView = this.gvwUsers;
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.Size = new System.Drawing.Size(470, 227);
            this.grdUsers.TabIndex = 2;
            this.grdUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwUsers});
            this.grdUsers.Click += new System.EventHandler(this.grdUsers_Click);
            // 
            // gvwUsers
            // 
            this.gvwUsers.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwUsers.Appearance.FooterPanel.Options.UseFont = true;
            this.gvwUsers.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwUsers.Appearance.GroupFooter.Options.UseFont = true;
            this.gvwUsers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvwUsers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvwUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colUserGroup,
            this.colActive});
            this.gvwUsers.GridControl = this.grdUsers;
            this.gvwUsers.Name = "gvwUsers";
            this.gvwUsers.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvwUsers.OptionsBehavior.Editable = false;
            this.gvwUsers.OptionsCustomization.AllowColumnMoving = false;
            this.gvwUsers.OptionsCustomization.AllowFilter = false;
            this.gvwUsers.OptionsCustomization.AllowGroup = false;
            this.gvwUsers.OptionsMenu.EnableColumnMenu = false;
            this.gvwUsers.OptionsView.EnableAppearanceEvenRow = true;
            this.gvwUsers.OptionsView.EnableAppearanceOddRow = true;
            this.gvwUsers.OptionsView.ShowAutoFilterRow = true;
            this.gvwUsers.OptionsView.ShowGroupPanel = false;
            this.gvwUsers.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colUserName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colUserName
            // 
            this.colUserName.Caption = "User Name";
            this.colUserName.FieldName = "usrUserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            this.colUserName.Width = 196;
            // 
            // colUserGroup
            // 
            this.colUserGroup.Caption = "User Group";
            this.colUserGroup.FieldName = "usrUserGroupName";
            this.colUserGroup.Name = "colUserGroup";
            this.colUserGroup.Visible = true;
            this.colUserGroup.VisibleIndex = 1;
            this.colUserGroup.Width = 192;
            // 
            // colActive
            // 
            this.colActive.AppearanceHeader.Options.UseTextOptions = true;
            this.colActive.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActive.Caption = "Active";
            this.colActive.FieldName = "usrIsActive";
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 2;
            this.colActive.Width = 64;
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.labelControl3);
            this.grpMain.Controls.Add(this.txtPassword);
            this.grpMain.Controls.Add(this.labelControl1);
            this.grpMain.Controls.Add(this.chkActive);
            this.grpMain.Controls.Add(this.labelControl7);
            this.grpMain.Controls.Add(this.txtUserName);
            this.grpMain.Controls.Add(this.labelControl2);
            this.grpMain.Controls.Add(this.cmbUserGroup);
            this.grpMain.Enabled = false;
            this.grpMain.Location = new System.Drawing.Point(12, 109);
            this.grpMain.Name = "grpMain";
            this.grpMain.ShowCaption = false;
            this.grpMain.Size = new System.Drawing.Size(470, 56);
            this.grpMain.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(241, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(293, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "User Name";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(291, 31);
            this.chkActive.Name = "chkActive";
            this.chkActive.Properties.Caption = "";
            this.chkActive.Size = new System.Drawing.Size(19, 19);
            this.chkActive.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(257, 34);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Active";
            // 
            // txtUserName
            // 
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(63, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "User Group";
            // 
            // cmbUserGroup
            // 
            this.cmbUserGroup.Location = new System.Drawing.Point(63, 31);
            this.cmbUserGroup.Name = "cmbUserGroup";
            this.cmbUserGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserGroup.Properties.PopupSizeable = true;
            this.cmbUserGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbUserGroup.Size = new System.Drawing.Size(172, 20);
            this.cmbUserGroup.TabIndex = 5;
            // 
            // grcCaption
            // 
            this.grcCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCaption.Controls.Add(this.lblCaption);
            this.grcCaption.Location = new System.Drawing.Point(12, 53);
            this.grcCaption.Name = "grcCaption";
            this.grcCaption.ShowCaption = false;
            this.grcCaption.Size = new System.Drawing.Size(470, 50);
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
            this.lblCaption.Size = new System.Drawing.Size(466, 46);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Users";
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 432);
            this.Controls.Add(this.grdUsers);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grcCaption);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUsers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserGroup.Properties)).EndInit();
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
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem sitmStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraGrid.GridControl grdUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.GroupControl grpMain;
        private DevExpress.XtraEditors.CheckEdit chkActive;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl grcCaption;
        private DevExpress.XtraEditors.LabelControl lblCaption;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colUserGroup;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUserGroup;
    }
}