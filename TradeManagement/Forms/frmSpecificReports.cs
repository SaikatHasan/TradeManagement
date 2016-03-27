using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FastReport;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmSpecificReports : XtraForm
    {
        readonly clsReports _reports = new clsReports();
        public string ReportFor;

        public frmSpecificReports()
        {
            InitializeComponent();
        }

        private void frmSpecificReports_Load(object sender, EventArgs e)
        {
            cmbCustomers.Properties.DataSource = _reports.GetAllCustomers();
            cmbSuppliers.Properties.DataSource = _reports.GetAllSuppliers();
            dtpSingleDate.DateTime = DateTime.Today;
            dtpStartDate.DateTime = DateTime.Today.AddMonths(-1);
            dtpEndDate.DateTime = DateTime.Today;
        }

        private void chkSingleDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSingleDate.Checked)
            {
                grpSingleDate.Enabled = true;
                dtpSingleDate.Focus();
                chkDateRange.Checked = false;
                grpDateRange.Enabled = false;
            }
            else
                grpSingleDate.Enabled = false;
        }

        private void chkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateRange.Checked)
            {
                grpDateRange.Enabled = true;
                dtpStartDate.Focus();
                chkSingleDate.Checked = false;
                grpSingleDate.Enabled = false;
            }
            else
                grpDateRange.Enabled = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.Visible && cmbCustomers.EditValue == null)
            {
                XtraMessageBox.Show("Please select the customer.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbSuppliers.Visible && cmbSuppliers.EditValue == null)
            {
                XtraMessageBox.Show("Please select the supplier.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var report = new Report())
            {
                switch (ReportFor)
                {
                    case "Purchase":
                        report.Load(@"Reports\rptPurchases.frx");
                        report.SetParameterValue("Title", "Purchases of " + cmbSuppliers.Text);
                        report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                        report.RegisterData(chkSingleDate.Checked
                                ? _reports.GetPurchasesBySupplierAndDate(cmbSuppliers.EditValue.ToString(), dtpSingleDate.DateTime)
                                : _reports.GetPurchasesBySupplierAndRange(cmbSuppliers.EditValue.ToString(), dtpStartDate.DateTime, dtpEndDate.DateTime), "vwPurchases");
                        report.RegisterData(_reports.GetPurchaseDetails(), "vwPurchaseDetails");
                        report.GetDataSource("CompanyInformation").Enabled = true;
                        report.GetDataSource("vwPurchases").Enabled = true;
                        report.GetDataSource("vwPurchaseDetails").Enabled = true;
                        report.Show();
                        break;
                    case "PurchaseReturn":
                        report.Load(@"Reports\rptPurchaseReturns.frx");
                        report.SetParameterValue("Title", "Purchase Returns of " + cmbSuppliers.Text);
                        report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                        report.RegisterData(chkSingleDate.Checked
                                ? _reports.GetPurchaseReturnsBySupplierAndDate(cmbSuppliers.EditValue.ToString(), dtpSingleDate.DateTime)
                                : _reports.GetPurchaseReturnsBySupplierAndRange(cmbSuppliers.EditValue.ToString(), dtpStartDate.DateTime, dtpEndDate.DateTime), "vwPurchaseReturns");
                        report.RegisterData(_reports.GetPurchaseReturnDetails(), "vwPurchaseReturnDetails");
                        report.GetDataSource("CompanyInformation").Enabled = true;
                        report.GetDataSource("vwPurchaseReturns").Enabled = true;
                        report.GetDataSource("vwPurchaseReturnDetails").Enabled = true;
                        report.Show();
                        break;
                    case "Sale":
                        report.Load(@"Reports\rptSales.frx");
                        report.SetParameterValue("Title", "Sales of " + cmbCustomers.Text);
                        report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                        report.RegisterData(chkSingleDate.Checked
                                ? _reports.GetSalesByCustomerAndDate(cmbCustomers.EditValue.ToString(), dtpSingleDate.DateTime)
                                : _reports.GetSalesByCustomerAndRange(cmbCustomers.EditValue.ToString(), dtpStartDate.DateTime, dtpEndDate.DateTime), "vwSales");
                        report.RegisterData(_reports.GetSaleDetails(), "vwSaleDetails");
                        report.GetDataSource("CompanyInformation").Enabled = true;
                        report.GetDataSource("vwSales").Enabled = true;
                        report.GetDataSource("vwSaleDetails").Enabled = true;
                        report.Show();
                        break;
                    case "SaleReturn":
                        report.Load(@"Reports\rptSaleReturns.frx");
                        report.SetParameterValue("Title", "Sales Returns of " + cmbCustomers.Text);
                        report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                        report.RegisterData(chkSingleDate.Checked
                                ? _reports.GetSaleReturnsByCustomerAndDate(cmbCustomers.EditValue.ToString(), dtpSingleDate.DateTime)
                                : _reports.GetSaleReturnsByCustomerAndRange(cmbCustomers.EditValue.ToString(), dtpStartDate.DateTime, dtpEndDate.DateTime), "vwSaleReturns");
                        report.RegisterData(_reports.GetSaleReturnDetails(), "vwSaleReturnDetails");
                        report.GetDataSource("CompanyInformation").Enabled = true;
                        report.GetDataSource("vwSaleReturns").Enabled = true;
                        report.GetDataSource("vwSaleReturnDetails").Enabled = true;
                        report.Show();
                        break;
                    case "AccountsPayable":
                        report.Load(@"Reports\rptAccountsPayable.frx");
                        report.SetParameterValue("Title", "Account Payable of " + cmbCustomers.Text);
                        report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                        report.RegisterData(chkSingleDate.Checked
                                ? _reports.GetSaleReturnsByCustomerAndDate(cmbCustomers.EditValue.ToString(), dtpSingleDate.DateTime)
                                : _reports.GetSaleReturnsByCustomerAndRange(cmbCustomers.EditValue.ToString(), dtpStartDate.DateTime, dtpEndDate.DateTime), "vwSaleReturns");
                        report.RegisterData(_reports.GetSaleReturnDetails(), "vwSaleReturnDetails");
                        report.GetDataSource("CompanyInformation").Enabled = true;
                        report.GetDataSource("vwSaleReturns").Enabled = true;
                        report.GetDataSource("vwSaleReturnDetails").Enabled = true;
                        report.Show();
                        break;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}