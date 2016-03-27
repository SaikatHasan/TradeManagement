using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmExpenses : XtraForm
    {
        readonly clsExpenses _expenses = new clsExpenses();
        static bool _isNew;

        public frmExpenses()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            dtpExpenseDate.EditValue = null;
            cmbCategory.EditValue = null;
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
            grpSearch.Enabled = enable;
        }

        private void frmDailyExpenses_Load(object sender, EventArgs e)
        {
            var permission = _expenses.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("ExpN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("ExpN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("ExpE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("ExpE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("ExpD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("ExpD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            cmbCategory.Properties.DataSource = _expenses.GetAllExpenseCategories();
            cmbSCategory.Properties.DataSource = _expenses.GetAllExpenseCategories();
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            dtpSDate.EditValue = null;
            cmbSCategory.EditValue = null;
            grdSearch.DataSource = null;
            dtpExpenseDate.DateTime = DateTime.Today;
            MakeEnable(false);
            cmbCategory.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwSearch.IsDataRow(gvwSearch.FocusedRowHandle)) return;
            _isNew = false;
            MakeEnable(false);
            cmbCategory.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var expenseId = _expenses.GetNextExpenseId();
            _expenses.BeginTran();
            if (_isNew)
            {
                if (_expenses.InsertExpenses(expenseId, dtpExpenseDate.DateTime, cmbCategory.EditValue.ToString(), txtDescription.EditValue.ToString(), txtAmount.EditValue.ToString(), Program.UserName))
                {
                    _expenses.CommitTran();
                    MakeEmpty();
                    dtpSDate.EditValue = null;
                    cmbSCategory.EditValue = null;
                    grdSearch.DataSource = null;
                    MakeEnable(true);
                    sitmStatus.Caption = Resources.SaveSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _expenses.RollbackTran();
                }
            }
            else
            {
                if (_expenses.UpdateExpenses(gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "expExpenseId").ToString(), dtpExpenseDate.DateTime, cmbCategory.EditValue.ToString(), txtDescription.EditValue.ToString(), txtAmount.EditValue.ToString(), Program.UserName))
                {
                    _expenses.CommitTran();
                    MakeEmpty();
                    dtpSDate.EditValue = null;
                    cmbSCategory.EditValue = null;
                    grdSearch.DataSource = null;
                    MakeEnable(true);
                    sitmStatus.Caption = Resources.UpdateSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _expenses.RollbackTran();
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
            if (!gvwSearch.IsDataRow(gvwSearch.FocusedRowHandle)) return;
            if (gvwSearch.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected data?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _expenses.BeginTran();
                if (_expenses.DeleteExpenses(gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "expExpenseId").ToString(), Program.UserName))
                {
                    _expenses.CommitTran();
                    MakeEmpty();
                    dtpSDate.EditValue = null;
                    cmbSCategory.EditValue = null;
                    grdSearch.DataSource = null;
                    sitmStatus.Caption = Resources.DeleteSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.DeleteFail;
                    sitmStatus.Glyph = Resources.Error;
                    _expenses.RollbackTran();
                }
            }
            else
            {
                sitmStatus.Caption = Resources.OperationCancel;
                sitmStatus.Glyph = Resources.Warning;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            if (dtpSDate.EditValue != null && cmbSCategory.EditValue != null)
                dt = _expenses.SearchExpensesByDateAndCategory(dtpSDate.DateTime, cmbSCategory.EditValue.ToString());
            else if (dtpSDate.EditValue != null && cmbSCategory.EditValue == null)
                dt = _expenses.SearchExpensesByDate(dtpSDate.DateTime);
            else if (dtpSDate.EditValue == null && cmbSCategory.EditValue != null)
                dt = _expenses.SearchExpensesByCategory(cmbSCategory.EditValue.ToString());
            if (dt.Rows.Count <= 0)
            {
                XtraMessageBox.Show("No data found for the condition.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                sitmStatus.Caption = Resources.NoData;
                sitmStatus.Glyph = Resources.Warning;
                return;
            }
            grdSearch.DataSource = dt;
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void grdSearch_Click(object sender, EventArgs e)
        {
            MakeEmpty();
            if (!gvwSearch.IsDataRow(gvwSearch.FocusedRowHandle)) return;
            dtpExpenseDate.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "expExpenseDate");
            cmbCategory.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "expExpenseCategoryId");
            txtDescription.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "expDescription");
            txtAmount.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "expAmount");
        }
    }
}