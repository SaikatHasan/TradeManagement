using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsBrands : clsCommon
    {
        public DataTable GetAllBrands()
        {
            return Query("SELECT * FROM Brands WHERE bndIsDelete = 0");
        }

        public string GetNextBrandId()
        {
            return "BND-" + Query("SELECT ISNULL(MAX(RIGHT(bndBrandId, 3)), 0) + 1 FROM Brands").Rows[0][0].ToString().PadLeft(3, '0');
        }

        public bool IsRefferedInProducts(string pdtBrandId)
        {
            return Query($"SELECT * FROM Products WHERE pdtBrandId = '{pdtBrandId}'").Rows.Count > 0;
        }

        public bool InsertBrand(string bndBrandId, string bndBrandName, string bndIsActive, string bndInsertBy)
        {
            return Command($"INSERT INTO Brands (bndBrandId, bndBrandName, bndIsActive, bndInsertBy, bndInsertDate) Values ('{bndBrandId}','{bndBrandName}',{bndIsActive},'{bndInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateBrand(string bndBrandId, string bndBrandName, string bndIsActive, string bndUpdateBy)
        {
            return Command($"UPDATE Brands SET bndBrandName = '{bndBrandName}', bndIsActive = {bndIsActive}, bndUpdateBy = '{bndUpdateBy}', bndUpdateDate = '{DateTime.Now}' WHERE bndBrandId = '{bndBrandId}'");
        }

        public bool DeleteBrand(string bndBrandId, string bndDeleteBy)
        {
            return Command($"UPDATE Brands SET bndIsDelete = 1, bndDeleteBy = '{bndDeleteBy}', bndDeleteDate = '{DateTime.Now}' WHERE bndBrandId = '{bndBrandId}'");
        }
    }
}
