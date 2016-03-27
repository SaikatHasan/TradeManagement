using System;
using System.Data;

namespace TradeManagement_DAL
{
    public class clsProductCategories : clsCommon
    {
        public DataTable GetAllProductCategories()
        {
            return Query("SELECT * FROM ProductCategories WHERE pctIsDelete = 0");
        }

        public string GetNextProductCategoryId()
        {
            return "PCT-" + Query("SELECT ISNULL(MAX(RIGHT(pctProductCategoryId, 3)), 0) + 1 FROM ProductCategories").Rows[0][0].ToString().PadLeft(3, '0');
        }

        public bool IsRefferedInProducts(string pctProductCategoryId)
        {
            return Query($"SELECT * FROM Products WHERE pdtProductCategoryId = '{pctProductCategoryId}'").Rows.Count > 0;
        }

        public bool InsertProductCategory(string pctProductCategoryId, string pctProductCategoryName, string pctIsActive, string pctInsertBy)
        {
            return Command(
                $"INSERT INTO ProductCategories (pctProductCategoryId, pctProductCategoryName, pctIsActive, pctInsertBy, pctInsertDate) Values ('{pctProductCategoryId}','{pctProductCategoryName}',{pctIsActive},'{pctInsertBy}','{DateTime.Now}')");
        }

        public bool UpdateProductCategory(string pctProductCategoryId, string pctProductCategoryName, string pctIsActive, string pctUpdateBy)
        {
            return Command(
                $"UPDATE ProductCategories SET pctProductCategoryName = '{pctProductCategoryName}', pctIsActive = {pctIsActive}, pctUpdateBy = '{pctUpdateBy}', pctUpdateDate = '{DateTime.Now}' WHERE pctProductCategoryId = '{pctProductCategoryId}'");
        }

        public bool DeleteProductCategory(string pctProductCategoryId, string pctDeleteBy)
        {
            return Command(
                $"UPDATE ProductCategories SET pctIsDelete = 1, pctDeleteBy = '{pctDeleteBy}', pctDeleteDate = '{DateTime.Now}' WHERE pctProductCategoryId = '{pctProductCategoryId}'");
        }
    }
}
