using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsCustomers : clsCommon
    {
        public new DataTable GetAllCustomers()
        {
            return Query("SELECT * FROM Customers WHERE cstIsDelete = 0");
        }

        public string GetNextCustomerId()
        {
            return "CST-1" + Query("SELECT ISNULL(MAX(RIGHT(cstCustomerId, 3)), 0) + 1 FROM Customers").Rows[0][0].ToString().PadLeft(3, '0');
        }

        public bool IsRefferedInSales(string cstCustomerId)
        {
            return Query($"SELECT * FROM Sales WHERE slsCustomerId = '{cstCustomerId}'").Rows.Count > 0;
        }

        public bool InsertCustomer(string cstCustomerId, string cstCustomerName, string cstAddress, string cstLandPhone, string cstMobile, string cstIsActive, string cstInsertBy)
        {
            return Command(
                $"INSERT INTO Customers (cstCustomerId, cstCustomerName, cstAddress, cstLandPhone, cstMobile, cstIsActive, cstInsertBy, cstInsertDate) Values ('{cstCustomerId}','{cstCustomerName}','{cstAddress}','{cstLandPhone}','{cstMobile}',{cstIsActive},'{cstInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateCustomer(string cstCustomerId, string cstCustomerName, string cstAddress, string cstLandPhone, string cstMobile, string cstIsActive, string cstUpdateBy)
        {
            return Command(
                $"UPDATE Customers SET cstCustomerName = '{cstCustomerName}', cstAddress = '{cstAddress}', cstLandPhone = '{cstLandPhone}', cstMobile = '{cstMobile}', cstIsActive = {cstIsActive}, cstUpdateBy = '{cstUpdateBy}', cstUpdateDate = '{DateTime.Now}' WHERE cstCustomerId = '{cstCustomerId}'");
        }

        public bool DeleteCustomer(string cstCustomerId, string cstDeleteBy)
        {
            return Command(
                $"UPDATE Customers SET cstIsDelete = 1, cstDeleteBy = '{cstDeleteBy}', cstDeleteDate = '{DateTime.Now}' WHERE cstCustomerId = '{cstCustomerId}'");
        }
    }
}
