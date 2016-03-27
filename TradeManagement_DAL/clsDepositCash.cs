using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsDepositCash : clsCommon
    {
        public DataTable GetAllData()
        {
            return Query("SELECT * FROM DepositCash WHERE dpcIsDelete = 0 ORDER BY dpcDate DESC");
        }

        public bool InsertDepositCash(DateTime dpcDate, string dpcDescription, string dpcAmount, string dpcInsertBy)
        {
            return Command("INSERT INTO DepositCash (dpcId, dpcDate, dpcDescription, dpcAmount, dpcInsertBy, dpcInsertDate) VALUES ('" + Guid.NewGuid() + "', '" + dpcDate + "', '" + dpcDescription + "', " + dpcAmount + ", '" + dpcInsertBy + "', '" + DateTime.Now + "')");
        }

        public bool UpdateDepositCash(string dpcId, DateTime dpcDate, string dpcDescription, string dpcAmount, string dpcUpdateBy)
        {
            return Command("UPDATE DepositCash SET dpcDate = '" + dpcDate + "', dpcDescription = '" + dpcDescription + "', dpcAmount = " + dpcAmount + ", dpcUpdateBy = '" + dpcUpdateBy + "', dpcUpdateDate = '" + DateTime.Now + "' WHERE dpcId = '" + dpcId + "'");
        }

        public bool DeleteDepositCash(string dpcId, string dpcDeleteBy)
        {
            return Command("UPDATE DepositCash SET dpcIsDelete = 1, dpcDeleteBy = '" + dpcDeleteBy + "', dpcDeleteDate = '" + DateTime.Now + "' WHERE dpcId = '" + dpcId + "'");
        }
    }
}