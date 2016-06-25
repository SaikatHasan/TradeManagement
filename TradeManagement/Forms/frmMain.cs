using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using FastReport;
using SKGL;
using TradeManagement_DAL;
using VistaDB.DDA;
using VistaDB.Provider;

namespace TradeManagement.Forms
{
    public partial class frmMain : RibbonForm
    {
        private readonly clsCommon _common = new clsCommon();
        readonly SerialKeyConfiguration _serialKeyConfiguration = new SerialKeyConfiguration();

        public frmMain()
        {
            InitializeComponent();
            _common.RunChangeScripts();
            var machineCode = new Generate(_serialKeyConfiguration).MachineCode;
            SkinHelper.InitSkinGallery(skinGalleryBarItem, true);
            var dtTheme = _common.GetTheme(machineCode.ToString());
            dlfSkin.LookAndFeel.SkinName = dtTheme.Rows.Count > 0 ? dtTheme.Rows[0]["optTheme"].ToString() : "DevExpress Style";
            frmLogin.Instance().ShowDialog();
            CheckLicense();
            tmrDateTime.Enabled = true;
            barStaticStatus.Caption = $"Welcome, {_common.Decrypt(Program.UserName, "Saikat")}";
        }

        private void CheckLicense()
        {
            var machineCode = new Generate(_serialKeyConfiguration).MachineCode;
            var skc = new SerialKeyConfiguration();
            var licenseInformation = _common.GetLicenseInformation(machineCode.ToString());
            //var key = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("AlphaSoftTradeManagement");
            //if (key == null) return;
            var validate = new Validate(skc)
            {
                //Key = key.GetValue("SerialNo").ToString(),
                Key = licenseInformation.Rows[0]["lcnSerialNo"].ToString(),
                secretPhase = "91b53799-75d5-4590-90fd-c1f64b41cd47"
            };
            if (validate.DaysLeft <= 10)
            {
                _common.BeginTran();
                _common.UpdateLicenseInformation(machineCode.ToString(), "1");
                _common.CommitTran();
                XtraMessageBox.Show("Your license will expire in " + validate.DaysLeft + " days. Please renew the license before it expires to continue without uninterruption.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (DetectClockManipulation(DateTime.Now))
            {
                XtraMessageBox.Show("System date is modified. Please correct the system and then open the software again to continue. The software will close now.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private bool DetectClockManipulation(DateTime thresholdTime)
        {
            //var adjustedThresholdTime = new DateTime(thresholdTime.Year, thresholdTime.Month, thresholdTime.Day, 23, 59, 59);
            var eventLog = new EventLog("system");
            //return eventLog.Entries.Cast<EventLogEntry>().Any(entry => entry.TimeWritten > adjustedThresholdTime);
            return eventLog.Entries.Cast<EventLogEntry>().Any(entry => entry.TimeWritten > thresholdTime);
        }

        private void envSettings_DatabaseLogin(object sender, DatabaseLoginEventArgs e)
        {
            e.ConnectionString = "Data Source=" + Application.StartupPath + "\\Data\\Database.data;Open Mode=NonExclusiveReadWrite;Password=p@ssw0rd";
        }

        private void bbtnCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomers.Instance().MdiParent = this;
            frmCustomers.Instance().Show();
        }

        private void bbtnSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSuppliers.Instance().MdiParent = this;
            frmSuppliers.Instance().Show();
        }

        private void bbtnProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmProducts.Instance().MdiParent = this;
            frmProducts.Instance().Show();
        }

        private void bbtnVAT_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmVAT.Instance().MdiParent = this;
            frmVAT.Instance().Show();
        }

        private void bbtnExpenseCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmExpenseCategories.Instance().MdiParent = this;
            frmExpenseCategories.Instance().Show();
        }

        private void bbtnBankAccounts_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBankAccounts.Instance().MdiParent = this;
            frmBankAccounts.Instance().Show();
        }

