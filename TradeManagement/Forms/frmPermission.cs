using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    using System.Linq;

    public partial class frmPermission : XtraForm
    {
        readonly clsUserGroups userGroups = new clsUserGroups();

        public frmPermission()
        {
            InitializeComponent();
        }

        private void frmPermission_Load(object sender, EventArgs e)
        {
            var dataTable = userGroups.GetAllUserGroups();
            foreach (DataRow row in dataTable.Rows)
            {
                row["grpUserGroupName"] = userGroups.Decrypt(row["grpUserGroupName"].ToString(), "Saikat");
                cmbUserGroup.Properties.Items.Add(row["grpUserGroupName"].ToString());
            }
        }

        private void cmbUserGroup_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbUserGroup.Text == null) return;
            tlpOptions.Enabled = cmbUserGroup.Text != "ADMINISTRATOR";
            foreach (var chk in tlpOptions.Controls.Cast<Control>().Where(chk => chk.GetType() == typeof(CheckEdit)))
                ((CheckEdit)chk).CheckedChanged -= CheckBoxes_CheckedChanged;
            var permission = userGroups.GetPermission(userGroups.Encrypt(cmbUserGroup.Text, "Saikat"));
            foreach (var chk in tlpOptions.Controls.Cast<Control>().Where(chk => chk.GetType() == typeof(CheckEdit)))
            {
                ((CheckEdit)chk).Checked = false;
                if (permission.IndexOf(chk.Name.Remove(0, 3)) == -1) continue;
                ((CheckEdit)chk).Checked = Convert.ToBoolean(Convert.ToInt16(permission.Substring(permission.IndexOf(chk.Name.Remove(0, 3), 0) + chk.Name.Remove(0, 3).Length, 1)));
            }
            foreach (var chk in tlpOptions.Controls.Cast<Control>().Where(chk => chk.GetType() == typeof(CheckEdit)))
                ((CheckEdit)chk).CheckedChanged += CheckBoxes_CheckedChanged;
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbUserGroup.Text == null) return;
            var permission = userGroups.GetPermission(userGroups.Encrypt(cmbUserGroup.Text, "Saikat"));
            var find = ((CheckEdit)sender).Name.Remove(0, 3) + Convert.ToInt16(!((CheckEdit)sender).Checked);
            var replace = ((CheckEdit)sender).Name.Remove(0, 3) + Convert.ToInt16(((CheckEdit)sender).Checked);
            if (permission.IndexOf(find, 0) != -1)
                permission = permission.Replace(find, replace);
            else
                permission += replace;
            userGroups.BeginTran();
            if (userGroups.UpdatePermission(userGroups.Encrypt(cmbUserGroup.Text, "Saikat"), permission, Program.UserName))
                userGroups.CommitTran();
            else
                userGroups.RollbackTran();
        }
    }
}