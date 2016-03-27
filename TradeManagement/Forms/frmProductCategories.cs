using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;
using FastReport;

namespace TradeManagement.Forms
{
    public partial class frmProductCategories : XtraForm
    {
        readonly clsProductCategories _productCategories = new clsProductCategories();
        static bool _isNew;

        public frmProductCategories()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtProductCategoryID.Text = string.Empty;
            txtProductCategoryName.Text = string.Empty;
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
            grdProductCategories.DataSource = _productCategories.GetAllProductCategories();
            gvwProductCategories.ExpandAllGroups();
        }

        private void frmProductCategories_Load(object sender, EventArgs e)
        {
            var permission = _productCategories.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("PctN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("PctN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("PctE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("PctE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("PctD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("PctD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            BindGrid();
        }

        private void grdProductCategories_Click(object sender, EventArgs e)
        {
            if (grpMain.Enabled) return;
            MakeEmpty();
            if (!gvwProductCategories.IsDataRow(gvwProductCategories.FocusedRowHandle)) return;
            txtProductCategoryID.Text = gvwProductCategories.GetRowCellValue(gvwProductCategories.FocusedRowHandle, "pctProductCategoryId").ToString();
            txtProductCategoryName.Text = gvwProductCategories.GetRowCellValue(gvwProductCategories.FocusedRowHandle, "pctProductCategoryName").ToString();
            chkActive.Checked = Convert.ToBoolean(gvwProductCategories.GetRowCellValue(gvwProductCategories.FocusedRowHandle, "pctIsActive"));
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            txtProductCategoryID.Text = _productCategories.GetNextProductCategoryId();
            chkActive.Checked = true;
            MakeEnable(false);
            txtProductCategoryName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwProductCategories.IsDataRow(gvwProductCategories.FocusedRowHandle)) return;
            _isNew = false;
            MakeEnable(false);
            txtProductCategoryName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            _productCategories.BeginTran();
            if (_isNew)
            {
                if (_productCategories.InsertProductCategory(txtProductCategoryID.Text, txtProductCategoryName.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _productCategories.CommitTran();
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
                    _productCategories.RollbackTran();
                }
            }
            else
            {
                if (_productCategories.UpdateProductCategory(txtProductCategoryID.Text, txtProductCategoryName.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _productCategories.CommitTran();
                    BindGrid(); MakeEmpty();
                    MakeEnable(true);
                    sitmStatus.Caption = Resources.UpdateSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _productCategories.RollbackTran();
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
            if (!gvwProductCategories.IsDataRow(gvwProductCategories.FocusedRowHandle)) return;
            if (gvwProductCategories.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected product category?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_productCategories.IsRefferedInProducts((gvwProductCategories.GetRowCellValue(gvwProductCategories.FocusedRowHandle, "pctProductCategoryId").ToString())))
                {
                    XtraMessageBox.Show("Cannot delete the category. Found a reference in Products.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _productCategories.BeginTran();
                if (_productCategories.DeleteProductCategory(gvwProductCategories.GetRowCellValue(gvwProductCategories.FocusedRowHandle, "pctProductCategoryId").ToString(), Program.UserName))
                {
                    _productCategories.CommitTran();
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
                    _productCategories.RollbackTran();
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
                report.Load(@"Reports\rptProductCategories.frx");
                report.RegisterData(_productCategories.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_productCategories.GetAllProductCategories(), "ProductCategories");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("ProductCategories").Enabled = true;
                report.Show();
            }
        }
    }
}