using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;
using FastReport;

namespace TradeManagement.Forms
{
    public partial class frmExpenseCategories : XtraForm
    {
        readonly clsExpenseCategories _expenseCategories = new clsExpenseCategories();
        static bool _isNew;

        public frmExpenseCategories()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtExpenseCategoryID.Text = string.Empty;
            txtExpenseCategoryName.Text = string.Empty;
            chkActive.Checked = false;
        }

        private void MakeEnable(bool enable)
        {
            bbtnNew.Enabled = enable;
            bbtnEdit.Enabled = enable;
            bbtnDelete.Enabled = enable;
            bbtnRefresh.Enabled = enable;
            bbtnSave.Enabled = !enable;
            bbtnCancel.Enabled = !enable;
            grpMain.Enabled = !enable;
        }

        private void BindGrid()
        {
            grdExpenseCategories.DataSource = _expenseCategories.GetAllExpenseCategories();
            gvwExpenseCategories.ExpandAllGroups();
        }

        private void frmExpenseCategories_Load(object sender, EventArgs e)
        {
            var permission = _expenseCategories.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("EctN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("EctN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("EctE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("EctE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("EctD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("EctD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            BindGrid();
        }

        private void grdExpenseCategories_Click(object sender, EventArgs e)
        {
            if (grpMain.Enabled) return;
            MakeEmpty();
            if (!gvwExpenseCategories.IsDataRow(gvwExpenseCategories.FocusedRowHandle)) return;
            txtExpenseCategoryID.Text = gvwExpenseCategories.GetRowCellValue(gvwExpenseCategories.FocusedRowHandle, "ectExpenseCategoryId").ToString();
            txtExpenseCategoryName.Text = gvwExpenseCategories.GetRowCellValue(gvwExpenseCategories.FocusedRowHandle, "ectExpenseCategoryName").ToString();
            chkActive.Checked = Convert.ToBoolean(gvwExpenseCategories.GetRowCellValue(gvwExpenseCategories.FocusedRowHandle, "ectIsActive"));
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            txtExpenseCategoryID.Text = _expenseCategories.GetNextExpenseCategoryId();
            chkActive.Checked = true;
            MakeEnable(false);
            txtExpenseCategoryName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwExpenseCategories.IsDataRow(gvwExpenseCategories.FocusedRowHandle)) return;
            _isNew = false;
            MakeEnable(false);
            txtExpenseCategoryName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            _expenseCategories.BeginTran();
            if (_isNew)
            {
                if (_expenseCategories.InsertExpenseCategory(txtExpenseCategoryID.Text, txtExpenseCategoryName.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _expenseCategories.CommitTran();
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
                    _expenseCategories.RollbackTran();
                }
            }
            else
            {
                if (_expenseCategories.UpdateExpenseCategory(txtExpenseCategoryID.Text, txtExpenseCategoryName.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _expenseCategories.CommitTran();
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
                    _expenseCategories.RollbackTran();
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
            if (!gvwExpenseCategories.IsDataRow(gvwExpenseCategories.FocusedRowHandle)) return;
            if (gvwExpenseCategories.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected expense category?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_expenseCategories.IsRefferedInExpenses((gvwExpenseCategories.GetRowCellValue(gvwExpenseCategories.FocusedRowHandle, "ectExpenseCategoryId").ToString())))
                {
                    XtraMessageBox.Show("Cannot delete the category. Found a reference in Expenses.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _expenseCategories.BeginTran();
                if (_expenseCategories.DeleteExpenseCategory(gvwExpenseCategories.GetRowCellValue(gvwExpenseCategories.FocusedRowHandle, "ectExpenseCategoryId").ToString(), Program.UserName))
                {
                    _expenseCategories.CommitTran();
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
                    _expenseCategories.RollbackTran();
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
    }
}