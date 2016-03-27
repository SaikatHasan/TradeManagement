using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using FastReport;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmBrands : XtraForm
    {
        private static bool _isNew;
        private readonly clsBrands _brands = new clsBrands();

        public frmBrands()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtBrandID.Text = string.Empty;
            txtBrandName.Text = string.Empty;
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
            grdBrands.DataSource = _brands.GetAllBrands();
        }

        private void frmBrands_Load(object sender, EventArgs e)
        {
            var permission = _brands.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("BndN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("BndN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("BndE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("BndE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("BndD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("BndD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            BindGrid();
        }

        private void grdBrands_Click(object sender, EventArgs e)
        {
            if (grpMain.Enabled) return;
            MakeEmpty();
            if (!gvwBrands.IsDataRow(gvwBrands.FocusedRowHandle)) return;
            txtBrandID.Text = gvwBrands.GetRowCellValue(gvwBrands.FocusedRowHandle, "bndBrandId").ToString();
            txtBrandName.Text = gvwBrands.GetRowCellValue(gvwBrands.FocusedRowHandle, "bndBrandName").ToString();
            chkActive.Checked = Convert.ToBoolean(gvwBrands.GetRowCellValue(gvwBrands.FocusedRowHandle, "bndIsActive"));
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            txtBrandID.Text = _brands.GetNextBrandId();
            chkActive.Checked = true;
            MakeEnable(false);
            txtBrandName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwBrands.IsDataRow(gvwBrands.FocusedRowHandle)) return;
            _isNew = false;
            MakeEnable(false);
            txtBrandName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            _brands.BeginTran();
            if (_isNew)
            {
                if (_brands.InsertBrand(txtBrandID.Text, txtBrandName.Text, chkActive.Checked ? "1" : "0",
                    Program.UserName))
                {
                    _brands.CommitTran();
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
                    _brands.RollbackTran();
                }
            }
            else
            {
                if (_brands.UpdateBrand(txtBrandID.Text, txtBrandName.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _brands.CommitTran();
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
                    _brands.RollbackTran();
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
            if (!gvwBrands.IsDataRow(gvwBrands.FocusedRowHandle)) return;
            if (gvwBrands.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected brand?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_brands.IsRefferedInProducts((gvwBrands.GetRowCellValue(gvwBrands.FocusedRowHandle, "bndBrandId").ToString())))
                {
                    XtraMessageBox.Show("Cannot delete the brand. Found a reference in Products.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _brands.BeginTran();
                if (_brands.DeleteBrand(gvwBrands.GetRowCellValue(gvwBrands.FocusedRowHandle, "bndBrandId").ToString(), Program.UserName))
                {
                    _brands.CommitTran();
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
                    _brands.RollbackTran();
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
                report.Load(@"Reports\rptBrands.frx");
                report.RegisterData(_brands.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_brands.GetAllBrands(), "Brands");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("Brands").Enabled = true;
                report.Show();
            }
        }
    }
}