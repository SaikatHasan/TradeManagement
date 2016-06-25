using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmAccountsPayable : XtraForm
    {
        private readonly clsPurchases _purchases = new clsPurchases();
        private static bool _isNew;

        public frmAccountsPayable()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtPayableId.EditValue = null;
            dtpPayableDate.EditValue = null;
            cmbSupplierName.EditValue = null;
            cmbVoucherNo.EditValue = null;
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

        private void frmAccountsPayable_Load(object sender, EventArgs e)
        {
            var permission = _purchases.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("AcpN", 0) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("AcpN", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("AcpE", 0) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("AcpE", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("AcpD", 0) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("AcpD", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            cmbSupplierName.Properties.DataSource = _purchases.GetAllActiveSuppliers();
            cmbSearchSupplier.Properties.DataSource = cmbSupplierName.Properties.DataSource;
            dtpStartDate.DateTime = DateTime.Today.AddMonths(-1);
            dtpEndDate.DateTime = DateTime.Today;
            sitmTotalDue.Caption = "Total Due: " + _purchases.GetTotalDue();
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEnable(false);
            MakeEmpty();
            txtPayableId.Text = _purchases.GetNextPayableId();
            dtpPayableDate.EditValue = DateTime.Today;
            cmbSupplierName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPayableId.Text)) return;
            if (gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpFromPurchase").ToString() == "True")
            {
                XtraMessageBox.Show("Cannot edit transactions from purchase.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _isNew = false;
            MakeEnable(false);
            cmbSupplierName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (cmbSupplierName.EditValue == null)
            {
                XtraMessageBox.Show("Please select the supplier.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbSupplierName.Focus();
                return;
            }
            if (cmbVoucherNo.EditValue == null)
            {
                XtraMessageBox.Show("Please select the voucher.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbVoucherNo.Focus();
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
                _purchases.BeginTran();
                if (_purchases.InsertAccountsPayable(txtPayableId.EditValue.ToString(), dtpPayableDate.DateTime, cmbSupplierName.EditValue.ToString(), cmbVoucherNo.Text, cmbVoucherNo.EditValue.ToString(), txtTotalAmount.EditValue.ToString(),
                    txtDiscount.EditValue.ToString(), (Convert.ToDecimal(txtDue.EditValue) - Convert.ToDecimal(txtAmountPaying.EditValue)).ToString(), txtAmountPaying.EditValue.ToString(), "0", txtRemarks.EditValue.ToString(), Program.UserName))
                {
                    if (_purchases.SetFullPaid(cmbVoucherNo.EditValue.ToString(), txtDue.EditValue.ToString() == txtAmountPaying.EditValue.ToString() ? "1" : "0"))
                    {
                        _purchases.CommitTran();
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
                        _purchases.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _purchases.RollbackTran();
                }
            }
            else
            {
                _purchases.BeginTran();
                if (_purchases.UpdateAccountsPayable(txtPayableId.EditValue.ToString(), dtpPayableDate.DateTime, cmbSupplierName.EditValue.ToString(), cmbVoucherNo.Text, cmbVoucherNo.EditValue.ToString(), txtTotalAmount.EditValue.ToString(),
                    txtDiscount.EditValue.ToString(), (Convert.ToDecimal(txtDue.EditValue) - Convert.ToDecimal(txtAmountPaying.EditValue)).ToString(), txtAmountPaying.EditValue.ToString(), "0", txtRemarks.EditValue.ToString(), Program.UserName))
                {
                    if (_purchases.SetFullPaid(cmbVoucherNo.EditValue.ToString(), txtDue.EditValue.Equals(txtAmountPaying.EditValue) ? "1" : "0"))
                    {
                        _purchases.CommitTran();
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
                        _purchases.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _purchases.RollbackTran();
                }
            }
            sitmTotalDue.Caption = "Total Due: " + _purchases.GetTotalDue();
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
            if (string.IsNullOrWhiteSpace(txtPayableId.Text)) return;
            if (XtraMessageBox.Show("Are you sure to delete current record?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _purchases.BeginTran();
                if (_purchases.DeleteAccountsPayable(txtPayableId.Text, Program.UserName))
                {
                    if (_purchases.SetFullPaid(cmbVoucherNo.EditValue.ToString(), "0"))
                    {
                        _purchases.CommitTran();
                        MakeEmpty();
                        sitmStatus.Caption = Resources.DeleteSuccess;
                        sitmStatus.Glyph = Resources.Success;
                    }
                    else
                    {
                        XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sitmStatus.Caption = Resources.DeleteFail;
                        sitmStatus.Glyph = Resources.Error;
                        _purchases.RollbackTran();
                    }
                    sitmTotalDue.Caption = "Total Due: " + _purchases.GetTotalDue();
                }
                else
                {
                    XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.DeleteFail;
                    sitmStatus.Glyph = Resources.Error;
                    _purchases.RollbackTran();
                }
            }
            else
            {
                sitmStatus.Caption = Resources.OperationCancel;
                sitmStatus.Glyph = Resources.Warning;
            }
        }

        private void cmbSupplierName_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbSupplierName.EditValue == null) return;
            cmbVoucherNo.Properties.DataSource = _purchases.GetUnpaidVoucherNo(cmbSupplierName.EditValue.ToString());
        }

        private void cmbVoucherNo_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbVoucherNo.EditValue == null) return;
            var accountsPayable = _purchases.GetAccountsPayable(cmbVoucherNo.EditValue.ToString());
            txtTotalAmount.EditValue = accountsPayable.Rows[0]["acpTotalAmount"];
            txtDiscount.EditValue = accountsPayable.Rows[0]["acpDiscount"];
            txtDue.EditValue = accountsPayable.Rows[0]["acpDue"];
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
            txtPayableId.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpPayableId");
            dtpPayableDate.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpPayableDate");
            cmbSupplierName.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpSupplierId");
            cmbVoucherNo.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpPurchaseId");
            txtTotalAmount.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpTotalAmount");
            txtDiscount.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpDiscount");
            txtAmountPaying.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpAmountPaying");
            if (gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpFromPurchase").ToString() == "True")
                txtDue.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpDue");
            else
                txtDue.EditValue = Convert.ToDecimal(gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpDue")) + Convert.ToDecimal(gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpAmountPaying"));
            txtRemarks.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "acpRemarks");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MakeEmpty();
            var dt = _purchases.SearchAccountsPayable(cmbSearchSupplier.EditValue == null ? string.Empty : cmbSearchSupplier.EditValue.ToString(), dtpStartDate.DateTime, dtpEndDate.DateTime);
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