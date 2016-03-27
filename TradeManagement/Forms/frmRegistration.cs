using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SKGL;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmRegistration : XtraForm
    {
        private readonly clsCommon _common = new clsCommon();
        readonly SerialKeyConfiguration _serialKeyConfiguration = new SerialKeyConfiguration();

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            txtMachineCode.EditValue = new Generate(_serialKeyConfiguration).MachineCode;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSerialNumber.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Please enter the serial number.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var validate = new Validate(_serialKeyConfiguration) { Key = txtSerialNumber.EditValue.ToString(), secretPhase = "91b53799-75d5-4590-90fd-c1f64b41cd47" };
            if (validate.IsValid && validate.IsOnRightMachine && !validate.IsExpired)
            {
                _common.BeginTran();
                _common.UpdateLicenseInformation(txtMachineCode.EditValue.ToString(), txtSerialNumber.EditValue.ToString(), "1");
                _common.CommitTran();
                //var key = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("AlphaSoftTradeManagement");
                //if (key == null) return;
                //key.SetValue("MachineCode", txtMachineCode.EditValue.ToString());
                //key.SetValue("SerialNo", txtSerialNumber.EditValue.ToString());
                XtraMessageBox.Show("Software registered/licensed successfully. Your license will be valid until " + validate.ExpireDate.ToLongDateString() + ".\n\nThank you for using valid license.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
            {
                XtraMessageBox.Show("Wrong Serial Number.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}