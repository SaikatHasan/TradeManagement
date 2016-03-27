using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsBankAccounts : clsCommon
    {
        public DataTable GetAllBankAccounts()
        {
            return Query("SELECT * FROM BankAccounts WHERE bacIsDelete = 0 ORDER BY bacAccountId");
        }

        public string GetNextBankAccountId()
        {
            return "BAC-" + Query("SELECT ISNULL(MAX(RIGHT(bacAccountId, 3)), 0) + 1 FROM BankAccounts").Rows[0][0].ToString().PadLeft(3, '0');
        }

        public bool IsRefferedInPurchases(string purBankAccountId)
        {
            return Query($"SELECT * FROM Purchases WHERE purBankAccountId = '{purBankAccountId}'").Rows.Count > 0;
        }

        public bool IsRefferedInAccountsPayable(string acpBankAccountId)
        {
            return Query($"SELECT * FROM AccountsPayable WHERE acpBankAccountId = '{acpBankAccountId}'").Rows.Count > 0;
        }

        public bool InsertBank(string bacAccountId, string bacBankName, string bacAccountNo, string bacIsActive, string bacInsertBy)
        {
            return Command($"INSERT INTO BankAccounts (bacAccountId, bacBankName, bacAccountNo, bacIsActive, bacInsertBy, bacInsertDate) Values ('{bacAccountId}','{bacBankName}','{bacAccountNo}',{bacIsActive},'{bacInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateBank(string bacAccountId, string bacBankName, string bacAccountNo, string bacIsActive, string bacUpdateBy)
        {
            return Command($"UPDATE BankAccounts SET bacBankName = '{bacBankName}', bacAccountNo = '{bacAccountNo}', bacIsActive = {bacIsActive}, bacUpdateBy = '{bacUpdateBy}', bacUpdateDate = '{DateTime.Now}' WHERE bacAccountId = '{bacAccountId}'");
        }
        public bool DeleteBank(string bacAccountId, string bacDeleteBy)
        {
            return Command($"UPDATE BankAccounts SET bacIsDelete = 1, bacDeleteBy = '{bacDeleteBy}', bacDeleteDate = '{DateTime.Now}' WHERE bacAccountId = '{bacAccountId}'");
        }
    }
}