using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using FastReport;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmBankAccounts : XtraForm
    {
        private static bool _isNew;
        private readonly clsBankAccounts _bankAccounts = new clsBankAccounts();

        public frmBankAccounts()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtBankID.Text = string.Empty;
            txtBankName.Text = string.Empty;
            txtAccountNo.Text = string.Empty;
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
            grdBankAccounts.DataSource = _bankAccounts.GetAllBankAccounts();
        }

        private void frmBanks_Load(object sender, EventArgs e)
        {
            var permission = _bankAccounts.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("BacN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("BacN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("BacE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("BacE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("BacD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("BacD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            BindGrid();
        }

        private void grdBanks_Click(object sender, EventArgs e)
        {
            if (grpMain.Enabled) return;
            MakeEmpty();
            if (!gvwBankAccountss.IsDataRow(gvwBankAccountss.FocusedRowHandle)) return;
            txtBankID.Text = gvwBankAccountss.GetRowCellValue(gvwBankAccountss.FocusedRowHandle, "bacAccountId").ToString();
            txtBankName.Text = gvwBankAccountss.GetRowCellValue(gvwBankAccountss.FocusedRowHandle, "bacBankName").ToString();
            txtAccountNo.Text = gvwBankAccountss.GetRowCellValue(gvwBankAccountss.FocusedRowHandle, "bacAccountNo").ToString();
            chkActive.Checked = Convert.ToBoolean(gvwBankAccountss.GetRowCellValue(gvwBankAccountss.FocusedRowHandle, "bacIsActive"));
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            txtBankID.Text = _bankAccounts.GetNextBankAccountId();
            chkActive.Checked = true;
            MakeEnable(false);
            txtBankName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwBankAccountss.IsDataRow(gvwBankAccountss.FocusedRowHandle)) return;
            _isNew = false;
            MakeEnable(false);
            txtBankName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            _bankAccounts.BeginTran();
            if (_isNew)
            {
                if (_bankAccounts.InsertBank(txtBankID.Text, txtBankName.Text, txtAccountNo.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _bankAccounts.CommitTran();
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
                    _bankAccounts.RollbackTran();
                }
            }
            else
            {
                if (_bankAccounts.UpdateBank(txtBankID.Text, txtBankName.Text, txtAccountNo.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _bankAccounts.CommitTran();
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
                    _bankAccounts.RollbackTran();
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
            if (!gvwBankAccountss.IsDataRow(gvwBankAccountss.FocusedRowHandle)) return;
            if (gvwBankAccountss.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected brand?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_bankAccounts.IsRefferedInPurchases((gvwBankAccountss.GetRowCellValue(gvwBankAccountss.FocusedRowHandle, "bacAccountId").ToString())))
                {
                    XtraMessageBox.Show("Cannot delete the bank. Found a reference in Purchase.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_bankAccounts.IsRefferedInAccountsPayable((gvwBankAccountss.GetRowCellValue(gvwBankAccountss.FocusedRowHandle, "bacAccountId").ToString())))
                {
                    XtraMessageBox.Show("Cannot delete the bank. Found a reference in Account Receivable.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _bankAccounts.BeginTran();
                if (_bankAccounts.DeleteBank(gvwBankAccountss.GetRowCellValue(gvwBankAccountss.FocusedRowHandle, "bacAccountId").ToString(), Program.UserName))
                {
                    _bankAccounts.CommitTran();
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
                    _bankAccounts.RollbackTran();
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
            //using (var report = new Report())
            //{
            //    report.Load(@"Reports\rptBanks.frx");
            //    report.RegisterData(_bankAccounts.GetCompanyInformation(), "CompanyInformation");
            //    report.RegisterData(_bankAccounts.GetAllBankAccounts(), "Banks");
            //    report.GetDataSource("CompanyInformation").Enabled = true;
            //    report.GetDataSource("Banks").Enabled = true;
            //    report.Show();
            //}
        }
    }
}