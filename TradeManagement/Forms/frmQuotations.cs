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
    public partial class frmQuotations : XtraForm
    {
        private readonly clsQuotations _quotations = new clsQuotations();
        private static bool _isNew;
        private decimal _vat;
        private readonly Dictionary<string, short> _prevProducts = new Dictionary<string, short>();

        public frmQuotations()
        {
            InitializeComponent();
        }

        private void MakeEmpty(bool all)
        {
            if (all)
            {
                txtQuotationNo.EditValue = null;
                dtpQuotationDate.EditValue = null;
                txtCustomerName.EditValue = null;
                txtBarcode.EditValue = null;
                grdQuotations.DataSource = null;
                txtVAT.EditValue = null;
                txtDiscount.EditValue = null;
                txtNetTotal.EditValue = null;
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
        }

        private void frmQuotations_Load(object sender, EventArgs e)
        {
            var permission = _quotations.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("QotN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("QotN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("QotE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("QotE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("QotD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("QotD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            //_vat = _quotations.GetVATRegNo();
            cmbSearchCustomer.Properties.DataSource = _quotations.GetAllCustomers();
            dtpStartDate.DateTime = DateTime.Today.AddMonths(-1);
            dtpEndDate.DateTime = DateTime.Today;
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty(true);
            grpSearch.Visible = false;
            grpMaster.Enabled = true;
            txtQuotationNo.EditValue = _quotations.GetNextQuotationNo();
            MakeEnable(false);
            dtpQuotationDate.EditValue = DateTime.Today;
            txtCustomerName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuotationNo.EditValue.ToString()))
                return;
            for (var i = 0; i < gvwQuotations.RowCount; i++)
                _prevProducts.Add(gvwQuotations.GetRowCellValue(i, "pdtProductId").ToString(), Convert.ToInt16(gvwQuotations.GetRowCellValue(i, "qodQuantity")));
            _isNew = false;
            MakeEnable(false);
            grpSearch.Visible = false;
            grpMaster.Enabled = true;
            txtCustomerName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvwQuotations.RowCount == 0)
            {
                XtraMessageBox.Show("Please enter at least one Product.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarcode.Focus();
                return;
            }
            if (!Program.ValidateLicense(dtpQuotationDate.DateTime))
            {
                XtraMessageBox.Show("The date is greater than the license date. Please renew the license.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmRenewLicense.Instance().ShowDialog();
                return;
            }
            if (_isNew)
            {
                _quotations.BeginTran();
                if (_quotations.InsertQuotations(txtQuotationNo.EditValue.ToString(), dtpQuotationDate.DateTime, txtCustomerName.EditValue.ToString(), txtAddress.EditValue.ToString(), txtPhone.EditValue.ToString(), colTotal.SummaryItem.SummaryValue.ToString(), txtVAT.EditValue.ToString(), (txtDiscount.EditValue ?? 0).ToString(), Program.UserName))
                {
                    var success = false;
                    for (var i = 0; i < gvwQuotations.RowCount; i++)
                    {
                        success = _quotations.InsertQuotationDetails(txtQuotationNo.EditValue.ToString(), gvwQuotations.GetRowCellValue(i, "qodProductId").ToString(), gvwQuotations.GetRowCellValue(i, "qodQuotationPrice").ToString(), gvwQuotations.GetRowCellValue(i, "qodQuantity").ToString());
                        if (!success)
                            break;
                    }
                    if (success)
                    {
                        _quotations.CommitTran();
                        using (var report = new Report())
                        {
                            report.Load(@"Reports\rptQuotations.frx");
                            report.RegisterData(_quotations.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_quotations.GetQuotations(txtQuotationNo.EditValue.ToString()), "vwQuotations");
                            report.RegisterData(_quotations.GetQuotationDetails(txtQuotationNo.EditValue.ToString()), "vwQuotationDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwQuotations").Enabled = true;
                            report.GetDataSource("vwQuotationDetails").Enabled = true;
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
                        _quotations.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _quotations.RollbackTran();
                }
            }
            else
            {
                _quotations.BeginTran();
                if (_quotations.UpdateQuotations(txtQuotationNo.EditValue.ToString(), dtpQuotationDate.DateTime, txtCustomerName.EditValue.ToString(), txtAddress.EditValue.ToString(), txtPhone.EditValue.ToString(), colTotal.SummaryItem.SummaryValue.ToString(), txtVAT.EditValue.ToString(), (txtDiscount.EditValue ?? 0).ToString(), Program.UserName))
                {
                    var success = false;
                    _quotations.DeleteQuotationDetails(txtQuotationNo.EditValue.ToString());
                    for (var i = 0; i < gvwQuotations.RowCount; i++)
                    {
                        success = _quotations.InsertQuotationDetails(txtQuotationNo.EditValue.ToString(), gvwQuotations.GetRowCellValue(i, "qodProductId").ToString(), gvwQuotations.GetRowCellValue(i, "qodQuotationPrice").ToString(), gvwQuotations.GetRowCellValue(i, "qodQuantity").ToString());
                        if (!success) break;
                    }
                    if (success)
                    {
                        _prevProducts.Clear();
                        _quotations.CommitTran();
                        using (var report = new Report())
                        {
                            report.Load(@"Reports\rptQuotations.frx");
                            report.RegisterData(_quotations.GetCompanyInformation(), "CompanyInformation");
                            report.RegisterData(_quotations.GetQuotations(txtQuotationNo.EditValue.ToString()), "vwQuotations");
                            report.RegisterData(_quotations.GetQuotationDetails(txtQuotationNo.EditValue.ToString()), "vwQuotationDetails");
                            report.GetDataSource("CompanyInformation").Enabled = true;
                            report.GetDataSource("vwQuotations").Enabled = true;
                            report.GetDataSource("vwQuotationDetails").Enabled = true;
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
                        _quotations.RollbackTran();
                    }
                }
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _quotations.RollbackTran();
                }
            }
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
            if (string.IsNullOrWhiteSpace(txtQuotationNo.EditValue.ToString())) return;
            if (XtraMessageBox.Show("Are you sure to delete current quotation?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dt = _quotations.GetQuotationDetails(txtQuotationNo.EditValue.ToString());
                _quotations.BeginTran();
                if (_quotations.DeleteQuotations(txtQuotationNo.EditValue.ToString(), Program.UserName))
                {
                    _quotations.CommitTran();
                    MakeEmpty(true);
                    sitmStatus.Caption = Resources.DeleteSuccess;
                    sitmStatus.Glyph = Resources.Success;
                }
                else
                {
                    XtraMessageBox.Show(Resources.DeleteFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.DeleteFail;
                    sitmStatus.Glyph = Resources.Error;
                    _quotations.RollbackTran();
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
            //var dtQuotations = _quotations.GetQuotations(txtQuotationNo.EditValue.ToString());
            //dtQuotations.TableName = "vwQuotations";
            //dtQuotations.WriteXmlSchema(@"Reports\vwQuotations.xml");
            //var dtQuotationDetails = _quotations.GetQuotationDetails(txtQuotationNo.EditValue.ToString());
            //dtQuotationDetails.TableName = "vwQuotationDetails";
            //dtQuotationDetails.WriteXmlSchema(@"Reports\vwQuotationDetails.xml");
            //return;
            if (string.IsNullOrEmpty(txtQuotationNo.EditValue.ToString())) return;
            using (var report = new Report())
            {
                report.Load(@"Reports\rptQuotations.frx");
                report.RegisterData(_quotations.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_quotations.GetQuotations(txtQuotationNo.EditValue.ToString()), "vwQuotations");
                report.RegisterData(_quotations.GetQuotationDetails(txtQuotationNo.EditValue.ToString()), "vwQuotationDetails");
                report.RegisterData(_quotations.GetCompanyInformation(), "CompanyInformation");
                report.GetDataSource("vwQuotations").Enabled = true;
                report.GetDataSource("vwQuotationDetails").Enabled = true;
                report.Show();
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            if (string.IsNullOrWhiteSpace(txtPhone.EditValue.ToString()))
            {
                XtraMessageBox.Show("Please enter the Phone Number.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            grpDetails.Enabled = true;
            txtBarcode.Focus();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter || txtBarcode.EditValue == null) return;
            var dt = _quotations.GetProductInfo(txtBarcode.EditValue.ToString());
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Wrong barcode.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            short count = 0;
            for (var i = 0; i < gvwQuotations.RowCount; i++)
                if (dt.Rows[0]["pdtProductId"].ToString() == gvwQuotations.GetRowCellValue(i, "qodProductId").ToString())
                    count = Convert.ToInt16(gvwQuotations.GetRowCellValue(i, "qodQuantity"));
            count++;
            short prevCount = 0;
            if (count > 1)
            {
                var rowHandle = gvwQuotations.LocateByValue("qodProductId", dt.Rows[0]["pdtProductId"].ToString(), arguments => { });
                gvwQuotations.SetRowCellValue(rowHandle, "qodQuantity", count);
            }
            else
            {
                DataTable dtQuotation;
                if (grdQuotations.DataSource != null)
                    dtQuotation = (DataTable)grdQuotations.DataSource;
                else
                {
                    dtQuotation = new DataTable();
                    dtQuotation.Columns.Add("qodProductId");
                    dtQuotation.Columns.Add("pdtProductName");
                    dtQuotation.Columns.Add("bndBrandName");
                    dtQuotation.Columns.Add("pdtModel");
                    dtQuotation.Columns.Add("pdtPackageUnit");
                    dtQuotation.Columns.Add("qodQuotationPrice");
                    dtQuotation.Columns.Add("qodQuantity");
                    dtQuotation.Columns.Add("qodTotal");
                }
                object[] row =
                {
                    dt.Rows[0]["pdtProductId"], dt.Rows[0]["pdtProductName"], dt.Rows[0]["bndBrandName"],
                    dt.Rows[0]["pdtModel"], dt.Rows[0]["pdtPackageUnit"], dt.Rows[0]["pdtUnitPrice"], count
                    , Convert.ToDecimal(dt.Rows[0]["pdtUnitPrice"]) * count
                };
                dtQuotation.Rows.Add(row);
                grdQuotations.DataSource = dtQuotation;
            }
            txtVAT.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) * _vat / 100;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) + Convert.ToDecimal(txtVAT.EditValue) - Convert.ToDecimal(txtDiscount.EditValue ?? "0");
            MakeEmpty(false);
            txtBarcode.Focus();
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            if (colTotal.SummaryItem.SummaryValue == null) return;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) + Convert.ToDecimal(txtVAT.EditValue) - Convert.ToDecimal(txtDiscount.EditValue ?? "0");
        }

        private void gvwQuotations_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column != colUnitPrice & e.Column != colQuantity) return;
            if (e.Value == DBNull.Value || Convert.ToInt32(e.Value) == 0)
                gvwQuotations.DeleteRow(e.RowHandle);
            else
                gvwQuotations.SetRowCellValue(e.RowHandle, "qodTotal", Convert.ToDecimal(gvwQuotations.GetRowCellValue(e.RowHandle, "qodQuotationPrice")) * Convert.ToDecimal(gvwQuotations.GetRowCellValue(e.RowHandle, "qodQuantity")));
            grdQuotations.RefreshDataSource();
            txtVAT.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) * _vat / 100;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) + Convert.ToDecimal(txtVAT.EditValue) - Convert.ToDecimal(txtDiscount.EditValue ?? "0");
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
            var dt = _quotations.SearchQuotationsByCustomer(cmbSearchCustomer.EditValue.ToString());
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
            var dt = _quotations.SearchQuotationsByDate(dtpStartDate.DateTime, dtpEndDate.DateTime);
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
            txtQuotationNo.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "qotQuotationNo");
            dtpQuotationDate.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "qotQuotationDate");
            txtCustomerName.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "qotCustomerName");
            txtAddress.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "qotAddress");
            txtPhone.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "qotPhone");
            txtVAT.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "qotVAT");
            txtDiscount.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "qotDiscount");
            txtNetTotal.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "qotNetTotal");
            grdQuotations.DataSource = _quotations.GetQuotationDetails(txtQuotationNo.EditValue.ToString());
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
                grdProducts.DataSource = _quotations.GetAllProducts();
                grdQuotations.Visible = false;
                pnlSales.Visible = false;
                grdProducts.Visible = true;
                gvwProducts.Focus();
                btnProductList.Text = "Hide Product List";
            }
            else
            {
                grdQuotations.Visible = true;
                pnlSales.Visible = true;
                grdProducts.Visible = false;
                txtBarcode.Focus();
                btnProductList.Text = "Show Product List";
            }
        }

        private void AddProduct()
        {
            short count = 0;
            for (var i = 0; i < gvwQuotations.RowCount; i++)
            {
                if (gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString() == gvwQuotations.GetRowCellValue(i, "qodProductId").ToString())
                    count = Convert.ToInt16(gvwQuotations.GetRowCellValue(i, "qodQuantity"));
            }
            count++;
            short prevCount = 0;
            //if (_prevProducts.ContainsKey(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString()))
            //    prevCount = _prevProducts[gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString()];
            //if (Convert.ToInt32(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtStockQuantity")) < (count - prevCount))
            //{
            //    XtraMessageBox.Show("Cannot add. The product is out of stock.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (Convert.ToInt32(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtReorderLevel")) >= (Convert.ToInt32(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtStockQuantity")) - (count - prevCount)))
            //    XtraMessageBox.Show("Product stock is low.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (count > 1)
            {
                var rowHandle = gvwQuotations.LocateByValue("qodProductId", gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId").ToString(), arguments => { });
                gvwQuotations.SetRowCellValue(rowHandle, "qodQuantity", count);
            }
            else
            {
                DataTable dtQuotation;
                if (grdQuotations.DataSource != null)
                {
                    dtQuotation = (DataTable)grdQuotations.DataSource;
                    //dtSale.Columns.RemoveAt(0);
                }
                else
                {
                    dtQuotation = new DataTable();
                    dtQuotation.Columns.Add("qodProductId");
                    dtQuotation.Columns.Add("pdtProductName");
                    dtQuotation.Columns.Add("bndBrandName");
                    dtQuotation.Columns.Add("pdtModel");
                    dtQuotation.Columns.Add("pdtPackageUnit");
                    dtQuotation.Columns.Add("qodQuotationPrice");
                    dtQuotation.Columns.Add("qodQuantity");
                    dtQuotation.Columns.Add("qodTotal");
                }
                object[] row =
                {
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductId"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtProductName"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "bndBrandName"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtModel"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtPackageUnit"),
                    gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtUnitPrice"),
                    count, Convert.ToDecimal(gvwProducts.GetRowCellValue(gvwProducts.FocusedRowHandle, "pdtUnitPrice"))*count
                };
                dtQuotation.Rows.Add(row);
                grdQuotations.DataSource = dtQuotation;
            }
            txtVAT.EditValue = (Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) * _vat / 100).ToString();
            txtNetTotal.EditValue = (Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) + Convert.ToDecimal(txtVAT.EditValue) - Convert.ToDecimal(txtDiscount.EditValue ?? "0")).ToString();
            grdQuotations.Visible = true;
            pnlSales.Visible = true;
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
    }
}