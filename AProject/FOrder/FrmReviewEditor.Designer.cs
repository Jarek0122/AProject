namespace AProject.FOrder
{
    partial class FrmReviewEditor
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
            this.cbScore = new System.Windows.Forms.ComboBox();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.fbReviewDate = new prjCustomerSystem.FieldBox();
            this.fbProductId = new prjCustomerSystem.FieldBox();
            this.fbOrderId = new prjCustomerSystem.FieldBox();
            this.fbUserId = new prjCustomerSystem.FieldBox();
            this.SuspendLayout();
            // 
            // cbScore
            // 
            this.cbScore.FormattingEnabled = true;
            this.cbScore.Location = new System.Drawing.Point(327, 12);
            this.cbScore.Name = "cbScore";
            this.cbScore.Size = new System.Drawing.Size(61, 23);
            this.cbScore.TabIndex = 0;
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(105, 242);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReview.Size = new System.Drawing.Size(283, 145);
            this.txtReview.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(32, 408);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(288, 408);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReview.Location = new System.Drawing.Point(11, 237);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(92, 25);
            this.lblReview.TabIndex = 9;
            this.lblReview.Text = "評價內容";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblScore.Location = new System.Drawing.Point(229, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(92, 25);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "評價分數";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTitle.Location = new System.Drawing.Point(12, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 46);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fbReviewDate
            // 
            this.fbReviewDate.fieldName = "評價日期";
            this.fbReviewDate.fieldValue = "";
            this.fbReviewDate.Location = new System.Drawing.Point(13, 192);
            this.fbReviewDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbReviewDate.Name = "fbReviewDate";
            this.fbReviewDate.Size = new System.Drawing.Size(375, 38);
            this.fbReviewDate.TabIndex = 4;
            // 
            // fbProductId
            // 
            this.fbProductId.fieldName = "商品編號";
            this.fbProductId.fieldValue = "";
            this.fbProductId.Location = new System.Drawing.Point(13, 146);
            this.fbProductId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbProductId.Name = "fbProductId";
            this.fbProductId.Size = new System.Drawing.Size(375, 38);
            this.fbProductId.TabIndex = 3;
            // 
            // fbOrderId
            // 
            this.fbOrderId.fieldName = "訂單編號";
            this.fbOrderId.fieldValue = "";
            this.fbOrderId.Location = new System.Drawing.Point(13, 100);
            this.fbOrderId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbOrderId.Name = "fbOrderId";
            this.fbOrderId.Size = new System.Drawing.Size(375, 38);
            this.fbOrderId.TabIndex = 2;
            // 
            // fbUserId
            // 
            this.fbUserId.fieldName = "會員編號";
            this.fbUserId.fieldValue = "";
            this.fbUserId.Location = new System.Drawing.Point(13, 54);
            this.fbUserId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbUserId.Name = "fbUserId";
            this.fbUserId.Size = new System.Drawing.Size(375, 38);
            this.fbUserId.TabIndex = 1;
            // 
            // FrmReviewEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.cbScore);
            this.Controls.Add(this.fbReviewDate);
            this.Controls.Add(this.fbProductId);
            this.Controls.Add(this.fbOrderId);
            this.Controls.Add(this.fbUserId);
            this.Name = "FrmReviewEditor";
            this.Text = "FrmReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prjCustomerSystem.FieldBox fbUserId;
        private prjCustomerSystem.FieldBox fbOrderId;
        private prjCustomerSystem.FieldBox fbProductId;
        private prjCustomerSystem.FieldBox fbReviewDate;
        private System.Windows.Forms.ComboBox cbScore;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTitle;
    }
}