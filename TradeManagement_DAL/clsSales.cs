using System;
using System.Data;
using System.Linq;

namespace TradeManagement_DAL
{
    public class clsSales : clsCommon
    {
        public DataTable GetProductInfo(string prdBarcode)
        {
            return Query($"SELECT pdtProductId, pdtProductName, bndBrandName, pdtModel, pdtPackageUnit, pdtReorderLevel, pdtUnitPrice, pdtVAT, pdtStockQuantity FROM vwProducts WHERE pdtBarcode = '{prdBarcode}'");
        }

        public DataTable GetAllProducts()
        {
            return Query("SELECT * FROM vwProducts WHERE pdtIsActive = 1 AND pdtIsDelete = 0");
        }

        public string GetNextInvoiceNo()
        {
            return $"INV-{DateTime.Now:yy}-{Query("SELECT ISNULL(MAX(RIGHT(slsInvoiceNo, 5)), 0) + 1 FROM Sales WHERE SUBSTRING(slsInvoiceNo, 5, 2) = RIGHT(DATEPART(YY, GETDATE()), 2)").Rows[0][0].ToString().PadLeft(5, '0')}";
        }

        public DataTable GetUnpaidInvoiceNo(string slsCustomerId)
        {
            return Query($"SELECT slsInvoiceNo FROM Sales WHERE slsCustomerId = '{slsCustomerId}' AND slsIsDelete = 0 AND slsIsFullPaid = 0");
        }

