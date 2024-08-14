namespace AProject.FOrder
{
    partial class FrmOrderEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.cbOrderStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.cbServiceStatus = new System.Windows.Forms.ComboBox();
            this.lblShippingStatus = new System.Windows.Forms.Label();
            this.cbShippingStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentInfo = new System.Windows.Forms.Label();
            this.cbPaymentInfo = new System.Windows.Forms.ComboBox();
            this.lblShippingInfo = new System.Windows.Forms.Label();
            this.cbShippingInfo = new System.Windows.Forms.ComboBox();
            this.lblReturnInfo = new System.Windows.Forms.Label();
            this.cbReturnInfo = new System.Windows.Forms.ComboBox();
            this.fbPrice = new prjCustomerSystem.FieldBox();
            this.fbPromotionId = new prjCustomerSystem.FieldBox();
            this.fbQuantity = new prjCustomerSystem.FieldBox();
            this.fbProductId = new prjCustomerSystem.FieldBox();
            this.fbOrderDate = new prjCustomerSystem.FieldBox();
            this.fbUserId = new prjCustomerSystem.FieldBox();
            this.fbInvoiceInfo = new prjCustomerSystem.FieldBox();
            this.fbRecepientName = new prjCustomerSystem.FieldBox();
            this.fbRecepientAddress = new prjCustomerSystem.FieldBox();
            this.fbRecepientPhone = new prjCustomerSystem.FieldBox();
            this.fbRecepientEmail = new prjCustomerSystem.FieldBox();
            this.lblOrderRemarks = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtOrderRemarks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(12, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 46);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "編輯訂單";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderStatus.Location = new System.Drawing.Point(206, 19);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(92, 25);
            this.lblOrderStatus.TabIndex = 17;
            this.lblOrderStatus.Text = "訂單狀態";
            this.lblOrderStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbOrderStatus
            // 
            this.cbOrderStatus.FormattingEnabled = true;
            this.cbOrderStatus.Location = new System.Drawing.Point(304, 21);
            this.cbOrderStatus.Name = "cbOrderStatus";
            this.cbOrderStatus.Size = new System.Drawing.Size(86, 23);
            this.cbOrderStatus.TabIndex = 16;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(407, 19);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(92, 25);
            this.lblPaymentStatus.TabIndex = 22;
            this.lblPaymentStatus.Text = "付款狀態";
            this.lblPaymentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Location = new System.Drawing.Point(505, 21);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(86, 23);
            this.cbPaymentStatus.TabIndex = 21;
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblServiceStatus.Location = new System.Drawing.Point(407, 94);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(92, 25);
            this.lblServiceStatus.TabIndex = 24;
            this.lblServiceStatus.Text = "服務狀態";
            this.lblServiceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbServiceStatus
            // 
            this.cbServiceStatus.FormattingEnabled = true;
            this.cbServiceStatus.Location = new System.Drawing.Point(505, 96);
            this.cbServiceStatus.Name = "cbServiceStatus";
            this.cbServiceStatus.Size = new System.Drawing.Size(86, 23);
            this.cbServiceStatus.TabIndex = 23;
            // 
            // lblShippingStatus
            // 
            this.lblShippingStatus.AutoSize = true;
            this.lblShippingStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShippingStatus.Location = new System.Drawing.Point(407, 57);
            this.lblShippingStatus.Name = "lblShippingStatus";
            this.lblShippingStatus.Size = new System.Drawing.Size(92, 25);
            this.lblShippingStatus.TabIndex = 26;
            this.lblShippingStatus.Text = "配送狀態";
            this.lblShippingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbShippingStatus
            // 
            this.cbShippingStatus.FormattingEnabled = true;
            this.cbShippingStatus.Location = new System.Drawing.Point(505, 59);
            this.cbShippingStatus.Name = "cbShippingStatus";
            this.cbShippingStatus.Size = new System.Drawing.Size(86, 23);
            this.cbShippingStatus.TabIndex = 25;
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPaymentInfo.Location = new System.Drawing.Point(603, 19);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(92, 25);
            this.lblPaymentInfo.TabIndex = 28;
            this.lblPaymentInfo.Text = "付款方式";
            this.lblPaymentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPaymentInfo
            // 
            this.cbPaymentInfo.FormattingEnabled = true;
            this.cbPaymentInfo.Location = new System.Drawing.Point(701, 21);
            this.cbPaymentInfo.Name = "cbPaymentInfo";
            this.cbPaymentInfo.Size = new System.Drawing.Size(86, 23);
            this.cbPaymentInfo.TabIndex = 27;
            // 
            // lblShippingInfo
            // 
            this.lblShippingInfo.AutoSize = true;
            this.lblShippingInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblShippingInfo.Location = new System.Drawing.Point(603, 57);
            this.lblShippingInfo.Name = "lblShippingInfo";
            this.lblShippingInfo.Size = new System.Drawing.Size(92, 25);
            this.lblShippingInfo.TabIndex = 30;
            this.lblShippingInfo.Text = "配送方式";
            this.lblShippingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbShippingInfo
            // 
            this.cbShippingInfo.FormattingEnabled = true;
            this.cbShippingInfo.Location = new System.Drawing.Point(701, 59);
            this.cbShippingInfo.Name = "cbShippingInfo";
            this.cbShippingInfo.Size = new System.Drawing.Size(86, 23);
            this.cbShippingInfo.TabIndex = 29;
            // 
            // lblReturnInfo
            // 
            this.lblReturnInfo.AutoSize = true;
            this.lblReturnInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReturnInfo.Location = new System.Drawing.Point(603, 94);
            this.lblReturnInfo.Name = "lblReturnInfo";
            this.lblReturnInfo.Size = new System.Drawing.Size(92, 25);
            this.lblReturnInfo.TabIndex = 32;
            this.lblReturnInfo.Text = "退貨方式";
            this.lblReturnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbReturnInfo
            // 
            this.cbReturnInfo.FormattingEnabled = true;
            this.cbReturnInfo.Location = new System.Drawing.Point(701, 96);
            this.cbReturnInfo.Name = "cbReturnInfo";
            this.cbReturnInfo.Size = new System.Drawing.Size(86, 23);
            this.cbReturnInfo.TabIndex = 31;
            // 
            // fbPrice
            // 
            this.fbPrice.fieldName = "結帳金額";
            this.fbPrice.fieldValue = "";
            this.fbPrice.Location = new System.Drawing.Point(17, 243);
            this.fbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbPrice.Name = "fbPrice";
            this.fbPrice.Size = new System.Drawing.Size(375, 38);
            this.fbPrice.TabIndex = 20;
            // 
            // fbPromotionId
            // 
            this.fbPromotionId.fieldName = "折　　扣";
            this.fbPromotionId.fieldValue = "";
            this.fbPromotionId.Location = new System.Drawing.Point(222, 197);
            this.fbPromotionId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbPromotionId.Name = "fbPromotionId";
            this.fbPromotionId.Size = new System.Drawing.Size(170, 38);
            this.fbPromotionId.TabIndex = 19;
            // 
            // fbQuantity
            // 
            this.fbQuantity.fieldName = "商品數量";
            this.fbQuantity.fieldValue = "";
            this.fbQuantity.Location = new System.Drawing.Point(17, 197);
            this.fbQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbQuantity.Name = "fbQuantity";
            this.fbQuantity.Size = new System.Drawing.Size(170, 38);
            this.fbQuantity.TabIndex = 18;
            // 
            // fbProductId
            // 
            this.fbProductId.fieldName = "商品編號";
            this.fbProductId.fieldValue = "";
            this.fbProductId.Location = new System.Drawing.Point(17, 151);
            this.fbProductId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbProductId.Name = "fbProductId";
            this.fbProductId.Size = new System.Drawing.Size(375, 38);
            this.fbProductId.TabIndex = 15;
            // 
            // fbOrderDate
            // 
            this.fbOrderDate.fieldName = "訂單日期";
            this.fbOrderDate.fieldValue = "";
            this.fbOrderDate.Location = new System.Drawing.Point(17, 105);
            this.fbOrderDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbOrderDate.Name = "fbOrderDate";
            this.fbOrderDate.Size = new System.Drawing.Size(375, 38);
            this.fbOrderDate.TabIndex = 14;
            // 
            // fbUserId
            // 
            this.fbUserId.fieldName = "會員編號";
            this.fbUserId.fieldValue = "";
            this.fbUserId.Location = new System.Drawing.Point(17, 59);
            this.fbUserId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbUserId.Name = "fbUserId";
            this.fbUserId.Size = new System.Drawing.Size(375, 38);
            this.fbUserId.TabIndex = 13;
            // 
            // fbInvoiceInfo
            // 
            this.fbInvoiceInfo.fieldName = "發票資訊";
            this.fbInvoiceInfo.fieldValue = "";
            this.fbInvoiceInfo.Location = new System.Drawing.Point(17, 289);
            this.fbInvoiceInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbInvoiceInfo.Name = "fbInvoiceInfo";
            this.fbInvoiceInfo.Size = new System.Drawing.Size(375, 38);
            this.fbInvoiceInfo.TabIndex = 33;
            // 
            // fbRecepientName
            // 
            this.fbRecepientName.fieldName = "收件人姓名";
            this.fbRecepientName.fieldValue = "";
            this.fbRecepientName.Location = new System.Drawing.Point(412, 151);
            this.fbRecepientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbRecepientName.Name = "fbRecepientName";
            this.fbRecepientName.Size = new System.Drawing.Size(375, 38);
            this.fbRecepientName.TabIndex = 34;
            // 
            // fbRecepientAddress
            // 
            this.fbRecepientAddress.fieldName = "收件人地址";
            this.fbRecepientAddress.fieldValue = "";
            this.fbRecepientAddress.Location = new System.Drawing.Point(412, 197);
            this.fbRecepientAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbRecepientAddress.Name = "fbRecepientAddress";
            this.fbRecepientAddress.Size = new System.Drawing.Size(375, 38);
            this.fbRecepientAddress.TabIndex = 35;
            // 
            // fbRecepientPhone
            // 
            this.fbRecepientPhone.fieldName = "收件人電話";
            this.fbRecepientPhone.fieldValue = "";
            this.fbRecepientPhone.Location = new System.Drawing.Point(412, 243);
            this.fbRecepientPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbRecepientPhone.Name = "fbRecepientPhone";
            this.fbRecepientPhone.Size = new System.Drawing.Size(375, 38);
            this.fbRecepientPhone.TabIndex = 36;
            // 
            // fbRecepientEmail
            // 
            this.fbRecepientEmail.fieldName = "收件人信箱";
            this.fbRecepientEmail.fieldValue = "";
            this.fbRecepientEmail.Location = new System.Drawing.Point(412, 289);
            this.fbRecepientEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbRecepientEmail.Name = "fbRecepientEmail";
            this.fbRecepientEmail.Size = new System.Drawing.Size(375, 38);
            this.fbRecepientEmail.TabIndex = 37;
            // 
            // lblOrderRemarks
            // 
            this.lblOrderRemarks.AutoSize = true;
            this.lblOrderRemarks.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderRemarks.Location = new System.Drawing.Point(13, 334);
            this.lblOrderRemarks.Name = "lblOrderRemarks";
            this.lblOrderRemarks.Size = new System.Drawing.Size(92, 25);
            this.lblOrderRemarks.TabIndex = 39;
            this.lblOrderRemarks.Text = "訂單備註";
            this.lblOrderRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(581, 408);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(687, 408);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 40;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtOrderRemarks
            // 
            this.txtOrderRemarks.Location = new System.Drawing.Point(107, 334);
            this.txtOrderRemarks.Multiline = true;
            this.txtOrderRemarks.Name = "txtOrderRemarks";
            this.txtOrderRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrderRemarks.Size = new System.Drawing.Size(283, 104);
            this.txtOrderRemarks.TabIndex = 42;
            // 
            // FrmOrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOrderRemarks);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblOrderRemarks);
            this.Controls.Add(this.fbRecepientEmail);
            this.Controls.Add(this.fbRecepientPhone);
            this.Controls.Add(this.fbRecepientAddress);
            this.Controls.Add(this.fbRecepientName);
            this.Controls.Add(this.fbInvoiceInfo);
            this.Controls.Add(this.lblReturnInfo);
            this.Controls.Add(this.cbReturnInfo);
            this.Controls.Add(this.lblShippingInfo);
            this.Controls.Add(this.cbShippingInfo);
            this.Controls.Add(this.lblPaymentInfo);
            this.Controls.Add(this.cbPaymentInfo);
            this.Controls.Add(this.lblShippingStatus);
            this.Controls.Add(this.cbShippingStatus);
            this.Controls.Add(this.lblServiceStatus);
            this.Controls.Add(this.cbServiceStatus);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.cbPaymentStatus);
            this.Controls.Add(this.fbPrice);
            this.Controls.Add(this.fbPromotionId);
            this.Controls.Add(this.fbQuantity);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.cbOrderStatus);
            this.Controls.Add(this.fbProductId);
            this.Controls.Add(this.fbOrderDate);
            this.Controls.Add(this.fbUserId);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmOrderEditor";
            this.Text = "FrmOrderEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private prjCustomerSystem.FieldBox fbUserId;
        private prjCustomerSystem.FieldBox fbOrderDate;
        private prjCustomerSystem.FieldBox fbProductId;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.ComboBox cbOrderStatus;
        private prjCustomerSystem.FieldBox fbQuantity;
        private prjCustomerSystem.FieldBox fbPromotionId;
        private prjCustomerSystem.FieldBox fbPrice;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.ComboBox cbServiceStatus;
        private System.Windows.Forms.Label lblShippingStatus;
        private System.Windows.Forms.ComboBox cbShippingStatus;
        private System.Windows.Forms.Label lblPaymentInfo;
        private System.Windows.Forms.ComboBox cbPaymentInfo;
        private System.Windows.Forms.Label lblShippingInfo;
        private System.Windows.Forms.ComboBox cbShippingInfo;
        private System.Windows.Forms.Label lblReturnInfo;
        private System.Windows.Forms.ComboBox cbReturnInfo;
        private prjCustomerSystem.FieldBox fbInvoiceInfo;
        private prjCustomerSystem.FieldBox fbRecepientName;
        private prjCustomerSystem.FieldBox fbRecepientAddress;
        private prjCustomerSystem.FieldBox fbRecepientPhone;
        private prjCustomerSystem.FieldBox fbRecepientEmail;
        private System.Windows.Forms.Label lblOrderRemarks;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtOrderRemarks;
    }
}