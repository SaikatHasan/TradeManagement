using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;
using FastReport;

namespace TradeManagement.Forms
{
    public partial class frmCustomers : XtraForm
    {
        readonly clsCustomers _customers = new clsCustomers();
        static bool _isNew;

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtLandPhone.Text = string.Empty;
            txtMobile.Text = string.Empty;
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
        }

        private void BindGrid()
        {
            grdCustomers.DataSource = _customers.GetAllCustomers();
            gvwCustomers.ExpandAllGroups();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            var permission = _customers.GetPermissionByUser(Program.UserName);
            if (permission.IndexOf("CstN", 0, StringComparison.Ordinal) != -1)
                bbtnNew.Visibility = permission.Substring(permission.IndexOf("CstN", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnNew.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("CstE", 0, StringComparison.Ordinal) != -1)
                bbtnEdit.Visibility = permission.Substring(permission.IndexOf("CstE", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnEdit.Visibility = BarItemVisibility.Never;
            if (permission.IndexOf("CstD", 0, StringComparison.Ordinal) != -1)
                bbtnDelete.Visibility = permission.Substring(permission.IndexOf("CstD", 0, StringComparison.Ordinal) + 4, 1) == "1" ? BarItemVisibility.Always : BarItemVisibility.Never;
            else
                bbtnDelete.Visibility = BarItemVisibility.Never;
            BindGrid();
        }

        private void grdCustomers_Click(object sender, EventArgs e)
        {
            MakeEmpty();
            if (!gvwCustomers.IsDataRow(gvwCustomers.FocusedRowHandle)) return;
            txtCustomerID.Text = gvwCustomers.GetRowCellValue(gvwCustomers.FocusedRowHandle, "cstCustomerId").ToString();
            txtCustomerName.Text = gvwCustomers.GetRowCellValue(gvwCustomers.FocusedRowHandle, "cstCustomerName").ToString();
            txtAddress.Text = gvwCustomers.GetRowCellValue(gvwCustomers.FocusedRowHandle, "cstAddress").ToString();
            txtLandPhone.Text = gvwCustomers.GetRowCellValue(gvwCustomers.FocusedRowHandle, "cstLandPhone").ToString();
            txtMobile.Text = gvwCustomers.GetRowCellValue(gvwCustomers.FocusedRowHandle, "cstMobile").ToString();
            chkActive.Checked = Convert.ToBoolean(gvwCustomers.GetRowCellValue(gvwCustomers.FocusedRowHandle, "cstIsActive"));
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            _isNew = true;
            MakeEmpty();
            txtCustomerID.Text = _customers.GetNextCustomerId();
            chkActive.Checked = true;
            MakeEnable(false);
            txtCustomerName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwCustomers.IsDataRow(gvwCustomers.FocusedRowHandle)) return;
            _isNew = false;
            MakeEnable(false);
            txtCustomerName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            _customers.BeginTran();
            if (_isNew)
            {
                if (_customers.InsertCustomer(txtCustomerID.Text, txtCustomerName.Text, txtAddress.Text.Replace("'","''"), txtLandPhone.Text, txtMobile.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _customers.CommitTran();
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
                    _customers.RollbackTran();
                }
            }
            else
            {
                if (_customers.UpdateCustomer(txtCustomerID.Text, txtCustomerName.Text, txtAddress.Text.Replace("'", "''"), txtLandPhone.Text, txtMobile.Text, chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    _customers.CommitTran();
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
                    _customers.RollbackTran();
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
            if (!gvwCustomers.IsDataRow(gvwCustomers.FocusedRowHandle)) return;
            if (gvwCustomers.SelectedRowsCount <= 0) return;
            if (XtraMessageBox.Show("Are you sure to delete the selected customer?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_customers.IsRefferedInSales((gvwCustomers.GetRowCellValue(gvwCustomers.FocusedRowHandle, "cstCustomerId").ToString())))
                {
                    XtraMessageBox.Show("Cannot delete the customer. Found a reference in Sales.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _customers.BeginTran();
                if (_customers.DeleteCustomer(gvwCustomers.GetRowCellValue(gvwCustomers.FocusedRowHandle, "cstCustomerId").ToString(), Program.UserName))
                {
                    _customers.CommitTran();
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
                    _customers.RollbackTran();
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
            using (var report = new Report())
            {
                report.Load(@"Reports\rptCustomers.frx");
                report.RegisterData(_customers.GetCompanyInformation(), "CompanyInformation");
                report.RegisterData(_customers.GetAllCustomers(), "Customers");
                report.GetDataSource("CompanyInformation").Enabled = true;
                report.GetDataSource("Customers").Enabled = true;
                report.Show();
            }
        }
    }
}