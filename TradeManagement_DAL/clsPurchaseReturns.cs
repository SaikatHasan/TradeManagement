using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsPurchaseReturns : clsCommon
    {
        public string GetNextReturnId()
        {
            return
                $"PRT-{DateTime.Now:yy}-{Query("SELECT ISNULL(MAX(RIGHT(prtReturnId, 3)), 0) + 1 FROM PurchaseReturns WHERE SUBSTRING(prtReturnId, 5, 2) = RIGHT(DATEPART(YY, GETDATE()), 2)").Rows[0][0].ToString().PadLeft(3, '0')}";
        }
        
        public DataTable GetPurchaseDetails(string prdPurchaseId)
        {
            return Query($"SELECT * FROM vwPurchaseDetails WHERE prdPurchaseId = '{prdPurchaseId}'");
        }

        public DataTable GetPurchaseReturns(string prtReturnId)
        {
            return Query($"SELECT * FROM vwPurchaseReturns WHERE prtReturnId = '{prtReturnId}'");
        }

        public DataTable GetPurchaseReturnDetails(string prdReturnId)
        {
            return Query($"SELECT * FROM vwPurchaseReturnDetails WHERE prdReturnId = '{prdReturnId}'");
        }

        public bool IsSold(string sldProductId)
        {
            return Query($"SELECT * FROM SaleDetails WHERE sldProductId = '{sldProductId}'").Rows.Count > 0;
        }

        public bool IsReturnedPrev(string prtPurchaseId)
        {
            return Query($"SELECT * FROM PurchaseReturns WHERE prtPurchaseId = '{prtPurchaseId}' AND prtIsDelete = 0").Rows.Count > 0;
        }

        public string GetReturnId(string prtPurchaseId)
        {
            return Query(
                $"SELECT prtReturnId FROM PurchaseReturns WHERE prtPurchaseId = '{prtPurchaseId}' AND prtIsDelete = 0").Rows[0][0].ToString();
        }

        public bool InsertPurchaseReturns(string prtReturnId, DateTime prtReturnDate, string prtPurchaseId, string prtInsertBy)
        {
            return Command(
                $"INSERT INTO PurchaseReturns (prtReturnId, prtReturnDate, prtPurchaseId, prtInsertBy, prtInsertDate) Values ('{prtReturnId}','{prtReturnDate}','{prtPurchaseId}','{prtInsertBy}','{DateTime.Now}')");
        }

        public bool InsertPurchaseReturnDetails(string prdReturnId, string prdProductId, string prdPurchaseQuantity, string prdReturnQuantity)
        {
            return Command(
                $"INSERT INTO PurchaseReturnDetails (prdReturnId, prdProductId, prdPurchaseQuantity, prdReturnQuantity) Values ('{prdReturnId}','{prdProductId}',{prdPurchaseQuantity},{prdReturnQuantity})");
        }

        public bool UpdatePurchaseReturns(string prtReturnId, DateTime prtReturnDate, string prtPurchaseId, string prtUpdateBy)
        {
            return Command(string.Format("UPDATE PurchaseReturns SET prtReturnDate = '{1}', prtPurchaseId = '{2}', prtUpdateBy = '{3}', prtUpdateDate = '{4}' WHERE prtReturnId = '{0}' AND prtIsDelete = 0",
                prtReturnId, prtReturnDate, prtPurchaseId, prtUpdateBy, DateTime.Now));
        }

        public bool DeletePurchaseReturns(string prtReturnId, string prtDeleteBy)
        {
            return Command(
                $"UPDATE PurchaseReturns SET prtIsDelete = 1, prtDeleteBy = '{prtDeleteBy}', prtDeleteDate = '{DateTime.Now}' WHERE prtReturnId = '{prtReturnId}' AND prtIsDelete = 0");
        }

        public bool DeletePurchaseReturnDetails(string prdReturnId)
        {
            return Command($"DELETE FROM PurchaseReturnDetails WHERE prdReturnId = '{prdReturnId}'");
        }

        public DataTable SearchPurchaseReturnsBySupplier(string purSupplierId)
        {
            return Query($"SELECT * FROM vwPurchaseReturns WHERE purSupplierId = '{purSupplierId}'");
        }

        public DataTable SearchPurchaseReturnsByDate(DateTime startDate, DateTime endDate)
        {
            return Query($"SELECT * FROM vwPurchaseReturns WHERE prtReturnDate BETWEEN '{startDate}' AND '{endDate}'");
        }
    }
}
