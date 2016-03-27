using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TradeManagement_DAL;

namespace TradeManagement.Forms
{
    public partial class frmVAT : XtraForm
    {
        readonly clsCommon _clsCommon = new clsCommon();

        public frmVAT()
        {
            InitializeComponent();
        }

        private void frmVAT_Load(object sender, EventArgs e)
        {
            txtVATRegNo.Text = _clsCommon.GetVATRegNo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _clsCommon.BeginTran();
            if (_clsCommon.UpdateVATRegNo(txtVATRegNo.Text))
            {
                _clsCommon.CommitTran();
                XtraMessageBox.Show("VAT Registration No updated successfully.", "VAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _clsCommon.RollbackTran();
                XtraMessageBox.Show("VAT Registration No did not updated successfully. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}