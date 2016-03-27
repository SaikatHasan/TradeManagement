using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsProducts : clsCommon
    {
        public bool Demo()
        {
            return Convert.ToInt32(Query("SELECT COUNT(*) FROM Products").Rows[0][0]) >= 20;
        }

        public DataTable GetAllProductCategories()
        {
            return Query("SELECT pctProductCategoryID, pctProductCategoryName FROM ProductCategories WHERE pctIsActive = 1 AND pctIsDelete = 0 ORDER BY pctProductCategoryName");
        }

        public DataTable GetAllBrands()
        {
            return Query("SELECT bndBrandID, bndBrandName FROM Brands WHERE bndIsActive = 1 AND bndIsDelete = 0 ORDER BY bndBrandName");
        }

        public DataTable GetAllModels()
        {
            return Query("SELECT * FROM Models");
        }

        public DataTable GetAllPackageUnits()
        {
            return Query("SELECT * FROM PackageUnits");
        }

        public DataTable GetAllProducts()
        {
            return Query("SELECT * FROM vwProducts WHERE pdtIsDelete = 0");
        }

        public string GetNextProductId()
        {
            return "PDT-" + Query("SELECT ISNULL(MAX(RIGHT(pdtProductID, 6)), 0) + 1 FROM Products").Rows[0][0].ToString().PadLeft(6, '0');
        }

        public bool IsRefferedInSales(string pdtProductId)
        {
            return Query($"SELECT * FROM vwSaleDetails WHERE prdProductId = '{pdtProductId}'").Rows.Count > 0;
        }

        public bool IsRefferedInPurchases(string pdtProductId)
        {
            return Query($"SELECT * FROM vwPurchaseDetails WHERE prdProductId = '{pdtProductId}'").Rows.Count > 0;
        }

        public bool InsertProduct(string pdtProductId, string pdtProductName, string pdtProductCategoryId, string pdtBrandId, string pdtModel, string pdtPackageUnit, string pdtUnitPrice, string pdtVAT, string pdtReorderLevel, string pdtBarcode, string pdtIsActive, string pdtInsertBy)
        {
            return Command($"INSERT INTO Products (pdtProductID, pdtProductName, pdtProductCategoryID, pdtBrandID, pdtModel, pdtPackageUnit, pdtUnitPrice, pdtVAT, pdtReorderLevel, pdtBarcode, pdtIsActive, pdtInsertBy, pdtInsertDate) Values ('{pdtProductId}','{pdtProductName}','{pdtProductCategoryId}','{pdtBrandId}','{pdtModel}','{pdtPackageUnit}',{pdtUnitPrice},{pdtVAT},{pdtReorderLevel},'{pdtBarcode}',{pdtIsActive},'{pdtInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateProduct(string pdtProductId, string pdtProductName, string pdtProductCategoryId, string pdtBrandId, string pdtModel, string pdtPackageUnit, string pdtUnitPrice, string pdtVAT, string pdtReorderLevel, string pdtBarcode, string pdtIsActive, string pdtUpdateBy)
        {
            return Command($"UPDATE Products SET pdtProductName = '{pdtProductName}', pdtProductCategoryId = '{pdtProductCategoryId}', pdtBrandId = '{pdtBrandId}', pdtModel = '{pdtModel}', pdtPackageUnit = '{pdtPackageUnit}', pdtUnitPrice = {pdtUnitPrice}, pdtVAT = {pdtVAT}, pdtReorderLevel = {pdtReorderLevel}, pdtBarcode = '{pdtBarcode}', pdtIsActive = {pdtIsActive}, pdtUpdateBy = '{pdtUpdateBy}', pdtUpdateDate = '{DateTime.Now}' WHERE pdtProductID = '{pdtProductId}'");
        }

        public bool DeleteProduct(string pdtProductId, string pdtDeleteBy)
        {
            return Command($"UPDATE Products SET pdtIsDelete = 1, pdtDeleteBy = '{pdtDeleteBy}', pdtDeleteDate = '{DateTime.Now}' WHERE pdtProductID = '{pdtProductId}'");
        }

        public void InsertModel(string mdlModelName)
        {
            if (Query($"SELECT * FROM Models WHERE mdlModelName = '{mdlModelName}'").Rows.Count == 0)
            {
                BeginTran();
                Command($"INSERT INTO Models VALUES ('{mdlModelName}')");
                CommitTran();
            }
        }

        public void InsertPackageUnit(string pkgUnitName)
        {
            if (Query($"SELECT * FROM PackageUnits WHERE pkgUnitName = '{pkgUnitName}'").Rows.Count == 0)
            {
                BeginTran();
                Command($"INSERT INTO PackageUnits VALUES ('{pkgUnitName}')");
                CommitTran();
            }
        }
    }
}
