using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FastReport;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmAccountsReport : XtraForm
    {
        readonly clsReports _reports = new clsReports();
        public string ReportFor;

        public frmAccountsReport()
        {
            InitializeComponent();
        }

        private void frmAccountsReport_Load(object sender, EventArgs e)
        {
            cmbCustomers.Properties.DataSource = _reports.GetAllActiveCustomers();
            cmbSuppliers.Properties.DataSource = _reports.GetAllActiveSuppliers();
        }

        private void cmbCustomers_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.EditValue == null) return;
            cmbInvoiceNo.Properties.DataSource = _reports.GetAllInvoiceNo(cmbCustomers.EditValue.ToString());
        }

        private void cmbSuppliers_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbSuppliers.EditValue == null) return;
            cmbVoucherNo.Properties.DataSource = _reports.GetAllVoucherNo(cmbSuppliers.EditValue.ToString());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (chkAllDues.Checked)
            {
                using (var report = new Report())
                {
                    if (cmbCustomers.Visible)
                    {
                        //var dtAllCustomerDues = _reports.GetAllCustomerDues();
                        //dtAllCustomerDues.TableName = "AllCustomerDues";
                        //dtAllCustomerDues.WriteXmlSchema(@"Reports\AllCustomerDues.xml");
                        report.Load(@"Reports\rptAllCustomerDues.frx");
                        report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                        report.RegisterData(_reports.GetAllCustomerDues(), "AllCustomerDues");
                        report.GetDataSource("CompanyInformation").Enabled = true;
                        report.GetDataSource("AllCustomerDues").Enabled = true;
                        report.Show();
                    }
                    else
                    {
                        //var dtAllSupplierDues = _reports.GetAllSupplierDues();
                        //dtAllSupplierDues.TableName = "AllSupplierDues";
                        //dtAllSupplierDues.WriteXmlSchema(@"Reports\AllSupplierDues.xml");
                        report.Load(@"Reports\rptAllSupplierDues.frx");
                        report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                        report.RegisterData(_reports.GetAllSupplierDues(), "AllSupplierDues");
                        report.GetDataSource("CompanyInformation").Enabled = true;
                        report.GetDataSource("AllSupplierDues").Enabled = true;
                        report.Show();
                    }
                }
                return;
            }
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
                    case "AccountsPayable":
                        report.Load(@"Reports\rptAccountsPayable.frx");
                        report.SetParameterValue("Title", "Accounts Payable of " + cmbSuppliers.Text);
                        report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                        report.RegisterData(cmbVoucherNo.EditValue == null
                            ? _reports.GetAccountsPayableBySupplier(cmbSuppliers.EditValue.ToString())
                            : _reports.GetAccountsPayableBySupplierAndVoucher(cmbSuppliers.EditValue.ToString(),
                                cmbVoucherNo.EditValue.ToString()), "vwAccountsPayable");
                        report.GetDataSource("CompanyInformation").Enabled = true;
                        report.GetDataSource("vwAccountsPayable").Enabled = true;
                        report.Show();
                        break;
                    case "AccountsReceivable":
                        report.Load(@"Reports\rptAccountsReceivable.frx");
                        report.SetParameterValue("Title", "Accounts Receivable of " + cmbCustomers.Text);
                        report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                        report.RegisterData(cmbInvoiceNo.EditValue == null
                            ? _reports.GetAccountsReceivableByCustomer(cmbCustomers.EditValue.ToString())
                            : _reports.GetAccountsReceivableByCustomerAndInvoice(cmbCustomers.EditValue.ToString(),
                                cmbInvoiceNo.EditValue.ToString()), "vwAccountsReceivable");
                        report.GetDataSource("CompanyInformation").Enabled = true;
                        report.GetDataSource("vwAccountsReceivable").Enabled = true;
                        report.Show();
                        break;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void chkAllDues_CheckedChanged(object sender, EventArgs e)
        {
            grpOptions.Enabled = !chkAllDues.Checked;
        }
    }
}