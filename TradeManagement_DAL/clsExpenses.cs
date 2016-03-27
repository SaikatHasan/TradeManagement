using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsExpenses : clsCommon
    {
        public string GetNextExpenseId()
        {
            return
                $"EXP-{DateTime.Now:yy}-{Query("SELECT ISNULL(MAX(RIGHT(expExpenseId, 3)), 0) + 1 FROM Expenses WHERE SUBSTRING(expExpenseId, 5, 2) = RIGHT(DATEPART(YY, GETDATE()), 2)").Rows[0][0].ToString().PadLeft(3, '0')}";
        }

        public bool InsertExpenses(string expExpenseId, DateTime expExpenseDate, string expExpenseCategoryId, string expDescription, string expAmount, string expInsertBy)
        {
            return Command(
                $"INSERT INTO Expenses (expExpenseId, expExpenseDate, expExpenseCategoryId, expDescription, expAmount, expInsertBy, expInsertDate) Values ('{expExpenseId}','{expExpenseDate}','{expExpenseCategoryId}','{expDescription}',{expAmount},'{expInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateExpenses(string expExpenseId, DateTime expExpenseDate, string expExpenseCategoryId, string expDescription, string expAmount, string expUpdateBy)
        {
            return Command(
                $"UPDATE Expenses SET expExpenseDate = '{expExpenseDate}', expExpenseCategoryId = '{expExpenseCategoryId}', expDescription = '{expDescription}', expAmount = {expAmount}, expUpdateBy = '{expUpdateBy}', expUpdateDate = '{DateTime.Now}' WHERE expExpenseId = '{expExpenseId}'");
        }

        public bool DeleteExpenses(string expExpenseId, string expDeleteBy)
        {
            return Command(
                $"UPDATE Expenses SET expIsDelete = 1, expDeleteBy = '{expDeleteBy}', expDeleteDate = '{DateTime.Now}' WHERE expExpenseId = '{expExpenseId}'");
        }

        public DataTable SearchExpensesByDate(DateTime expExpenseDate)
        {
            return Query(
                $"SELECT expExpenseId, expExpenseDate, expExpenseCategoryId, ectExpenseCategoryName, expDescription, expAmount FROM Expenses JOIN ExpenseCategories ON ectExpenseCategoryId = expExpenseCategoryId WHERE expExpenseDate = '{expExpenseDate}' AND expIsDelete = 0");
        }

        public DataTable SearchExpensesByCategory(string expExpenseCategoryId)
        {
            return Query(
                $"SELECT expExpenseId, expExpenseDate, expExpenseCategoryId, ectExpenseCategoryName, expDescription, expAmount FROM Expenses JOIN ExpenseCategories ON ectExpenseCategoryId = expExpenseCategoryId WHERE expExpenseCategoryId = '{expExpenseCategoryId}' AND expIsDelete = 0");
        }

        public DataTable SearchExpensesByDateAndCategory(DateTime expExpenseDate, string expExpenseCategoryId)
        {
            return Query(
                $"SELECT expExpenseId, expExpenseDate, expExpenseCategoryId, ectExpenseCategoryName, expDescription, expAmount FROM Expenses JOIN ExpenseCategories ON expExpenseCategoryId = ectExpenseCategoryId WHERE expExpenseDate = '{expExpenseDate}' AND expExpenseCategoryId = '{expExpenseCategoryId}' AND expIsDelete = 0");
        }

        public DataTable GetAllExpenseCategories()
        {
            return Query("SELECT ectExpenseCategoryId, ectExpenseCategoryName FROM ExpenseCategories WHERE ectIsActive = 1 AND ectIsDelete = 0 ORDER BY ectExpenseCategoryName");
        }
    }
}