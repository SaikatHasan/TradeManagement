using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsSaleReturns : clsCommon
    {
        public string GetNextReturnId()
        {
            return
                $"SRT-{DateTime.Now:yy}-{Query("SELECT ISNULL(MAX(RIGHT(srtReturnId, 3)), 0) + 1 FROM SaleReturns WHERE SUBSTRING(srtReturnId, 5, 2) = RIGHT(DATEPART(YY, GETDATE()), 2)").Rows[0][0].ToString().PadLeft(3, '0')}";
        }

        public DataTable GetSaleDetails(string sldInvoiceNo)
        {
            return Query($"SELECT * FROM vwSaleDetails WHERE sldInvoiceNo = '{sldInvoiceNo}'");
        }

        public DataTable GetSaleReturns(string srtReturnId)
        {
            return Query($"SELECT * FROM vwSaleReturns WHERE srtReturnId = '{srtReturnId}'");
        }

        public DataTable GetSaleReturnDetails(string srdReturnId)
        {
            return Query($"SELECT * FROM vwSaleReturnDetails WHERE srdReturnId = '{srdReturnId}'");
        }

        public bool IsReturnedPrev(string srtInvoiceNo)
        {
            return Query($"SELECT * FROM SaleReturns WHERE srtInvoiceNo = '{srtInvoiceNo}'").Rows.Count > 0;
        }

        public string GetReturnId(string srtInvoiceNo)
        {
            return Query($"SELECT srtReturnId FROM SaleReturns WHERE srtInvoiceNo = '{srtInvoiceNo}'").Rows[0][0].ToString();
        }

        public bool InsertSaleReturns(string srtReturnId, DateTime srtReturnDate, string srtInvoiceNo, string srtInsertBy)
        {
            return Command(
                $"INSERT INTO SaleReturns (srtReturnId, srtReturnDate, srtInvoiceNo, srtInsertBy, srtInsertDate) Values ('{srtReturnId}','{srtReturnDate}','{srtInvoiceNo}','{srtInsertBy}','{DateTime.Now}')");
        }

        public bool InsertSaleReturnDetails(string srdReturnId, string srdProductId, string srdSaleQuantity, string srdReturnQuantity)
        {
            return Command(
                $"INSERT INTO SaleReturnDetails (srdReturnId, srdProductId, srdSaleQuantity, srdReturnQuantity) Values ('{srdReturnId}','{srdProductId}',{srdSaleQuantity},{srdReturnQuantity})");
        }

        public bool UpdateSaleReturns(string srtReturnId, DateTime srtReturnDate, string srtInvoiceNo, string srtUpdateBy)
        {
            return Command(string.Format("UPDATE SaleReturns SET srtReturnDate = '{1}', srtInvoiceNo = '{2}', srtUpdateBy = '{3}', srtUpdateDate = '{4}' WHERE srtReturnId = '{0}'",
                srtReturnId, srtReturnDate, srtInvoiceNo, srtUpdateBy, DateTime.Now));
        }

        public bool DeleteSaleReturns(string srtReturnId, string srtDeleteBy)
        {
            return Command(
                $"UPDATE SaleReturns SET srtIsDelete = 1, srtDeleteBy = '{srtDeleteBy}', srtDeleteDate = '{DateTime.Now}' WHERE srtReturnId = '{srtReturnId}'");
        }

        public bool DeleteSaleReturnDetails(string srdReturnId)
        {
            return Command($"DELETE FROM SaleReturnDetails WHERE srdReturnId = '{srdReturnId}'");
        }

        public DataTable SearchSaleReturnsBySupplier(string slsCustomerId)
        {
            return Query($"SELECT * FROM vwSaleReturns WHERE slsCustomerId = '{slsCustomerId}'");
        }

        public DataTable SearchPurchaseReturnsByDate(DateTime startDate, DateTime endDate)
        {
            return Query($"SELECT * FROM vwSaleReturns WHERE srtReturnDate BETWEEN '{startDate}' AND '{endDate}'");
        }
    }
}
