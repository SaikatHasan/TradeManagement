using System;
using System.Data;
using System.Linq;

namespace TradeManagement_DAL
{
    public class clsPurchases : clsCommon
    {
        public DataTable GetProductInfo(string prdBarcode)
        {
            return Query($"SELECT pdtProductId, pdtProductName, bndBrandName, pdtModel, pdtPackageUnit, pdtReorderLevel, pdtUnitPrice, pdtStockQuantity FROM vwProducts WHERE pdtBarcode = '{prdBarcode}'");
        }

        public DataTable GetAllProducts()
        {
            return Query("SELECT pdtProductId, pdtProductName, bndBrandName, pdtModel, pdtPackageUnit FROM vwProducts WHERE pdtIsActive = 1 AND pdtIsDelete = 0 ORDER BY pdtProductName");
        }

        public string GetNextPurchaseId()
        {
            return
                $"PUR-{DateTime.Now:yy}-{Query("SELECT ISNULL(MAX(RIGHT(purPurchaseId, 5)), 0) + 1 FROM Purchases WHERE SUBSTRING(purPurchaseId, 5, 2) = RIGHT(DATEPART(YY, GETDATE()), 2)").Rows[0][0].ToString().PadLeft(5, '0')}";
        }

        public DataTable GetUnpaidVoucherNo(string purSupplierId)
        {
            return Query(
                $"SELECT purPurchaseId, purVoucherNo FROM Purchases WHERE purSupplierId = '{purSupplierId}' AND purIsDelete = 0 AND purIsFullPaid = 0");
        }

        public bool CheckVoucherForNew(string purSupplierId, string purVoucherNo)
        {
            return Query(
                $"SELECT * FROM Purchases WHERE purSupplierId = '{purSupplierId}' AND purVoucherNo = '{purVoucherNo}' AND purIsDelete = 0").Rows.Count > 0;
        }

        public bool CheckVoucherForEdit(string purPurchaseId, string purSupplierId, string purVoucherNo)
        {
            return Query(
                $"SELECT * FROM Purchases WHERE purPurchaseId != '{purPurchaseId}' AND purSupplierId = '{purSupplierId}' AND purVoucherNo = '{purVoucherNo}' AND purIsDelete = 0").Rows.Count > 0;
        }

        public bool InsertPurchases(string purPurchaseId, DateTime purPurchaseDate, string purSupplierId, string purVoucherNo, string purTotalAmount, string purDiscount, string purAmountPaid, string purIsFullPaid, string purInsertBy)
        {
            return Command(
                $"INSERT INTO Purchases (purPurchaseId, purPurchaseDate, purSupplierId, purVoucherNo, purTotalAmount, purDiscount, purAmountPaid, purIsFullPaid, purInsertBy, purInsertDate) Values ('{purPurchaseId}','{purPurchaseDate}','{purSupplierId}','{purVoucherNo}',{purTotalAmount},{purDiscount},{purAmountPaid},{purIsFullPaid},'{purInsertBy}','{DateTime.Now}')");
        }

        public bool InsertPurchaseDetails(string prdPurchaseId, string prdProductId, string prdPurchasePrice, string prdQuantity)
        {
            return Command(
                $"INSERT INTO PurchaseDetails (prdPurchaseId, prdProductId, prdPurchasePrice, prdQuantity) Values ('{prdPurchaseId}','{prdProductId}',{prdPurchasePrice},{prdQuantity})");
        }

        public bool UpdatePurchases(string purPurchaseId, DateTime purPurchaseDate, string purSupplierId, string purVoucherNo, string purTotalAmount, string purDiscount, string purAmountPaid, string purIsFullPaid, string purUpdateBy)
        {
            return Command(string.Format("UPDATE Purchases SET purPurchaseDate = '{1}', purSupplierId = '{2}', purVoucherNo = '{3}', purTotalAmount = {4}, purDiscount = {5}, purAmountPaid = {6}, purIsFullPaid = {7}, purUpdateBy = '{8}', purUpdateDate = '{9}' WHERE purPurchaseId = '{0}'",
                purPurchaseId, purPurchaseDate, purSupplierId, purVoucherNo, purTotalAmount, purDiscount, purAmountPaid, purIsFullPaid, purUpdateBy, DateTime.Now));
        }

        public bool DeletePurchases(string purPurchaseId, string purDeleteBy)
        {
            return Command(
                $"UPDATE Purchases SET purIsDelete = 1, purDeleteBy = '{purDeleteBy}', purDeleteDate = '{DateTime.Now}' WHERE purPurchaseId = '{purPurchaseId}'");
        }

        public bool DeletePurchaseDetails(string prdPurchaseId)
        {
            return Command($"DELETE FROM PurchaseDetails WHERE prdPurchaseId = '{prdPurchaseId}'");
        }

        public DataTable SearchPurchasesBySupplier(string purSupplierId)
        {
            return Query($"SELECT * FROM vwPurchases WHERE purSupplierId = '{purSupplierId}'");
        }

        public DataTable SearchPurchasesByDate(DateTime startDate, DateTime endDate)
        {
            return Query($"SELECT * FROM vwPurchases WHERE purPurchaseDate BETWEEN '{startDate}' AND '{endDate}'");
        }

        public DataTable GetPurchases(string purPurchaseId)
        {
            return Query($"SELECT * FROM vwPurchases WHERE purPurchaseId = '{purPurchaseId}'");
        }

