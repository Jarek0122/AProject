using AProject.Model;
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
    public partial class FrmReviewEditor : Form
    {
        private COrder _order = null;
        private COrderDetail _orderdetail = null;
        public FrmReviewEditor()
        {
            InitializeComponent();
            cbScore.DropDownStyle = ComboBoxStyle.DropDownList;
            cbScore.Items.Add("5");
            cbScore.Items.Add("4");
            cbScore.Items.Add("3");
            cbScore.Items.Add("2");
            cbScore.Items.Add("1");
        }

        public DialogResult isOk { get; set; }

        public string title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public COrder order
        {
            get
            {
                if (_order == null) 
                    _order = new COrder();
                _order.fUserId = Convert.ToInt32(fbUserId.fieldValue);
                _order.fOrderId = Convert.ToInt32(fbOrderId.fieldValue);
                return _order;
            }
            set
            {
                _order = value;
                fbUserId.fieldValue = _order.fUserId.ToString();
                fbOrderId.fieldValue = _order.fOrderId.ToString();
            }
        }

        public COrderDetail orderdetail
        {
            get
            {
                if (_orderdetail == null)
                    _orderdetail = new COrderDetail();
                _orderdetail.fProductId = Convert.ToInt32(fbProductId.fieldValue);
                _orderdetail.fReviewDate = fbReviewDate.fieldValue;
                _orderdetail.fReviewScore = Convert.ToInt32(cbScore.SelectedItem);
                _orderdetail.fProductReview = txtReview.Text;
                return _orderdetail;
            }
            set
            {
                _orderdetail = value;
                fbProductId.fieldValue = _orderdetail.fProductId.ToString();
                fbReviewDate.fieldValue = _orderdetail.fReviewDate.ToString();
                cbScore.SelectedItem = _orderdetail.fReviewScore.ToString();
                txtReview.Text = _orderdetail.fProductReview.ToString();
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
