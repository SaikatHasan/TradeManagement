using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TradeManagement.Forms
{
    public partial class frmBarcodeCount : XtraForm
    {
        public frmBarcodeCount()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}