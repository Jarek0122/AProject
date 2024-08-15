namespace AProject.FOrder
{
    partial class FrmOrderManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblOrder = new System.Windows.Forms.Label();
            this.btnOrderRefresh = new System.Windows.Forms.Button();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderUpdate = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnOrderRead = new System.Windows.Forms.Button();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblDonation = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnReviewRefresh = new System.Windows.Forms.Button();
            this.btnReviewCreate = new System.Windows.Forms.Button();
            this.btnReviewDelete = new System.Windows.Forms.Button();
            this.btnReviewUpdate = new System.Windows.Forms.Button();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnReviewRead = new System.Windows.Forms.Button();
            this.btnDonateRefresh = new System.Windows.Forms.Button();
            this.btnDonateCreate = new System.Windows.Forms.Button();
            this.btnDonateDelete = new System.Windows.Forms.Button();
            this.btnDonateUpdate = new System.Windows.Forms.Button();
            this.txtDonate = new System.Windows.Forms.TextBox();
            this.btnDonateRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(545, 190);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrder.Location = new System.Drawing.Point(12, 7);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(105, 29);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "訂單管理";
            // 
            // btnOrderRefresh
            // 
            this.btnOrderRefresh.Location = new System.Drawing.Point(12, 39);
            this.btnOrderRefresh.Name = "btnOrderRefresh";
            this.btnOrderRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnOrderRefresh.TabIndex = 3;
            this.btnOrderRefresh.Text = "重整";
            this.btnOrderRefresh.UseVisualStyleBackColor = true;
            this.btnOrderRefresh.Click += new System.EventHandler(this.btnOrderRefresh_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Location = new System.Drawing.Point(93, 39);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(75, 23);
            this.btnOrderDelete.TabIndex = 4;
            this.btnOrderDelete.Text = "刪除";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.Location = new System.Drawing.Point(174, 39);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnOrderUpdate.TabIndex = 5;
            this.btnOrderUpdate.Text = "修改";
            this.btnOrderUpdate.UseVisualStyleBackColor = true;
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(255, 37);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(221, 25);
            this.txtOrder.TabIndex = 6;
            // 
            // btnOrderRead
            // 
            this.btnOrderRead.Location = new System.Drawing.Point(482, 39);
            this.btnOrderRead.Name = "btnOrderRead";
            this.btnOrderRead.Size = new System.Drawing.Size(75, 23);
            this.btnOrderRead.TabIndex = 7;
            this.btnOrderRead.Text = "查詢";
            this.btnOrderRead.UseVisualStyleBackColor = true;
            this.btnOrderRead.Click += new System.EventHandler(this.btnOrderRead_Click);
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblReview.Location = new System.Drawing.Point(571, 7);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(105, 29);
            this.lblReview.TabIndex = 8;
            this.lblReview.Text = "評價管理";
            // 
            // lblDonation
            // 
            this.lblDonation.AutoSize = true;
            this.lblDonation.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDonation.Location = new System.Drawing.Point(12, 261);
            this.lblDonation.Name = "lblDonation";
            this.lblDonation.Size = new System.Drawing.Size(151, 29);
            this.lblDonation.TabIndex = 9;
            this.lblDonation.Text = "捐款紀錄管理";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 322);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(545, 119);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(576, 100);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(240, 341);
            this.dataGridView3.TabIndex = 11;
            this.dataGridView3.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_RowEnter);
            // 
            // btnReviewRefresh
            // 
            this.btnReviewRefresh.Location = new System.Drawing.Point(741, 10);
            this.btnReviewRefresh.Name = "btnReviewRefresh";
            this.btnReviewRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnReviewRefresh.TabIndex = 12;
            this.btnReviewRefresh.Text = "重整";
            this.btnReviewRefresh.UseVisualStyleBackColor = true;
            this.btnReviewRefresh.Click += new System.EventHandler(this.btnReviewRefresh_Click);
            // 
            // btnReviewCreate
            // 
            this.btnReviewCreate.Location = new System.Drawing.Point(576, 39);
            this.btnReviewCreate.Name = "btnReviewCreate";
            this.btnReviewCreate.Size = new System.Drawing.Size(75, 23);
            this.btnReviewCreate.TabIndex = 13;
            this.btnReviewCreate.Text = "新增";
            this.btnReviewCreate.UseVisualStyleBackColor = true;
            this.btnReviewCreate.Click += new System.EventHandler(this.btnReviewCreate_Click);
            // 
            // btnReviewDelete
            // 
            this.btnReviewDelete.Location = new System.Drawing.Point(660, 39);
            this.btnReviewDelete.Name = "btnReviewDelete";
            this.btnReviewDelete.Size = new System.Drawing.Size(75, 23);
            this.btnReviewDelete.TabIndex = 14;
            this.btnReviewDelete.Text = "刪除";
            this.btnReviewDelete.UseVisualStyleBackColor = true;
            this.btnReviewDelete.Click += new System.EventHandler(this.btnReviewDelete_Click);
            // 
            // btnReviewUpdate
            // 
            this.btnReviewUpdate.Location = new System.Drawing.Point(741, 39);
            this.btnReviewUpdate.Name = "btnReviewUpdate";
            this.btnReviewUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnReviewUpdate.TabIndex = 15;
            this.btnReviewUpdate.Text = "修改";
            this.btnReviewUpdate.UseVisualStyleBackColor = true;
            this.btnReviewUpdate.Click += new System.EventHandler(this.btnReviewUpdate_Click);
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(576, 68);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(159, 25);
            this.txtReview.TabIndex = 16;
            // 
            // btnReviewRead
            // 
            this.btnReviewRead.Location = new System.Drawing.Point(741, 70);
            this.btnReviewRead.Name = "btnReviewRead";
            this.btnReviewRead.Size = new System.Drawing.Size(75, 23);
            this.btnReviewRead.TabIndex = 17;
            this.btnReviewRead.Text = "查詢";
            this.btnReviewRead.UseVisualStyleBackColor = true;
            this.btnReviewRead.Click += new System.EventHandler(this.btnReviewRead_Click);
            // 
            // btnDonateRefresh
            // 
            this.btnDonateRefresh.Location = new System.Drawing.Point(12, 293);
            this.btnDonateRefresh.Name = "btnDonateRefresh";
            this.btnDonateRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnDonateRefresh.TabIndex = 18;
            this.btnDonateRefresh.Text = "重整";
            this.btnDonateRefresh.UseVisualStyleBackColor = true;
            this.btnDonateRefresh.Click += new System.EventHandler(this.btnDonateRefresh_Click);
            // 
            // btnDonateCreate
            // 
            this.btnDonateCreate.Location = new System.Drawing.Point(93, 293);
            this.btnDonateCreate.Name = "btnDonateCreate";
            this.btnDonateCreate.Size = new System.Drawing.Size(75, 23);
            this.btnDonateCreate.TabIndex = 19;
            this.btnDonateCreate.Text = "新增";
            this.btnDonateCreate.UseVisualStyleBackColor = true;
            this.btnDonateCreate.Click += new System.EventHandler(this.btnDonateCreate_Click);
            // 
            // btnDonateDelete
            // 
            this.btnDonateDelete.Location = new System.Drawing.Point(174, 293);
            this.btnDonateDelete.Name = "btnDonateDelete";
            this.btnDonateDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDonateDelete.TabIndex = 20;
            this.btnDonateDelete.Text = "刪除";
            this.btnDonateDelete.UseVisualStyleBackColor = true;
            this.btnDonateDelete.Click += new System.EventHandler(this.btnDonateDelete_Click);
            // 
            // btnDonateUpdate
            // 
            this.btnDonateUpdate.Location = new System.Drawing.Point(255, 293);
            this.btnDonateUpdate.Name = "btnDonateUpdate";
            this.btnDonateUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDonateUpdate.TabIndex = 21;
            this.btnDonateUpdate.Text = "修改";
            this.btnDonateUpdate.UseVisualStyleBackColor = true;
            this.btnDonateUpdate.Click += new System.EventHandler(this.btnDonateUpdate_Click);
            // 
            // txtDonate
            // 
            this.txtDonate.Location = new System.Drawing.Point(336, 291);
            this.txtDonate.Name = "txtDonate";
            this.txtDonate.Size = new System.Drawing.Size(140, 25);
            this.txtDonate.TabIndex = 22;
            // 
            // btnDonateRead
            // 
            this.btnDonateRead.Location = new System.Drawing.Point(482, 293);
            this.btnDonateRead.Name = "btnDonateRead";
            this.btnDonateRead.Size = new System.Drawing.Size(75, 23);
            this.btnDonateRead.TabIndex = 0;
            this.btnDonateRead.Text = "查詢";
            this.btnDonateRead.Click += new System.EventHandler(this.btnDonateRead_Click);
            // 
            // FrmOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 453);
            this.Controls.Add(this.btnDonateRead);
            this.Controls.Add(this.txtDonate);
            this.Controls.Add(this.btnDonateUpdate);
            this.Controls.Add(this.btnDonateDelete);
            this.Controls.Add(this.btnDonateCreate);
            this.Controls.Add(this.btnDonateRefresh);
            this.Controls.Add(this.btnReviewRead);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.btnReviewUpdate);
            this.Controls.Add(this.btnReviewDelete);
            this.Controls.Add(this.btnReviewCreate);
            this.Controls.Add(this.btnReviewRefresh);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblDonation);
            this.Controls.Add(this.lblReview);
            this.Controls.Add(this.btnOrderRead);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.btnOrderUpdate);
            this.Controls.Add(this.btnOrderDelete);
            this.Controls.Add(this.btnOrderRefresh);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOrderManager";
            this.Text = "FrmOrderManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOrderManager_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmOrderManager_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnOrderRefresh;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderUpdate;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnOrderRead;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblDonation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnReviewRefresh;
        private System.Windows.Forms.Button btnReviewCreate;
        private System.Windows.Forms.Button btnReviewDelete;
        private System.Windows.Forms.Button btnReviewUpdate;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Button btnReviewRead;
        private System.Windows.Forms.Button btnDonateRefresh;
        private System.Windows.Forms.Button btnDonateCreate;
        private System.Windows.Forms.Button btnDonateDelete;
        private System.Windows.Forms.Button btnDonateUpdate;
        private System.Windows.Forms.TextBox txtDonate;
        private System.Windows.Forms.Button btnDonateRead;
    }
}