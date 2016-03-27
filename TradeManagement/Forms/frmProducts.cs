using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;
using FastReport;

namespace TradeManagement.Forms
{
    public partial class frmProducts : XtraForm
    {readonly clsProducts _products = new clsProducts();
        static bool _isNew;

        public frmProducts()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            cmbCategory.EditValue = string.Empty;
            cmbBrand.EditValue = string.Empty;
            cmbModel.EditValue = string.Empty;
            cmbPackageUnit.EditValue = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtVAT.Text = string.Empty;
            txtReorderLevel.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            chkActive.Checked = false;
        }

        private void MakeEnable(bool enable)
        {
            bbtnNew.Enabled = enable;
            bbtnEdit.Enabled = enable;
            bbtnDelete.Enabled = enable;
            bbtnRefresh.Enabled = enable;
            bbtnPrint.Enabled = enable;
            bbtnSave.Enabled = !enable;
            bbtnCancel.Enabled = !enable;
            grpMain.Enabled = !enable;
        }

        private void BindGrid()
        {
            grdProducts.DataSource = _products.GetAllProducts();
            gvwProducts.ExpandAllGroups();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            var permission = _products.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("PdtN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("PdtN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("PdtE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("PdtE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("PdtD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("PdtD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            cmbCategory.Properties.DataSource = _products.GetAllProductCategories();
            cmbBrand.Properties.DataSource = _products.GetAllBrands();
            foreach (DataRow dataRow in _products.GetAllModels().Rows)
                cmbModel.Properties.Items.Add(dataRow["mdlModelName"].ToString());
            foreach (DataRow dataRow in _products.GetAllPackageUnits().Rows)
                cmbPackageUnit.Properties.Items.Add(dataRow["pkgUnitName"].ToString());
            BindGrid();
        }

        private void grdProducts_Click(object sender, EventArgs e)
        {
            if (grpMain.Enabled) return;
            MakeEmpty();
            if (!gvwProducts.IsDataRow(gvwProducts.FocusedRowHandle)) return;
            txtProductID.Text = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString();
            txtProductName.Text = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductName").ToString();
            cmbCategory.EditValue = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductCategoryId").ToString();
            cmbBrand.EditValue = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtBrandId").ToString();
            cmbModel.EditValue = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtModel").ToString();
            cmbPackageUnit.EditValue = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtPackageUnit").ToString();
            txtUnitPrice.Text = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtUnitPrice").ToString();
            txtVAT.Text = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtVAT").ToString();
            txtReorderLevel.Text = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtReorderLevel").ToString();
            txtBarcode.Text = gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtBarcode").ToString();
            chkActive.Checked = Convert.ToBoolean(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtIsActive"));
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            txtProductID.Text = _products.GetNextProductId();
            chkActive.Checked = true;
            MakeEnable(false);
            txtProductName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwProducts.IsDataRow(gvwProducts.FocusedRowHandle)) return;
            _isNew = false;
            MakeEnable(false);
            txtProductName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            _products.BeginTran();
            if (_isNew)
            {
                if (_products.InsertProduct(txtProductID.Text, txtProductName.Text, cmbCategory.EditValue.ToString(), cmbBrand.EditValue.ToString(), cmbModel.EditValue.ToString(), cmbPackageUnit.EditValue.ToString(), txtUnitPrice.Text, txtVAT.Text, txtReorderLevel.Text, (txtBarcode.Text.Trim() == string.Empty ? txtProductID.Text.Substring(4) : txtBarcode.Text), (chkActive.Checked ? "1" : "0"), Program.UserName))
                {
                    _products.CommitTran();
                    _products.InsertModel(cmbModel.EditValue.ToString());
                    _products.InsertPackageUnit(cmbPackageUnit.EditValue.ToString());
                    cmbModel.Properties.Items.Clear();
                    cmbPackageUnit.Properties.Items.Clear();
                    foreach (DataRow dataRow in _products.GetAllModels().Rows)
                        cmbModel.Properties.Items.Add(dataRow["mdlModelName"].ToString());
                    foreach (DataRow dataRow in _products.GetAllPackageUnits().Rows)
                        cmbPackageUnit.Properties.Items.Add(dataRow["pkgUnitName"].ToString());
                    BindGrid();
                    MakeEmpty();
                    MakeEnable(true);
                    sitmStatus.Caption = Resources.SaveSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _products.RollbackTran();
                }
            }
            else
            {
                if (_products.UpdateProduct(txtProductID.Text, txtProductName.Text, cmbCategory.EditValue.ToString(), cmbBrand.EditValue.ToString(), cmbModel.EditValue.ToString(), cmbPackageUnit.EditValue.ToString(), txtUnitPrice.Text, txtVAT.Text, txtReorderLevel.Text, (txtBarcode.Text.Trim() == string.Empty ? txtProductID.Text.Substring(4) : txtBarcode.Text), (chkActive.Checked ? "1" : "0"), Program.UserName))
                {
                    _products.CommitTran();
                    _products.InsertModel(cmbModel.EditValue.ToString());
                    _products.InsertPackageUnit(cmbPackageUnit.EditValue.ToString());
                    cmbModel.Properties.Items.Clear();
                    cmbPackageUnit.Properties.Items.Clear();
                    foreach (DataRow dataRow in _products.GetAllModels().Rows)
                        cmbModel.Properties.Items.Add(dataRow["mdlModelName"].ToString());
                    foreach (DataRow dataRow in _products.GetAllPackageUnits().Rows)
                        cmbPackageUnit.Properties.Items.Add(dataRow["pkgUnitName"].ToString());
                    BindGrid();
                    MakeEmpty();
                    MakeEnable(true);
                    sitmStatus.Caption = Resources.UpdateSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _products.RollbackTran();
                }
            }
        }

        private void bbtnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            BindGrid();
            MakeEmpty();
            MakeEnable(true);
            sitmStatus.Caption = Resources.OperationCancel;
            sitmStatus.Glyph = Resources.Warning;
        }

        private void bbtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwProducts.IsDataRow(gvwProducts.FocusedRowHandle)) return;
            if (gvwProducts.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected product?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_products.IsRefferedInSales((gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString())))
                {
                    XtraMessageBox.Show("Cannot delete the product. Found a reference in Sales.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_products.IsRefferedInPurchases((gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString())))
                {
                    XtraMessageBox.Show("Cannot delete the product. Found a reference in Purchase.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _products.BeginTran();
                if (_products.DeleteProduct(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString(), Program.UserName))
                {
                    _products.CommitTran();
                    BindGrid();
                    MakeEmpty();
                    sitmStatus.Caption = Resources.DeleteSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.DeleteFail;
                    sitmStatus.Glyph = Resources.Error;
                    _products.RollbackTran();
                }
            }
            else
            {
                sitmStatus.Caption = Resources.OperationCancel;
                sitmStatus.Glyph = Resources.Warning;
            }
        }

        private void bbtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            BindGrid();
            MakeEmpty();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var report = new Report())
            {
                report.Load(@"Reports\rptProducts.frx");
                report.RegisterData(_products.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_products.GetAllProducts(), "vwProducts");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("vwProducts").Enabled = true;
                report.Show();
            }
        }

        private void gvwProducts_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (!gvwProducts.IsDataRow(e.RowHandle)) return;
            if (Convert.ToInt32(gvwProducts.GetRowCellValue(e.RowHandle, "pdtStockQuantity")) <=
                Convert.ToInt32(gvwProducts.GetRowCellValue(e.RowHandle, "pdtReorderLevel")))
                e.Appearance.BackColor = Color.Salmon;
        }