        public DataTable GetPurchaseDetails(string prdPurchaseId)
        {
            return Query($"SELECT * FROM vwPurchaseDetails WHERE prdPurchaseId = '{prdPurchaseId}'");
        }

        //Account Payable
        public string GetTotalDue()
        {
            var dtPayableIds = Query("SELECT MAX(acpPayableId) FROM AccountsPayable WHERE acpIsDelete <> 1 AND acpDue <> 0 GROUP BY acpPurchaseId");
            if (dtPayableIds.Rows.Count == 0) return "0";
            var payableIds = dtPayableIds.Rows.Cast<DataRow>().Aggregate(string.Empty, (current, rowPayableId) => current + ("'" + rowPayableId[0] + "',"));
            payableIds = payableIds.Remove(payableIds.Length - 1);
            return Query("SELECT SUM(acpDue) FROM AccountsPayable WHERE acpPayableId IN (" + payableIds + ")").Rows[0][0].ToString();
        }

        public string GetNextPayableId()
        {
            return
                $"ACP-{DateTime.Now:yy}-{Query("SELECT ISNULL(MAX(RIGHT(acpPayableId, 5)), 0) + 1 FROM AccountsPayable WHERE SUBSTRING(acpPayableId, 5, 2) = RIGHT(DATEPART(YY, GETDATE()), 2)").Rows[0][0].ToString().PadLeft(5, '0')}";
        }

        public string GetPayableId(string acpSupplierId, string acpVoucherNo)
        {
            return Query("SELECT acpPayableId FROM AccountsPayable WHERE acpSupplierId = '" + acpSupplierId + "' AND acpVoucherNo = '" + acpVoucherNo + "' AND acpIsDelete = 0").Rows[0][0].ToString();
        }

        public DataTable GetAccountsPayable(string acpPurchaseId)
        {
            return Query(string.Format("SELECT * FROM vwAccountsPayable WHERE acpPurchaseId = '{0}' AND acpPayableId = (SELECT MAX(acpPayableId) FROM vwAccountsPayable  WHERE acpPurchaseId = '{0}')", acpPurchaseId));
        }

        public bool InsertAccountsPayable(string acpPayableId, DateTime acpPayableDate, string acpSupplierId, string acpVoucherNo, string acpPurchaseId, string acpTotalAmount, string acpDiscount, string acpDue, string acpAmountPaying, string acpFromPurchase, string acpRemarks, string acpInsertBy)
        {
            return Command("INSERT INTO AccountsPayable (acpPayableId, acpPayableDate, acpSupplierId, acpVoucherNo, acpPurchaseId, acpTotalAmount, acpDiscount, acpDue, acpAmountPaying, acpFromPurchase, acpRemarks, acpInsertBy, acpInsertDate) VALUES ('" +
                acpPayableId + "', '" + acpPayableDate + "', '" + acpSupplierId + "', '" + acpVoucherNo + "', '" + acpPurchaseId + "', " + acpTotalAmount + ", " + acpDiscount + ", " + acpDue + ", " + acpAmountPaying + ", " + acpFromPurchase + ", '" + acpRemarks + "', '" + acpInsertBy + "', '" + DateTime.Now + "')");
        }

        public bool UpdateAccountsPayable(string acpPayableId, DateTime acpPayableDate, string acpSupplierId, string acpVoucherNo, string acpPurchaseId, string acpTotalAmount, string acpDiscount, string acpDue, string acpAmountPaying, string acpFromPurchase, string acpRemarks, string acpUpdateBy)
        {
            return Command("UPDATE AccountsPayable SET acpPayableDate = '" + acpPayableDate + "', acpSupplierId = '" + acpSupplierId + "', acpVoucherNo = '" + acpVoucherNo + "', acpPurchaseId = '" + acpPurchaseId + "', acpTotalAmount = " + acpTotalAmount + ", acpDiscount = " + acpDiscount + ", acpDue = " + acpDue +
                ", acpAmountPaying = " + acpAmountPaying + ", acpFromPurchase = " + acpFromPurchase + ", acpRemarks = '" + acpRemarks + "', acpUpdateBy = '" + acpUpdateBy + "', acpUpdateDate = '" + DateTime.Now + "' WHERE acpPayableId = '" + acpPayableId + "'");
        }

        public bool DeleteAccountsPayable(string acpPayableId, string acpDeleteBy)
        {
            return Command("UPDATE AccountsPayable SET acpIsDelete = 1, acpDeleteBy = '" + acpDeleteBy + "', acpDeleteDate = '" + DateTime.Now + "' WHERE acpPayableId = '" + acpPayableId + "'");
        }

        public bool SetFullPaid(string purPurchaseId, string purIsFullPaid)
        {
            return Command("UPDATE Purchases SET purIsFullPaid = " + purIsFullPaid + " WHERE purPurchaseId = '" + purPurchaseId + "'");
        }

        public DataTable SearchAccountsPayable(string acpSupplierId, DateTime startDate, DateTime endDate)
        {
            return acpSupplierId != string.Empty
                ? Query("SELECT * FROM vwAccountsPayable WHERE acpSupplierId = '" + acpSupplierId + "' AND acpPayableDate BETWEEN '" + startDate + "' AND '" + endDate + "'")
                : Query("SELECT * FROM vwAccountsPayable WHERE acpPayableDate BETWEEN '" + startDate + "' AND '" + endDate + "'");
        }
    }
}
