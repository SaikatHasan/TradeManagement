using System;
using System.Data;
using System.Linq;

namespace TradeManagement_DAL
{
    public class clsReports : clsCommon
    {
        public DataTable GetPurchasesByDate(DateTime purPurchaseDate)
        {
            return Query($"SELECT * FROM vwPurchases WHERE purPurchaseDate = '{purPurchaseDate}'");
        }

        public DataTable GetPurchasesBySupplierAndDate(string purSupplierId, DateTime purPurchaseDate)
        {
            return Query(
                $"SELECT * FROM vwPurchases WHERE purSupplierId = '{purSupplierId}' AND purPurchaseDate = '{purPurchaseDate}'");
        }

        public DataTable GetPurchasesByRange(DateTime startDate, DateTime endDate)
        {
            return Query($"SELECT * FROM vwPurchases WHERE purPurchaseDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetPurchasesBySupplierAndRange(string purSupplierId, DateTime startDate, DateTime endDate)
        {
            return Query(
                $"SELECT * FROM vwPurchases WHERE purSupplierId = '{purSupplierId}' AND purPurchaseDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetPurchaseDetails()
        {
            return Query("SELECT * FROM vwPurchaseDetails");
        }

        public DataTable GetSalesByDate(DateTime slsSalesDate)
        {
            return Query($"SELECT * FROM vwSales WHERE slsSalesDate = '{slsSalesDate}'");
        }

        public DataTable GetSalesByCustomerAndDate(string slsCustomerId, DateTime slsSalesDate)
        {
            return Query(
                $"SELECT * FROM vwSales WHERE slsCustomerId = '{slsCustomerId}' AND slsSalesDate = '{slsSalesDate}'");
        }

        public DataTable GetSalesByRange(DateTime startDate, DateTime endDate)
        {
            return Query($"SELECT * FROM vwSales WHERE slsSalesDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetSalesByCustomerAndRange(string slsCustomerId, DateTime startDate, DateTime endDate)
        {
            return Query(
                $"SELECT * FROM vwSales WHERE slsCustomerId = '{slsCustomerId}' AND slsSalesDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetSaleDetails()
        {
            return Query("SELECT * FROM vwSaleDetails");
        }

        public string GetTotalSalePriceByDate(DateTime slsSalesDate)
        {
            return Query($"SELECT ISNULL(SUM(slsTotalAmount) - SUM(slsDiscount) + SUM(slsVAT), 0) FROM Sales WHERE slsSalesDate = '{slsSalesDate}'").Rows[0][0].ToString();
        }

        public DataTable GetTotalVATByDate(DateTime slsSalesDate)
        {
            return Query($"SELECT slsInvoiceNo, slsSalesDate, cstCustomerName, SUM(sldVAT) sldVAT FROM vwVAT WHERE slsSalesDate = '{slsSalesDate}' GROUP BY slsInvoiceNo, slsSalesDate, cstCustomerName ORDER BY slsSalesDate");
        }

        public DataTable GetTotalVATByRange(DateTime startDate, DateTime endDate)
        {
            return Query($"SELECT slsInvoiceNo, slsSalesDate, cstCustomerName, SUM(sldVAT) sldVAT FROM vwVAT WHERE slsSalesDate BETWEEN '{startDate}' AND '{endDate}' GROUP BY slsInvoiceNo, slsSalesDate, cstCustomerName ORDER BY slsSalesDate");
        }

        public string GetTotalPurchasePriceByDate(DateTime slsSalesDate)
        {
            return Query("SELECT ISNULL(SUM(prdPurchasePrice * sldQuantity), 0) FROM PurchaseDetails JOIN vwSaleDetails ON prdProductId = sldProductId JOIN Sales ON sldInvoiceNo = slsInvoiceNo WHERE slsSalesDate = '" + slsSalesDate + "'").Rows[0][0].ToString();
        }

        public string GetTotalExpenseByDate(DateTime expExpenseDate)
        {
            return Query("SELECT ISNULL(SUM(expAmount), 0) FROM Expenses WHERE expExpenseDate = '" + expExpenseDate + "'").Rows[0][0].ToString();
        }

        public string GetTotalSalePriceByRange(DateTime startDate, DateTime endDate)
        {
            return Query("SELECT ISNULL(SUM(slsTotalAmount) - SUM(slsDiscount) + SUM(slsVAT), 0) FROM Sales WHERE slsSalesDate BETWEEN '" + startDate + "' AND '" + endDate + "'").Rows[0][0].ToString();
        }

        public string GetTotalPurchasePriceByRange(DateTime startDate, DateTime endDate)
        {
            return Query("SELECT ISNULL(SUM(prdPurchasePrice * sldQuantity), 0) FROM PurchaseDetails JOIN vwSaleDetails ON prdProductId = sldProductId JOIN Sales ON sldInvoiceNo = slsInvoiceNo WHERE slsSalesDate BETWEEN '" + startDate + "' AND '" + endDate + "'").Rows[0][0].ToString();
        }

        public string GetTotalExpenseByRange(DateTime startDate, DateTime endDate)
        {
            return Query("SELECT ISNULL(SUM(expAmount), 0) FROM Expenses WHERE expExpenseDate BETWEEN '" + startDate + "' AND '" + endDate + "'").Rows[0][0].ToString();
        }

        public DataTable GetExpenseByDate(DateTime expExpenseDate)
        {
            return Query(
                $"SELECT expExpenseDate, ectExpenseCategoryName, expDescription, expAmount FROM Expenses JOIN ExpenseCategories ON expExpenseCategoryId = ectExpenseCategoryId WHERE expExpenseDate = '{expExpenseDate}'");
        }

        public DataTable GetExpenseByRange(DateTime startDate, DateTime endDate)
        {
            return Query(
                $"SELECT expExpenseDate, ectExpenseCategoryName, expDescription, expAmount FROM Expenses JOIN ExpenseCategories ON expExpenseCategoryId = ectExpenseCategoryId WHERE expExpenseDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetDepositCashByDate(DateTime dpcDate)
        {
            return Query($"SELECT * FROM DepositCash WHERE dpcDate = '{dpcDate}'");
        }

        public DataTable GetWithdrawCashByDate(DateTime wdcDate)
        {
            return Query($"SELECT * FROM WithdrawCash WHERE wdcDate = '{wdcDate}'");
        }

        public DataTable GetDepositCashByRange(DateTime startDate, DateTime endDate)
        {
            return Query(
                $"SELECT * FROM DepositCash WHERE dpcDate BETWEEN '{startDate}' AND '{endDate}' ORDER BY dpcDate");
        }

        public DataTable GetWithdrawCashByRange(DateTime startDate, DateTime endDate)
        {
            return Query(
                $"SELECT * FROM WithdrawCash WHERE wdcDate BETWEEN '{startDate}' AND '{endDate}' ORDER BY wdcDate");
        }

        public DataTable GetPurchaseReturnsByDate(DateTime prtReturnDate)
        {
            return Query($"SELECT * FROM vwPurchaseReturns WHERE prtReturnDate = '{prtReturnDate}'");
        }

        public DataTable GetPurchaseReturnsBySupplierAndDate(string purSupplierId, DateTime prtReturnDate)
        {
            return Query(
                $"SELECT * FROM vwPurchaseReturns WHERE purSupplierId = '{purSupplierId}' AND prtReturnDate = '{prtReturnDate}'");
        }

        public DataTable GetPurchaseReturnsByRange(DateTime startDate, DateTime endDate)
        {
            return Query($"SELECT * FROM vwPurchaseReturns WHERE prtReturnDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetPurchaseReturnsBySupplierAndRange(string purSupplierId, DateTime startDate, DateTime endDate)
        {
            return Query(
                $"SELECT * FROM vwPurchaseReturns WHERE purSupplierId = '{purSupplierId}' AND prtReturnDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetPurchaseReturnDetails()
        {
            return Query("SELECT * FROM vwPurchaseReturnDetails");
        }

        public DataTable GetSaleReturnsByDate(DateTime srtReturnDate)
        {
            return Query($"SELECT * FROM vwSaleReturns WHERE srtReturnDate = '{srtReturnDate}'");
        }

        public DataTable GetSaleReturnsByCustomerAndDate(string slsCustomerId, DateTime srtReturnDate)
        {
            return Query(
                $"SELECT * FROM vwSaleReturns WHERE slsCustomerId = '{slsCustomerId}' AND srtReturnDate = '{srtReturnDate}'");
        }

        public DataTable GetSaleReturnsByRange(DateTime startDate, DateTime endDate)
        {
            return Query($"SELECT * FROM vwSaleReturns WHERE srtReturnDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetSaleReturnsByCustomerAndRange(string slsCustomerId, DateTime startDate, DateTime endDate)
        {
            return Query(
                $"SELECT * FROM vwSaleReturns WHERE slsCustomerId = '{slsCustomerId}' AND srtReturnDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetSaleReturnDetails()
        {
            return Query("SELECT * FROM vwSaleReturnDetails");
        }

        public DataTable GetAccountsPayableBySupplier(string acpSupplierId)
        {
            return Query("SELECT * FROM vwAccountsPayable WHERE acpSupplierId = '" + acpSupplierId + "' ORDER BY acpPayableId");
        }

        public DataTable GetAccountsPayableBySupplierAndVoucher(string acpSupplierId, string acpPurchaseId)
        {
            return Query("SELECT * FROM vwAccountsPayable WHERE acpSupplierId = '" + acpSupplierId + "' AND acpPurchaseId = '" + acpPurchaseId + "' ORDER BY acpPayableId");
        }
        public DataTable GetAccountsReceivableByCustomer(string acrCustomerId)
        {
            return Query("SELECT * FROM vwAccountsReceivable WHERE acrCustomerId = '" + acrCustomerId + "' ORDER BY acrReceivableId");
        }

        public DataTable GetAccountsReceivableByCustomerAndInvoice(string acrCustomerId, string acrInvoiceNo)
        {
            return Query("SELECT * FROM vwAccountsReceivable WHERE acrCustomerId = '" + acrCustomerId + "' AND acrInvoiceNo = '" + acrInvoiceNo + "' ORDER BY acrReceivableId");
        }

        public DataTable GetAllSupplierDues()
        {
            var dtPayableIds = Query("SELECT MAX(acpPayableId) FROM AccountsPayable WHERE acpIsDelete <> 1 AND acpDue <> 0 GROUP BY acpPurchaseId");
            if (dtPayableIds.Rows.Count == 0) return new DataTable();
            var payableIds = dtPayableIds.Rows.Cast<DataRow>().Aggregate(string.Empty, (current, rowPayableId) => current + ("'" + rowPayableId[0] + "',"));
            payableIds = payableIds.Remove(payableIds.Length - 1);
            return Query("SELECT acpSupplierId, supSupplierName, acpDue FROM AccountsPayable JOIN Suppliers ON acpSupplierId = supSupplierId WHERE acpPayableId IN (" + payableIds + ")");
        }

        public DataTable GetAllCustomerDues()
        {
            var dtReceivableIds = Query("SELECT MAX(acrReceivableId) FROM AccountsReceivable WHERE acrIsDelete <> 1 AND acrDue <> 0 GROUP BY acrInvoiceNo ");
            if (dtReceivableIds.Rows.Count == 0) return new DataTable();
            var receivableIds = dtReceivableIds.Rows.Cast<DataRow>().Aggregate(string.Empty, (current, rowReceivableId) => current + ("'" + rowReceivableId[0] + "',"));
            receivableIds = receivableIds.Remove(receivableIds.Length - 1);
            return Query("SELECT acrCustomerId, cstCustomerName, acrDue FROM AccountsReceivable JOIN Customers ON acrCustomerId = cstCustomerId WHERE acrReceivableId IN (" + receivableIds + ")");
        }

        public DataTable GetTop10Products()
        {
            return Query("SELECT * FROM vwSaleDetails");
        }
    }
}