        private void bbtnPrintBarcode_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwProducts.IsDataRow(gvwProducts.FocusedRowHandle)) return;
            var dtBarcode = new DataTable();
            dtBarcode.Columns.Add("colCompanyName");
            dtBarcode.Columns.Add("colBarcode");
            dtBarcode.Columns.Add("colModel");
            dtBarcode.Columns.Add("colPrice");
            var barcodeCount = new frmBarcodeCount();
            if(barcodeCount.ShowDialog() != DialogResult.OK) return;
            var companyName = _products.GetCompanyInformation().Rows[0]["cmpCompanyName"].ToString();
            for (var i = 0; i < Convert.ToInt32(barcodeCount.txtCount.EditValue); i++)
            {
                object[] row = { companyName, gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtBarcode"), gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtModel"), gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtUnitPrice") };
                dtBarcode.Rows.Add(row);
            }
            //dtBarcode.TableName = "Barcode";
            //dtBarcode.WriteXmlSchema(@"Reports\Barcode.xml");
            //return;

            using (var report = new Report())
            {
                report.Load(@"Reports\rptBarcode.frx");
                report.RegisterData(dtBarcode, "Barcode");
                report.GetDataSource("Barcode").Enabled = true;
                report.Show();
            }

            //using (var report = new Report())
            //{
            //    report.RegisterData(dtBarcode, "dtBarcode");
            //    report.GetDataSource("dtBarcode").Enabled = true;

            //    var page = new ReportPage();
            //    page.CreateUniqueName();
            //    page.TopMargin = 10.0f;
            //    page.LeftMargin = 10.0f;
            //    page.RightMargin = 10.0f;
            //    page.BottomMargin = 7.0f;
            //    report.Pages.Add(page);

            //    var band = new DataBand();
            //    page.Bands.Add(band);
            //    band.CreateUniqueName();
            //    band.DataSource = report.GetDataSource("dtBarcode");
            //    band.Height = 2.0f * Units.Centimeters;
            //    if (gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtBarcode").ToString().Length < 7)
            //        band.Columns.Count = 7;
            //    else if (gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtBarcode").ToString().Length < 9)
            //        band.Columns.Count = 5;
            //    else if (gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtBarcode").ToString().Length < 11)
            //        band.Columns.Count = 4;
            //    else
            //        band.Columns.Count = 3;

            //    var companyNameT = new TextObject();
            //    companyNameT.CreateUniqueName();
            //    companyNameT.HorzAlign = HorzAlign.Center;
            //    companyNameT.Font = new Font("Arial", 10.0f, FontStyle.Bold);
            //    if (gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtBarcode").ToString().Length < 7)
            //        companyNameT.Bounds = new RectangleF(0.0f, 0.0f, 2.71f * Units.Centimeters, .40f * Units.Centimeters);
            //    else if (gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtBarcode").ToString().Length < 9)
            //        companyNameT.Bounds = new RectangleF(0.0f, 0.0f, 3.80f * Units.Centimeters, .40f * Units.Centimeters);
            //    else if (gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtBarcode").ToString().Length < 11)
            //        companyNameT.Bounds = new RectangleF(0.0f, 0.0f, 4.75f * Units.Centimeters, .40f * Units.Centimeters);
            //    else
            //        companyNameT.Bounds = new RectangleF(0.0f, 0.0f, 6.33f * Units.Centimeters, .40f * Units.Centimeters);
            //    companyNameT.Text = "[dtBarcode.colCompanyName]";
            //    band.AddChild(companyNameT);

            //    var barcode = new BarcodeObject();
            //    barcode.CreateUniqueName();
            //    barcode.Height = 1.20f * Units.Centimeters;
            //    barcode.Top = .40f * Units.Centimeters;
            //    barcode.Left = .25f * Units.Centimeters;
            //    barcode.Barcode = new Barcode128();
            //    barcode.DataColumn = "dtBarcode.colBarcode";
            //    band.AddChild(barcode);

            //    var model = new TextObject();
            //    model.CreateUniqueName();
            //    model.Bounds = new RectangleF(0.20f, 1.50f * Units.Centimeters, 1.50f * Units.Centimeters, .40f * Units.Centimeters);
            //    model.Text = "[dtBarcode.colModel]";
            //    band.AddChild(model);

            //    var price = new TextObject();
            //    price.CreateUniqueName();
            //    price.HorzAlign = HorzAlign.Right;
            //    price.Bounds = new RectangleF(3.50f, 1.50f * Units.Centimeters, 1.50f * Units.Centimeters, .40f * Units.Centimeters);
            //    price.Text = "[dtBarcode.colPrice]";
            //    band.AddChild(price);

            //    report.Show();
            //}
        }
    }
}