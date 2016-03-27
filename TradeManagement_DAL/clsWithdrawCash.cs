using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsWithdrawCash : clsCommon
    {
        public DataTable GetAllData()
        {
            return Query("SELECT * FROM WithdrawCash WHERE wdcIsDelete = 0 ORDER BY wdcDate DESC");
        }

        public bool InsertWithdrawCash(DateTime wdcDate, string wdcDescription, string wdcAmount, string wdcInsertBy)
        {
            return Command("INSERT INTO WithdrawCash (wdcId, wdcDate, wdcDescription, wdcAmount, wdcInsertBy, wdcInsertDate) VALUES ('" + Guid.NewGuid() + "', '" + wdcDate + "', '" + wdcDescription + "', " + wdcAmount + ", '" + wdcInsertBy + "', '" + DateTime.Now + "')");
        }

        public bool UpdateWithdrawCash(string wdcId, DateTime wdcDate, string wdcDescription, string wdcAmount, string wdcUpdateBy)
        {
            return Command("UPDATE WithdrawCash SET wdcDate = '" + wdcDate + "', wdcDescription = '" + wdcDescription + "', wdcAmount = " + wdcAmount + ", wdcUpdateBy = '" + wdcUpdateBy + "', wdcUpdateDate = '" + DateTime.Now + "' WHERE wdcId = '" + wdcId + "'");
        }

        public bool DeleteWithdrawCash(string wdcId, string wdcDeleteBy)
        {
            return Command("UPDATE WithdrawCash SET wdcIsDelete = 1, wdcDeleteBy = '" + wdcDeleteBy + "', wdcDeleteDate = '" + DateTime.Now + "' WHERE wdcId = '" + wdcId + "'");
        }
    }
}