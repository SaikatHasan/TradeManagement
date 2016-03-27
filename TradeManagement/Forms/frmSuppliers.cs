using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using FastReport.Utils;
using TradeManagement.Properties;
using TradeManagement_DAL;
using FastReport;

namespace TradeManagement.Forms
{
    public partial class frmSuppliers : XtraForm
    {
        readonly clsSuppliers _suppliers = new clsSuppliers();
        static bool _isNew;

        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtMobile1.Text = string.Empty;
            txtMobile2.Text = string.Empty;
            txtLandPhone.Text = string.Empty;
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
        }

        private void BindGrid()
        {
            var permission = _suppliers.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("SupN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("SupN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("SupE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("SupE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("SupD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("SupD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            grdSuppliers.DataSource = _suppliers.GetAllSuppliers();
            gvwSuppliers.ExpandAllGroups();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void grdSuppliers_Click(object sender, EventArgs e)
        {
            MakeEmpty();
            if (!gvwSuppliers.IsDataRow(gvwSuppliers.FocusedRowHandle)) return;
            txtSupplierID.Text = gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supSupplierId").ToString();
            txtSupplierName.Text = gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supSupplierName").ToString();
            txtContactPerson.Text = gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supContactPerson").ToString();
            txtAddress.Text = gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supAddress").ToString();
            txtMobile1.Text = gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supMobile1").ToString();
            txtMobile2.Text = gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supMobile2").ToString();
            txtLandPhone.Text = gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supLandPhone").ToString();
            chkActive.Checked = Convert.ToBoolean(gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supIsActive"));
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            txtSupplierID.Text = _suppliers.GetNextSupplierId();
            MakeEnable(false);
            txtSupplierName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwSuppliers.IsDataRow(gvwSuppliers.FocusedRowHandle)) return;
            _isNew = false;
            MakeEnable(false);
            txtSupplierName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            _suppliers.BeginTran();
            if (_isNew)
            {
                if (_suppliers.InsertSupplier(txtSupplierID.Text, txtSupplierName.Text, txtAddress.Text, txtContactPerson.Text, txtLandPhone.Text, txtMobile1.Text, txtMobile2.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _suppliers.CommitTran();
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
                    _suppliers.RollbackTran();
                }
            }
            else
            {
                if (_suppliers.UpdateSupplier(txtSupplierID.Text, txtSupplierName.Text, txtAddress.Text, txtContactPerson.Text, txtLandPhone.Text, txtMobile1.Text, txtMobile2.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _suppliers.CommitTran();
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
                    _suppliers.RollbackTran();
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
            if (!gvwSuppliers.IsDataRow(gvwSuppliers.FocusedRowHandle)) return;
            if (gvwSuppliers.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected supplier?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_suppliers.IsRefferedInPurchases((gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supSupplierId").ToString())))
                {
                    XtraMessageBox.Show("Cannot delete the supplier. Found a reference in Purchase.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _suppliers.BeginTran();
                if (_suppliers.DeleteSupplier(gvwSuppliers.GetRowCellValue(gvwSuppliers.FocusedRowHandle, "supSupplierId").ToString(), Program.UserName))
                {
                    _suppliers.CommitTran();
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
                    _suppliers.RollbackTran();
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
                report.Load(@"Reports\rptSuppliers.frx");
                report.RegisterData(_suppliers.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_suppliers.GetAllSuppliers(), "Suppliers");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("Suppliers").Enabled = true;
                report.Show();
            }
        }
    }
}