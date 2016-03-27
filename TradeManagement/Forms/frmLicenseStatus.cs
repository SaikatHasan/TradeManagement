using System;
using DevExpress.XtraEditors;
using SKGL;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmLicenseStatus : XtraForm
    {
        private readonly clsCommon _common = new clsCommon();
        
        public frmLicenseStatus()
        {
            InitializeComponent();
        }

        private void frmLicenseStatus_Load(object sender, EventArgs e)
        {
            var skc = new SerialKeyConfiguration();
            var licenseInformation = _common.GetLicenseInformation();
            //var key = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("AlphaSoftTradeManagement");
            //if (key == null) return;
            var validate = new Validate(skc)
            {
                //Key = key.GetValue("SerialNo").ToString(),
                Key = licenseInformation.Rows[0]["lcnSerialNo"].ToString(),
                secretPhase = "91b53799-75d5-4590-90fd-c1f64b41cd47"
            };
            if (validate.IsValid && validate.IsOnRightMachine && validate.ExpireDate >= DateTime.Today)
                lblStatus.Text = "You have a valid license installed. Your license will expire after " +
                                 validate.DaysLeft + " days on " + validate.ExpireDate.ToString("MMM dd, yyyy") +
                                 ". Thank you for using a valid license.";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}