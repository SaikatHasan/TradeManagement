using System;
using System.Data;
using System.Linq;

namespace TradeManagement_DAL
{
    public class clsQuotations : clsCommon
    {
        public DataTable GetProductInfo(string prdBarcode)
        {
            return Query(
                $"SELECT pdtProductId, pdtProductName, bndBrandName, pdtModel, pdtPackageUnit, pdtReorderLevel, pdtUnitPrice, pdtStockQuantity FROM vwProducts WHERE pdtBarcode = '{prdBarcode}'");
        }

        public DataTable GetAllProducts()
        {
            return Query("SELECT * FROM vwProducts WHERE pdtIsActive = 1 AND pdtIsDelete = 0");
        }

        public string GetNextQuotationNo()
        {
            return
                $"QOT-{DateTime.Now:yy}-{Query("SELECT ISNULL(MAX(RIGHT(qotQuotationNo, 3)), 0) + 1 FROM Quotations WHERE SUBSTRING(qotQuotationNo, 5, 2) = RIGHT(DATEPART(YY, GETDATE()), 2)").Rows[0][0].ToString().PadLeft(3, '0')}";
        }

        new public DataTable GetAllCustomers()
        {
            return Query("SELECT DISTINCT qotCustomerName FROM Quotations WHERE qotIsDelete = 0 ORDER BY qotCustomerName");
        }

        public bool InsertQuotations(string qotQuotationNo, DateTime qotQuotationDate, string qotCustomerName, string qotAddress, string qotPhone, string qotTotalAmount, string qotVAT, string qotDiscount, string qotInsertBy)
        {
            return Command(
                $"INSERT INTO Quotations (qotQuotationNo, qotQuotationDate, qotCustomerName, qotAddress, qotPhone, qotTotalAmount, qotVAT, qotDiscount, qotInsertBy, qotInsertDate) Values ('{qotQuotationNo}','{qotQuotationDate}','{qotCustomerName}','{qotAddress}','{qotPhone}',{qotTotalAmount},{qotVAT},{qotDiscount},'{qotInsertBy}','{DateTime.Now}')");
        }

        public bool InsertQuotationDetails(string qodQuotationNo, string qodProductId, string qodQuotationPrice, string qodQuantity)
        {
            return Command(
                $"INSERT INTO QuotationDetails (qodQuotationNo, qodProductId, qodQuotationPrice, qodQuantity) Values ('{qodQuotationNo}','{qodProductId}',{qodQuotationPrice},{qodQuantity})");
        }

        public bool UpdateQuotations(string qotQuotationNo, DateTime qotQuotationDate, string qotCustomerName, string qotAddress, string qotPhone, string qotTotalAmount, string qotVAT, string qotDiscount, string qotUpdateBy)
        {
            return Command(string.Format("UPDATE Quotations SET qotQuotationDate = '{1}', qotCustomerName = '{2}', qotAddress = '{3}', qotPhone = '{4}', qotTotalAmount = {5}, qotVAT = {6}, qotDiscount = {7}, qotUpdateBy = '{8}', qotUpdateDate = '{9}' WHERE qotQuotationNo = '{0}'",
                qotQuotationNo, qotQuotationDate, qotCustomerName, qotAddress, qotPhone, qotTotalAmount, qotVAT, qotDiscount, qotUpdateBy, DateTime.Now));
        }

        public bool DeleteQuotations(string qotQuotationNo, string qotDeleteBy)
        {
            return Command(
                $"UPDATE Quotations SET qotIsDelete = 1, qotDeleteBy = '{qotDeleteBy}', qotDeleteDate = '{DateTime.Now}' WHERE qotQuotationNo = '{qotQuotationNo}'");
        }

        public bool DeleteQuotationDetails(string qodQuotationNo)
        {
            return Command($"DELETE FROM QuotationDetails WHERE qodQuotationNo = '{qodQuotationNo}'");
        }

        public DataTable SearchQuotationsByCustomer(string qotCustomerName)
        {
            return Query(
                $"SELECT qotQuotationNo, qotQuotationDate, qotCustomerName, qotAddress, qotPhone, qotTotalAmount, qotVAT, qotDiscount, qotTotalAmount + qotVAT - qotDiscount AS qotNetTotal FROM Quotations WHERE qotCustomerName = '{qotCustomerName}' AND qotIsDelete = 0");
        }

        public DataTable SearchQuotationsByDate(DateTime startDate, DateTime endDate)
        {
            return Query(
                $"SELECT qotQuotationNo, qotQuotationDate, qotCustomerName, qotAddress, qotPhone, qotTotalAmount, qotVAT, qotDiscount, qotTotalAmount + qotVAT - qotDiscount AS qotNetTotal FROM Quotations WHERE qotQuotationDate BETWEEN '{startDate}' AND '{endDate}' AND qotIsDelete = 0");
        }

        public DataTable GetQuotations(string qotQuotationNo)
        {
            return Query($"SELECT * FROM Quotations WHERE qotQuotationNo = '{qotQuotationNo}'");
        }

        public DataTable GetQuotationDetails(string qotQuotationNo)
        {
            return Query($"SELECT * FROM vwQuotationDetails WHERE qotQuotationNo = '{qotQuotationNo}'");
        }
    }
}
