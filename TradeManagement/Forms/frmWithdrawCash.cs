using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmWithdrawCash : XtraForm
    {
        readonly clsWithdrawCash _withdrawCash = new clsWithdrawCash();
        static bool _isNew;

        public frmWithdrawCash()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            dtpDate.EditValue = null;
            txtDescription.EditValue = null;
            txtAmount.EditValue = null;
        }

        private void MakeEnable(bool enable)
        {
            bbtnNew.Enabled = enable;
            bbtnEdit.Enabled = enable;
            bbtnDelete.Enabled = enable;
            bbtnSave.Enabled = !enable;
            bbtnCancel.Enabled = !enable;
            grpMain.Enabled = !enable;
        }

        private void BindGrid()
        {
            grdWithdrawCash.DataSource = _withdrawCash.GetAllData();
        }

        private void frmWithdrawCash_Load(object sender, EventArgs e)
        {
            var permission = _withdrawCash.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("WdcN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("WdcN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("WdcE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("WdcE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("WdcD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("WdcD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            BindGrid();
        }

        private void grdWithdrawCash_Click(object sender, EventArgs e)
        {
            if (grpMain.Enabled) return;
            MakeEmpty();
            if (!gvwWithdrawCash.IsDataRow(gvwWithdrawCash.FocusedRowHandle)) return;
            dtpDate.DateTime = Convert.ToDateTime(gvwWithdrawCash.GetRowCellValue(gvwWithdrawCash.FocusedRowHandle, "wdcDate").ToString());
            txtDescription.EditValue = gvwWithdrawCash.GetRowCellValue(gvwWithdrawCash.FocusedRowHandle, "wdcDescription").ToString();
            txtAmount.EditValue = gvwWithdrawCash.GetRowCellValue(gvwWithdrawCash.FocusedRowHandle, "wdcAmount");

        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            dtpDate.DateTime = DateTime.Today;
            MakeEnable(false);
            txtDescription.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwWithdrawCash.IsDataRow(gvwWithdrawCash.FocusedRowHandle)) return;
            if (gvwWithdrawCash.SelectedRowsCount <= 0) return;
            _isNew = false;
            MakeEnable(false);
            txtDescription.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            _withdrawCash.BeginTran();
            if (_isNew)
            {
                if (_withdrawCash.InsertWithdrawCash(dtpDate.DateTime, txtDescription.EditValue.ToString(), txtAmount.EditValue.ToString(), Program.UserName))
                {
                    _withdrawCash.CommitTran();
                    MakeEmpty();
                    BindGrid();
                    MakeEnable(true);
                    sitmStatus.Caption = Resources.SaveSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _withdrawCash.RollbackTran();
                }
            }
            else
            {
                if (_withdrawCash.UpdateWithdrawCash(gvwWithdrawCash.GetRowCellValue(gvwWithdrawCash.FocusedRowHandle, "wdcId").ToString(), dtpDate.DateTime, txtDescription.EditValue.ToString(), txtAmount.EditValue.ToString(), Program.UserName))
                {
                    _withdrawCash.CommitTran();
                    MakeEmpty();
                    BindGrid();
                    MakeEnable(true);
                    sitmStatus.Caption = Resources.UpdateSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _withdrawCash.RollbackTran();
                }
            }
        }

        private void bbtnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            MakeEmpty();
            MakeEnable(true);
            sitmStatus.Caption = Resources.OperationCancel;
            sitmStatus.Glyph = Resources.Warning;
        }

        private void bbtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwWithdrawCash.IsDataRow(gvwWithdrawCash.FocusedRowHandle)) return;
            if (gvwWithdrawCash.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected data?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _withdrawCash.BeginTran();
                if (_withdrawCash.DeleteWithdrawCash(gvwWithdrawCash.GetRowCellValue(gvwWithdrawCash.FocusedRowHandle, "wdcId").ToString(), Program.UserName))
                {
                    _withdrawCash.CommitTran();
                    MakeEmpty();
                    BindGrid();
                    sitmStatus.Caption = Resources.DeleteSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.DeleteFail;
                    sitmStatus.Glyph = Resources.Error;
                    _withdrawCash.RollbackTran();
                }
            }
            else
            {
                sitmStatus.Caption = Resources.OperationCancel;
                sitmStatus.Glyph = Resources.Warning;
            }
        }
    }
}