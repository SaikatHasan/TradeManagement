using System;
using System.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using FastReport;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmPurchaseReturns : XtraForm
    {
        private readonly clsPurchaseReturns _purchaseReturns = new clsPurchaseReturns();
        private static bool _isNew;

        public frmPurchaseReturns()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtReturnId.Text = string.Empty;
            dtpReturnDate.Text = string.Empty;
            cmbSupplierName.EditValue = null;
            cmbVoucherNo.EditValue = null;
            grdPurchaseReturn.DataSource = null;
        }

        private void MakeEnable(bool enable)
        {
            bbtnNew.Enabled = enable;
            bbtnEdit.Enabled = enable;
            bbtnDelete.Enabled = enable;
            bbtnPrint.Enabled = enable;
            bbtnSave.Enabled = !enable;
            bbtnCancel.Enabled = !enable;
        }

        private void frmPurchaseReturns_Load(object sender, EventArgs e)
        {
            var permission = _purchaseReturns.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("PrtN", 0) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("PrtN", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("PrtE", 0) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("PrtE", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("PrtD", 0) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("PrtD", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            cmbSupplierName.Properties.DataSource = _purchaseReturns.GetAllActiveSuppliers();
            cmbSearchSupplier.Properties.DataSource = cmbSupplierName.Properties.DataSource;
            dtpStartDate.DateTime = DateTime.Today.AddMonths(-1);
            dtpEndDate.DateTime = DateTime.Today;
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            grpSearch.Visible = false;
            grpMaster.Enabled = true;
            txtReturnId.Text = _purchaseReturns.GetNextReturnId();
            MakeEnable(false);
            dtpReturnDate.EditValue = DateTime.Today;
            cmbSupplierName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReturnId.Text)) return;
            _isNew = false;
            MakeEnable(false);
            grpSearch.Visible = false;
            grpMaster.Enabled = true;
            cmbSupplierName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isReturned = false;
            for (var i = 0; i < gvwPurchaseReturn.RowCount; i++)
            {
                if (string.IsNullOrEmpty(gvwPurchaseReturn.GetRowCellValue(i, "prdReturnQuantity").ToString()))
                    continue;
                isReturned = true;
                break;
            }
            if (!isReturned)
            {
                XtraMessageBox.Show("Please return at least one Product.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvwPurchaseReturn.FocusedRowHandle = 0;
                gvwPurchaseReturn.FocusedColumn = gvwPurchaseReturn.VisibleColumns[6];
                gvwPurchaseReturn.ShowEditor();
                return;
            }
            for (var i = 0; i < gvwPurchaseReturn.RowCount; i++)
            {
                //if (purchaseReturns.IsSold(gvwPurchaseReturn.GetRowCellValue(i, "prdProductId").ToString()))
                //{
                //    XtraMessageBox.Show("This product is already sold. Can not return it.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    gvwPurchaseReturn.SetRowCellValue(i, "prdReturnQuantity", null);
                //    grdPurchaseReturn.Focus();
                //    return;
                //}
                if (Convert.ToInt16(gvwPurchaseReturn.GetRowCellValue(i, "prdReturnQuantity") == DBNull.Value ? 0 : gvwPurchaseReturn.GetRowCellValue(i, "prdReturnQuantity"))
                    <= Convert.ToInt16(gvwPurchaseReturn.GetRowCellValue(i, "prdPurchaseQuantity")))
                    continue;
                XtraMessageBox.Show("Return Quantity can not be greater than Purchase Quantity.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvwPurchaseReturn.SetRowCellValue(i, "prdReturnQuantity", null);
                grdPurchaseReturn.Focus();
                return;
            }
            if (_isNew)
            {
                _purchaseReturns.BeginTran();
                if (_purchaseReturns.InsertPurchaseReturns(txtReturnId.Text, dtpReturnDate.DateTime, cmbVoucherNo.EditValue.ToString(), Program.UserName))
                {
                    var success = false;
                    for (var i = 0; i < gvwPurchaseReturn.RowCount; i++)
                    {
                        if (gvwPurchaseReturn.GetRowCellValue(i, "prdReturnQuantity") == DBNull.Value)
                            gvwPurchaseReturn.SetRowCellValue(i, "prdReturnQuantity", "0");
                        success = _purchaseReturns.InsertPurchaseReturnDetails(txtReturnId.Text, gvwPurchaseReturn.GetRowCellValue(i, "prdProductId").ToString(), gvwPurchaseReturn.GetRowCellValue(i, "prdPurchaseQuantity").ToString(), gvwPurchaseReturn.GetRowCellValue(i, "prdReturnQuantity").ToString());
                        if (!success) break;
                        _purchaseReturns.DecreaseStock(gvwPurchaseReturn.GetRowCellValue(i, "prdProductId").ToString(), gvwPurchaseReturn.GetRowCellValue(i, "prdReturnQuantity").ToString());
                    }
                    if (success)
                    {
                        _purchaseReturns.CommitTran();
                        MakeEmpty();
                        MakeEnable(true);
                        sitmStatus.Caption = Resources.SaveSuccess;
                        sitmStatus.Glyph = Resources.Success;
                        grpMaster.Enabled = false;
                        grpDetails.Enabled = false;
                    }
                    else
                    {
                        XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sitmStatus.Caption = Resources.SaveFail;
                        sitmStatus.Glyph = Resources.Error;
                        _purchaseReturns.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _purchaseReturns.RollbackTran();
                }
            }
            else
            {
                var dt = _purchaseReturns.GetPurchaseReturnDetails(txtReturnId.Text);
                _purchaseReturns.BeginTran();
                if (_purchaseReturns.UpdatePurchaseReturns(txtReturnId.Text, dtpReturnDate.DateTime, cmbVoucherNo.EditValue.ToString(), Program.UserName))
                {
                    var success = false;
                    foreach (DataRow row in dt.Rows) 
                        _purchaseReturns.IncreaseStock(row["prdProductId"].ToString(), row["prdReturnQuantity"].ToString());
                    _purchaseReturns.DeletePurchaseReturnDetails(txtReturnId.Text);
                    for (var i = 0; i < gvwPurchaseReturn.RowCount; i++)
                    {
                        if (gvwPurchaseReturn.GetRowCellValue(i, "prdReturnQuantity") == DBNull.Value)
                            gvwPurchaseReturn.SetRowCellValue(i, "prdReturnQuantity", "0");
                        success = _purchaseReturns.InsertPurchaseReturnDetails(txtReturnId.Text, gvwPurchaseReturn.GetRowCellValue(i, "prdProductId").ToString(), gvwPurchaseReturn.GetRowCellValue(i, "prdPurchaseQuantity").ToString(), gvwPurchaseReturn.GetRowCellValue(i, "prdReturnQuantity").ToString());
                        if (!success) break;
                        _purchaseReturns.DecreaseStock(gvwPurchaseReturn.GetRowCellValue(i, "prdProductId").ToString(), gvwPurchaseReturn.GetRowCellValue(i, "prdReturnQuantity").ToString());
                    }
                    if (success)
                    {
                        _purchaseReturns.CommitTran();
                        MakeEmpty();
                        MakeEnable(true);
                        sitmStatus.Caption = Resources.UpdateSuccess;
                        sitmStatus.Glyph = Resources.Success;
                        grpMaster.Enabled = false;
                        grpDetails.Enabled = false;
                    }
                    else
                    {
                        XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sitmStatus.Caption = Resources.UpdateFail;
                        sitmStatus.Glyph = Resources.Error;
                        _purchaseReturns.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _purchaseReturns.RollbackTran();
                }
            }
        }

        private void bbtnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            MakeEmpty();
            MakeEnable(true);
            sitmStatus.Caption = Resources.OperationCancel;
            sitmStatus.Glyph = Resources.Warning;
            grpMaster.Enabled = false;
            grpDetails.Enabled = false;
        }

        private void bbtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReturnId.Text)) return;
            if (XtraMessageBox.Show("Are you sure to delete current record?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dt = _purchaseReturns.GetPurchaseReturnDetails(txtReturnId.Text);
                _purchaseReturns.BeginTran();
                if (_purchaseReturns.DeletePurchaseReturns(txtReturnId.Text, Program.UserName))
                {
                    foreach (DataRow row in dt.Rows) _purchaseReturns.IncreaseStock(row["prdProductId"].ToString(), row["prdReturnQuantity"].ToString());
                    _purchaseReturns.CommitTran();
                    MakeEmpty();
                    sitmStatus.Caption = Resources.DeleteSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.DeleteFail;
                    sitmStatus.Glyph = Resources.Error;
                    _purchaseReturns.RollbackTran();
                }
            }
            else
            {
                sitmStatus.Caption = Resources.OperationCancel;
                sitmStatus.Glyph = Resources.Warning;
            }
        }

        private void bbtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var report = new Report())
            {
                report.Load(@"Reports\rptPurchaseReturns.frx");
                report.SetParameterValue("Title", "Purchase Return");
                report.RegisterData(_purchaseReturns.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_purchaseReturns.GetPurchaseReturns(txtReturnId.Text), "vwPurchaseReturns");
                report.RegisterData(_purchaseReturns.GetPurchaseReturnDetails(txtReturnId.Text), "vwPurchaseReturnDetails");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("vwPurchaseReturns").Enabled = true;
                report.GetDataSource("vwPurchaseReturnDetails").Enabled = true;
                report.Show();
            }
        }

        private void cmbSupplierName_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbSupplierName.EditValue == null) return;
            cmbVoucherNo.Properties.DataSource = _purchaseReturns.GetAllVoucherNo(cmbSupplierName.EditValue.ToString());
        }

        private void cmbVoucherNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            if (cmbSupplierName.EditValue == null)
            {
                XtraMessageBox.Show("Please select the Supplier.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSupplierName.Focus();
                return;
            }
            if (cmbVoucherNo.EditValue == null)
            {
                XtraMessageBox.Show("Please select the Voucher.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbVoucherNo.Focus();
                return;
            }
            grpDetails.Enabled = true;
            if (_purchaseReturns.IsReturnedPrev(cmbVoucherNo.EditValue.ToString()))
            {
                txtReturnId.Text = _purchaseReturns.GetReturnId(cmbVoucherNo.EditValue.ToString());
                grdPurchaseReturn.DataSource = _purchaseReturns.GetPurchaseReturnDetails(txtReturnId.Text);
                _isNew = false;
            }
            else
            {
                var purchaseDetails = _purchaseReturns.GetPurchaseDetails(cmbVoucherNo.EditValue.ToString());
                purchaseDetails.Columns["prdQuantity"].ColumnName = "prdPurchaseQuantity";
                purchaseDetails.Columns.Add("prdReturnQuantity", typeof (short));
                grdPurchaseReturn.DataSource = purchaseDetails;
                _isNew = true;
            }
            gvwPurchaseReturn.Focus();
            gvwPurchaseReturn.FocusedRowHandle = 0;
            gvwPurchaseReturn.FocusedColumn = gvwPurchaseReturn.VisibleColumns[5];
            gvwPurchaseReturn.ShowEditor();
        }

        private void gvwPurchaseReturn_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column != colReturnQuantity) return;
            if (e.Value == DBNull.Value || Convert.ToInt32(e.Value) == 0)
            {
            }
            else
            {
                //if (purchaseReturns.IsSold(gvwPurchaseReturn.GetRowCellValue(e.RowHandle, "prdProductId").ToString()))
                //{
                //    XtraMessageBox.Show("This product is already sold. Can not return it.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    gvwPurchaseReturn.SetRowCellValue(e.RowHandle, "prdReturnQuantity", 0);
                //    grdPurchaseReturn.Focus();
                //    return;
                //}
                if (Convert.ToInt16(e.Value) <= Convert.ToInt16(gvwPurchaseReturn.GetRowCellValue(e.RowHandle, "prdPurchaseQuantity")))
                    return;
                XtraMessageBox.Show("Return Quantity can not be greater than Purchase Quantity.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvwPurchaseReturn.SetRowCellValue(e.RowHandle, "prdReturnQuantity", null);
                grdPurchaseReturn.Focus();
            }
        }

        private void bbtnBySupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            MakeEnable(true);
            grdSearch.DataSource = null;
            grpSearch.Visible = !grpSearchBySupplier.Visible;
            grpSearchBySupplier.Visible = true;
            grpSearchByDate.Visible = false;
            cmbSearchSupplier.Focus();
        }

        private void bbtnByDate_ItemClick(object sender, ItemClickEventArgs e)
        {
            MakeEnable(true);
            grdSearch.DataSource = null;
            grpSearch.Visible = !grpSearchByDate.Visible;
            grpSearchBySupplier.Visible = false;
            grpSearchByDate.Visible = true;
            dtpStartDate.Focus();
        }

        private void btnSearchBySupplier_Click(object sender, EventArgs e)
        {
            if (cmbSearchSupplier.EditValue == null)
            {
                XtraMessageBox.Show("Please select a Supplier.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            grdSearch.DataSource = null;
            var dt = _purchaseReturns.SearchPurchaseReturnsBySupplier(cmbSearchSupplier.EditValue.ToString());
            if (dt.Rows.Count > 0)
            {
                grdSearch.DataSource = dt;
                sitmStatus.Caption = $"Total {dt.Rows.Count} row(s) found.";
                sitmStatus.Glyph = Resources.Success;
            }
            else
            {
                XtraMessageBox.Show("No data found for selected Supplier.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                sitmStatus.Caption = Resources.NoData;
                sitmStatus.Glyph = Resources.Warning;
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            grdSearch.DataSource = null;
            var dt = _purchaseReturns.SearchPurchaseReturnsByDate(dtpStartDate.DateTime, dtpEndDate.DateTime);
            if (dt.Rows.Count > 0)
            {
                grdSearch.DataSource = dt;
                sitmStatus.Caption = $"Total {dt.Rows.Count} row(s) found.";
                sitmStatus.Glyph = Resources.Success;
            }
            else
            {
                XtraMessageBox.Show("No data found for selected Date Range.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                sitmStatus.Caption = Resources.NoData;
                sitmStatus.Glyph = Resources.Warning;
            }
        }

        private void SearchDetails()
        {
            txtReturnId.Text = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "prtReturnId").ToString();
            dtpReturnDate.Text = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "prtReturnDate").ToString();
            cmbSupplierName.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purSupplierId").ToString();
            cmbVoucherNo.Text = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purVoucherNo").ToString();
            grdPurchaseReturn.DataSource = _purchaseReturns.GetPurchaseReturnDetails(txtReturnId.Text);
            grpSearch.Visible = false;
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void gvwSearch_DoubleClick(object sender, EventArgs e)
        {
            SearchDetails();
        }

        private void gvwSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            SearchDetails();
        }
    }
}