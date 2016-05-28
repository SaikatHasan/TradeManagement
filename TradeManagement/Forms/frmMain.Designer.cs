namespace TradeManagement.Forms
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        private static frmMain sForm = null;

        public static frmMain Instance()
        {
            if (sForm == null) { sForm = new frmMain(); }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            FastReport.Design.DesignerSettings designerSettings1 = new FastReport.Design.DesignerSettings();
            FastReport.Design.DesignerRestrictions designerRestrictions1 = new FastReport.Design.DesignerRestrictions();
            FastReport.Export.Email.EmailSettings emailSettings1 = new FastReport.Export.Email.EmailSettings();
            FastReport.PreviewSettings previewSettings1 = new FastReport.PreviewSettings();
            FastReport.ReportSettings reportSettings1 = new FastReport.ReportSettings();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnuApplication = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.pccOptions = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.sbtnExit = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnLogOff = new DevExpress.XtraEditors.SimpleButton();
            this.bbtnBackupDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRestoreDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDefragDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnCustomers = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSuppliers = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPurchaseReturn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSales = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSaleReturn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnExpenses = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDepositCash = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnCategories = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnBrands = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnUserGroups = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPermission = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnProfitReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnExpensesReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDepositCashReport = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticDateTime = new DevExpress.XtraBars.BarStaticItem();
            this.bbtnViewLog = new DevExpress.XtraBars.BarButtonItem();
            this.skinGalleryBarItem = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bbtnPPurchaseReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSSalesReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnPPurchaseReturnReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSSaleReturnReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRenewLicense = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnLicenseStatus = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRPurchaseReturn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRSales = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRSaleReturn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnInventory = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnAccountsPayable = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnAccountsReceivable = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRAccountsPayable = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRAccountsReceivable = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRTop10Products = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnWithdrawCash = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnQuotation = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnWithdrawCashReport = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnVAT = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnExpenseCategories = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnBankAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.rpManagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgPersons = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgProducts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAccounts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSkins = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpBackOffice = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgPurchase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBOfficeReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSales = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSales = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgFOfficeReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgQuotation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpAccounts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgCash = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTransactions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAccountsReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgRProducts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgRBackOffice = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgRSales = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgRAccounts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgStatistical = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpSecurity = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgAuthentication = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAuthorisation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpMaintenance = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDatabase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgLicense = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.envSettings = new FastReport.EnvironmentSettings();
            this.pnlInfo = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblLastInvoice = new DevExpress.XtraEditors.LabelControl();
            this.lblLastSaleAmount = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSaleAmount = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSaleCount = new DevExpress.XtraEditors.LabelControl();
            this.sptSplit = new DevExpress.XtraEditors.SplitterControl();
            this.dlfSkin = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.ofdRestore = new System.Windows.Forms.OpenFileDialog();
            this.fbdBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.bbtnVATReport = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnuApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccOptions)).BeginInit();
            this.pccOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfo)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.mnuApplication;
            this.ribbon.ApplicationIcon = global::TradeManagement.Properties.Resources.trade_icon24;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbtnCustomers,
            this.bbtnSuppliers,
            this.bbtnProducts,
            this.bbtnPurchase,
            this.bbtnPurchaseReturn,
            this.bbtnSales,
            this.bbtnSaleReturn,
            this.bbtnExpenses,
            this.bbtnDepositCash,
            this.bbtnCategories,
            this.bbtnBrands,
            this.bbtnUserGroups,
            this.bbtnUsers,
            this.bbtnPermission,
            this.bbtnProfitReport,
            this.bbtnExpensesReport,
            this.bbtnDepositCashReport,
            this.barStaticStatus,
            this.barStaticDateTime,
            this.bbtnViewLog,
            this.skinGalleryBarItem,
            this.bbtnPPurchaseReport,
            this.bbtnSSalesReport,
            this.bbtnPPurchaseReturnReport,
            this.bbtnSSaleReturnReport,
            this.bbtnBackupDatabase,
            this.bbtnRestoreDatabase,
            this.bbtnDefragDatabase,
            this.bbtnRenewLicense,
            this.bbtnLicenseStatus,
            this.bbtnRPurchase,
            this.bbtnRPurchaseReturn,
            this.bbtnRSales,
            this.bbtnRSaleReturn,
            this.bbtnInventory,
            this.bbtnAccountsPayable,
            this.bbtnAccountsReceivable,
            this.bbtnRAccountsPayable,
            this.bbtnRAccountsReceivable,
            this.bbtnRTop10Products,
            this.bbtnWithdrawCash,
            this.bbtnQuotation,
            this.bbtnWithdrawCashReport,
            this.bbtnVAT,
            this.bbtnExpenseCategories,
            this.bbtnBankAccounts,
            this.bbtnVATReport});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 27;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpManagement,
            this.rpBackOffice,
            this.rpSales,
            this.rpAccounts,
            this.rpReports,
            this.rpSecurity,
            this.rpMaintenance});
            this.ribbon.Size = new System.Drawing.Size(963, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // mnuApplication
            // 
            this.mnuApplication.BottomPaneControlContainer = this.pccOptions;
            this.mnuApplication.ItemLinks.Add(this.bbtnBackupDatabase);
            this.mnuApplication.ItemLinks.Add(this.bbtnRestoreDatabase);
            this.mnuApplication.ItemLinks.Add(this.bbtnDefragDatabase);
            this.mnuApplication.Name = "mnuApplication";
            this.mnuApplication.Ribbon = this.ribbon;
            // 
            // pccOptions
            // 
            this.pccOptions.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pccOptions.Appearance.Options.UseBackColor = true;
            this.pccOptions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pccOptions.Controls.Add(this.sbtnExit);
            this.pccOptions.Controls.Add(this.sbtnLogOff);
            this.pccOptions.Location = new System.Drawing.Point(404, 261);
            this.pccOptions.Name = "pccOptions";
            this.pccOptions.Ribbon = this.ribbon;
            this.pccOptions.Size = new System.Drawing.Size(162, 29);
            this.pccOptions.TabIndex = 16;
            this.pccOptions.Visible = false;
            // 
            // sbtnExit
            // 
            this.sbtnExit.Location = new System.Drawing.Point(84, 3);
            this.sbtnExit.Name = "sbtnExit";
            this.sbtnExit.Size = new System.Drawing.Size(75, 23);
            this.sbtnExit.TabIndex = 1;
            this.sbtnExit.Text = "Exit";
            this.sbtnExit.Click += new System.EventHandler(this.sbtnExit_Click);
            // 
            // sbtnLogOff
            // 
            this.sbtnLogOff.Location = new System.Drawing.Point(3, 3);
            this.sbtnLogOff.Name = "sbtnLogOff";
            this.sbtnLogOff.Size = new System.Drawing.Size(75, 23);
            this.sbtnLogOff.TabIndex = 0;
            this.sbtnLogOff.Text = "Log Off";
            this.sbtnLogOff.Click += new System.EventHandler(this.sbtnLogOff_Click);
            // 
            // bbtnBackupDatabase
            // 
            this.bbtnBackupDatabase.Caption = "Backup Database";
            this.bbtnBackupDatabase.Glyph = global::TradeManagement.Properties.Resources.Backup;
            this.bbtnBackupDatabase.Id = 5;
            this.bbtnBackupDatabase.Name = "bbtnBackupDatabase";
            this.bbtnBackupDatabase.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnBackupDatabase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnBackupDatabase_ItemClick);
            // 
            // bbtnRestoreDatabase
            // 
            this.bbtnRestoreDatabase.Caption = "Restore Database";
            this.bbtnRestoreDatabase.Glyph = global::TradeManagement.Properties.Resources.Restore;
            this.bbtnRestoreDatabase.Id = 6;
            this.bbtnRestoreDatabase.Name = "bbtnRestoreDatabase";
            this.bbtnRestoreDatabase.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnRestoreDatabase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRestoreDatabase_ItemClick);
            // 
            // bbtnDefragDatabase
            // 
            this.bbtnDefragDatabase.Caption = "Defrag Database";
            this.bbtnDefragDatabase.Glyph = global::TradeManagement.Properties.Resources.Defrag;
            this.bbtnDefragDatabase.Id = 7;
            this.bbtnDefragDatabase.Name = "bbtnDefragDatabase";
            this.bbtnDefragDatabase.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnDefragDatabase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDefragDatabase_ItemClick);
            // 
            // bbtnCustomers
            // 
            this.bbtnCustomers.Caption = "Customers";
            this.bbtnCustomers.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnCustomers.Glyph")));
            this.bbtnCustomers.Id = 1;
            this.bbtnCustomers.Name = "bbtnCustomers";
            this.bbtnCustomers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnCustomers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnCustomers_ItemClick);
            // 
            // bbtnSuppliers
            // 
            this.bbtnSuppliers.Caption = "Suppliers";
            this.bbtnSuppliers.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnSuppliers.Glyph")));
            this.bbtnSuppliers.Id = 2;
            this.bbtnSuppliers.Name = "bbtnSuppliers";
            this.bbtnSuppliers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnSuppliers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSuppliers_ItemClick);
            // 
            // bbtnProducts
            // 
            this.bbtnProducts.Caption = "Products";
            this.bbtnProducts.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnProducts.Glyph")));
            this.bbtnProducts.Id = 3;
            this.bbtnProducts.Name = "bbtnProducts";
            this.bbtnProducts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnProducts_ItemClick);
            // 
            // bbtnPurchase
            // 
            this.bbtnPurchase.Caption = "Purchase";
            this.bbtnPurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnPurchase.Glyph")));
            this.bbtnPurchase.Id = 4;
            this.bbtnPurchase.Name = "bbtnPurchase";
            this.bbtnPurchase.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnPurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPurchase_ItemClick);
            // 
            // bbtnPurchaseReturn
            // 
            this.bbtnPurchaseReturn.Caption = "Purchase Return";
            this.bbtnPurchaseReturn.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnPurchaseReturn.Glyph")));
            this.bbtnPurchaseReturn.Id = 5;
            this.bbtnPurchaseReturn.Name = "bbtnPurchaseReturn";
            this.bbtnPurchaseReturn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnPurchaseReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPurchaseReturn_ItemClick);
            // 
            // bbtnSales
            // 
            this.bbtnSales.Caption = "Sales";
            this.bbtnSales.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnSales.Glyph")));
            this.bbtnSales.Id = 6;
            this.bbtnSales.Name = "bbtnSales";
            this.bbtnSales.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnSales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSales_ItemClick);
            // 
            // bbtnSaleReturn
            // 
            this.bbtnSaleReturn.Caption = "Sales Return";
            this.bbtnSaleReturn.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnSaleReturn.Glyph")));
            this.bbtnSaleReturn.Id = 7;
            this.bbtnSaleReturn.Name = "bbtnSaleReturn";
            this.bbtnSaleReturn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnSaleReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSaleReturn_ItemClick);
            // 
            // bbtnExpenses
            // 
            this.bbtnExpenses.Caption = "Expenses";
            this.bbtnExpenses.Glyph = global::TradeManagement.Properties.Resources.daily_expense;
            this.bbtnExpenses.Id = 9;
            this.bbtnExpenses.Name = "bbtnExpenses";
            this.bbtnExpenses.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnExpenses.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnExpenses_ItemClick);
            // 
            // bbtnDepositCash
            // 
            this.bbtnDepositCash.Caption = "Deposit Cash";
            this.bbtnDepositCash.Glyph = global::TradeManagement.Properties.Resources.cash_in;
            this.bbtnDepositCash.Id = 10;
            this.bbtnDepositCash.Name = "bbtnDepositCash";
            this.bbtnDepositCash.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnDepositCash.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDepositCash_ItemClick);
            // 
            // bbtnCategories
            // 
            this.bbtnCategories.Caption = "Categories";
            this.bbtnCategories.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnCategories.Glyph")));
            this.bbtnCategories.Id = 11;
            this.bbtnCategories.Name = "bbtnCategories";
            this.bbtnCategories.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnCategories_ItemClick);
            // 
            // bbtnBrands
            // 
            this.bbtnBrands.Caption = "Brands";
            this.bbtnBrands.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnBrands.Glyph")));
            this.bbtnBrands.Id = 12;
            this.bbtnBrands.Name = "bbtnBrands";
            this.bbtnBrands.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnBrands.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnBrands_ItemClick);
            // 
            // bbtnUserGroups
            // 
            this.bbtnUserGroups.Caption = "User Groups";
            this.bbtnUserGroups.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnUserGroups.Glyph")));
            this.bbtnUserGroups.Id = 13;
            this.bbtnUserGroups.Name = "bbtnUserGroups";
            this.bbtnUserGroups.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnUserGroups.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnUserGroups_ItemClick);
            // 
            // bbtnUsers
            // 
            this.bbtnUsers.Caption = "Users";
            this.bbtnUsers.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnUsers.Glyph")));
            this.bbtnUsers.Id = 14;
            this.bbtnUsers.Name = "bbtnUsers";
            this.bbtnUsers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnUsers_ItemClick);
            // 
            // bbtnPermission
            // 
            this.bbtnPermission.Caption = "Permission";
            this.bbtnPermission.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnPermission.Glyph")));
            this.bbtnPermission.Id = 15;
            this.bbtnPermission.Name = "bbtnPermission";
            this.bbtnPermission.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnPermission.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPermission_ItemClick);
            // 
            // bbtnProfitReport
            // 
            this.bbtnProfitReport.Caption = "Profit Report";
            this.bbtnProfitReport.Glyph = global::TradeManagement.Properties.Resources.profit_report;
            this.bbtnProfitReport.Id = 19;
            this.bbtnProfitReport.Name = "bbtnProfitReport";
            this.bbtnProfitReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnProfitReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnProfitReport_ItemClick);
            // 
            // bbtnExpensesReport
            // 
            this.bbtnExpensesReport.Caption = "Expenses Report";
            this.bbtnExpensesReport.Glyph = global::TradeManagement.Properties.Resources.daily_expense_report;
            this.bbtnExpensesReport.Id = 23;
            this.bbtnExpensesReport.Name = "bbtnExpensesReport";
            this.bbtnExpensesReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnExpensesReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnExpensesReport_ItemClick);
            // 
            // bbtnDepositCashReport
            // 
            this.bbtnDepositCashReport.Caption = "Deposit Cash Report";
            this.bbtnDepositCashReport.Glyph = global::TradeManagement.Properties.Resources.cash_in_report;
            this.bbtnDepositCashReport.Id = 25;
            this.bbtnDepositCashReport.Name = "bbtnDepositCashReport";
            this.bbtnDepositCashReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnDepositCashReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDepositCashReport_ItemClick);
            // 
            // barStaticStatus
            // 
            this.barStaticStatus.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.barStaticStatus.Id = 30;
            this.barStaticStatus.Name = "barStaticStatus";
            this.barStaticStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticDateTime
            // 
            this.barStaticDateTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticDateTime.Id = 31;
            this.barStaticDateTime.Name = "barStaticDateTime";
            this.barStaticDateTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbtnViewLog
            // 
            this.bbtnViewLog.Caption = "View Log";
            this.bbtnViewLog.Id = 33;
            this.bbtnViewLog.Name = "bbtnViewLog";
            // 
            // skinGalleryBarItem
            // 
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Standard";
            this.skinGalleryBarItem.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.skinGalleryBarItem.Id = 35;
            this.skinGalleryBarItem.Name = "skinGalleryBarItem";
            this.skinGalleryBarItem.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.skinGalleryBarItem_GalleryItemClick);
            // 
            // bbtnPPurchaseReport
            // 
            this.bbtnPPurchaseReport.Caption = "Purchase Report";
            this.bbtnPPurchaseReport.Glyph = global::TradeManagement.Properties.Resources.purchase_report;
            this.bbtnPPurchaseReport.Id = 1;
            this.bbtnPPurchaseReport.Name = "bbtnPPurchaseReport";
            this.bbtnPPurchaseReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnPPurchaseReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPPurchaseReport_ItemClick);
            // 
            // bbtnSSalesReport
            // 
            this.bbtnSSalesReport.Caption = "Sales Report";
            this.bbtnSSalesReport.Glyph = global::TradeManagement.Properties.Resources.sales_report;
            this.bbtnSSalesReport.Id = 2;
            this.bbtnSSalesReport.Name = "bbtnSSalesReport";
            this.bbtnSSalesReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnSSalesReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSSalesReport_ItemClick);
            // 
            // bbtnPPurchaseReturnReport
            // 
            this.bbtnPPurchaseReturnReport.Caption = "Purchase Return Report";
            this.bbtnPPurchaseReturnReport.Glyph = global::TradeManagement.Properties.Resources.purchase_report;
            this.bbtnPPurchaseReturnReport.Id = 3;
            this.bbtnPPurchaseReturnReport.Name = "bbtnPPurchaseReturnReport";
            this.bbtnPPurchaseReturnReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnPPurchaseReturnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPPurchaseReturnReport_ItemClick);
            // 
            // bbtnSSaleReturnReport
            // 
            this.bbtnSSaleReturnReport.Caption = "Sales Return Report";
            this.bbtnSSaleReturnReport.Glyph = global::TradeManagement.Properties.Resources.sales_report;
            this.bbtnSSaleReturnReport.Id = 4;
            this.bbtnSSaleReturnReport.Name = "bbtnSSaleReturnReport";
            this.bbtnSSaleReturnReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnSSaleReturnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSSaleReturnReport_ItemClick);
            // 
            // bbtnRenewLicense
            // 
            this.bbtnRenewLicense.Caption = "Renew License";
            this.bbtnRenewLicense.Glyph = global::TradeManagement.Properties.Resources.Renew;
            this.bbtnRenewLicense.Id = 8;
            this.bbtnRenewLicense.Name = "bbtnRenewLicense";
            this.bbtnRenewLicense.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnRenewLicense.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRenewLicense_ItemClick);
            // 
            // bbtnLicenseStatus
            // 
            this.bbtnLicenseStatus.Caption = "License Status";
            this.bbtnLicenseStatus.Glyph = global::TradeManagement.Properties.Resources.Status;
            this.bbtnLicenseStatus.Id = 9;
            this.bbtnLicenseStatus.Name = "bbtnLicenseStatus";
            this.bbtnLicenseStatus.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnLicenseStatus.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnLicenseStatus_ItemClick);
            // 
            // bbtnRPurchase
            // 
            this.bbtnRPurchase.Caption = "Purchase";
            this.bbtnRPurchase.Glyph = global::TradeManagement.Properties.Resources.purchase_report;
            this.bbtnRPurchase.Id = 10;
            this.bbtnRPurchase.Name = "bbtnRPurchase";
            this.bbtnRPurchase.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnRPurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRPurchase_ItemClick);
            // 
            // bbtnRPurchaseReturn
            // 
            this.bbtnRPurchaseReturn.Caption = "Purchase Return";
            this.bbtnRPurchaseReturn.Glyph = global::TradeManagement.Properties.Resources.purchase_report;
            this.bbtnRPurchaseReturn.Id = 11;
            this.bbtnRPurchaseReturn.Name = "bbtnRPurchaseReturn";
            this.bbtnRPurchaseReturn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnRPurchaseReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRPurchaseReturn_ItemClick);
            // 
            // bbtnRSales
            // 
            this.bbtnRSales.Caption = "Sales";
            this.bbtnRSales.Glyph = global::TradeManagement.Properties.Resources.sales_report;
            this.bbtnRSales.Id = 12;
            this.bbtnRSales.Name = "bbtnRSales";
            this.bbtnRSales.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnRSales.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRSales_ItemClick);
            // 
            // bbtnRSaleReturn
            // 
            this.bbtnRSaleReturn.Caption = "Sales Return";
            this.bbtnRSaleReturn.Glyph = global::TradeManagement.Properties.Resources.sales_report;
            this.bbtnRSaleReturn.Id = 13;
            this.bbtnRSaleReturn.Name = "bbtnRSaleReturn";
            this.bbtnRSaleReturn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnRSaleReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRSaleReturn_ItemClick);
            // 
            // bbtnInventory
            // 
            this.bbtnInventory.Caption = "Inventory";
            this.bbtnInventory.Glyph = global::TradeManagement.Properties.Resources.Inventory;
            this.bbtnInventory.Id = 14;
            this.bbtnInventory.Name = "bbtnInventory";
            this.bbtnInventory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnInventory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnInventory_ItemClick);
            // 
            // bbtnAccountsPayable
            // 
            this.bbtnAccountsPayable.Caption = "Accounts Payable";
            this.bbtnAccountsPayable.Glyph = global::TradeManagement.Properties.Resources.AccountsPayable;
            this.bbtnAccountsPayable.Id = 15;
            this.bbtnAccountsPayable.Name = "bbtnAccountsPayable";
            this.bbtnAccountsPayable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnAccountsPayable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnAccountsPayable_ItemClick);
            // 
            // bbtnAccountsReceivable
            // 
            this.bbtnAccountsReceivable.Caption = "Accounts Receivable";
            this.bbtnAccountsReceivable.Glyph = global::TradeManagement.Properties.Resources.AccountsReceivable;
            this.bbtnAccountsReceivable.Id = 16;
            this.bbtnAccountsReceivable.Name = "bbtnAccountsReceivable";
            this.bbtnAccountsReceivable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnAccountsReceivable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnAccountsReceivable_ItemClick);
            // 
            // bbtnRAccountsPayable
            // 
            this.bbtnRAccountsPayable.Caption = "Accounts Payable";
            this.bbtnRAccountsPayable.Glyph = global::TradeManagement.Properties.Resources.AccountsPayableReport;
            this.bbtnRAccountsPayable.Id = 17;
            this.bbtnRAccountsPayable.Name = "bbtnRAccountsPayable";
            this.bbtnRAccountsPayable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnRAccountsPayable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRAccountsPayable_ItemClick);
            // 
            // bbtnRAccountsReceivable
            // 
            this.bbtnRAccountsReceivable.Caption = "Accounts Receivable";
            this.bbtnRAccountsReceivable.Glyph = global::TradeManagement.Properties.Resources.AccountsReceivableReport;
            this.bbtnRAccountsReceivable.Id = 18;
            this.bbtnRAccountsReceivable.Name = "bbtnRAccountsReceivable";
            this.bbtnRAccountsReceivable.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnRAccountsReceivable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRAccountsReceivable_ItemClick);
            // 
            // bbtnRTop10Products
            // 
            this.bbtnRTop10Products.Caption = "Top 10 Products";
            this.bbtnRTop10Products.Glyph = global::TradeManagement.Properties.Resources.Chart;
            this.bbtnRTop10Products.Id = 19;
            this.bbtnRTop10Products.Name = "bbtnRTop10Products";
            this.bbtnRTop10Products.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnRTop10Products.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRTop10Products_ItemClick);
            // 
            // bbtnWithdrawCash
            // 
            this.bbtnWithdrawCash.Caption = "Withdraw Cash";
            this.bbtnWithdrawCash.Glyph = global::TradeManagement.Properties.Resources.Withdraw;
            this.bbtnWithdrawCash.Id = 20;
            this.bbtnWithdrawCash.Name = "bbtnWithdrawCash";
            this.bbtnWithdrawCash.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnWithdrawCash.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnWithdrawCash_ItemClick);
            // 
            // bbtnQuotation
            // 
            this.bbtnQuotation.Caption = "Quotation";
            this.bbtnQuotation.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnQuotation.Glyph")));
            this.bbtnQuotation.Id = 21;
            this.bbtnQuotation.Name = "bbtnQuotation";
            this.bbtnQuotation.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnQuotation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnQuotation_ItemClick);
            // 
            // bbtnWithdrawCashReport
            // 
            this.bbtnWithdrawCashReport.Caption = "Withdraw Cash Report";
            this.bbtnWithdrawCashReport.Glyph = global::TradeManagement.Properties.Resources.cash_in_report;
            this.bbtnWithdrawCashReport.Id = 22;
            this.bbtnWithdrawCashReport.Name = "bbtnWithdrawCashReport";
            this.bbtnWithdrawCashReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnWithdrawCashReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnWithdrawCashReport_ItemClick);
            // 
            // bbtnVAT
            // 
            this.bbtnVAT.Caption = "VAT Reg. No";
            this.bbtnVAT.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnVAT.Glyph")));
            this.bbtnVAT.Id = 23;
            this.bbtnVAT.Name = "bbtnVAT";
            this.bbtnVAT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnVAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnVAT_ItemClick);
            // 
            // bbtnExpenseCategories
            // 
            this.bbtnExpenseCategories.Caption = "Expense Categories";
            this.bbtnExpenseCategories.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnExpenseCategories.Glyph")));
            this.bbtnExpenseCategories.Id = 24;
            this.bbtnExpenseCategories.Name = "bbtnExpenseCategories";
            this.bbtnExpenseCategories.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnExpenseCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnExpenseCategories_ItemClick);
            // 
            // bbtnBankAccounts
            // 
            this.bbtnBankAccounts.Caption = " Bank  Accounts";
            this.bbtnBankAccounts.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnBankAccounts.Glyph")));
            this.bbtnBankAccounts.Id = 25;
            this.bbtnBankAccounts.Name = "bbtnBankAccounts";
            this.bbtnBankAccounts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnBankAccounts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnBankAccounts_ItemClick);
            // 
            // rpManagement
            // 
            this.rpManagement.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgPersons,
            this.rpgProducts,
            this.rpgAccounts,
            this.rpgSkins});
            this.rpManagement.Name = "rpManagement";
            this.rpManagement.Text = "Management";
            // 
            // rpgPersons
            // 
            this.rpgPersons.ItemLinks.Add(this.bbtnCustomers);
            this.rpgPersons.ItemLinks.Add(this.bbtnSuppliers);
            this.rpgPersons.Name = "rpgPersons";
            this.rpgPersons.ShowCaptionButton = false;
            this.rpgPersons.Text = "Persons";
            // 
            // rpgProducts
            // 
            this.rpgProducts.ItemLinks.Add(this.bbtnCategories);
            this.rpgProducts.ItemLinks.Add(this.bbtnBrands);
            this.rpgProducts.ItemLinks.Add(this.bbtnProducts);
            this.rpgProducts.Name = "rpgProducts";
            this.rpgProducts.ShowCaptionButton = false;
            this.rpgProducts.Text = "Products";
            // 
            // rpgAccounts
            // 
            this.rpgAccounts.ItemLinks.Add(this.bbtnVAT);
            this.rpgAccounts.ItemLinks.Add(this.bbtnExpenseCategories);
            this.rpgAccounts.ItemLinks.Add(this.bbtnBankAccounts);
            this.rpgAccounts.Name = "rpgAccounts";
            this.rpgAccounts.ShowCaptionButton = false;
            this.rpgAccounts.Text = "Accounts";
            // 
            // rpgSkins
            // 
            this.rpgSkins.ItemLinks.Add(this.skinGalleryBarItem);
            this.rpgSkins.Name = "rpgSkins";
            this.rpgSkins.ShowCaptionButton = false;
            this.rpgSkins.Text = "Skins";
            // 
            // rpBackOffice
            // 
            this.rpBackOffice.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgPurchase,
            this.rpgBOfficeReports});
            this.rpBackOffice.Name = "rpBackOffice";
            this.rpBackOffice.Text = "Back Office";
            // 
            // rpgPurchase
            // 
            this.rpgPurchase.ItemLinks.Add(this.bbtnPurchase);
            this.rpgPurchase.ItemLinks.Add(this.bbtnPurchaseReturn);
            this.rpgPurchase.Name = "rpgPurchase";
            this.rpgPurchase.ShowCaptionButton = false;
            this.rpgPurchase.Text = "Purchase";
            // 
            // rpgBOfficeReports
            // 
            this.rpgBOfficeReports.ItemLinks.Add(this.bbtnPPurchaseReport);
            this.rpgBOfficeReports.ItemLinks.Add(this.bbtnPPurchaseReturnReport);
            this.rpgBOfficeReports.Name = "rpgBOfficeReports";
            this.rpgBOfficeReports.ShowCaptionButton = false;
            this.rpgBOfficeReports.Text = "Reports";
            // 
            // rpSales
            // 
            this.rpSales.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSales,
            this.rpgFOfficeReports,
            this.rpgQuotation});
            this.rpSales.Name = "rpSales";
            this.rpSales.Text = "Sales";
            // 
            // rpgSales
            // 
            this.rpgSales.ItemLinks.Add(this.bbtnSales);
            this.rpgSales.ItemLinks.Add(this.bbtnSaleReturn);
            this.rpgSales.Name = "rpgSales";
            this.rpgSales.ShowCaptionButton = false;
            this.rpgSales.Text = "Sales";
            // 
            // rpgFOfficeReports
            // 
            this.rpgFOfficeReports.ItemLinks.Add(this.bbtnSSalesReport);
            this.rpgFOfficeReports.ItemLinks.Add(this.bbtnSSaleReturnReport);
            this.rpgFOfficeReports.Name = "rpgFOfficeReports";
            this.rpgFOfficeReports.ShowCaptionButton = false;
            this.rpgFOfficeReports.Text = "Reports";
            // 
            // rpgQuotation
            // 
            this.rpgQuotation.ItemLinks.Add(this.bbtnQuotation);
            this.rpgQuotation.Name = "rpgQuotation";
            this.rpgQuotation.ShowCaptionButton = false;
            this.rpgQuotation.Text = "Quotation";
            // 
            // rpAccounts
            // 
            this.rpAccounts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgCash,
            this.rpgTransactions,
            this.rpgAccountsReports});
            this.rpAccounts.Name = "rpAccounts";
            this.rpAccounts.Text = "Accounts";
            // 
            // rpgCash
            // 
            this.rpgCash.ItemLinks.Add(this.bbtnExpenses);
            this.rpgCash.ItemLinks.Add(this.bbtnDepositCash);
            this.rpgCash.ItemLinks.Add(this.bbtnWithdrawCash);
            this.rpgCash.Name = "rpgCash";
            this.rpgCash.ShowCaptionButton = false;
            this.rpgCash.Text = "Cash";
            // 
            // rpgTransactions
            // 
            this.rpgTransactions.ItemLinks.Add(this.bbtnAccountsPayable);
            this.rpgTransactions.ItemLinks.Add(this.bbtnAccountsReceivable);
            this.rpgTransactions.Name = "rpgTransactions";
            this.rpgTransactions.ShowCaptionButton = false;
            this.rpgTransactions.Text = "Transactions";
            // 
            // rpgAccountsReports
            // 
            this.rpgAccountsReports.ItemLinks.Add(this.bbtnExpensesReport);
            this.rpgAccountsReports.ItemLinks.Add(this.bbtnDepositCashReport);
            this.rpgAccountsReports.ItemLinks.Add(this.bbtnWithdrawCashReport);
            this.rpgAccountsReports.ItemLinks.Add(this.bbtnVATReport);
            this.rpgAccountsReports.ItemLinks.Add(this.bbtnProfitReport, true);
            this.rpgAccountsReports.Name = "rpgAccountsReports";
            this.rpgAccountsReports.ShowCaptionButton = false;
            this.rpgAccountsReports.Text = "Reports";
            // 
            // rpReports
            // 
            this.rpReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgRProducts,
            this.rpgRBackOffice,
            this.rpgRSales,
            this.rpgRAccounts,
            this.rpgStatistical});
            this.rpReports.Name = "rpReports";
            this.rpReports.Text = "Reports";
            // 
            // rpgRProducts
            // 
            this.rpgRProducts.ItemLinks.Add(this.bbtnInventory);
            this.rpgRProducts.Name = "rpgRProducts";
            this.rpgRProducts.ShowCaptionButton = false;
            this.rpgRProducts.Text = "Products";
            // 
            // rpgRBackOffice
            // 
            this.rpgRBackOffice.ItemLinks.Add(this.bbtnRPurchase);
            this.rpgRBackOffice.ItemLinks.Add(this.bbtnRPurchaseReturn);
            this.rpgRBackOffice.Name = "rpgRBackOffice";
            this.rpgRBackOffice.ShowCaptionButton = false;
            this.rpgRBackOffice.Text = "Back Office";
            // 
            // rpgRSales
            // 
            this.rpgRSales.ItemLinks.Add(this.bbtnRSales);
            this.rpgRSales.ItemLinks.Add(this.bbtnRSaleReturn);
            this.rpgRSales.Name = "rpgRSales";
            this.rpgRSales.ShowCaptionButton = false;
            this.rpgRSales.Text = "Sales";
            // 
            // rpgRAccounts
            // 
            this.rpgRAccounts.ItemLinks.Add(this.bbtnRAccountsPayable);
            this.rpgRAccounts.ItemLinks.Add(this.bbtnRAccountsReceivable);
            this.rpgRAccounts.Name = "rpgRAccounts";
            this.rpgRAccounts.ShowCaptionButton = false;
            this.rpgRAccounts.Text = "Accounts";
            // 
            // rpgStatistical
            // 
            this.rpgStatistical.ItemLinks.Add(this.bbtnRTop10Products);
            this.rpgStatistical.Name = "rpgStatistical";
            this.rpgStatistical.ShowCaptionButton = false;
            this.rpgStatistical.Text = "Statistical";
            // 
            // rpSecurity
            // 
            this.rpSecurity.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgAuthentication,
            this.rpgAuthorisation});
            this.rpSecurity.Name = "rpSecurity";
            this.rpSecurity.Text = "Security";
            // 
            // rpgAuthentication
            // 
            this.rpgAuthentication.ItemLinks.Add(this.bbtnUserGroups);
            this.rpgAuthentication.ItemLinks.Add(this.bbtnUsers);
            this.rpgAuthentication.Name = "rpgAuthentication";
            this.rpgAuthentication.ShowCaptionButton = false;
            this.rpgAuthentication.Text = "Authentication";
            // 
            // rpgAuthorisation
            // 
            this.rpgAuthorisation.ItemLinks.Add(this.bbtnPermission);
            this.rpgAuthorisation.Name = "rpgAuthorisation";
            this.rpgAuthorisation.ShowCaptionButton = false;
            this.rpgAuthorisation.Text = "Authorisation";
            // 
            // rpMaintenance
            // 
            this.rpMaintenance.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDatabase,
            this.rpgLicense});
            this.rpMaintenance.Name = "rpMaintenance";
            this.rpMaintenance.Text = "Maintenance";
            // 
            // rpgDatabase
            // 
            this.rpgDatabase.ItemLinks.Add(this.bbtnBackupDatabase);
            this.rpgDatabase.ItemLinks.Add(this.bbtnRestoreDatabase);
            this.rpgDatabase.ItemLinks.Add(this.bbtnDefragDatabase);
            this.rpgDatabase.Name = "rpgDatabase";
            this.rpgDatabase.ShowCaptionButton = false;
            this.rpgDatabase.Text = "Database";
            // 
            // rpgLicense
            // 
            this.rpgLicense.ItemLinks.Add(this.bbtnLicenseStatus);
            this.rpgLicense.ItemLinks.Add(this.bbtnRenewLicense);
            this.rpgLicense.Name = "rpgLicense";
            this.rpgLicense.ShowCaptionButton = false;
            this.rpgLicense.Text = "License";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticDateTime);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 518);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(963, 32);
            // 
            // envSettings
            // 
            designerSettings1.ApplicationConnection = null;
            designerSettings1.DefaultFont = new System.Drawing.Font("Arial", 10F);
            designerSettings1.Icon = null;
            designerSettings1.Restrictions = designerRestrictions1;
            designerSettings1.Text = "";
            this.envSettings.DesignerSettings = designerSettings1;
            emailSettings1.Address = "";
            emailSettings1.Host = "";
            emailSettings1.MessageTemplate = "";
            emailSettings1.Name = "";
            emailSettings1.Password = "";
            emailSettings1.UserName = "";
            this.envSettings.EmailSettings = emailSettings1;
            previewSettings1.Buttons = ((FastReport.PreviewButtons)((((((((((FastReport.PreviewButtons.Print | FastReport.PreviewButtons.Save) 
            | FastReport.PreviewButtons.Email) 
            | FastReport.PreviewButtons.Find) 
            | FastReport.PreviewButtons.Zoom) 
            | FastReport.PreviewButtons.Outline) 
            | FastReport.PreviewButtons.PageSetup) 
            | FastReport.PreviewButtons.Watermark) 
            | FastReport.PreviewButtons.Navigator) 
            | FastReport.PreviewButtons.Close)));
            previewSettings1.Icon = ((System.Drawing.Icon)(resources.GetObject("previewSettings1.Icon")));
            previewSettings1.Text = "";
            this.envSettings.PreviewSettings = previewSettings1;
            this.envSettings.ReportSettings = reportSettings1;
            this.envSettings.UIStyle = FastReport.Utils.UIStyle.VistaGlass;
            this.envSettings.DatabaseLogin += new FastReport.DatabaseLoginEventHandler(this.envSettings_DatabaseLogin);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.groupControl1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(0, 144);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(235, 374);
            this.pnlInfo.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.Controls.Add(this.lblLastInvoice);
            this.groupControl1.Controls.Add(this.lblLastSaleAmount);
            this.groupControl1.Controls.Add(this.lblTotalSaleAmount);
            this.groupControl1.Controls.Add(this.lblTotalSaleCount);
            this.groupControl1.Location = new System.Drawing.Point(6, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(223, 116);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Today\'s Status";
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
            // sptSplit
            // 
            this.sptSplit.Location = new System.Drawing.Point(235, 144);
            this.sptSplit.Name = "sptSplit";
            this.sptSplit.Size = new System.Drawing.Size(6, 374);
            this.sptSplit.TabIndex = 12;
            this.sptSplit.TabStop = false;
            // 
            // dlfSkin
            // 
            this.dlfSkin.LookAndFeel.SkinName = "Office 2010 Silver";
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // ofdRestore
            // 
            this.ofdRestore.Filter = "Database Backup File(*.dbbkp)|*.dbbkp";
            this.ofdRestore.Title = "Select The Backup File";
            // 
            // fbdBackup
            // 
            this.fbdBackup.Description = "Select where to create the database backup";
            // 
            // bbtnVATReport
            // 
            this.bbtnVATReport.Caption = "VAT Report";
            this.bbtnVATReport.Glyph = ((System.Drawing.Image)(resources.GetObject("bbtnVATReport.Glyph")));
            this.bbtnVATReport.Id = 26;
            this.bbtnVATReport.Name = "bbtnVATReport";
            this.bbtnVATReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbtnVATReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnVATReport_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 550);
            this.Controls.Add(this.pccOptions);
            this.Controls.Add(this.sptSplit);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Trade Management :: ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnuApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccOptions)).EndInit();
            this.pccOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlInfo)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPersons;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbtnCustomers;
        private DevExpress.XtraBars.BarButtonItem bbtnSuppliers;
        private DevExpress.XtraBars.BarButtonItem bbtnProducts;
        private FastReport.EnvironmentSettings envSettings;
        private DevExpress.XtraBars.BarButtonItem bbtnPurchase;
        private DevExpress.XtraBars.BarButtonItem bbtnPurchaseReturn;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpBackOffice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPurchase;
        private DevExpress.XtraBars.BarButtonItem bbtnSales;
        private DevExpress.XtraBars.BarButtonItem bbtnSaleReturn;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSales;
        private DevExpress.XtraEditors.PanelControl pnlInfo;
        private DevExpress.XtraEditors.SplitterControl sptSplit;
        private DevExpress.LookAndFeel.DefaultLookAndFeel dlfSkin;
        private DevExpress.XtraBars.BarButtonItem bbtnExpenses;
        private DevExpress.XtraBars.BarButtonItem bbtnDepositCash;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAccounts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCash;
        private DevExpress.XtraBars.BarButtonItem bbtnCategories;
        private DevExpress.XtraBars.BarButtonItem bbtnBrands;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAccounts;
        private DevExpress.XtraBars.BarButtonItem bbtnUserGroups;
        private DevExpress.XtraBars.BarButtonItem bbtnUsers;
        private DevExpress.XtraBars.BarButtonItem bbtnPermission;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSecurity;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAuthentication;
        private DevExpress.XtraBars.BarButtonItem bbtnProfitReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAccountsReports;
        private DevExpress.XtraBars.BarButtonItem bbtnExpensesReport;
        private DevExpress.XtraBars.BarButtonItem bbtnDepositCashReport;
        private DevExpress.XtraBars.BarStaticItem barStaticStatus;
        private DevExpress.XtraBars.BarStaticItem barStaticDateTime;
        private System.Windows.Forms.Timer tmrDateTime;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu mnuApplication;
        private DevExpress.XtraBars.PopupControlContainer pccOptions;
        private DevExpress.XtraEditors.SimpleButton sbtnExit;
        private DevExpress.XtraEditors.SimpleButton sbtnLogOff;
        private DevExpress.XtraBars.BarButtonItem bbtnViewLog;
        private DevExpress.XtraBars.RibbonGalleryBarItem skinGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSkins;
        private DevExpress.XtraBars.BarButtonItem bbtnPPurchaseReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBOfficeReports;
        private DevExpress.XtraBars.BarButtonItem bbtnSSalesReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgFOfficeReports;
        private DevExpress.XtraEditors.LabelControl lblTotalSaleCount;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblTotalSaleAmount;
        private DevExpress.XtraEditors.LabelControl lblLastSaleAmount;
        private DevExpress.XtraEditors.LabelControl lblLastInvoice;
        private DevExpress.XtraBars.BarButtonItem bbtnPPurchaseReturnReport;
        private DevExpress.XtraBars.BarButtonItem bbtnSSaleReturnReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgRProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgRBackOffice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgRSales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgRAccounts;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpMaintenance;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDatabase;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgLicense;
        private DevExpress.XtraBars.BarButtonItem bbtnBackupDatabase;
        private DevExpress.XtraBars.BarButtonItem bbtnRestoreDatabase;
        private DevExpress.XtraBars.BarButtonItem bbtnDefragDatabase;
        private DevExpress.XtraBars.BarButtonItem bbtnRenewLicense;
        private DevExpress.XtraBars.BarButtonItem bbtnLicenseStatus;
        private System.Windows.Forms.OpenFileDialog ofdRestore;
        private System.Windows.Forms.FolderBrowserDialog fbdBackup;
        private DevExpress.XtraBars.BarButtonItem bbtnRPurchase;
        private DevExpress.XtraBars.BarButtonItem bbtnRPurchaseReturn;
        private DevExpress.XtraBars.BarButtonItem bbtnRSales;
        private DevExpress.XtraBars.BarButtonItem bbtnRSaleReturn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgStatistical;
        private DevExpress.XtraBars.BarButtonItem bbtnInventory;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAuthorisation;
        private DevExpress.XtraBars.BarButtonItem bbtnAccountsPayable;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTransactions;
        private DevExpress.XtraBars.BarButtonItem bbtnAccountsReceivable;
        private DevExpress.XtraBars.BarButtonItem bbtnRAccountsPayable;
        private DevExpress.XtraBars.BarButtonItem bbtnRAccountsReceivable;
        private DevExpress.XtraBars.BarButtonItem bbtnRTop10Products;
        private DevExpress.XtraBars.BarButtonItem bbtnWithdrawCash;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgQuotation;
        private DevExpress.XtraBars.BarButtonItem bbtnQuotation;
        private DevExpress.XtraBars.BarButtonItem bbtnWithdrawCashReport;
        private DevExpress.XtraBars.BarButtonItem bbtnVAT;
        private DevExpress.XtraBars.BarButtonItem bbtnExpenseCategories;
        private DevExpress.XtraBars.BarButtonItem bbtnBankAccounts;
        private DevExpress.XtraBars.BarButtonItem bbtnVATReport;
    }
}