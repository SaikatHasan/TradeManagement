using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmLogin : XtraForm
    {
        private readonly clsCommon _common = new clsCommon();

        public frmLogin()
        {
            InitializeComponent();
            if (Program.ValidateLicense(DateTime.Today)) return;
            _common.BeginTran();
            _common.UpdateLicenseInformation("0");
            _common.CommitTran();
            frmRegistration.Instance().ShowDialog();
        }

        private void CheckUser()
        {
            if (_common.IsValidUser(txtUserName.Text, txtPassword.Text))
            {
                Program.UserName = _common.Encrypt(txtUserName.Text, "Saikat");
                Hide();
            }
            else
            {
                XtraMessageBox.Show("Invalid user name or password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                CheckUser();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckUser();
        }
    }
}