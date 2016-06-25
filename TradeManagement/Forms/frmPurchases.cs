using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using TradeManagement.Properties;
using TradeManagement_DAL;
using FastReport;
using DevExpress.XtraBars;

namespace TradeManagement.Forms
{
    public partial class frmPurchases : XtraForm
    {
        private readonly clsPurchases _purchases = new clsPurchases();
        private static bool _isNew;
        private string _accountPayableId;

        public frmPurchases()
        {
            InitializeComponent();
        }

        private void MakeEmpty(bool all)
        {
            if (all)
            {
                txtPurchaseId.EditValue = null;
                dtpPurchaseDate.EditValue = null;
                cmbSupplierName.EditValue = null;
                txtVoucherNo.EditValue = null;
                txtBarcode.EditValue = null;
                cmbProduct.EditValue = null;
                txtBrand.EditValue = null;
                txtModel.EditValue = null;
                txtPackageUnit.EditValue = null;
                txtUnitPrice.EditValue = null;
                txtQuantity.EditValue = null;
                grdPurchases.DataSource = null;
                txtDiscount.EditValue = null;
                txtNetTotal.EditValue = null;
                txtAmountPaid.EditValue = null;
                txtDue.EditValue = null;
            }
            else
            {
                txtBarcode.EditValue = null;
                cmbProduct.EditValue = null;
                txtBrand.EditValue = null;
                txtModel.EditValue = null;
                txtPackageUnit.EditValue = null;
                txtUnitPrice.EditValue = null;
                txtQuantity.EditValue = null;
                btnAdd.Enabled = true;
                btnModify.Enabled = false;
                btnRemove.Enabled = false;
            }
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

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            var permission = _purchases.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("PurN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("PurN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("PurE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("PurE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("PurD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("PurD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            cmbSupplierName.Properties.DataSource = _purchases.GetAllActiveSuppliers();
            cmbProduct.Properties.DataSource = _purchases.GetAllProducts();
            cmbProduct.Properties.View.BestFitColumns();
            cmbSearchSupplier.Properties.DataSource = cmbSupplierName.Properties.DataSource;
            dtpStartDate.DateTime = DateTime.Today.AddMonths(-1);
            dtpEndDate.DateTime = DateTime.Today;
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty(true);
            grpSearch.Visible = false;
            grpMaster.Enabled = true;
            txtPurchaseId.Text = _purchases.GetNextPurchaseId();
            MakeEnable(false);
            dtpPurchaseDate.EditValue = DateTime.Today;
            cmbSupplierName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPurchaseId.Text)) return;
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
            if (gvwPurchases.RowCount == 0)
            {
                XtraMessageBox.Show("Please enter at least one Product.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbProduct.Focus();
                return;
            }
            if (!Program.ValidateLicense(dtpPurchaseDate.DateTime))
            {
                XtraMessageBox.Show("The date is greater than the license date. Please renew the license.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmRenewLicense.Instance().ShowDialog();
                return;
            }
            if (_isNew)
            {
                if (_purchases.CheckVoucherForNew(cmbSupplierName.EditValue.ToString(), txtVoucherNo.Text))
                {
                    XtraMessageBox.Show("The Voucher No for the selected Supplier already exists.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVoucherNo.Focus();
                    return;
                }
                _accountPayableId = _purchases.GetNextPayableId();
                _purchases.BeginTran();
                if (_purchases.InsertPurchases(txtPurchaseId.EditValue.ToString(), dtpPurchaseDate.DateTime, cmbSupplierName.EditValue.ToString(), txtVoucherNo.EditValue.ToString(), colTotal.SummaryItem.SummaryValue.ToString(), (txtDiscount.EditValue ?? 0).ToString(), txtAmountPaid.EditValue.ToString(), txtDue.EditValue == null ? "1" : Convert.ToDecimal(txtDue.EditValue) > 0 ? "0" : "1", Program.UserName))
                {
                    var success = false;
                    for (var i = 0; i < gvwPurchases.RowCount; i++)
                    {
                        success = _purchases.InsertPurchaseDetails(txtPurchaseId.Text, gvwPurchases.GetRowCellValue(i, "prdProductId").ToString(), gvwPurchases.GetRowCellValue(i, "prdPurchasePrice").ToString(), gvwPurchases.GetRowCellValue(i, "prdQuantity").ToString());
                        if (!success) break;
                        _purchases.IncreaseStock(gvwPurchases.GetRowCellValue(i, "prdProductId").ToString(), gvwPurchases.GetRowCellValue(i, "prdQuantity").ToString());
                    }
                    if (success)
                    {
                        if (_purchases.InsertAccountsPayable(_accountPayableId, dtpPurchaseDate.DateTime, cmbSupplierName.EditValue.ToString(), txtVoucherNo.EditValue.ToString(), txtPurchaseId.EditValue.ToString(),
                            txtNetTotal.EditValue.ToString(), (txtDiscount.EditValue ?? 0).ToString(), (txtDue.EditValue ?? 0).ToString(), txtAmountPaid.EditValue.ToString(), "1", "For purchase id " + txtPurchaseId.EditValue, Program.UserName))
                        {
                            _purchases.CommitTran();
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
                    XtraMessageBox.Show(Resources.SaveFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.SaveFail;
                    sitmStatus.Glyph = Resources.Error;
                    _purchases.RollbackTran();
                }
            }
            else
            {
                if (_purchases.CheckVoucherForEdit(txtPurchaseId.Text, cmbSupplierName.EditValue.ToString(), txtVoucherNo.Text))
                {
                    XtraMessageBox.Show("The Voucher No for the selected Supplier already exists.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVoucherNo.Focus();
                    return;
                }
                var dt = _purchases.GetPurchaseDetails(txtPurchaseId.Text);
                _purchases.BeginTran();
                if (_purchases.UpdatePurchases(txtPurchaseId.EditValue.ToString(), dtpPurchaseDate.DateTime, cmbSupplierName.EditValue.ToString(), txtVoucherNo.EditValue.ToString(), colTotal.SummaryItem.SummaryValue.ToString(), (txtDiscount.EditValue ?? 0).ToString(), txtAmountPaid.EditValue.ToString(), txtDue.EditValue == null ? "1" : Convert.ToDecimal(txtDue.EditValue) > 0 ? "0" : "1", Program.UserName))
                {
                    var success = false;
                    foreach (DataRow row in dt.Rows) _purchases.DecreaseStock(row["prdProductId"].ToString(), row["prdQuantity"].ToString());
                    _purchases.DeletePurchaseDetails(txtPurchaseId.Text);
                    for (var i = 0; i < gvwPurchases.RowCount; i++)
                    {
                        success = _purchases.InsertPurchaseDetails(txtPurchaseId.Text, gvwPurchases.GetRowCellValue(i, "prdProductId").ToString(), gvwPurchases.GetRowCellValue(i, "prdPurchasePrice").ToString(), gvwPurchases.GetRowCellValue(i, "prdQuantity").ToString());
                        if (!success) break;
                        _purchases.IncreaseStock(gvwPurchases.GetRowCellValue(i, "prdProductId").ToString(), gvwPurchases.GetRowCellValue(i, "prdQuantity").ToString());
                    }
                    if (success)
                    {
                        if (_purchases.UpdateAccountsPayable(_accountPayableId, dtpPurchaseDate.DateTime, cmbSupplierName.EditValue.ToString(), txtVoucherNo.EditValue.ToString(), txtPurchaseId.EditValue.ToString(),
                            txtNetTotal.EditValue.ToString(), (txtDiscount.EditValue ?? 0).ToString(), (txtDue.EditValue ?? 0).ToString(), txtAmountPaid.EditValue.ToString(), "1", "Updated for purchase id " + txtPurchaseId.EditValue, Program.UserName))
                        {
                            _purchases.CommitTran();
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
                else
                {
                    XtraMessageBox.Show(Resources.UpdateFail, ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sitmStatus.Caption = Resources.UpdateFail;
                    sitmStatus.Glyph = Resources.Error;
                    _purchases.RollbackTran();
                }
            }
        }

        private void bbtnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            MakeEmpty(true);
            MakeEnable(true);
            sitmStatus.Caption = Resources.OperationCancel;
            sitmStatus.Glyph = Resources.Warning;
            grpMaster.Enabled = false;
            grpDetails.Enabled = false;
        }

        private void bbtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPurchaseId.Text)) return;
            if (XtraMessageBox.Show("Are you sure to delete current purchase?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dt = _purchases.GetPurchaseDetails(txtPurchaseId.Text);
                _purchases.BeginTran();
                if (_purchases.DeletePurchases(txtPurchaseId.Text, Program.UserName))
                {
                    foreach (DataRow row in dt.Rows) 
                        _purchases.DecreaseStock(row["prdProductId"].ToString(), row["prdQuantity"].ToString());
                    if (_purchases.DeleteAccountsPayable(_accountPayableId, Program.UserName))
                    {
                        _purchases.CommitTran();
                        MakeEmpty(true);
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

        private void bbtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var report = new Report())
            {
                report.Load(@"Reports\rptPurchases.frx");
                report.SetParameterValue("Title", "Voucher");
                report.RegisterData(_purchases.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_purchases.GetPurchases(txtPurchaseId.Text), "vwPurchases");
                report.RegisterData(_purchases.GetPurchaseDetails(txtPurchaseId.Text), "vwPurchaseDetails");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("vwPurchases").Enabled = true;
                report.GetDataSource("vwPurchaseDetails").Enabled = true;
                report.Show();
            }
        }

        private void txtVoucherNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;
            if (string.IsNullOrEmpty(cmbSupplierName.Text))
            {
                XtraMessageBox.Show("Please select the Supplier.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSupplierName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtVoucherNo.Text))
            {
                XtraMessageBox.Show("Please enter the Voucher.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVoucherNo.Text = string.Empty;
                txtVoucherNo.Focus();
                return;
            }
            grpDetails.Enabled = true;
            txtBarcode.Focus();
        }

        private void cmbProduct_EditValueChanged(object sender, EventArgs e)
        {
            if (gridLookUpEdit1View.FocusedRowHandle < 0) return;
            txtBrand.EditValue = gridLookUpEdit1View.GetRowCellValue(gridLookUpEdit1View.FocusedRowHandle, "bndBrandName");
            txtModel.EditValue = gridLookUpEdit1View.GetRowCellValue(gridLookUpEdit1View.FocusedRowHandle, "pdtModel");
            txtPackageUnit.EditValue = gridLookUpEdit1View.GetRowCellValue(gridLookUpEdit1View.FocusedRowHandle, "pdtPackageUnit");
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && btnAdd.Enabled) AddProduct();
        }

        private void gvwPurchase_MouseDown(object sender, MouseEventArgs e)
        {
            var gridView = sender as GridView;
            if (gridView == null) return;
            var hi = gridView.CalcHitInfo(new Point(e.X, e.Y));
            if (hi.InRowCell)
            {
                gridView.SelectRow(hi.RowHandle);
                cmbProduct.EditValue = gvwPurchases.GetRowCellValue(gvwPurchases.FocusedRowHandle, "prdProductId").ToString();
                txtBrand.Text = gvwPurchases.GetRowCellValue(gvwPurchases.FocusedRowHandle, "bndBrandName").ToString();
                txtModel.Text = gvwPurchases.GetRowCellValue(gvwPurchases.FocusedRowHandle, "pdtModel").ToString();
                txtPackageUnit.Text = gvwPurchases.GetRowCellValue(gvwPurchases.FocusedRowHandle, "pdtPackageUnit").ToString();
                txtUnitPrice.Text = gvwPurchases.GetRowCellValue(gvwPurchases.FocusedRowHandle, "prdPurchasePrice").ToString();
                txtQuantity.Text = gvwPurchases.GetRowCellValue(gvwPurchases.FocusedRowHandle, "prdQuantity").ToString();
                btnAdd.Enabled = false;
                btnModify.Enabled = true;
                btnRemove.Enabled = true;
            }
            else
            {
                gridView.ClearSelection();
                MakeEmpty(false);
            }
        }

        private bool ValidateData()
        {
            if (cmbProduct.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Please select the Product.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProduct.Focus();
                return true;
            }
            if (txtUnitPrice.Text == "0" || txtUnitPrice.Text == "")
            {
                XtraMessageBox.Show("Please enter the Unit Price.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return true;
            }
            if (txtQuantity.Text == "0" || txtQuantity.Text == "")
            {
                XtraMessageBox.Show("Please enter the Quantity.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return true;
            }
            return false;
        }

        private void AddProduct()
        {
            if (ValidateData()) return;
            DataTable dtPurchase;
            if (grdPurchases.DataSource != null)
                dtPurchase = (DataTable)grdPurchases.DataSource;
            else
            {
                dtPurchase = new DataTable();
                dtPurchase.Columns.Add("prdProductId");
                dtPurchase.Columns.Add("pdtProductName");
                dtPurchase.Columns.Add("bndBrandName");
                dtPurchase.Columns.Add("pdtModel");
                dtPurchase.Columns.Add("pdtPackageUnit");
                dtPurchase.Columns.Add("prdPurchasePrice");
                dtPurchase.Columns.Add("prdQuantity");
                dtPurchase.Columns.Add("prdTotal");
            }
            object[] row = {
                               cmbProduct.EditValue, cmbProduct.Text, txtBrand.Text, txtModel.Text, txtPackageUnit.Text,
                               txtUnitPrice.Text, txtQuantity.Text,
                               Convert.ToDecimal(txtUnitPrice.Text) * Convert.ToDecimal(txtQuantity.Text)
                           };
            dtPurchase.Rows.Add(row);
            grdPurchases.DataSource = dtPurchase;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtDiscount.EditValue ?? "0");
            MakeEmpty(false);
            txtBarcode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ValidateData()) return;
            var dt = (DataTable)grdPurchases.DataSource;
            dt.Rows[gvwPurchases.FocusedRowHandle]["prdProductId"] = cmbProduct.EditValue;
            dt.Rows[gvwPurchases.FocusedRowHandle]["pdtProductName"] = cmbProduct.Text;
            dt.Rows[gvwPurchases.FocusedRowHandle]["bndBrandName"] = txtBrand.Text;
            dt.Rows[gvwPurchases.FocusedRowHandle]["pdtModel"] = txtModel.Text;
            dt.Rows[gvwPurchases.FocusedRowHandle]["pdtPackageUnit"] = txtPackageUnit.Text;
            dt.Rows[gvwPurchases.FocusedRowHandle]["prdPurchasePrice"] = txtUnitPrice.Text;
            dt.Rows[gvwPurchases.FocusedRowHandle]["prdQuantity"] = txtQuantity.Text;
            dt.Rows[gvwPurchases.FocusedRowHandle]["prdTotal"] = Convert.ToDecimal(txtUnitPrice.Text) * Convert.ToDecimal(txtQuantity.Text);
            grdPurchases.DataSource = dt;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtDiscount.EditValue ?? "0");
            MakeEmpty(false);
            txtBarcode.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure to delete the selected product?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gvwPurchases.DeleteRow(gvwPurchases.FocusedRowHandle);
                txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtDiscount.EditValue ?? "0");
                txtDue.EditValue = Convert.ToDecimal(txtNetTotal.Text) - Convert.ToDecimal(txtAmountPaid.EditValue ?? "0");
            }
            MakeEmpty(false);
            txtBarcode.Focus();
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {
            if (colTotal.SummaryItem.SummaryValue == null) return;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtDiscount.EditValue ?? "0");
            txtDue.EditValue = Convert.ToDecimal(txtNetTotal.Text) - Convert.ToDecimal(txtAmountPaid.EditValue ?? "0");
        }

        private void txtAmountPaid_EditValueChanged(object sender, EventArgs e)
        {
            if (colTotal.SummaryItem.SummaryValue == null) return;
            txtNetTotal.EditValue = Convert.ToDecimal(colTotal.SummaryItem.SummaryValue) - Convert.ToDecimal(txtDiscount.EditValue ?? "0");
            txtDue.EditValue = Convert.ToDecimal(txtNetTotal.Text) - Convert.ToDecimal(txtAmountPaid.EditValue ?? "0");
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
            var dt = _purchases.SearchPurchasesBySupplier(cmbSearchSupplier.EditValue.ToString());
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
            var dt = _purchases.SearchPurchasesByDate(dtpStartDate.DateTime, dtpEndDate.DateTime);
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
            txtPurchaseId.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purPurchaseId");
            dtpPurchaseDate.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purPurchaseDate");
            cmbSupplierName.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purSupplierId");
            txtVoucherNo.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purVoucherNo");
            txtDiscount.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purDiscount");
            txtNetTotal.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purNetTotal");
            txtAmountPaid.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purAmountPaid");
            txtDue.EditValue = gvwSearch.GetRowCellValue(gvwSearch.FocusedRowHandle, "purDue");
            _accountPayableId = _purchases.GetPayableId(cmbSupplierName.EditValue.ToString(), txtVoucherNo.EditValue.ToString());
            grdPurchases.DataSource = _purchases.GetPurchaseDetails(txtPurchaseId.Text);
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

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;
            if (txtBarcode.EditValue == null) return;
            var dt = _purchases.GetProductInfo(txtBarcode.EditValue.ToString());
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("Wrong barcode.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmbProduct.EditValue = dt.Rows[0]["pdtProductId"];
            txtBrand.EditValue = dt.Rows[0]["bndBrandName"];
            txtModel.EditValue = dt.Rows[0]["pdtModel"];
            txtPackageUnit.EditValue = dt.Rows[0]["pdtPackageUnit"];
            txtUnitPrice.Focus();
        }
    }
}