        public bool InsertSales(string slsInvoiceNo, DateTime slsSalesDate, string slsCustomerId, string slsTotalAmount, string slsDiscount, string slsPaymentType, string slsChequeNo, string slsAccountId, string slsOthers, string slsAmountPaid, string slsIsFullPaid, string slsInsertBy)
        {
            return Command($@"INSERT INTO Sales (slsInvoiceNo, slsSalesDate, slsCustomerId, slsTotalAmount, slsDiscount, slsPaymentType, slsChequeNo, slsAccountId, slsOthers, slsAmountPaid, slsIsFullPaid, slsInsertBy, slsInsertDate)
                            Values ('{slsInvoiceNo}', '{slsSalesDate}', '{slsCustomerId}', {slsTotalAmount}, {slsDiscount}, {slsPaymentType}, '{slsChequeNo}', '{slsAccountId}', '{slsOthers}', {slsAmountPaid}, {slsIsFullPaid}, '{slsInsertBy}', '{DateTime.Now}')");
        }

        public bool InsertSaleDetails(string sldInvoiceNo, string sldProductId, string sldSalesPrice, string sldVAT, string sldQuantity, string sldDiscount)
        {
            return Command($"INSERT INTO SaleDetails (sldInvoiceNo, sldProductId, sldSalesPrice, sldVAT, sldQuantity, sldDiscount) Values ('{sldInvoiceNo}', '{sldProductId}', {sldSalesPrice}, {sldVAT}, {sldQuantity}, {sldDiscount})");
        }

        public bool UpdateSales(string slsInvoiceNo, DateTime slsSalesDate, string slsCustomerId, string slsTotalAmount, string slsDiscount, string slsPaymentType, string slsChequeNo, string slsAccountId, string slsOthers, string slsAmountPaid, string slsIsFullPaid, string slsUpdateBy)
        {
            return Command($@"UPDATE Sales SET slsSalesDate = '{slsSalesDate}', slsCustomerId = '{slsCustomerId}', slsTotalAmount = {slsTotalAmount}, slsDiscount = {slsDiscount}, slsPaymentType = {slsPaymentType}, slsChequeNo = '{slsChequeNo}', 
                            slsAccountId = '{slsAccountId}', slsOthers = '{slsOthers}', slsAmountPaid = {slsAmountPaid}, slsIsFullPaid = {slsIsFullPaid}, slsUpdateBy = '{slsUpdateBy}', slsUpdateDate = '{DateTime.Now}' WHERE slsInvoiceNo = '{slsInvoiceNo}'");
        }

        public bool DeleteSales(string slsInvoiceNo, string slsDaleteBy)
        {
            return Command($"UPDATE Sales SET slsIsDelete = 1, slsDaleteBy = '{slsDaleteBy}', slsDeleteDate = '{DateTime.Now}' WHERE slsInvoiceNo = '{slsInvoiceNo}'");
        }

        public bool DeleteSaleDetails(string sldInvoiceNo)
        {
            return Command($"DELETE FROM SaleDetails WHERE sldInvoiceNo = '{sldInvoiceNo}'");
        }

        public DataTable SearchSalesByCustomer(string slsCustomerId)
        {
            return Query($"SELECT * FROM vwSales WHERE slsCustomerId = '{slsCustomerId}'");
        }

        public DataTable SearchSalesByDate(DateTime startDate, DateTime endDate)
        {
            return Query($"SELECT * FROM vwSales WHERE slsSalesDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public int GetProductStock(string pdtProductId)
        {
            return Convert.ToInt32(Query($"SELECT pdtStockQuantity FROM Products WHERE pdtProductId = '{pdtProductId}'").Rows[0][0]);
        }

        public string GetSalesPersonName(string slsInvoiceNo)
        {
            return Decrypt(Query($"SELECT ISNULL(slsUpdateBy, slsInsertBy) FROM Sales WHERE slsInvoiceNo = '{slsInvoiceNo}'").Rows[0][0].ToString(), "Saikat");
        }

        public DataTable GetSales(string slsInvoiceNo)
        {
            return Query($"SELECT * FROM vwSales WHERE slsInvoiceNo = '{slsInvoiceNo}'");
        }

        public DataTable GetSaleDetails(string sldInvoiceNo)
        {
            return Query($"SELECT * FROM vwSaleDetails WHERE sldInvoiceNo = '{sldInvoiceNo}'");
        }

        public bool HasReference(string acrInvoiceNo)
        {
            return Query($"SELECT * FROM AccountsReceivable WHERE acrInvoiceNo = '{acrInvoiceNo}' AND acrIsDelete = 0").Rows.Count > 1;
        }

        //Account Receivable
        public string GetTotalDue()
        {
            var dtReceivableIds = Query("SELECT MAX(acrReceivableId) FROM AccountsReceivable WHERE acrIsDelete <> 1 AND acrInvoiceNo NOT IN (SELECT acrInvoiceNo FROM AccountsReceivable WHERE acrDue = 0) GROUP BY acrInvoiceNo");
            if (dtReceivableIds.Rows.Count == 0) return "0";
            var receivableIds = dtReceivableIds.Rows.Cast<DataRow>().Aggregate(string.Empty, (current, rowReceivableId) => current + "'" + rowReceivableId[0] + "',");
            receivableIds = receivableIds.Remove(receivableIds.Length - 1);
            return Query("SELECT SUM(acrDue) FROM AccountsReceivable WHERE acrReceivableId IN (" + receivableIds + ")").Rows[0][0].ToString();
        }

        public string GetNextReceivableId()
        {
            return $"ACR-{DateTime.Now:yy}-{Query("SELECT ISNULL(MAX(RIGHT(acrReceivableId, 5)), 0) + 1 FROM AccountsReceivable WHERE SUBSTRING(acrReceivableId, 5, 2) = RIGHT(DATEPART(YY, GETDATE()), 2)").Rows[0][0].ToString().PadLeft(5, '0')}";
        }

        public string GetReceivableId(string acrCustomerId, string acrInvoiceNo)
        {
            return Query($"SELECT acrReceivableId FROM AccountsReceivable WHERE acrCustomerId = '{acrCustomerId}' AND acrInvoiceNo = '{acrInvoiceNo}' AND acrIsDelete = 0").Rows[0][0].ToString();
        }

        public DataTable GetAccountsReceivable(string acrInvoiceNo)
        {
            return Query(string.Format("SELECT * FROM vwAccountsReceivable WHERE acrInvoiceNo = '{0}' AND acrReceivableId = (SELECT MAX(acrReceivableId) FROM vwAccountsReceivable  WHERE acrInvoiceNo = '{0}')", acrInvoiceNo));
        }

        public bool InsertAccountsReceivable(string acrReceivableId, DateTime acrReceivableDate, string acrCustomerId, string acrInvoiceNo, string acrTotalAmount, string acrDiscount, string acrDue, string acrAmountPaying, string acrFromSale, string acrRemarks, string acrInsertBy)
        {
            return Command("INSERT INTO AccountsReceivable (acrReceivableId, acrReceivableDate, acrCustomerId, acrInvoiceNo, acrTotalAmount, acrDiscount, acrDue, acrAmountPaying, acrFromSale, acrRemarks, acrInsertBy, acrInsertDate) VALUES ('" +
                acrReceivableId + "', '" + acrReceivableDate + "', '" + acrCustomerId + "', '" + acrInvoiceNo + "', " + acrTotalAmount + ", " + acrDiscount + ", " + acrDue + ", " + acrAmountPaying + ", " + acrFromSale + ", '" + acrRemarks + "', '" + acrInsertBy + "', '" + DateTime.Now + "')");
        }

        public bool UpdateAccountsReceivable(string acrReceivableId, DateTime acrReceivableDate, string acrCustomerId, string acrInvoiceNo, string acrTotalAmount, string acrDiscount, string acrDue, string acrAmountPaying, string acrFromSale, string acrRemarks, string acrUpdateBy)
        {
            return Command("UPDATE AccountsReceivable SET acrReceivableDate = '" + acrReceivableDate + "', acrCustomerId = '" + acrCustomerId + "', acrInvoiceNo = '" + acrInvoiceNo + "', acrTotalAmount = " + acrTotalAmount + ", acrDiscount = " + acrDiscount + ", acrDue = " + acrDue +
                ", acrAmountPaying = " + acrAmountPaying + ", acrFromSale = " + acrFromSale + ", acrRemarks = '" + acrRemarks + "', acrUpdateBy = '" + acrUpdateBy + "', acrUpdateDate = '" + DateTime.Now + "' WHERE acrReceivableId = '" + acrReceivableId + "'");
        }

        public bool DeleteAccountsReceivable(string acrReceivableId, string acrDeleteBy)
        {
            return Command("UPDATE AccountsReceivable SET acrIsDelete = 1, acrDeleteBy = '" + acrDeleteBy + "', acrDeleteDate = '" + DateTime.Now + "' WHERE acrReceivableId = '" + acrReceivableId + "'");
        }

        public bool SetFullPaid(string slsInvoiceNo, string slsIsFullPaid)
        {
            return Command("UPDATE Sales SET slsIsFullPaid = " + slsIsFullPaid + " WHERE slsInvoiceNo = '" + slsInvoiceNo + "'");
        }

        public DataTable SearchAccountsReceivable(string acrCustomerId, DateTime startDate, DateTime endDate)
        {
            return acrCustomerId != string.Empty
                ? Query("SELECT * FROM vwAccountsReceivable WHERE acrCustomerId = '" + acrCustomerId + "' AND acrReceivableDate BETWEEN '" + startDate + "' AND '" + endDate + "'")
                : Query("SELECT * FROM vwAccountsReceivable WHERE acrReceivableDate BETWEEN '" + startDate + "' AND '" + endDate + "'");
        }
    }
}
