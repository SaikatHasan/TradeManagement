using System;
using DevExpress.XtraEditors;
using FastReport;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmReports : XtraForm
    {
        readonly clsReports _reports = new clsReports();
        public string ReportFor;

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
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
            using (var report = new Report())
            {
                if (chkSingleDate.Checked)
                {
                    switch (ReportFor)
                    {
                        case "Purchase":
                            report.Load(@"Reports\rptPurchases.frx");
                            report.SetParameterValue("Title", "Purchases of " + dtpSingleDate.DateTime.ToString("MMM dd, yyyy"));
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetPurchasesByDate(dtpSingleDate.DateTime), "vwPurchases");
                            report.RegisterData(_reports.GetPurchaseDetails(), "vwPurchaseDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwPurchases").Enabled = true;
                            report.GetDataSource("vwPurchaseDetails").Enabled = true;
                            report.Show();
                            break;
                        case "Sales":
                            report.Load(@"Reports\rptSales.frx");
                            report.SetParameterValue("Title", "Sales of " + dtpSingleDate.DateTime.ToString("MMM dd, yyyy"));
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetSalesByDate(dtpSingleDate.DateTime), "vwSales");
                            report.RegisterData(_reports.GetSaleDetails(), "vwSaleDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwSales").Enabled = true;
                            report.GetDataSource("vwSaleDetails").Enabled = true;
                            report.Show();
                            break;
                        case "Profit":
                            var totalSalePrice = Convert.ToDecimal(_reports.GetTotalSalePriceByDate(dtpSingleDate.DateTime));
                            var totalPurchasePrice = Convert.ToDecimal(_reports.GetTotalPurchasePriceByDate(dtpSingleDate.DateTime));
                            var totalExpense = Convert.ToDecimal(_reports.GetTotalExpenseByDate(dtpSingleDate.DateTime));
                            report.Load(@"Reports\rptProfit.frx");
                            report.SetParameterValue("Title", "Net Profit of " + dtpSingleDate.DateTime.ToString("MMM dd, yyyy"));
                            report.SetParameterValue("TotalSalePrice", totalSalePrice);
                            report.SetParameterValue("TotalPurchasePrice", totalPurchasePrice);
                            report.SetParameterValue("TotalExpense", totalExpense);
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.Show();
                            break;
                        case "Expenses":
                            report.Load(@"Reports\rptExpenseByDate.frx");
                            report.SetParameterValue("ExpenseDate", dtpSingleDate.DateTime);
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetExpenseByDate(dtpSingleDate.DateTime), "Expenses");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("Expenses").Enabled = true;
                            report.Show();
                            break;
                        case "DepositCash":
                            report.Load(@"Reports\rptDepositCashByDate.frx");
                            report.SetParameterValue("DepositCashDate", dtpSingleDate.DateTime);
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetDepositCashByDate(dtpSingleDate.DateTime), "DepositCash");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("DepositCash").Enabled = true;
                            report.Show();
                            break;
                        case "WithdrawCash":
                            report.Load(@"Reports\rptWithdrawCashByDate.frx");
                            report.SetParameterValue("WithdrawCashDate", dtpSingleDate.DateTime);
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetWithdrawCashByDate(dtpSingleDate.DateTime), "WithdrawCash");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("WithdrawCash").Enabled = true;
                            report.Show();
                            break;
                        case "PurchaseReturn":
                            report.Load(@"Reports\rptPurchaseReturns.frx");
                            report.SetParameterValue("Title", "Purchase Returns of " + dtpSingleDate.DateTime.ToString("MMM dd, yyyy"));
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetPurchaseReturnsByDate(dtpSingleDate.DateTime), "vwPurchaseReturns");
                            report.RegisterData(_reports.GetPurchaseReturnDetails(), "vwPurchaseReturnDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwPurchaseReturns").Enabled = true;
                            report.GetDataSource("vwPurchaseReturnDetails").Enabled = true;
                            report.Show();
                            break;
                        case "SaleReturn":
                            report.Load(@"Reports\rptSaleReturns.frx");
                            report.SetParameterValue("Title", "Sales Returns of " + dtpSingleDate.DateTime.ToString("MMM dd, yyyy"));
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetSaleReturnsByDate(dtpSingleDate.DateTime), "vwSaleReturns");
                            report.RegisterData(_reports.GetSaleReturnDetails(), "vwSaleReturnDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwSaleReturns").Enabled = true;
                            report.GetDataSource("vwSaleReturnDetails").Enabled = true;
                            report.Show();
                            break;
                    }
                }
                else
                {
                    switch (ReportFor)
                    {
                        case "Purchase":
                            report.Load(@"Reports\rptPurchases.frx");
                            report.SetParameterValue("Title", "Purchases from " + dtpStartDate.DateTime.ToString("MMM dd, yyyy") + " to " + dtpEndDate.DateTime.ToString("MMM dd, yyyy"));
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetPurchasesByRange(dtpStartDate.DateTime, dtpEndDate.DateTime), "vwPurchases");
                            report.RegisterData(_reports.GetPurchaseDetails(), "vwPurchaseDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwPurchases").Enabled = true;
                            report.GetDataSource("vwPurchaseDetails").Enabled = true;
                            report.Show();
                            break;
                        case "Sales":
                            report.Load(@"Reports\rptSales.frx");
                            report.SetParameterValue("Title", "Sales from " + dtpStartDate.DateTime.ToString("MMM dd, yyyy") + " to " + dtpEndDate.DateTime.ToString("MMM dd, yyyy"));
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetSalesByRange(dtpStartDate.DateTime, dtpEndDate.DateTime), "vwSales");
                            report.RegisterData(_reports.GetSaleDetails(), "vwSaleDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwSales").Enabled = true;
                            report.GetDataSource("vwSaleDetails").Enabled = true;
                            report.Show();
                            break;
                        case "Profit":
                            var totalSalePrice = Convert.ToDecimal(_reports.GetTotalSalePriceByRange(dtpStartDate.DateTime, dtpEndDate.DateTime));
                            var totalPurchasePrice = Convert.ToDecimal(_reports.GetTotalPurchasePriceByRange(dtpStartDate.DateTime, dtpEndDate.DateTime));
                            var totalExpense = Convert.ToDecimal(_reports.GetTotalExpenseByRange(dtpStartDate.DateTime, dtpEndDate.DateTime));
                            report.Load(@"Reports\rptProfit.frx");
                            report.SetParameterValue("Title", "Net Profit from " + dtpStartDate.DateTime.ToString("MMM dd, yyyy") + " to " + dtpEndDate.DateTime.ToString("MMM dd, yyyy"));
                            report.SetParameterValue("TotalSalePrice", totalSalePrice);
                            report.SetParameterValue("TotalPurchasePrice", totalPurchasePrice);
                            report.SetParameterValue("TotalExpense", totalExpense);
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.Show();
                            break;
                        case "Expenses":
                            report.Load(@"Reports\rptExpenseByRange.frx");
                            report.SetParameterValue("StartDate", dtpStartDate.DateTime);
                            report.SetParameterValue("EndDate", dtpEndDate.DateTime);
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetExpenseByRange(dtpStartDate.DateTime, dtpEndDate.DateTime), "Expenses");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("Expenses").Enabled = true;
                            report.Show();
                            break;
                        case "DepositCash":
                            report.Load(@"Reports\rptDepositCashByRange.frx");
                            report.SetParameterValue("StartDate", dtpStartDate.DateTime);
                            report.SetParameterValue("EndDate", dtpEndDate.DateTime);
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetDepositCashByRange(dtpStartDate.DateTime, dtpEndDate.DateTime), "DepositCash");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("DepositCash").Enabled = true;
                            report.Show();
                            break;
                        case "WithdrawCash":
                            report.Load(@"Reports\rptWithdrawCashByRange.frx");
                            report.SetParameterValue("StartDate", dtpStartDate.DateTime);
                            report.SetParameterValue("EndDate", dtpEndDate.DateTime);
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetWithdrawCashByRange(dtpStartDate.DateTime, dtpEndDate.DateTime), "WithdrawCash");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("WithdrawCash").Enabled = true;
                            report.Show();
                            break;
                        case "PurchaseReturn":
                            report.Load(@"Reports\rptPurchaseReturns.frx");
                            report.SetParameterValue("Title", "Purchase Returns from " + dtpStartDate.DateTime.ToString("MMM dd, yyyy") + " to " + dtpEndDate.DateTime.ToString("MMM dd, yyyy"));
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetPurchaseReturnsByRange(dtpStartDate.DateTime, dtpEndDate.DateTime), "vwPurchaseReturns");
                            report.RegisterData(_reports.GetPurchaseReturnDetails(), "vwPurchaseReturnDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwPurchaseReturns").Enabled = true;
                            report.GetDataSource("vwPurchaseReturnDetails").Enabled = true;
                            report.Show();
                            break;
                        case "SaleReturn":
                            report.Load(@"Reports\rptSaleReturns.frx");
                            report.SetParameterValue("Title", "Sales Returns from " + dtpStartDate.DateTime.ToString("MMM dd, yyyy") + " to " + dtpEndDate.DateTime.ToString("MMM dd, yyyy"));
                            report.RegisterData(_reports.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_reports.GetSaleReturnsByRange(dtpStartDate.DateTime, dtpEndDate.DateTime), "vwSaleReturns");
                            report.RegisterData(_reports.GetSaleReturnDetails(), "vwSaleReturnDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwSaleReturns").Enabled = true;
                            report.GetDataSource("vwSaleReturnDetails").Enabled = true;
                            report.Show();
                            break;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}