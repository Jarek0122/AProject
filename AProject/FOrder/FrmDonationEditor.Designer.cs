namespace AProject.FOrder
{
    partial class FrmDonationEditor
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fbAmount = new prjCustomerSystem.FieldBox();
            this.fbDonationDate = new prjCustomerSystem.FieldBox();
            this.fbCompanyId = new prjCustomerSystem.FieldBox();
            this.fbUserId = new prjCustomerSystem.FieldBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(12, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 46);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(269, 395);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fbAmount
            // 
            this.fbAmount.fieldName = "捐款金額";
            this.fbAmount.fieldValue = "";
            this.fbAmount.Location = new System.Drawing.Point(13, 306);
            this.fbAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbAmount.Name = "fbAmount";
            this.fbAmount.Size = new System.Drawing.Size(356, 38);
            this.fbAmount.TabIndex = 3;
            // 
            // fbDonationDate
            // 
            this.fbDonationDate.fieldName = "捐款日期";
            this.fbDonationDate.fieldValue = "";
            this.fbDonationDate.Location = new System.Drawing.Point(13, 240);
            this.fbDonationDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbDonationDate.Name = "fbDonationDate";
            this.fbDonationDate.Size = new System.Drawing.Size(356, 38);
            this.fbDonationDate.TabIndex = 2;
            // 
            // fbCompanyId
            // 
            this.fbCompanyId.fieldName = "廠商編號";
            this.fbCompanyId.fieldValue = "";
            this.fbCompanyId.Location = new System.Drawing.Point(13, 175);
            this.fbCompanyId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbCompanyId.Name = "fbCompanyId";
            this.fbCompanyId.Size = new System.Drawing.Size(356, 38);
            this.fbCompanyId.TabIndex = 1;
            // 
            // fbUserId
            // 
            this.fbUserId.fieldName = "會員編號";
            this.fbUserId.fieldValue = "";
            this.fbUserId.Location = new System.Drawing.Point(13, 111);
            this.fbUserId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbUserId.Name = "fbUserId";
            this.fbUserId.Size = new System.Drawing.Size(356, 38);
            this.fbUserId.TabIndex = 0;
            // 
            // FrmDonationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.fbAmount);
            this.Controls.Add(this.fbDonationDate);
            this.Controls.Add(this.fbCompanyId);
            this.Controls.Add(this.fbUserId);
            this.Name = "FrmDonationEditor";
            this.Text = "FrmDonationEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private prjCustomerSystem.FieldBox fbUserId;
        private prjCustomerSystem.FieldBox fbCompanyId;
        private prjCustomerSystem.FieldBox fbDonationDate;
        private prjCustomerSystem.FieldBox fbAmount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}