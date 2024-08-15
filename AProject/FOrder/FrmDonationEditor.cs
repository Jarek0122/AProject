using AProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AProject.FOrder
{
    public partial class FrmDonationEditor : Form
    {
        private CDonation _donation = null;
        public FrmDonationEditor()
        {
            InitializeComponent();
        }

        public DialogResult isOk { get; set; }

        public string title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public CDonation donation
        {
            get
            {
                if (_donation == null)
                    _donation = new CDonation();
                _donation.fUserId = Convert.ToInt32(fbUserId.fieldValue);
                _donation.fCompanyId = Convert.ToInt32(fbCompanyId.fieldValue);
                _donation.fDonationDate = fbDonationDate.fieldValue;
                _donation.fAmount = Convert.ToDecimal(fbAmount.fieldValue);
                return _donation;
            }

            set
            {
                _donation = value;
                fbUserId.fieldValue = _donation.fUserId.ToString();
                fbCompanyId.fieldValue = _donation.fCompanyId.ToString();
                fbDonationDate.fieldValue = _donation.fDonationDate.ToString();
                fbAmount.fieldValue = _donation.fAmount.ToString();
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.isOk = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