        private void bbtnPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPurchases.Instance().MdiParent = this;
            frmPurchases.Instance().Show();
        }

        private void bbtnPurchaseReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPurchaseReturns.Instance().MdiParent = this;
            frmPurchaseReturns.Instance().Show();
        }

        private void bbtnPPurchaseReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "Purchase";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }

        private void bbtnPPurchaseReturnReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "PurchaseReturn";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }

        private void bbtnSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmSales.Instance().MdiParent = this;
            frmSales.Instance().Show();
        }

        private void bbtnSaleReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSaleReturns.Instance().MdiParent = this;
            frmSaleReturns.Instance().Show();
        }

        private void bbtnSSalesReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "Sales";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }

        private void bbtnSSaleReturnReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "SaleReturn";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }

        private void bbtnQuotation_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuotations.Instance().MdiParent = this;
            frmQuotations.Instance().Show();
        }

        private void bbtnCategories_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmProductCategories.Instance().MdiParent = this;
            frmProductCategories.Instance().Show();
        }

        private void bbtnBrands_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBrands.Instance().MdiParent = this;
            frmBrands.Instance().Show();
        }

        private void bbtnExpenses_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmExpenses.Instance().MdiParent = this;
            frmExpenses.Instance().Show();
        }

        private void bbtnDepositCash_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDepositCash.Instance().MdiParent = this;
            frmDepositCash.Instance().Show();
        }

        private void bbtnWithdrawCash_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmWithdrawCash.Instance().MdiParent = this;
            frmWithdrawCash.Instance().Show();
        }

        private void bbtnProfitReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "Profit";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }

        private void bbtnExpensesReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "Expenses";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }

        private void bbtnDepositCashReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "DepositCash";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }

        private void bbtnWithdrawCashReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "WithdrawCash";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }

        private void bbtnUserGroups_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUserGroups.Instance().MdiParent = this;
            frmUserGroups.Instance().Show();
        }

        private void bbtnUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsers.Instance().MdiParent = this;
            frmUsers.Instance().Show();
        }

        private void bbtnPermission_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPermission.Instance().MdiParent = this;
            frmPermission.Instance().Show();
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            barStaticDateTime.Caption = $"Today is : {DateTime.Now.ToLongDateString()} and Time is : {DateTime.Now.ToLongTimeString()}";
            var stats = _common.GetStatistics();
            lblTotalSaleCount.Text = "Total Sale Count : " + stats.Rows[0]["TotalSaleCount"];
            lblTotalSaleAmount.Text = "Total Sale Amount : " + stats.Rows[0]["TotalSaleAmount"];
            lblLastSaleAmount.Text = "Last Sale Amount : " + stats.Rows[0]["LastSaleAmount"];
            lblLastInvoice.Text = "Last Invoice No : " + stats.Rows[0]["LastInvoiceNo"];
            grdProducts.DataSource = _common.GetLowStockProducts();
            gvwProducts.ExpandAllGroups();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Text = "Trade Management :: " + _common.GetCompanyInformation().Rows[0]["cmpCompanyName"];
            var userGroup = _common.GetUserGroup(Program.UserName);
            bbtnUsers.Visibility = _common.Decrypt(userGroup, "Saikat") == "ADMINISTRATOR" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnUserGroups.Visibility = _common.Decrypt(userGroup, "Saikat") == "ADMINISTRATOR" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnVAT.Visibility = _common.Decrypt(userGroup, "Saikat") == "ADMINISTRATOR" ? BarItemVisibility.Always : BarItemVisibility.Never;
            rpSecurity.Visible = _common.Decrypt(userGroup, "Saikat") == "ADMINISTRATOR";

            var permission = _common.GetPermissionByUser(Program.UserName);
            bbtnCustomers.Visibility = permission.Substring(permission.IndexOf("CstV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnSuppliers.Visibility = permission.Substring(permission.IndexOf("SupV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnCategories.Visibility = permission.Substring(permission.IndexOf("PctV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnBrands.Visibility = permission.Substring(permission.IndexOf("BndV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnProducts.Visibility = permission.Substring(permission.IndexOf("PdtV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnPurchase.Visibility = permission.Substring(permission.IndexOf("PurV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnPurchaseReturn.Visibility = permission.Substring(permission.IndexOf("PrtV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnSales.Visibility = permission.Substring(permission.IndexOf("SlsV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnSaleReturn.Visibility = permission.Substring(permission.IndexOf("SrtV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnBankAccounts.Visibility = permission.Substring(permission.IndexOf("BacV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnQuotation.Visibility = permission.Substring(permission.IndexOf("QotV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnAccountsPayable.Visibility = permission.Substring(permission.IndexOf("AcpV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnAccountsReceivable.Visibility = permission.Substring(permission.IndexOf("AcrV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnExpenseCategories.Visibility = permission.Substring(permission.IndexOf("EctV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnExpenses.Visibility = permission.Substring(permission.IndexOf("ExpV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnDepositCash.Visibility = permission.Substring(permission.IndexOf("DpcV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnWithdrawCash.Visibility = permission.Substring(permission.IndexOf("WdcV", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnPPurchaseReport.Visibility = permission.Substring(permission.IndexOf("PurRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnPPurchaseReturnReport.Visibility = permission.Substring(permission.IndexOf("PrtRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnSSalesReport.Visibility = permission.Substring(permission.IndexOf("SlsRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnSSaleReturnReport.Visibility = permission.Substring(permission.IndexOf("SrtRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnRAccountsPayable.Visibility = permission.Substring(permission.IndexOf("AcpRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnRAccountsReceivable.Visibility = permission.Substring(permission.IndexOf("AcrRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnExpensesReport.Visibility = permission.Substring(permission.IndexOf("ExpRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnDepositCashReport.Visibility = permission.Substring(permission.IndexOf("DpcRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnWithdrawCashReport.Visibility = permission.Substring(permission.IndexOf("WdcRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnInventory.Visibility = permission.Substring(permission.IndexOf("IvtRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnProfitReport.Visibility = permission.Substring(permission.IndexOf("PftRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            bbtnRTop10Products.Visibility = permission.Substring(permission.IndexOf("TopRepV", 0, StringComparison.Ordinal) + 7, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;


        }

        private void sbtnLogOff_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void sbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skinGalleryBarItem_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {
            var machineCode = new Generate(_serialKeyConfiguration).MachineCode;
            var dtTheme = _common.GetTheme(machineCode.ToString());
            if (dtTheme.Rows.Count > 0)
            {
                _common.BeginTran();
                _common.UpdateTheme(machineCode.ToString(), e.Item.Caption);
                _common.CommitTran();
            }
            else
            {
                _common.BeginTran();
                _common.SaveTheme(machineCode.ToString(), e.Item.Caption);
                _common.CommitTran();
            }
        }

        private void bbtnBackupDatabase_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fbdBackup.ShowDialog() != DialogResult.OK) return;
            var fileName = $"TradeManagementDataBackup {DateTime.Today.ToString("MMM dd, yyyy")}.dbbkp";
            var file = $"{fbdBackup.SelectedPath}\\{fileName}";
            File.Copy(@"Data\Database.data", file);
            XtraMessageBox.Show("Database backup successfull.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("explorer.exe", $"/select,\"{file}\"");
        }

        private void bbtnRestoreDatabase_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ofdRestore.ShowDialog() != DialogResult.OK) return;
            var connection = new VistaDBConnection($"Data Source={ofdRestore.FileName};Open Mode=NonExclusiveReadWrite;Password=p@ssw0rd");
            try
            {
                connection.Open();
                connection.Close();
                connection.Dispose();
                if (XtraMessageBox.Show("This will erase all data that is inserted or updated after the selected backup file creation. Are you sure?",
                    ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                File.Copy(ofdRestore.FileName, @"Data\Database.data", true);
                XtraMessageBox.Show("Database restore successfull.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Invalid backup file.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbtnDefragDatabase_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var ddaObj = VistaDBEngine.Connections.OpenDDA();
                ddaObj.PackDatabase(@"Data\Database.data", "p@ssw0rd", false, delegate { });
                XtraMessageBox.Show("Database defrag successfull.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Cannot defrag database. Please try again.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbtnLicenseStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLicenseStatus.Instance().MdiParent = this; ;
            frmLicenseStatus.Instance().Show();
        }

        private void bbtnRenewLicense_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRenewLicense.Instance().MdiParent = this;
            frmRenewLicense.Instance().Show();
        }

        private void bbtnRPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSpecificReports.Instance().lblOption.Text = "Supplier Name";
            frmSpecificReports.Instance().cmbCustomers.Visible = false;
            frmSpecificReports.Instance().cmbSuppliers.Visible = true;
            frmSpecificReports.Instance().ReportFor = "Purchase";
            frmSpecificReports.Instance().MdiParent = this;
            frmSpecificReports.Instance().Show();
        }

        private void bbtnRPurchaseReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSpecificReports.Instance().lblOption.Text = "Supplier Name";
            frmSpecificReports.Instance().cmbCustomers.Visible = false;
            frmSpecificReports.Instance().cmbSuppliers.Visible = true;
            frmSpecificReports.Instance().ReportFor = "PurchaseReturn";
            frmSpecificReports.Instance().MdiParent = this;
            frmSpecificReports.Instance().Show();
        }

        private void bbtnRSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSpecificReports.Instance().lblOption.Text = "Customer Name";
            frmSpecificReports.Instance().cmbCustomers.Visible = true;
            frmSpecificReports.Instance().cmbSuppliers.Visible = false;
            frmSpecificReports.Instance().ReportFor = "Sale";
            frmSpecificReports.Instance().MdiParent = this;
            frmSpecificReports.Instance().Show();
        }

        private void bbtnRSaleReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSpecificReports.Instance().lblOption.Text = "Customer Name";
            frmSpecificReports.Instance().cmbCustomers.Visible = true;
            frmSpecificReports.Instance().cmbSuppliers.Visible = false;
            frmSpecificReports.Instance().ReportFor = "SaleReturn";
            frmSpecificReports.Instance().MdiParent = this;
            frmSpecificReports.Instance().Show();
        }

        private void bbtnInventory_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var report = new Report())
            {
                report.Load(@"Reports\rptInventory.frx");
                report.RegisterData(_common.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(new clsProducts().GetAllProducts(), "vwProducts");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("vwProducts").Enabled = true;
                report.Show();
            }
        }

        private void bbtnAccountsPayable_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAccountsPayable.Instance().MdiParent = this;
            frmAccountsPayable.Instance().Show();
        }

        private void bbtnAccountsReceivable_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAccountsReceivable.Instance().MdiParent = this;
            frmAccountsReceivable.Instance().Show();
        }

        private void bbtnRAccountsPayable_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAccountsReport.Instance().lblName.Text = "Supplier Name";
            frmAccountsReport.Instance().cmbCustomers.Visible = false;
            frmAccountsReport.Instance().cmbSuppliers.Visible = true;
            frmAccountsReport.Instance().lblType.Text = "Voucher No";
            frmAccountsReport.Instance().cmbInvoiceNo.Visible = false;
            frmAccountsReport.Instance().cmbVoucherNo.Visible = true;
            frmAccountsReport.Instance().ReportFor = "AccountsPayable";
            frmAccountsReport.Instance().MdiParent = this;
            frmAccountsReport.Instance().Show();
        }

        private void bbtnRAccountsReceivable_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAccountsReport.Instance().lblName.Text = "Customer Name";
            frmAccountsReport.Instance().cmbCustomers.Visible = true;
            frmAccountsReport.Instance().cmbSuppliers.Visible = false;
            frmAccountsReport.Instance().lblType.Text = "Invoice No";
            frmAccountsReport.Instance().cmbInvoiceNo.Visible = true;
            frmAccountsReport.Instance().cmbVoucherNo.Visible = false;
            frmAccountsReport.Instance().ReportFor = "AccountsReceivable";
            frmAccountsReport.Instance().MdiParent = this;
            frmAccountsReport.Instance().Show();
        }

        private void bbtnRTop10Products_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var report = new Report())
            {
                report.Load(@"Reports\rptTop10Products.frx");
                report.RegisterData(_common.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(new clsReports().GetTop10Products(), "vwSaleDetails");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("vwSaleDetails").Enabled = true;
                report.Show();
            }
        }

        private void bbtnVATReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "VAT";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }

        private void bbtnCashReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReports.Instance().ReportFor = "Cash";
            frmReports.Instance().MdiParent = this;
            frmReports.Instance().Show();
        }
    }
}