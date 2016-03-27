using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsExpenseCategories : clsCommon
    {
        public DataTable GetAllExpenseCategories()
        {
            return Query("SELECT * FROM ExpenseCategories WHERE ectIsDelete = 0");
        }

        public string GetNextExpenseCategoryId()
        {
            return "ECT-" + Query("SELECT ISNULL(MAX(RIGHT(ectExpenseCategoryId, 3)), 0) + 1 FROM ExpenseCategories").Rows[0][0].ToString().PadLeft(3, '0');
        }

        public bool IsRefferedInExpenses(string expExpenseCategoryId)
        {
            return Query($"SELECT * FROM Expenses WHERE expExpenseCategoryId = '{expExpenseCategoryId}'").Rows.Count > 0;
        }

        public bool InsertExpenseCategory(string ectExpenseCategoryId, string ectExpenseCategoryName, string ectIsActive, string ectInsertBy)
        {
            return Command(
                $"INSERT INTO ExpenseCategories (ectExpenseCategoryId, ectExpenseCategoryName, ectIsActive, ectInsertBy, ectInsertDate) Values ('{ectExpenseCategoryId}','{ectExpenseCategoryName}',{ectIsActive},'{ectInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateExpenseCategory(string ectExpenseCategoryId, string ectExpenseCategoryName, string ectIsActive, string ectUpdateBy)
        {
            return Command(
                $"UPDATE ExpenseCategories SET ectExpenseCategoryName = '{ectExpenseCategoryName}', ectIsActive = {ectIsActive}, ectUpdateBy = '{ectUpdateBy}', ectUpdateDate = '{DateTime.Now}' WHERE ectExpenseCategoryId = '{ectExpenseCategoryId}'");
        }

        public bool DeleteExpenseCategory(string ectExpenseCategoryId, string ectDeleteBy)
        {
            return Command(
                $"UPDATE ExpenseCategories SET ectIsDelete = 1, ectDeleteBy = '{ectDeleteBy}', ectDeleteDate = '{DateTime.Now}' WHERE ectExpenseCategoryId = '{ectExpenseCategoryId}'");
        }
    }
}
