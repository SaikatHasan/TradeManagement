using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using SKGL;
using TradeManagement.Forms;
using TradeManagement_DAL;

namespace TradeManagement
{
    internal static class Program
    {
        private static readonly clsCommon Common = new clsCommon();
        static readonly SerialKeyConfiguration SerialKeyConfiguration = new SerialKeyConfiguration();

        public static string UserName = string.Empty;

        [STAThread]
        private static void Main()
        {
            //try
            //{
                BonusSkins.Register();
                SkinManager.EnableFormSkins();
                SkinManager.EnableMdiFormSkins();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public static bool ValidateLicense(DateTime checkDate)
        {
            var machineCode = new Generate(SerialKeyConfiguration).MachineCode;
            var skc = new SerialKeyConfiguration();
            var licenseInformation = Common.GetLicenseInformation(machineCode.ToString());
            if (licenseInformation.Rows.Count == 0) return false;
            if (Convert.ToBoolean(licenseInformation.Rows[0]["lcnIsLicenseValid"]) == false) return false;
            //var key = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("AlphaSoftTradeManagement");
            //if (key == null) return false;
            try
            {
                var validate = new Validate(skc)
                {
                    //Key = key.GetValue("SerialNo").ToString(),
                    Key = licenseInformation.Rows[0]["lcnSerialNo"].ToString(),
                    secretPhase = "91b53799-75d5-4590-90fd-c1f64b41cd47"
                };
                return validate.IsValid && validate.IsOnRightMachine && validate.ExpireDate >= checkDate;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}