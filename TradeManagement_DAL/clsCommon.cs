using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using VistaDB.Provider;

namespace TradeManagement_DAL
{
    public class clsCommon
    {
        readonly VistaDBConnection _connection = new VistaDBConnection("Data Source=" + Application.StartupPath + "\\Data\\Database.data;Open Mode=NonExclusiveReadWrite;Password=p@ssw0rd");
        VistaDBTransaction _transaction;

        public void BeginTran()
        {
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }
        public void CommitTran()
        {
            _transaction.Commit();
            _connection.Close();
        }

        public void RollbackTran()
        {
            _transaction.Rollback();
            _connection.Close();
        }

        protected DataTable Query(string query)
        {
            try
            {
                _connection.Open();
                using (var dataadapter = new VistaDBDataAdapter(query, _connection))
                {
                    var dataset = new DataSet();
                    dataadapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
            catch(Exception e)
            {
                XtraMessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
            finally
            {
                _connection.Close();
            }
        }

        protected bool Command(string cmd)
        {
            using (var command = new VistaDBCommand(cmd, _connection) { Transaction = _transaction })
                return command.ExecuteNonQuery() > 0;
        }
        public DataTable GetLicenseInformation()
        {
            return Query("SELECT * FROM License");
        }

        public bool UpdateLicenseInformation(string lcnMachineCode, string lcnSerialNo, string lcnIsLicenseValid)
        {
            return Command("UPDATE License SET lcnMachineCode = '" + lcnMachineCode + "', lcnSerialNo = '" + lcnSerialNo + "', lcnIsLicenseValid = " + lcnIsLicenseValid + ", lcnLastUseDate = GETDATE()");
        }

        public bool UpdateLicenseInformation(string lcnIsLicenseValid)
        {
            return Command("UPDATE License SET lcnIsLicenseValid = " + lcnIsLicenseValid + ", lcnLastUseDate = GETDATE()");
        }

        public DataTable GetCompanyInformation()
        {
            return Query("SELECT * FROM CompanyInformation");
        }

        public string GetTheme()
        {
            return Query("SELECT optTheme FROM Options").Rows[0][0].ToString();
        }

        public void SaveTheme(string optTheme)
        {
            Command("UPDATE Options SET optTheme = '" + optTheme + "'");
        }

        public DataTable GetAllSuppliers()
        {
            return Query("SELECT supSupplierId, supSupplierName FROM Suppliers WHERE supIsActive = 1 AND supIsDelete = 0 ORDER BY supSupplierName");
        }

        public DataTable GetAllVoucherNo(string purSupplierId)
        {
            return Query($"SELECT purPurchaseId, purVoucherNo FROM Purchases WHERE purSupplierId = '{purSupplierId}' AND purIsDelete = 0");
        }

        public DataTable GetAllCustomers()
        {
            return Query("SELECT cstCustomerID, cstCustomerName FROM Customers WHERE cstIsActive = 1 AND cstIsDelete = 0 ORDER BY cstCustomerName");
        }

        public DataTable GetAllBankAccounts()
        {
            return Query("SELECT bacBankName + ' - ' + bacAccountNo AS bacBankAccount, bacAccountId FROM BankAccounts ORDER BY 1");
        }

        public DataTable GetAllInvoiceNo(string slsCustomerId)
        {
            return Query($"SELECT slsInvoiceNo FROM Sales WHERE slsCustomerId = '{slsCustomerId}' AND slsIsDelete = 0");
        }

        public bool IncreaseStock(string pdtProductId, string pdtStockQuantity)
        {
            return Command($"UPDATE Products SET pdtStockQuantity = pdtStockQuantity + {pdtStockQuantity} WHERE pdtProductId = '{pdtProductId}'");
        }

        public bool DecreaseStock(string pdtProductId, string pdtStockQuantity)
        {
            return Command($"UPDATE Products SET pdtStockQuantity = pdtStockQuantity - {pdtStockQuantity} WHERE pdtProductId = '{pdtProductId}'");
        }

        public string GetVATRegNo()
        {
            return Query("SELECT vatRegistrationNo FROM VAT").Rows[0][0].ToString();
        }

        public bool UpdateVATRegNo(string vatRegistrationNo)
        {
            return Command("UPDATE VAT SET vatRegistrationNo = " + vatRegistrationNo);
        }

        public bool IsValidUser(string usrUserName, string usrPassword)
        {
            return Query($"SELECT * FROM Users JOIN UserGroups ON usrUserGroupName = grpUserGroupName WHERE usrUserName = '{Encrypt(usrUserName, "Saikat")}' AND usrPassword = '{Encrypt(usrPassword, "Saikat")}' AND usrIsActive = 1 AND grpIsActive = 1").Rows.Count > 0;
        }

        public string GetUserGroup(string usrUserName)
        {
            return Query($"SELECT usrUserGroupName FROM Users WHERE usrUserName = '{usrUserName}'").Rows[0]["usrUserGroupName"].ToString();
        }

        public string GetPermissionByUser(string usrUserName)
        {
            return Query($"SELECT grpPermission FROM UserGroups WHERE grpUserGroupName = (SELECT usrUserGroupName FROM Users WHERE usrUserName = '{usrUserName}')").Rows[0]["grpPermission"].ToString();
        }

        public DataTable GetStatistics()
        {
            return Query(@"SELECT (SELECT COUNT(*) FROM Sales WHERE slsIsDelete = 0 AND slsSalesDate = CONVERT(VARCHAR, GETDATE(), 101)) AS TotalSaleCount,
                        (SELECT ISNULL(SUM(slsNetTotal), 0) FROM vwSales WHERE slsSalesDate = CONVERT(VARCHAR, GETDATE(), 101)) AS TotalSaleAmount,
                        (SELECT ISNULL(SUM(slsNetTotal), 0) FROM vwSales WHERE slsSalesDate = CONVERT(VARCHAR, GETDATE(), 101) AND slsInvoiceNo = (SELECT MAX(slsInvoiceNo) FROM Sales)) AS LastSaleAmount,
                        (SELECT ISNULL(MAX(slsInvoiceNo), '-') FROM Sales WHERE slsIsDelete = 0 AND slsSalesDate = CONVERT(VARCHAR, GETDATE(), 101)) AS LastInvoiceNo");
        }

        private const string Salt = "Susmita";
        internal static string HashAlgorithm = "SHA1";
        internal static int PasswordIterations = 2;
        internal static string InitialVector = "OFRna73m*aze01xY";
        internal static int KeySize = 256;

        public string Encrypt(string plainText, string password)
        {
            if (string.IsNullOrEmpty(plainText)) return "";
            var initialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
            var saltValueBytes = Encoding.ASCII.GetBytes(Salt);
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            var derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, HashAlgorithm, PasswordIterations);
            var keyBytes = derivedPassword.GetBytes(KeySize / 8);
            var symmetricKey = new RijndaelManaged { Mode = CipherMode.CBC };
            byte[] cipherTextBytes;
            using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                using (var memStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memStream.ToArray();
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }
            symmetricKey.Clear();
            return Convert.ToBase64String(cipherTextBytes);
        }

        public string Decrypt(string cipherText, string password)
        {
            if (string.IsNullOrEmpty(cipherText)) return "";
            var initialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
            var saltValueBytes = Encoding.ASCII.GetBytes(Salt);
            var cipherTextBytes = Convert.FromBase64String(cipherText);
            var derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, HashAlgorithm, PasswordIterations);
            var keyBytes = derivedPassword.GetBytes(KeySize / 8);
            var symmetricKey = new RijndaelManaged { Mode = CipherMode.CBC };
            var plainTextBytes = new byte[cipherTextBytes.Length];
            int byteCount;
            using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes))
            {
                using (var memStream = new MemoryStream(cipherTextBytes))
                {
                    using (var cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                    {

                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                        memStream.Close();
                        cryptoStream.Close();
                    }
                }
            }
            symmetricKey.Clear();
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }
    }
}