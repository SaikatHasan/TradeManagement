using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SKGL;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmLogin : XtraForm
    {
        private readonly clsCommon _common = new clsCommon();
        readonly SerialKeyConfiguration _serialKeyConfiguration = new SerialKeyConfiguration();

        public frmLogin()
        {
            InitializeComponent();
            if (Program.ValidateLicense(DateTime.Today)) return;
            var machineCode = new Generate(_serialKeyConfiguration).MachineCode;
            _common.BeginTran();
            _common.UpdateLicenseInformation(machineCode.ToString(), "0");
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