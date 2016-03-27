using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TradeManagement.Properties;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmUserGroups : XtraForm
    {
        readonly clsUserGroups userGroups = new clsUserGroups();
        static bool isNew;

        public frmUserGroups()
        {
            InitializeComponent();
        }

        private void MakeEmpty()
        {
            txtGroupName.Text = string.Empty;
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
            var dataTable = userGroups.GetAllUserGroups();
            foreach (DataRow row in dataTable.Rows)
                row["grpUserGroupName"] = userGroups.Decrypt(row["grpUserGroupName"].ToString(), "Saikat");
            grdUserGroups.DataSource = dataTable;
            gvwUserGroups.ExpandAllGroups();
        }

        private void frmUserGroups_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void grdUserGroups_Click(object sender, EventArgs e)
        {
            if (grpMain.Enabled) return;
            MakeEmpty();
            if (!gvwUserGroups.IsDataRow(gvwUserGroups.FocusedRowHandle)) return;
            txtGroupName.Text = gvwUserGroups.GetRowCellValue(gvwUserGroups.FocusedRowHandle, "grpUserGroupName").ToString();
            chkActive.Checked = Convert.ToBoolean(gvwUserGroups.GetRowCellValue(gvwUserGroups.FocusedRowHandle, "grpIsActive"));
        }

        private void bbtnNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            isNew = true;
            MakeEmpty();
            MakeEnable(false);
            txtGroupName.Properties.ReadOnly = false;
            chkActive.Checked = true;
            txtGroupName.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!gvwUserGroups.IsDataRow(gvwUserGroups.FocusedRowHandle)) return;
            if (gvwUserGroups.GetRowCellValue(gvwUserGroups.FocusedRowHandle, "grpUserGroupName").ToString() == "ADMINISTRATOR")
            {
                XtraMessageBox.Show("This group cannot be edited.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isNew = false;
            MakeEnable(false);
            txtGroupName.Properties.ReadOnly = true;
            chkActive.Focus();
            sitmStatus.Caption = string.Empty;
            sitmStatus.Glyph = null;
        }

        private void bbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            userGroups.BeginTran();
            if (isNew)
            {
                if (userGroups.InsertUserGroup(userGroups.Encrypt(txtGroupName.Text, "Saikat"), chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    userGroups.CommitTran();
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
                    userGroups.RollbackTran();
                }
            }
            else
            {
                if (userGroups.UpdateUserGroup(userGroups.Encrypt(txtGroupName.Text, "Saikat"), chkActive.Checked ? "1" : "0", Program.UserName))
                {
                    userGroups.CommitTran();
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
                    userGroups.RollbackTran();
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
            if (!gvwUserGroups.IsDataRow(gvwUserGroups.FocusedRowHandle)) return;
            if (gvwUserGroups.SelectedRowsCount <= 0) return;
            if (gvwUserGroups.GetRowCellValue(gvwUserGroups.FocusedRowHandle, "grpUserGroupName").ToString() == "ADMINISTRATOR")
            {
                XtraMessageBox.Show("This group cannot be deleted.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (XtraMessageBox.Show("Are you sure to delete the selected group?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (userGroups.IsRefferedInUsers(userGroups.Encrypt(gvwUserGroups.GetRowCellValue(gvwUserGroups.FocusedRowHandle, "grpUserGroupName").ToString(), "Saikat")))
                {
                    XtraMessageBox.Show("Cannot delete the group. Found a reference in Users.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                userGroups.BeginTran();
                if (userGroups.DeleteUserGroup(userGroups.Encrypt(gvwUserGroups.GetRowCellValue(gvwUserGroups.FocusedRowHandle, "grpUserGroupName").ToString(), "Saikat"), Program.UserName))
                {
                    userGroups.CommitTran();
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
                    userGroups.RollbackTran();
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