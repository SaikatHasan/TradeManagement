using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmAccountsReceivable : XtraForm
    {
        private readonly clsSales _sales = new clsSales();
        private static bool _isNew;

        public frmAccountsReceivable()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtReceivableId.EditValue = null;
            dtpReceivableDate.EditValue = null;
            cmbCustomerName.EditValue = null;
            cmbInvoiceNo.EditValue = null;
            txtTotalAmount.EditValue = null;
            txtDiscount.EditValue = null;
            txtDue.EditValue = null;
            txtAmountPaying.EditValue = null;
            txtRemarks.EditValue = null;
            grdSearch.DataSource = null;
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

        private void frmAccountsReceivable_Load(object sender, EventArgs e)
        {
            var permission = _sales.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("AcrN", 0) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("AcrN", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("AcrE", 0) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("AcrE", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("AcrD", 0) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("AcrD", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            cmbCustomerName.Properties.DataSource = _sales.GetAllActiveCustomers();
            cmbSearchCustomer.Properties.DataSource = cmbCustomerName.Properties.DataSource;
            dtpStartDate.DateTime = DateTime.Today.AddMonths(-1);
            dtpEndDate.DateTime = DateTime.Today;
            sitmTotalDue.Caption = "Total Due: " + _sales.GetTotalDue();
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEnable(false);
            MakeEmpty();
            txtReceivableId.Text = _sales.GetNextReceivableId();
            dtpReceivableDate.EditValue = DateTime.Today;
            cmbCustomerName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReceivableId.Text)) return;
            if (gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrFromSale").ToString() == "True")
            {
                XtraMessageBox.Show("Cannot edit transactions from sale.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isNew = false;
            MakeEnable(false);
            cmbCustomerName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cmbCustomerName.EditValue == null)
            {
                XtraMessageBox.Show("Please select the customer.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCustomerName.Focus();
                return;
            }
            if (cmbInvoiceNo.EditValue == null)
            {
                XtraMessageBox.Show("Please select the invoice.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbInvoiceNo.Focus();
                return;
            }
            if (txtAmountPaying.EditValue == null)
            {
                XtraMessageBox.Show("Please enter the amount.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmountPaying.Focus();
                return;
            }
            if (_isNew)
            {
                _sales.BeginTran();
                if (_sales.InsertAccountsReceivable(txtReceivableId.EditValue.ToString(), dtpReceivableDate.DateTime, cmbCustomerName.EditValue.ToString(), cmbInvoiceNo.EditValue.ToString(), txtTotalAmount.EditValue.ToString(),
                    txtDiscount.EditValue.ToString(), (Convert.ToDecimal(txtDue.EditValue) - Convert.ToDecimal(txtAmountPaying.EditValue)).ToString(), txtAmountPaying.EditValue.ToString(), "0", txtRemarks.EditValue.ToString(), Program.UserName))
                {
                    if (_sales.SetFullPaid(cmbInvoiceNo.EditValue.ToString(), txtDue.EditValue.ToString() == txtAmountPaying.EditValue.ToString() ? "1" : "0"))
                    {
                        _sales.CommitTran();
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
                        _sales.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _sales.RollbackTran();
                }
            }
            else
            {
                _sales.BeginTran();
                if (_sales.UpdateAccountsReceivable(txtReceivableId.EditValue.ToString(), dtpReceivableDate.DateTime, cmbCustomerName.EditValue.ToString(), cmbInvoiceNo.EditValue.ToString(), txtTotalAmount.EditValue.ToString(),
                    txtDiscount.EditValue.ToString(), (Convert.ToDecimal(txtDue.EditValue) - Convert.ToDecimal(txtAmountPaying.EditValue)).ToString(), txtAmountPaying.EditValue.ToString(), "0", txtRemarks.EditValue.ToString(), Program.UserName))
                {
                    if (_sales.SetFullPaid(cmbInvoiceNo.EditValue.ToString(), txtDue.EditValue.Equals(txtAmountPaying.EditValue) ? "1" : "0"))
                    {
                        _sales.CommitTran();
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
                        _sales.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _sales.RollbackTran();
                }
            }
            sitmTotalDue.Caption = "Total Due: " + _sales.GetTotalDue();
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
            if (string.IsNullOrWhiteSpace(txtReceivableId.Text)) return;
            if (XtraMessageBox.Show("Are you sure to delete current record?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _sales.BeginTran();
                if (_sales.DeleteAccountsReceivable(txtReceivableId.Text, Program.UserName))
                {
                    if (_sales.SetFullPaid(cmbInvoiceNo.EditValue.ToString(), "0"))
                    {
                        _sales.CommitTran();
                        MakeEmpty();
                        sitmStatus.Caption = Resources.DeleteSuccess;
                        sitmStatus.Glyph = Resources.Success;
                    }
                    else
                    {
                        XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sitmStatus.Caption = Resources.DeleteFail;
                        sitmStatus.Glyph = Resources.Error;
                        _sales.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.DeleteFail;
                    sitmStatus.Glyph = Resources.Error;
                    _sales.RollbackTran();
                }
                sitmTotalDue.Caption = "Total Due: " + _sales.GetTotalDue();
            }
            else
            {
                sitmStatus.Caption = Resources.OperationCancel;
                sitmStatus.Glyph = Resources.Warning;
            }
        }

        private void cmbCustomerName_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomerName.EditValue == null) return;
            cmbInvoiceNo.Properties.DataSource = _sales.GetUnpaidInvoiceNo(cmbCustomerName.EditValue.ToString());
        }

        private void cmbInvoiceNo_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbInvoiceNo.EditValue == null) return;
            var accountsReceivable = _sales.GetAccountsReceivable(cmbInvoiceNo.EditValue.ToString());
            txtTotalAmount.EditValue = accountsReceivable.Rows[0]["acrTotalAmount"];
            txtDiscount.EditValue = accountsReceivable.Rows[0]["acrDiscount"];
            txtDue.EditValue = accountsReceivable.Rows[0]["acrDue"];
        }

        private void txtAmountPaying_EditValueChanged(object sender, EventArgs e)
        {
            if (!txtAmountPaying.Enabled) return;
            if (Convert.ToDecimal(txtAmountPaying.EditValue) <= Convert.ToDecimal(txtDue.EditValue)) return;
            XtraMessageBox.Show("Cannot pay more than due amount.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtAmountPaying.Focus();
            txtAmountPaying.EditValue = null;
        }

        private void grdSearch_Click(object sender, EventArgs e)
        {
            if (!gvwSearch.IsDataRow(gvwSearch.FocusedRowHandle)) return;
            txtReceivableId.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrReceivableId");
            dtpReceivableDate.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrReceivableDate");
            cmbCustomerName.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrCustomerId");
            cmbInvoiceNo.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrInvoiceNo");
            txtTotalAmount.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrTotalAmount");
            txtDiscount.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrDiscount");
            txtAmountPaying.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrAmountPaying");
            if (gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrFromSale").ToString() == "True")
                txtDue.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrDue");
            else
                txtDue.EditValue = Convert.ToDecimal(gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrDue")) + Convert.ToDecimal(gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrAmountPaying"));
            txtRemarks.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acrRemarks");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MakeEmpty();
            var dt = _sales.SearchAccountsReceivable(cmbSearchCustomer.EditValue == null ? string.Empty : cmbSearchCustomer.EditValue.ToString(), dtpStartDate.DateTime, dtpEndDate.DateTime);
            if (dt.Rows.Count > 0)
            {
                grdSearch.DataSource = dt;
                sitmStatus.Caption = $"Total {dt.Rows.Count} row(s) found.";
                sitmStatus.Glyph = Resources.Success;
            }
            else
            {
                XtraMessageBox.Show("No data found.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                sitmStatus.Caption = Resources.NoData;
                sitmStatus.Glyph = Resources.Warning;
            }
        }
    }
}