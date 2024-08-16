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
    public partial class FrmOrderEditor : Form
    {
        private COrder _order = null;
        private COrderDetail _orderdetail = null;
        public FrmOrderEditor()
        {
            InitializeComponent();
            cbOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrderStatus.Items.Add("待處理");
            cbOrderStatus.Items.Add("處理中");
            cbOrderStatus.Items.Add("已完成");
            cbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentStatus.Items.Add("未付款");
            cbPaymentStatus.Items.Add("已付款");
            cbShippingStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbShippingStatus.Items.Add("未配送");
            cbShippingStatus.Items.Add("已送達");
            cbServiceStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbServiceStatus.Items.Add("未完成");
            cbServiceStatus.Items.Add("已完成");
            cbPaymentInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentInfo.Items.Add("刷卡");
            cbPaymentInfo.Items.Add("貨到付款");
            cbShippingInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbShippingInfo.Items.Add("宅配");
            cbShippingInfo.Items.Add("超商取貨");
            cbShippingInfo.Items.Add("郵局寄送");
            cbReturnInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReturnInfo.Items.Add(" ");
            cbReturnInfo.Items.Add("宅配");
            cbReturnInfo.Items.Add("自行寄回");
        }

        public DialogResult isOk { get; set; }

        public COrder order
        {
            get
            {
                if (_order == null)
                    _order = new COrder();
                _order.fUserId = Convert.ToInt32(fbUserId.fieldValue);
                _order.fOrderDate = fbOrderDate.fieldValue;
                _order.fOrderStatus = Convert.ToString(cbOrderStatus.SelectedItem);
                _order.fPromotionId = Convert.ToInt32(fbPromotionId.fieldValue);
                if (cbPaymentStatus.SelectedItem != null)
                {
                    string selectedStatus = cbPaymentStatus.SelectedItem.ToString();
                    if (selectedStatus == "已付款")
                    {
                        _order.fPaymentStatus = true;
                    }
                    else if (selectedStatus == "未付款")
                    {
                        _order.fPaymentStatus = false;
                    }
                }
                if (cbShippingStatus.SelectedItem != null)
                {
                    string selectedStatus = cbShippingStatus.SelectedItem.ToString();
                    if (selectedStatus == "已送達")
                    {
                        _order.fShippingStatus = true;
                    }
                    else if (selectedStatus == "未配送")
                    {
                        _order.fShippingStatus = false;
                    }
                }
                if (cbServiceStatus.SelectedItem != null)
                {
                    string selectedStatus = cbServiceStatus.SelectedItem.ToString();
                    if (selectedStatus == "已完成")
                    {
                        _order.fServiceStatus = true;
                    }
                    else if (selectedStatus == "未完成")
                    {
                        _order.fServiceStatus = false;
                    }
                }
                //_order.fPaymentStatus = Convert.ToBoolean(cbPaymentStatus.SelectedItem);
                //_order.fShippingStatus = Convert.ToBoolean(cbShippingStatus.SelectedItem);
                //_order.fServiceStatus = Convert.ToBoolean(cbServiceStatus.SelectedItem);
                _order.fPaymentInfo = Convert.ToString(cbPaymentInfo.SelectedItem);
                _order.fShippingInfo = Convert.ToString(cbShippingInfo.SelectedItem);
                _order.fInvoiceInfo = fbInvoiceInfo.fieldValue;
                _order.fRecepientName = fbRecepientName.fieldValue;
                _order.fRecepientAddress = fbRecepientAddress.fieldValue;
                _order.fRecepientPhone = fbRecepientPhone.fieldValue;
                _order.fRecepientEmail = fbRecepientEmail.fieldValue;
                _order.fOrderRemarks = txtOrderRemarks.Text;
                _order.fReturnInfo = Convert.ToString(cbReturnInfo.SelectedItem);
                return _order;
            }
            set
            {
                _order = value;
                fbUserId.fieldValue = _order.fUserId.ToString();
                fbOrderDate.fieldValue = _order.fOrderDate.ToString();
                cbOrderStatus.SelectedItem = _order.fOrderStatus.ToString();
                fbPromotionId.fieldValue = _order.fPromotionId.ToString();
                cbPaymentStatus.SelectedItem = _order.fPaymentStatus.ToString();
                cbShippingStatus.SelectedItem = _order.fShippingStatus.ToString();
                cbServiceStatus.SelectedItem = _order.fServiceStatus.ToString();
                //cbPaymentStatus.SelectedItem = _order.fPaymentStatus ? "已付款" : "未付款";
                //cbShippingStatus.SelectedItem = _order.fShippingStatus ? "已送達" : "未配送";
                //cbServiceStatus.SelectedItem = _order.fServiceStatus ? "已完成" : "未完成";
                cbPaymentInfo.SelectedItem = _order.fPaymentInfo.ToString();
                cbShippingInfo.SelectedItem = _order.fShippingInfo.ToString();
                fbInvoiceInfo.fieldValue = _order.fInvoiceInfo.ToString();
                fbRecepientName.fieldValue = _order.fRecepientName.ToString();
                fbRecepientAddress.fieldValue = _order.fRecepientAddress.ToString();
                fbRecepientPhone.fieldValue = _order.fRecepientPhone.ToString();
                fbRecepientEmail.fieldValue = _order.fRecepientEmail.ToString();
                txtOrderRemarks.Text = _order.fOrderRemarks.ToString();
                cbReturnInfo.SelectedItem = _order.fReturnInfo.ToString();
            }
        }



        public COrderDetail orderdetail
        {
            get
            {
                if (_orderdetail == null)
                    _orderdetail = new COrderDetail();
                _orderdetail.fProductId = Convert.ToInt32(fbProductId.fieldValue);
                _orderdetail.fQuantity = Convert.ToInt32(fbQuantity.fieldValue);
                _orderdetail.fPrice = Convert.ToDecimal(fbPrice.fieldValue);
                return _orderdetail;
            }
            set
            {
                _orderdetail = value;
                fbProductId.fieldValue = _orderdetail.fProductId.ToString();
                fbQuantity.fieldValue = _orderdetail.fQuantity.ToString();
                fbPrice.fieldValue = _orderdetail.fPrice.ToString();
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
