using System;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
using FastReport;
using TradeManagement.Properties;
using TradeManagement_DAL;
using DevExpress.XtraBars;

namespace TradeManagement.Forms
{
    public partial class frmSaleReturns : XtraForm
    {
        private readonly clsSaleReturns _saleReturns = new clsSaleReturns();
        private static bool _isNew;

        public frmSaleReturns()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtReturnId.Text = string.Empty;
            dtpReturnDate.Text = string.Empty;
            cmbCustomerName.EditValue = string.Empty;
            cmbInvoiceNo.Text = string.Empty;
            grdSalesReturn.DataSource = null;
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

        private void frmSaleReturns_Load(object sender, EventArgs e)
        {
            var permission = _saleReturns.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("SrtN", 0) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("SrtN", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("SrtE", 0) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("SrtE", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("SrtD", 0) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("SrtD", 0) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            cmbCustomerName.Properties.DataSource = _saleReturns.GetAllCustomers();
            cmbSearchCustomer.Properties.DataSource = cmbCustomerName.Properties.DataSource;
            dtpStartDate.DateTime = DateTime.Today.AddMonths(-1);
            dtpEndDate.DateTime = DateTime.Today;
        }

        private void cmbCustomerName_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbCustomerName.EditValue == null) return;
            cmbInvoiceNo.Properties.DataSource = _saleReturns.GetAllInvoiceNo(cmbCustomerName.EditValue.ToString());
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            grpSearch.Visible = false;
            grpMaster.Enabled = true;
            txtReturnId.Text = _saleReturns.GetNextReturnId();
            MakeEnable(false);
            dtpReturnDate.EditValue = DateTime.Today;
            cmbCustomerName.Focus();
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
            cmbCustomerName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            var isReturned = false;
            for (var i = 0; i < gvwSalesReturn.RowCount; i++)
            {
                if (string.IsNullOrEmpty(gvwSalesReturn.GetRowCellValue(i, "srdReturnQuantity").ToString()))
                    continue;
                isReturned = true;
                break;
            }
            if (!isReturned)
            {
                XtraMessageBox.Show("Please return at least one Product.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvwSalesReturn.FocusedRowHandle = 0;
                gvwSalesReturn.FocusedColumn = gvwSalesReturn.VisibleColumns[6];
                gvwSalesReturn.ShowEditor();
                return;
            }
            for (var i = 0; i < gvwSalesReturn.RowCount; i++)
            {
                if (Convert.ToInt16(gvwSalesReturn.GetRowCellValue(i, "srdReturnQuantity") == DBNull.Value ? 0 : gvwSalesReturn.GetRowCellValue(i, "srdReturnQuantity"))
                    <= Convert.ToInt16(gvwSalesReturn.GetRowCellValue(i, "srdSaleQuantity")))
                    continue;
                XtraMessageBox.Show("Return Quantity can not be greater than Sale Quantity.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvwSalesReturn.SetRowCellValue(i, "srdReturnQuantity", null);
                grdSalesReturn.Focus();
                return;
            }
            if (_isNew)
            {
                _saleReturns.BeginTran();
                if (_saleReturns.InsertSaleReturns(txtReturnId.Text, dtpReturnDate.DateTime, cmbInvoiceNo.EditValue.ToString(), Program.UserName))
                {
                    var success = false;
                    for (var i = 0; i < gvwSalesReturn.RowCount; i++)
                    {
                        if (gvwSalesReturn.GetRowCellValue(i, "srdReturnQuantity") == DBNull.Value)
                            gvwSalesReturn.SetRowCellValue(i, "srdReturnQuantity", "0");
                        success = _saleReturns.InsertSaleReturnDetails(txtReturnId.Text, gvwSalesReturn.GetRowCellValue(i, "sldProductId").ToString(), gvwSalesReturn.GetRowCellValue(i, "srdSaleQuantity").ToString(), gvwSalesReturn.GetRowCellValue(i, "srdReturnQuantity").ToString());
                        if (!success) break;
                        _saleReturns.IncreaseStock(gvwSalesReturn.GetRowCellValue(i, "sldProductId").ToString(), gvwSalesReturn.GetRowCellValue(i, "srdReturnQuantity").ToString());
                    }
                    if (success)
                    {
                        _saleReturns.CommitTran();
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
                        _saleReturns.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _saleReturns.RollbackTran();
                }
            }
            else
            {
                var dt = _saleReturns.GetSaleReturnDetails(txtReturnId.Text);
                _saleReturns.BeginTran();
                if (_saleReturns.UpdateSaleReturns(txtReturnId.Text, dtpReturnDate.DateTime, cmbInvoiceNo.EditValue.ToString(), Program.UserName))
                {
                    var success = false;
                    foreach (DataRow row in dt.Rows)
                        _saleReturns.DecreaseStock(row["srdProductId"].ToString(), row["srdReturnQuantity"].ToString());
                    _saleReturns.DeleteSaleReturnDetails(txtReturnId.Text);
                    for (var i = 0; i < gvwSalesReturn.RowCount; i++)
                    {
                        if (gvwSalesReturn.GetRowCellValue(i, "srdReturnQuantity") == DBNull.Value)
                            gvwSalesReturn.SetRowCellValue(i, "srdReturnQuantity", "0");
                        success = _saleReturns.InsertSaleReturnDetails(txtReturnId.Text, gvwSalesReturn.GetRowCellValue(i, "sldProductId").ToString(), gvwSalesReturn.GetRowCellValue(i, "srdSaleQuantity").ToString(), gvwSalesReturn.GetRowCellValue(i, "srdReturnQuantity").ToString());
                        if (!success) break;
                        _saleReturns.IncreaseStock(gvwSalesReturn.GetRowCellValue(i, "sldProductId").ToString(), gvwSalesReturn.GetRowCellValue(i, "srdReturnQuantity").ToString());
                    }
                    if (success)
                    {
                        _saleReturns.CommitTran();
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
                        _saleReturns.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _saleReturns.RollbackTran();
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
                var dt = _saleReturns.GetSaleReturnDetails(txtReturnId.Text);
                _saleReturns.BeginTran();
                if (_saleReturns.DeleteSaleReturns(txtReturnId.Text, Program.UserName))
                {
                    foreach (DataRow row in dt.Rows)
                        _saleReturns.DecreaseStock(row["srdProductId"].ToString(), row["srdReturnQuantity"].ToString());
                    _saleReturns.CommitTran();
                    MakeEmpty();
                    sitmStatus.Caption = Resources.DeleteSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.DeleteFail;
                    sitmStatus.Glyph = Resources.Error;
                    _saleReturns.RollbackTran();
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
                report.Load(@"Reports\rptSaleReturns.frx");
                report.SetParameterValue("Title", "Sales Return");
                report.RegisterData(_saleReturns.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_saleReturns.GetSaleReturns(txtReturnId.Text), "vwSaleReturns");
                report.RegisterData(_saleReturns.GetSaleReturnDetails(txtReturnId.Text), "vwSaleReturnDetails");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("vwSaleReturns").Enabled = true;
                report.GetDataSource("vwSaleReturnDetails").Enabled = true;
                report.Show();
            }
        }

        private void cmbInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            if (string.IsNullOrEmpty(cmbCustomerName.Text))
            {
                XtraMessageBox.Show("Please select the Customer.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCustomerName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbInvoiceNo.Text))
            {
                XtraMessageBox.Show("Please select the Invoice.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbInvoiceNo.Focus();
                return;
            }
            grpDetails.Enabled = true;
            if (_saleReturns.IsReturnedPrev(cmbInvoiceNo.EditValue.ToString()))
            {
                txtReturnId.Text = _saleReturns.GetReturnId(cmbInvoiceNo.EditValue.ToString());
                var saleDetails = _saleReturns.GetSaleReturnDetails(txtReturnId.Text);
                saleDetails.Columns["srdProductId"].ColumnName = "sldProductId";
                grdSalesReturn.DataSource = saleDetails;
                _isNew = false;
            }
            else
            {
                var saleDetails = _saleReturns.GetSaleDetails(cmbInvoiceNo.EditValue.ToString());
                saleDetails.Columns["sldQuantity"].ColumnName = "srdSaleQuantity";
                saleDetails.Columns.Add("srdReturnQuantity", typeof(short));
                grdSalesReturn.DataSource = saleDetails;
                _isNew = true;
            }
            gvwSalesReturn.Focus();
            gvwSalesReturn.FocusedRowHandle = 0;
            gvwSalesReturn.FocusedColumn = gvwSalesReturn.VisibleColumns[5];
            gvwSalesReturn.ShowEditor();
        }

        private void gvwSalesReturn_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column != colReturnQuantity) return;
            if (string.IsNullOrEmpty(e.Value.ToString())) return;
            if (Convert.ToInt16(e.Value) <= Convert.ToInt16(gvwSalesReturn.GetRowCellValue(e.RowHandle, "srdSaleQuantity")))
                return;
            XtraMessageBox.Show("Return Quantity can not be greater than Sale Quantity.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            gvwSalesReturn.SetRowCellValue(e.RowHandle, "srdReturnQuantity", null);
            grdSalesReturn.Focus();
        }

        private void bbtnByCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            MakeEnable(true);
            grdSearch.DataSource = null;
            grpSearch.Visible = !grpSearchByCustomer.Visible;
            grpSearchByCustomer.Visible = true;
            grpSearchByDate.Visible = false;
            cmbSearchCustomer.Focus();
        }

        private void bbtnByDate_ItemClick(object sender, ItemClickEventArgs e)
        {
            MakeEnable(true);
            grdSearch.DataSource = null;
            grpSearch.Visible = !grpSearchByDate.Visible;
            grpSearchByCustomer.Visible = false;
            grpSearchByDate.Visible = true;
            dtpStartDate.Focus();
        }

        private void btnSearchByCustomer_Click(object sender, EventArgs e)
        {
            if (cmbSearchCustomer.EditValue == null)
            {
                XtraMessageBox.Show("Please select a Customer.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            grdSearch.DataSource = null;
            var dt = _saleReturns.SearchSaleReturnsBySupplier(cmbSearchCustomer.EditValue.ToString());
            if (dt.Rows.Count > 0)
            {
                grdSearch.DataSource = dt;
                sitmStatus.Caption = $"Total {dt.Rows.Count} row(s) found.";
                sitmStatus.Glyph = Resources.Success;
            }
            else
            {
                XtraMessageBox.Show("No data found for selected Customer.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                sitmStatus.Caption = Resources.NoData;
                sitmStatus.Glyph = Resources.Warning;
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            grdSearch.DataSource = null;
            var dt = _saleReturns.SearchPurchaseReturnsByDate(dtpStartDate.DateTime, dtpEndDate.DateTime);
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
            txtReturnId.Text = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "srtReturnId").ToString();
            dtpReturnDate.Text = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "srtReturnDate").ToString();
            cmbCustomerName.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsCustomerId").ToString();
            cmbInvoiceNo.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "srtInvoiceNo").ToString();
            grdSalesReturn.DataSource = _saleReturns.GetSaleReturnDetails(txtReturnId.Text);
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