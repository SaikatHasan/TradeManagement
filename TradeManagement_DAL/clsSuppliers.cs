using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsSuppliers : clsCommon
    {
        public DataTable GetAllSuppliers()
        {
            return Query("SELECT * FROM Suppliers WHERE supIsDelete = 0");
        }

        public string GetNextSupplierId()
        {
            return "SUP-" + Query("SELECT ISNULL(MAX(RIGHT(supSupplierId, 4)), 0) + 1 FROM Suppliers").Rows[0][0].ToString().PadLeft(4, '0');
        }

        public bool IsRefferedInPurchases(string supSupplierId)
        {
            return Query($"SELECT * FROM Purchases WHERE purSupplierId = '{supSupplierId}'").Rows.Count > 0;
        }

        public bool InsertSupplier(string supSupplierId, string supSupplierName, string supAddress, string supContactPerson, string supLandPhone, string supMobile1, string supMobile2, string supIsActive, string supInsertBy)
        {
            return Command($"INSERT INTO Suppliers (supSupplierId, supSupplierName, supAddress, supContactPerson, supLandPhone, supMobile1, supMobile2, supIsActive, supInsertBy, supInsertDate) Values ('{supSupplierId}','{supSupplierName.Replace("'", "''")}','{supAddress.Replace("'", "''")}','{supContactPerson}','{supLandPhone}','{supMobile1}','{supMobile2}',{supIsActive},'{supInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateSupplier(string supSupplierId, string supSupplierName, string supAddress, string supContactPerson, string supLandPhone, string supMobile1, string supMobile2, string supIsActive, string supUpdateBy)
        {
            return Command($"UPDATE Suppliers SET supSupplierName = '{supSupplierName.Replace("'", "''")}', supAddress = '{supAddress.Replace("'", "''")}', supContactPerson = '{supContactPerson}', supLandPhone = '{supLandPhone}', supMobile1 = '{supMobile1}', supMobile2 = '{supMobile2}', supIsActive = {supIsActive}, supUpdateBy = '{supUpdateBy}', supUpdateDate = '{DateTime.Now}' WHERE supSupplierId = '{supSupplierId}'");
        }

        public bool DeleteSupplier(string supSupplierId, string supDeleteBy)
        {
            return Command($"UPDATE Suppliers SET supIsDelete = 1, supDeleteBy = '{supDeleteBy}', supDeleteDate = '{DateTime.Now}' WHERE supSupplierId = '{supSupplierId}'");
        }
    }
}
