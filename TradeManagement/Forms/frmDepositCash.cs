using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmDepositCash : XtraForm
    {
        readonly clsDepositCash _depositCash = new clsDepositCash();
        static bool _isNew;

        public frmDepositCash()
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
            grdDepositCash.DataSource = _depositCash.GetAllData();
        }

        private void frmDepositCash_Load(object sender, EventArgs e)
        {
            var permission = _depositCash.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("DpcN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("DpcN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("DpcE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("DpcE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("DpcD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("DpcD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            BindGrid();
        }

        private void grdDepositCash_Click(object sender, EventArgs e)
        {
            if (grpMain.Enabled) return;
            MakeEmpty();
            if (!gvwDepositCash.IsDataRow(gvwDepositCash.FocusedRowHandle)) return;
            dtpDate.DateTime = Convert.ToDateTime(gvwDepositCash.GetRowCellValue(gvwDepositCash.FocusedRowHandle, "dpcDate").ToString());
            txtDescription.EditValue = gvwDepositCash.GetRowCellValue(gvwDepositCash.FocusedRowHandle, "dpcDescription").ToString();
            txtAmount.EditValue = gvwDepositCash.GetRowCellValue(gvwDepositCash.FocusedRowHandle, "dpcAmount");
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
            if (!gvwDepositCash.IsDataRow(gvwDepositCash.FocusedRowHandle)) return;
            if (gvwDepositCash.SelectedRowsCount <= 0) return;
            _isNew = false;
            MakeEnable(false);
            txtDescription.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            _depositCash.BeginTran();
            if (_isNew)
            {
                if (_depositCash.InsertDepositCash(dtpDate.DateTime, txtDescription.EditValue.ToString(), txtAmount.EditValue.ToString(), Program.UserName))
                {
                    _depositCash.CommitTran();
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
                    _depositCash.RollbackTran();
                }
            }
            else
            {
                if (_depositCash.UpdateDepositCash(gvwDepositCash.GetRowCellValue(gvwDepositCash.FocusedRowHandle, "dpcId").ToString(), dtpDate.DateTime, txtDescription.EditValue.ToString(), txtAmount.EditValue.ToString(), Program.UserName))
                {
                    _depositCash.CommitTran();
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
                    _depositCash.RollbackTran();
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
            if (!gvwDepositCash.IsDataRow(gvwDepositCash.FocusedRowHandle)) return;
            if (gvwDepositCash.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected data?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _depositCash.BeginTran();
                if (_depositCash.DeleteDepositCash(gvwDepositCash.GetRowCellValue(gvwDepositCash.FocusedRowHandle, "dpcId").ToString(), Program.UserName))
                {
                    _depositCash.CommitTran();
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
                    _depositCash.RollbackTran();
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