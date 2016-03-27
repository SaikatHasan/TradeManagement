using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmUsers : XtraForm
    {
        readonly clsUsers users = new clsUsers();
        static bool isNew;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cmbUserGroup.Text = string.Empty;
            chkActive.Checked = false;
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
            var dataTable = users.GetAllUsers();
            foreach (DataRow row in dataTable.Rows)
            {
                row["usrUserName"] = users.Decrypt(row["usrUserName"].ToString(), "Saikat");
                row["usrPassword"] = users.Decrypt(row["usrPassword"].ToString(), "Saikat");
                row["usrUserGroupName"] = users.Decrypt(row["usrUserGroupName"].ToString(), "Saikat");
            }
            grdUsers.DataSource = dataTable;
            gvwUsers.ExpandAllGroups();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            var dataTable = users.GetAllUserGroups();
            foreach (DataRow row in dataTable.Rows)
            {
                row["grpUserGroupName"] = users.Decrypt(row["grpUserGroupName"].ToString(), "Saikat");
                cmbUserGroup.Properties.Items.Add(row["grpUserGroupName"].ToString());
            }
            BindGrid();
        }

        private void grdUsers_Click(object sender, EventArgs e)
        {
            if (grpMain.Enabled) return;
            MakeEmpty();
            if (!gvwUsers.IsDataRow(gvwUsers.FocusedRowHandle)) return;
            txtUserName.Text = gvwUsers.GetRowCellValue(gvwUsers.FocusedRowHandle, "usrUserName").ToString();
            txtPassword.Text = gvwUsers.GetRowCellValue(gvwUsers.FocusedRowHandle, "usrPassword").ToString();
            cmbUserGroup.Text = gvwUsers.GetRowCellValue(gvwUsers.FocusedRowHandle, "usrUserGroupName").ToString();
            chkActive.Checked = Convert.ToBoolean(gvwUsers.GetRowCellValue(gvwUsers.FocusedRowHandle, "usrIsActive"));
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            isNew = true;
            MakeEmpty();
            MakeEnable(false);
            txtUserName.Properties.ReadOnly = false;
            chkActive.Checked = true;
            txtUserName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwUsers.IsDataRow(gvwUsers.FocusedRowHandle)) return;
            isNew = false;
            MakeEnable(false);
            txtUserName.Properties.ReadOnly = true;
            txtPassword.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (isNew)
            {
                if (users.IsUserNameUsed(users.Encrypt(txtUserName.Text, "Saikat")))
                {
                    XtraMessageBox.Show("The User Name already exists.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                users.BeginTran();
                if (users.InsertUser(users.Encrypt(txtUserName.Text, "Saikat"), users.Encrypt(txtPassword.Text, "Saikat"), users.Encrypt(cmbUserGroup.Text, "Saikat"), chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    users.CommitTran();
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
                    users.RollbackTran();
                }
            }
            else
            {
                users.BeginTran();
                if (users.UpdateUser(users.Encrypt(txtUserName.Text, "Saikat"), users.Encrypt(txtPassword.Text, "Saikat"), users.Encrypt(cmbUserGroup.Text, "Saikat"), chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    users.CommitTran();
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
                    users.RollbackTran();
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
            if (!gvwUsers.IsDataRow(gvwUsers.FocusedRowHandle)) return;
            if (gvwUsers.SelectedRowsCount <= 0) return;
            if (gvwUsers.GetRowCellValue(gvwUsers.FocusedRowHandle, "usrUserName").ToString() == "admin")
            {
                XtraMessageBox.Show("This user cannot be deleted.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (XtraMessageBox.Show("Are you sure to delete the selected user?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                users.BeginTran();
                if (users.DeleteUser(users.Encrypt(gvwUsers.GetRowCellValue(gvwUsers.FocusedRowHandle, "usrUserName").ToString(), "Saikat"), Program.UserName))
                {
                    users.CommitTran();
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
                    users.RollbackTran();
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