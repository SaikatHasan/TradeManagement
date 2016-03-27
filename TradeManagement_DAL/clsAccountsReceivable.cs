using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsAccountsReceivable : clsCommon
    {
        public string GetNextReceivableId()
        {
            return
                $"ACR-{DateTime.Now:yy}-{Query("SELECT ISNULL(MAX(RIGHT(acrReceivableId, 5)), 0) + 1 FROM AccountsReceivable WHERE SUBSTRING(acrReceivableId, 5, 2) = RIGHT(DATEPART(YY, GETDATE()), 2)").Rows[0][0].ToString().PadLeft(5, '0')}";
        }

        public bool InsertAccountsReceivable(string acrReceivableId, DateTime acrReceivableDate, string acrCustomerId, string acrVoucherNo, string acrAmount, string acrRemarks, string acrInsertBy)
        {
            return Command("INSERT INTO AccountsReceivable (acrReceivableId, acrReceivableDate, acrCustomerId, acrVoucherNo, acrAmount, acrRemarks, acrInsertBy, acrInsertDate) VALUES ('" +
                acrReceivableId + "', '" + acrReceivableDate + "', '" + acrCustomerId + "', '" + acrVoucherNo + "', " + acrAmount + ", '" + acrRemarks + "', '" + acrInsertBy + "', '" + DateTime.Now + "')");
        }

        public bool UpdateAccountsReceivable(string acrReceivableId, string acrAmount, string acrRemarks, string acrUpdateBy)
        {
            return Command("UPDATE AccountsReceivable SET acrAmount = " + acrAmount + ", acrRemarks = '" + acrRemarks + "', acrUpdateBy = '" + acrUpdateBy + "', acrUpdateDate = '" + DateTime.Now + "' WHERE acrReceivableId = '" + acrReceivableId + "'");
        }

        public bool DeleteAccountsReceivable(string acrReceivableId, string acrDeleteBy)
        {
            return Command("UPDATE AccountsReceivable SET acrIsDelete = 1, acrDeleteBy = '" + acrDeleteBy + "', acrDeleteDate = '" + DateTime.Now + "' WHERE acrReceivableId = '" + acrReceivableId + "'");
        }

        public DataTable SearchAccountsReceivable(string acrCustomerId, DateTime startDate, DateTime endDate)
        {
            return acrCustomerId != string.Empty
                ? Query("SELECT * FROM vwAccountsReceivable WHERE acrCustomerId = '" + acrCustomerId + "' AND acrReceivableDate BETWEEN '" + startDate + "' AND '" + endDate + "'")
                : Query("SELECT * FROM vwAccountsReceivable WHERE acrReceivableDate BETWEEN '" + startDate + "' AND '" + endDate + "'");
        }
    }
}