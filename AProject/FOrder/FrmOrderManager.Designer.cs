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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxReview = new System.Windows.Forms.GroupBox();
            this.btnReviewRead = new System.Windows.Forms.Button();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnReviewUpdate = new System.Windows.Forms.Button();
            this.btnReviewDelete = new System.Windows.Forms.Button();
            this.btnReviewCreate = new System.Windows.Forms.Button();
            this.btnReviewRefresh = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBoxDonation = new System.Windows.Forms.GroupBox();
            this.btnDonateRead = new System.Windows.Forms.Button();
            this.txtDonate = new System.Windows.Forms.TextBox();
            this.btnDonateUpdate = new System.Windows.Forms.Button();
            this.btnDonateDelete = new System.Windows.Forms.Button();
            this.btnDonateCreate = new System.Windows.Forms.Button();
            this.btnDonateRefresh = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.btnOrderRead = new System.Windows.Forms.Button();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnOrderUpdate = new System.Windows.Forms.Button();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBoxDonation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxReview);
            this.splitContainer1.Size = new System.Drawing.Size(862, 453);
            this.splitContainer1.SplitterDistance = 559;
            this.splitContainer1.TabIndex = 23;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxOrder);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Panel2.Controls.Add(this.groupBoxDonation);
            this.splitContainer2.Size = new System.Drawing.Size(559, 453);
            this.splitContainer2.SplitterDistance = 204;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBoxReview
            // 
            this.groupBoxReview.Controls.Add(this.btnReviewRead);
            this.groupBoxReview.Controls.Add(this.txtReview);
            this.groupBoxReview.Controls.Add(this.btnReviewUpdate);
            this.groupBoxReview.Controls.Add(this.btnReviewDelete);
            this.groupBoxReview.Controls.Add(this.btnReviewCreate);
            this.groupBoxReview.Controls.Add(this.btnReviewRefresh);
            this.groupBoxReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxReview.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxReview.Location = new System.Drawing.Point(0, 0);
            this.groupBoxReview.Name = "groupBoxReview";
            this.groupBoxReview.Size = new System.Drawing.Size(299, 150);
            this.groupBoxReview.TabIndex = 25;
            this.groupBoxReview.TabStop = false;
            this.groupBoxReview.Text = "評價管理";
            // 
            // btnReviewRead
            // 
            this.btnReviewRead.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReviewRead.Location = new System.Drawing.Point(171, 107);
            this.btnReviewRead.Name = "btnReviewRead";
            this.btnReviewRead.Size = new System.Drawing.Size(75, 35);
            this.btnReviewRead.TabIndex = 30;
            this.btnReviewRead.Text = "查詢";
            this.btnReviewRead.UseVisualStyleBackColor = true;
            this.btnReviewRead.Click += new System.EventHandler(this.btnReviewRead_Click);
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(6, 106);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(159, 38);
            this.txtReview.TabIndex = 29;
            // 
            // btnReviewUpdate
            // 
            this.btnReviewUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReviewUpdate.Location = new System.Drawing.Point(171, 65);
            this.btnReviewUpdate.Name = "btnReviewUpdate";
            this.btnReviewUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnReviewUpdate.TabIndex = 28;
            this.btnReviewUpdate.Text = "修改";
            this.btnReviewUpdate.UseVisualStyleBackColor = true;
            this.btnReviewUpdate.Click += new System.EventHandler(this.btnReviewUpdate_Click);
            // 
            // btnReviewDelete
            // 
            this.btnReviewDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReviewDelete.Location = new System.Drawing.Point(87, 65);
            this.btnReviewDelete.Name = "btnReviewDelete";
            this.btnReviewDelete.Size = new System.Drawing.Size(75, 35);
            this.btnReviewDelete.TabIndex = 27;
            this.btnReviewDelete.Text = "刪除";
            this.btnReviewDelete.UseVisualStyleBackColor = true;
            this.btnReviewDelete.Click += new System.EventHandler(this.btnReviewDelete_Click);
            // 
            // btnReviewCreate
            // 
            this.btnReviewCreate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReviewCreate.Location = new System.Drawing.Point(6, 65);
            this.btnReviewCreate.Name = "btnReviewCreate";
            this.btnReviewCreate.Size = new System.Drawing.Size(75, 35);
            this.btnReviewCreate.TabIndex = 26;
            this.btnReviewCreate.Text = "新增";
            this.btnReviewCreate.UseVisualStyleBackColor = true;
            this.btnReviewCreate.Click += new System.EventHandler(this.btnReviewCreate_Click);
            // 
            // btnReviewRefresh
            // 
            this.btnReviewRefresh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReviewRefresh.Location = new System.Drawing.Point(171, 26);
            this.btnReviewRefresh.Name = "btnReviewRefresh";
            this.btnReviewRefresh.Size = new System.Drawing.Size(75, 35);
            this.btnReviewRefresh.TabIndex = 25;
            this.btnReviewRefresh.Text = "重整";
            this.btnReviewRefresh.UseVisualStyleBackColor = true;
            this.btnReviewRefresh.Click += new System.EventHandler(this.btnReviewRefresh_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 150);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(299, 303);
            this.dataGridView3.TabIndex = 26;
            this.dataGridView3.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_RowEnter);
            // 
            // groupBoxDonation
            // 
            this.groupBoxDonation.Controls.Add(this.btnDonateRead);
            this.groupBoxDonation.Controls.Add(this.txtDonate);
            this.groupBoxDonation.Controls.Add(this.btnDonateUpdate);
            this.groupBoxDonation.Controls.Add(this.btnDonateDelete);
            this.groupBoxDonation.Controls.Add(this.btnDonateCreate);
            this.groupBoxDonation.Controls.Add(this.btnDonateRefresh);
            this.groupBoxDonation.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDonation.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxDonation.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDonation.Name = "groupBoxDonation";
            this.groupBoxDonation.Size = new System.Drawing.Size(559, 84);
            this.groupBoxDonation.TabIndex = 61;
            this.groupBoxDonation.TabStop = false;
            this.groupBoxDonation.Text = "捐款紀錄管理";
            // 
            // btnDonateRead
            // 
            this.btnDonateRead.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDonateRead.Location = new System.Drawing.Point(476, 37);
            this.btnDonateRead.Name = "btnDonateRead";
            this.btnDonateRead.Size = new System.Drawing.Size(75, 35);
            this.btnDonateRead.TabIndex = 61;
            this.btnDonateRead.Text = "查詢";
            this.btnDonateRead.Click += new System.EventHandler(this.btnDonateRead_Click);
            // 
            // txtDonate
            // 
            this.txtDonate.Location = new System.Drawing.Point(330, 34);
            this.txtDonate.Name = "txtDonate";
            this.txtDonate.Size = new System.Drawing.Size(140, 38);
            this.txtDonate.TabIndex = 66;
            // 
            // btnDonateUpdate
            // 
            this.btnDonateUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDonateUpdate.Location = new System.Drawing.Point(249, 37);
            this.btnDonateUpdate.Name = "btnDonateUpdate";
            this.btnDonateUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnDonateUpdate.TabIndex = 65;
            this.btnDonateUpdate.Text = "修改";
            this.btnDonateUpdate.UseVisualStyleBackColor = true;
            this.btnDonateUpdate.Click += new System.EventHandler(this.btnDonateUpdate_Click);
            // 
            // btnDonateDelete
            // 
            this.btnDonateDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDonateDelete.Location = new System.Drawing.Point(168, 37);
            this.btnDonateDelete.Name = "btnDonateDelete";
            this.btnDonateDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDonateDelete.TabIndex = 64;
            this.btnDonateDelete.Text = "刪除";
            this.btnDonateDelete.UseVisualStyleBackColor = true;
            this.btnDonateDelete.Click += new System.EventHandler(this.btnDonateDelete_Click);
            // 
            // btnDonateCreate
            // 
            this.btnDonateCreate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDonateCreate.Location = new System.Drawing.Point(87, 37);
            this.btnDonateCreate.Name = "btnDonateCreate";
            this.btnDonateCreate.Size = new System.Drawing.Size(75, 35);
            this.btnDonateCreate.TabIndex = 63;
            this.btnDonateCreate.Text = "新增";
            this.btnDonateCreate.UseVisualStyleBackColor = true;
            this.btnDonateCreate.Click += new System.EventHandler(this.btnDonateCreate_Click);
            // 
            // btnDonateRefresh
            // 
            this.btnDonateRefresh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDonateRefresh.Location = new System.Drawing.Point(6, 37);
            this.btnDonateRefresh.Name = "btnDonateRefresh";
            this.btnDonateRefresh.Size = new System.Drawing.Size(75, 35);
            this.btnDonateRefresh.TabIndex = 62;
            this.btnDonateRefresh.Text = "重整";
            this.btnDonateRefresh.UseVisualStyleBackColor = true;
            this.btnDonateRefresh.Click += new System.EventHandler(this.btnDonateRefresh_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 84);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(559, 161);
            this.dataGridView2.TabIndex = 62;
            this.dataGridView2.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowEnter);
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.btnOrderRead);
            this.groupBoxOrder.Controls.Add(this.txtOrder);
            this.groupBoxOrder.Controls.Add(this.btnOrderUpdate);
            this.groupBoxOrder.Controls.Add(this.btnOrderDelete);
            this.groupBoxOrder.Controls.Add(this.btnOrderRefresh);
            this.groupBoxOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOrder.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxOrder.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(559, 82);
            this.groupBoxOrder.TabIndex = 53;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "訂單管理";
            // 
            // btnOrderRead
            // 
            this.btnOrderRead.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderRead.Location = new System.Drawing.Point(476, 37);
            this.btnOrderRead.Name = "btnOrderRead";
            this.btnOrderRead.Size = new System.Drawing.Size(75, 35);
            this.btnOrderRead.TabIndex = 57;
            this.btnOrderRead.Text = "查詢";
            this.btnOrderRead.UseVisualStyleBackColor = true;
            this.btnOrderRead.Click += new System.EventHandler(this.btnOrderRead_Click);
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOrder.Location = new System.Drawing.Point(249, 37);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(221, 34);
            this.txtOrder.TabIndex = 56;
            // 
            // btnOrderUpdate
            // 
            this.btnOrderUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderUpdate.Location = new System.Drawing.Point(168, 37);
            this.btnOrderUpdate.Name = "btnOrderUpdate";
            this.btnOrderUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnOrderUpdate.TabIndex = 55;
            this.btnOrderUpdate.Text = "修改";
            this.btnOrderUpdate.UseVisualStyleBackColor = true;
            this.btnOrderUpdate.Click += new System.EventHandler(this.btnOrderUpdate_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderDelete.Location = new System.Drawing.Point(87, 37);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(75, 35);
            this.btnOrderDelete.TabIndex = 54;
            this.btnOrderDelete.Text = "刪除";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderRefresh
            // 
            this.btnOrderRefresh.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderRefresh.Location = new System.Drawing.Point(6, 37);
            this.btnOrderRefresh.Name = "btnOrderRefresh";
            this.btnOrderRefresh.Size = new System.Drawing.Size(75, 35);
            this.btnOrderRefresh.TabIndex = 53;
            this.btnOrderRefresh.Text = "重整";
            this.btnOrderRefresh.UseVisualStyleBackColor = true;
            this.btnOrderRefresh.Click += new System.EventHandler(this.btnOrderRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(559, 122);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // FrmOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 453);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmOrderManager";
            this.Text = "FrmOrderManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmOrderManager_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmOrderManager_Paint);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxReview.ResumeLayout(false);
            this.groupBoxReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBoxDonation.ResumeLayout(false);
            this.groupBoxDonation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBoxReview;
        private System.Windows.Forms.Button btnReviewRead;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Button btnReviewUpdate;
        private System.Windows.Forms.Button btnReviewDelete;
        private System.Windows.Forms.Button btnReviewCreate;
        private System.Windows.Forms.Button btnReviewRefresh;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBoxDonation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDonateRead;
        private System.Windows.Forms.TextBox txtDonate;
        private System.Windows.Forms.Button btnDonateUpdate;
        private System.Windows.Forms.Button btnDonateDelete;
        private System.Windows.Forms.Button btnDonateCreate;
        private System.Windows.Forms.Button btnDonateRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.Button btnOrderRead;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Button btnOrderUpdate;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderRefresh;
    }
}