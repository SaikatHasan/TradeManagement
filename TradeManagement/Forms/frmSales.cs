using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using FastReport;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmSales : XtraForm
    {
        private readonly clsSales _sales = new clsSales();
        private static bool _isNew;
        private string _accountReceivableId;
        private readonly Dictionary<string, short> _prevProducts = new Dictionary<string, short>();

        public frmSales()
        {
            InitializeComponent();
        }

        private void MakeEmpty(bool all)
        {
            if (all)
            {
                rgpPaymentType.SelectedIndex = 0;
                txtInvoiceNo.EditValue = null;
                dtpSalesDate.EditValue = null;
                cmbCustomerName.EditValue = null;
                txtBarcode.EditValue = null;
                grdSales.DataSource = null;
                txtFinalDiscount.EditValue = null;
                txtNetTotal.EditValue = null;
                txtAmountPaid.EditValue = null;
                txtDue.EditValue = null;
            }
            else
                txtBarcode.Text = string.Empty;
        }

        private void MakeEnable(bool enable)
        {
            bbtnNew.Enabled = enable;
            bbtnEdit.Enabled = enable;
            bbtnDelete.Enabled = enable;
            bbtnPrint.Enabled = enable;
            bbtnSave.Enabled = !enable;
            bbtnCancel.Enabled = !enable;
            bbtnExit.Enabled = enable;
        }

        private void GetTodaysStatus()
        {
            var stats = _sales.GetStatistics();
            lblTotalSaleCount.Text = "Total Sale Count : " + stats.Rows[0]["TotalSaleCount"];
            lblTotalSaleAmount.Text = "Total Sale Amount : " + stats.Rows[0]["TotalSaleAmount"];
            lblLastSaleAmount.Text = "Last Sale Amount : " + stats.Rows[0]["LastSaleAmount"];
            lblLastInvoice.Text = "Last Invoice No : " + stats.Rows[0]["LastInvoiceNo"];
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            var permission = _sales.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("SlsN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("SlsN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("SlsE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("SlsE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("SlsD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("SlsD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            cmbCustomerName.Properties.DataSource = _sales.GetAllCustomers();
            //_vat = _sales.GetVATRegNo();
            cmbSearchCustomer.Properties.DataSource = _sales.GetAllCustomers();
            dtpStartDate.DateTime = DateTime.Today.AddMonths(-1);
            dtpEndDate.DateTime = DateTime.Today;
            GetTodaysStatus();
            txtUserName.EditValue = _sales.Decrypt(Program.UserName, "Saikat");
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty(true);
            grpSearch.Visible = false;
            grpMaster.Enabled = true;
            txtInvoiceNo.EditValue = _sales.GetNextInvoiceNo();
            MakeEnable(false);
            dtpSalesDate.EditValue = DateTime.Today;
            cmbCustomerName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceNo.EditValue.ToString()))
                return;
            for (var i = 0; i < gvwSales.RowCount; i++)
                _prevProducts.Add(gvwSales.GetRowCellValue(i, "sldProductId").ToString(), Convert.ToInt16(gvwSales.GetRowCellValue(i, "sldQuantity")));
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
            if (gvwSales.RowCount == 0)
            {
                XtraMessageBox.Show("Please enter at least one Product.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarcode.Focus();
                return;
            }
            if (!Program.ValidateLicense(dtpSalesDate.DateTime))
            {
                XtraMessageBox.Show("The date is greater than the license date. Please renew the license.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmRenewLicense.Instance().ShowDialog();
                return;
            }
            if (_isNew)
            {
                _accountReceivableId = _sales.GetNextReceivableId();
                _sales.BeginTran();
                if (_sales.InsertSales(txtInvoiceNo.EditValue.ToString(), dtpSalesDate.DateTime, cmbCustomerName.EditValue.ToString(), colTotal.SummaryItem.SummaryValue.ToString(), txtVAT.EditValue.ToString(), (txtFinalDiscount.EditValue ?? 0).ToString(), rgpPaymentType.SelectedIndex.ToString(), (txtAmountPaid.EditValue ?? 0).ToString(), txtDue.EditValue == null ? "1" : Convert.ToDecimal(txtDue.EditValue) > 0 ? "0" : "1", Program.UserName))
                {
                    var success = false;
                    for (var i = 0; i < gvwSales.RowCount; i++)
                    {
                        success = _sales.InsertSaleDetails(txtInvoiceNo.EditValue.ToString(), gvwSales.GetRowCellValue(i, "sldProductId").ToString(), gvwSales.GetRowCellValue(i, "sldSalesPrice").ToString(), gvwSales.GetRowCellValue(i, "sldQuantity").ToString());
                        if (!success)
                            break;
                        _sales.DecreaseStock(gvwSales.GetRowCellValue(i, "sldProductId").ToString(), gvwSales.GetRowCellValue(i, "sldQuantity").ToString());
                    }
                    if (success)
                    {
                        if (_sales.InsertAccountsReceivable(_accountReceivableId, dtpSalesDate.DateTime, cmbCustomerName.EditValue.ToString(), txtInvoiceNo.EditValue.ToString(), txtNetTotal.EditValue.ToString(),
                            txtVAT.EditValue.ToString(), (txtFinalDiscount.EditValue ?? 0).ToString(), (txtDue.EditValue ?? 0).ToString(), (txtAmountPaid.EditValue ?? 0).ToString(), "1", "For invoice no " + txtInvoiceNo.EditValue, Program.UserName))
                        {
                            _sales.CommitTran();
                            using (var report = new Report())
                            {
                                report.Load(@"Reports\rptInvoice.frx");
                                report.SetParameterValue("SalesPerson", _sales.GetSalesPersonName(txtInvoiceNo.EditValue.ToString()));
                                report.RegisterData(_sales.GetCompanyInformation(), "CompanyInformation");
                                report.RegisterData(_sales.GetSales(txtInvoiceNo.EditValue.ToString()), "vwSales");
                                report.RegisterData(_sales.GetSaleDetails(txtInvoiceNo.EditValue.ToString()), "vwSaleDetails");
                                report.GetDataSource("CompanyInformation").Enabled = true;
                                report.GetDataSource("vwSales").Enabled = true;
                                report.GetDataSource("vwSaleDetails").Enabled = true;
                                report.Print();
                            }
                            MakeEmpty(true);
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
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _sales.RollbackTran();
                }
            }
            else
            {
                var dt = _sales.GetSaleDetails(txtInvoiceNo.Text);
                _sales.BeginTran();
                if (_sales.UpdateSales(txtInvoiceNo.EditValue.ToString(), dtpSalesDate.DateTime, cmbCustomerName.EditValue.ToString(), colTotal.SummaryItem.SummaryValue.ToString(), txtVAT.EditValue.ToString(), (txtFinalDiscount.EditValue ?? 0).ToString(), rgpPaymentType.SelectedIndex.ToString(), (txtAmountPaid.EditValue ?? 0).ToString(), txtDue.EditValue == null ? "1" : Convert.ToDecimal(txtDue.EditValue) > 0 ? "0" : "1", Program.UserName))
                {
                    var success = false;
                    foreach (DataRow row in dt.Rows)
                        _sales.IncreaseStock(row["sldProductId"].ToString(), row["sldQuantity"].ToString());
                    _sales.DeleteSaleDetails(txtInvoiceNo.EditValue.ToString());
                    for (var i = 0; i < gvwSales.RowCount; i++)
                    {
                        success = _sales.InsertSaleDetails(txtInvoiceNo.EditValue.ToString(), gvwSales.GetRowCellValue(i, "sldProductId").ToString(), gvwSales.GetRowCellValue(i, "sldSalesPrice").ToString(), gvwSales.GetRowCellValue(i, "sldQuantity").ToString());
                        if (!success) break;
                        _sales.DecreaseStock(gvwSales.GetRowCellValue(i, "sldProductId").ToString(), gvwSales.GetRowCellValue(i, "sldQuantity").ToString());
                    }
                    if (success)
                    {
                        if (_sales.UpdateAccountsReceivable(_accountReceivableId, dtpSalesDate.DateTime, cmbCustomerName.EditValue.ToString(), txtInvoiceNo.EditValue.ToString(), txtNetTotal.EditValue.ToString(),
                            txtVAT.EditValue.ToString(), (txtFinalDiscount.EditValue ?? 0).ToString(), (txtDue.EditValue ?? 0).ToString(), (txtAmountPaid.EditValue ?? 0).ToString(), "1", "Updated for invoice no " + txtInvoiceNo.EditValue, Program.UserName))
                        {
                            _prevProducts.Clear();
                            _sales.CommitTran();
                            using (var report = new Report())
                            {
                                report.Load(@"Reports\rptInvoice.frx");
                                report.SetParameterValue("SalesPerson", _sales.GetSalesPersonName(txtInvoiceNo.EditValue.ToString()));
                                report.RegisterData(_sales.GetCompanyInformation(), "CompanyInformation");
                                report.RegisterData(_sales.GetSales(txtInvoiceNo.EditValue.ToString()), "vwSales");
                                report.RegisterData(_sales.GetSaleDetails(txtInvoiceNo.EditValue.ToString()), "vwSaleDetails");
                                report.GetDataSource("CompanyInformation").Enabled = true;
                                report.GetDataSource("vwSales").Enabled = true;
                                report.GetDataSource("vwSaleDetails").Enabled = true;
                                report.Print();
                            }
                            MakeEmpty(true);
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
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _sales.RollbackTran();
                }
            }
            GetTodaysStatus();
        }

        private void bbtnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            _prevProducts.Clear();
            MakeEmpty(true);
            MakeEnable(true);
            sitmStatus.Caption = Resources.OperationCancel;
            sitmStatus.Glyph = Resources.Warning;
            grpMaster.Enabled = false;
            grpDetails.Enabled = false;
        }

        private void bbtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceNo.EditValue.ToString())) return;
            if (XtraMessageBox.Show("Are you sure to delete current sales?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dt = _sales.GetSaleDetails(txtInvoiceNo.EditValue.ToString());
                _sales.BeginTran();
                if (_sales.DeleteSales(txtInvoiceNo.EditValue.ToString(), Program.UserName))
                {
                    foreach (DataRow row in dt.Rows)
                        _sales.IncreaseStock(row["sldProductId"].ToString(), row["sldQuantity"].ToString());
                    if (_sales.DeleteAccountsReceivable(_accountReceivableId, Program.UserName))
                    {
                        _sales.CommitTran();
                        MakeEmpty(true);
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
                GetTodaysStatus();
            }
            else
            {
                sitmStatus.Caption = Resources.OperationCancel;
                sitmStatus.Glyph = Resources.Warning;
            }
        }

        private void bbtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInvoiceNo.EditValue.ToString())) return;
            using (var report = new Report())
            {
                report.Load(@"Reports\rptInvoice.frx");
                report.SetParameterValue("SalesPerson", _sales.GetSalesPersonName(txtInvoiceNo.EditValue.ToString()));
                report.RegisterData(_sales.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_sales.GetSales(txtInvoiceNo.EditValue.ToString()), "vwSales");
                report.RegisterData(_sales.GetSaleDetails(txtInvoiceNo.EditValue.ToString()), "vwSaleDetails");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("vwSales").Enabled = true;
                report.GetDataSource("vwSaleDetails").Enabled = true;
                report.Show();
            }
        }

        private void cmbCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter || cmbCustomerName.EditValue == null) return;
            if (string.IsNullOrWhiteSpace(cmbCustomerName.EditValue.ToString()))
            {
                XtraMessageBox.Show("Please select the Customer.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCustomerName.Focus();
                return;
            }
            grpDetails.Enabled = true;
            txtBarcode.Focus();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            if (txtBarcode.EditValue == null) return;
            var dt = _sales.GetProductInfo(txtBarcode.EditValue.ToString());
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Wrong barcode.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            short count = 0;
            for (var i = 0; i < gvwSales.RowCount; i++)
                if (dt.Rows[0]["pdtProductId"].ToString() == gvwSales.GetRowCellValue(i, "sldProductId").ToString())
                    count = Convert.ToInt16(gvwSales.GetRowCellValue(i, "sldQuantity"));
            count++;
            short prevCount = 0;
            if (_prevProducts.ContainsKey(dt.Rows[0]["pdtProductId"].ToString()))
                prevCount = _prevProducts[dt.Rows[0]["pdtProductId"].ToString()];
            if (Convert.ToInt32(dt.Rows[0]["pdtStockQuantity"]) < count - prevCount)
            {
                XtraMessageBox.Show("Cannot add. The product is out of stock.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(dt.Rows[0]["pdtReorderLevel"]) >= (Convert.ToInt32(dt.Rows[0]["pdtStockQuantity"]) - count - prevCount))
                XtraMessageBox.Show("Product stock is low.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (count > 1)
            {
                var rowHandle = gvwSales.LocateByValue("sldProductId", dt.Rows[0]["pdtProductId"].ToString(), arguments => { });
                gvwSales.SetRowCellValue(rowHandle, "sldQuantity", count);
            }
            else
            {
                DataTable dtSale;
                if (grdSales.DataSource != null)
                    dtSale = (DataTable)grdSales.DataSource;
                else
                {
                    dtSale = new DataTable();
                    dtSale.Columns.Add("sldProductId");
                    dtSale.Columns.Add("pdtProductName");
                    dtSale.Columns.Add("bndBrandName");
                    dtSale.Columns.Add("pdtModel");
                    dtSale.Columns.Add("pdtPackageUnit");
                    dtSale.Columns.Add("sldSalesPrice");
                    dtSale.Columns.Add("sldVAT");
                    dtSale.Columns.Add("sldQuantity");
                    dtSale.Columns.Add("sldTotal");
                }
                object[] row =
                {
                    dt.Rows[0]["pdtProductId"], dt.Rows[0]["pdtProductName"], dt.Rows[0]["bndBrandName"],
                    dt.Rows[0]["pdtModel"], dt.Rows[0]["pdtPackageUnit"], dt.Rows[0]["pdtUnitPrice"], dt.Rows[0]["pdtVAT"],
                    count, Convert.ToDecimal(dt.Rows[0]["pdtUnitPrice"]) * count +
                    Convert.ToDecimal(dt.Rows[0]["pdtUnitPrice"]) * count * Convert.ToDecimal(dt.Rows[0]["pdtVAT"]) / 100
                };
                dtSale.Rows.Add(row);
                grdSales.DataSource = dtSale;
            }
            //txtVAT.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) * _vat / 100;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtFinalDiscount.EditValue ?? "0");
            txtDue.EditValue = Convert.ToDecimal(txtNetTotal.EditValue) - Convert.ToDecimal(txtAmountPaid.EditValue ?? "0");
            MakeEmpty(false);
            txtBarcode.Focus();
        }

        private void txtFinalDiscount_EditValueChanged(object sender, EventArgs e)
        {
            if (colTotal.SummaryItem.SummaryValue == null) return;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtFinalDiscount.EditValue ?? "0");
            txtDue.EditValue = Convert.ToDecimal(txtNetTotal.EditValue) - Convert.ToDecimal(txtAmountPaid.EditValue ?? "0");
        }

        private void txtAmountPaid_EditValueChanged(object sender, EventArgs e)
        {
            if (colTotal.SummaryItem.SummaryValue == null) return;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtFinalDiscount.EditValue ?? "0");
            txtDue.EditValue = Convert.ToDecimal(txtNetTotal.EditValue) - Convert.ToDecimal(txtAmountPaid.EditValue ?? "0");
        }

        private void gvwSales_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column != colUnitPrice & e.Column != colQuantity & e.Column != colDiscount) return;
            if (e.Value == DBNull.Value || Convert.ToDecimal(e.Value) == 0)gvwSales.DeleteRow(e.RowHandle);
            else
            {
                if (e.Column == colQuantity)
                {
                    var stockQuantity = _sales.GetProductStock(gvwSales.GetRowCellValue(e.RowHandle, "sldProductId").ToString());
                    if (stockQuantity < Convert.ToInt16(e.Value))
                    {
                        gvwSales.SetRowCellValue(e.RowHandle, colQuantity, gvwSales.ActiveEditor.OldEditValue);
                        XtraMessageBox.Show("Stock does not have that much quantity.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (e.Column == colDiscount)
                {
                    if (gvwSales.ActiveEditor.EditValue.ToString().Trim().EndsWith("%"))
                    {
                        
                    }
                }
                gvwSales.SetRowCellValue(e.RowHandle, "sldTotal", Convert.ToDecimal(gvwSales.GetRowCellValue(e.RowHandle, "sldSalesPrice")) * Convert.ToDecimal(gvwSales.GetRowCellValue(e.RowHandle, "sldQuantity")) +
                    Convert.ToDecimal(gvwSales.GetRowCellValue(e.RowHandle, "sldSalesPrice")) * Convert.ToDecimal(gvwSales.GetRowCellValue(e.RowHandle, "sldQuantity")) * Convert.ToDecimal(gvwSales.GetRowCellValue(e.RowHandle, "sldVAT")) / 100);
            }
            grdSales.RefreshDataSource();
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtFinalDiscount.EditValue ?? "0");
            txtDue.EditValue = Convert.ToDecimal(txtNetTotal.EditValue) - Convert.ToDecimal(txtAmountPaid.EditValue ?? "0");
            txtBarcode.Focus();
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
            var dt = _sales.SearchSalesByCustomer(cmbSearchCustomer.EditValue.ToString());
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
            var dt = _sales.SearchSalesByDate(dtpStartDate.DateTime, dtpEndDate.DateTime);
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
            txtInvoiceNo.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsInvoiceNo");
            dtpSalesDate.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsSalesDate");
            cmbCustomerName.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsCustomerId");
            //txtVAT.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsVAT");
            txtFinalDiscount.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsDiscount");
            txtNetTotal.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsNetTotal");
            rgpPaymentType.SelectedIndex = Convert.ToInt16(gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsPaymentType"));
            txtAmountPaid.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsAmountPaid");
            txtDue.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "slsDue");
            _accountReceivableId = _sales.GetReceivableId(cmbCustomerName.EditValue.ToString(), txtInvoiceNo.EditValue.ToString());
            grdSales.DataSource = _sales.GetSaleDetails(txtInvoiceNo.EditValue.ToString());
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

        private void btnProductList_Click(object sender, EventArgs e)
        {
            if (btnProductList.Text == "Show Product List")
            {
                grdProducts.DataSource = _sales.GetAllProducts();
                grdSales.Visible = false;
                pnlSales.Visible = false;
                gclStatus.Visible = false;
                grdProducts.Visible = true;
                gvwProducts.Focus();
                btnProductList.Text = "Hide Product List";
            }
            else
            {
                grdSales.Visible = true;
                pnlSales.Visible = true;
                gclStatus.Visible = true;
                grdProducts.Visible = false;
                txtBarcode.Focus();
                btnProductList.Text = "Show Product List";
            }
        }

        private void AddProduct()
        {
            short count = 0;
            for (var i = 0; i < gvwSales.RowCount; i++)
            {
                if (gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString() == gvwSales.GetRowCellValue(i, "sldProductId").ToString())
                    count = Convert.ToInt16(gvwSales.GetRowCellValue(i, "sldQuantity"));
            }
            count++;
            short prevCount = 0;
            if (_prevProducts.ContainsKey(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString()))
                prevCount = _prevProducts[gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString()];
            if (Convert.ToInt32(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtStockQuantity")) < (count - prevCount))
            {
                XtraMessageBox.Show("Cannot add. The product is out of stock.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtReorderLevel")) >= (Convert.ToInt32(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtStockQuantity")) - (count - prevCount)))
                XtraMessageBox.Show("Product stock is low.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (count > 1)
            {
                var rowHandle = gvwSales.LocateByValue("sldProductId", gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString(), arguments => { });
                gvwSales.SetRowCellValue(rowHandle, "sldQuantity", count);
            }
            else
            {
                DataTable dtSale;
                if (grdSales.DataSource != null)
                {
                    dtSale = (DataTable)grdSales.DataSource;
                }
                else
                {
                    dtSale = new DataTable();
                    dtSale.Columns.Add("sldProductId");
                    dtSale.Columns.Add("pdtProductName");
                    dtSale.Columns.Add("bndBrandName");
                    dtSale.Columns.Add("pdtModel");
                    dtSale.Columns.Add("pdtPackageUnit");
                    dtSale.Columns.Add("sldSalesPrice");
                    dtSale.Columns.Add("sldVAT");
                    dtSale.Columns.Add("sldQuantity");
                    dtSale.Columns.Add("sldTotal");
                }
                object[] row =
                {
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductName"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "bndBrandName"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtModel"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtPackageUnit"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtUnitPrice"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtVAT"),
                    count, Convert.ToDecimal(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtUnitPrice")) * count +
                    Convert.ToDecimal(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtUnitPrice")) * count * 
                    Convert.ToDecimal(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtVAT")) / 100
                };
                dtSale.Rows.Add(row);
                grdSales.DataSource = dtSale;
            }
            txtNetTotal.EditValue = (Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtFinalDiscount.EditValue ?? "0")).ToString();
            txtDue.EditValue = (Convert.ToDecimal(txtNetTotal.EditValue) - Convert.ToDecimal(txtAmountPaid.EditValue ?? "0")).ToString();
            grdSales.Visible = true;
            pnlSales.Visible = true;
            gclStatus.Visible = true;
            grdProducts.Visible = false;
            btnProductList.Text = "Show Product List";
            btnProductList.Focus();
        }

        private void gvwProducts_DoubleClick(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void gvwProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            AddProduct();
        }

        private void bbtnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Dispose();
        }
    }
}