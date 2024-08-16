namespace AProject.Component
{
    partial class ActBox
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxActName = new System.Windows.Forms.TextBox();
            this.labelActName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.boxActLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.boxActFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxActNMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.boxActEditorD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxActAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.boxActCloseD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxActStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ActBox_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(613, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(311, 167);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boxActName);
            this.panel1.Controls.Add(this.labelActName);
            this.panel1.Location = new System.Drawing.Point(188, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 26);
            this.panel1.TabIndex = 8;
            // 
            // boxActName
            // 
            this.boxActName.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxActName.Enabled = false;
            this.boxActName.Font = new System.Drawing.Font("新細明體", 10F);
            this.boxActName.Location = new System.Drawing.Point(89, 0);
            this.boxActName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxActName.Name = "boxActName";
            this.boxActName.Size = new System.Drawing.Size(312, 27);
            this.boxActName.TabIndex = 1;
            this.boxActName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelActName
            // 
            this.labelActName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelActName.Font = new System.Drawing.Font("新細明體", 10F);
            this.labelActName.Location = new System.Drawing.Point(0, 0);
            this.labelActName.Name = "labelActName";
            this.labelActName.Size = new System.Drawing.Size(89, 26);
            this.labelActName.TabIndex = 0;
            this.labelActName.Text = "活動名稱";
            this.labelActName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // boxActLocation
            // 
            this.boxActLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxActLocation.Enabled = false;
            this.boxActLocation.Font = new System.Drawing.Font("新細明體", 10F);
            this.boxActLocation.Location = new System.Drawing.Point(89, 0);
            this.boxActLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxActLocation.Name = "boxActLocation";
            this.boxActLocation.Size = new System.Drawing.Size(312, 27);
            this.boxActLocation.TabIndex = 1;
            this.boxActLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("新細明體", 10F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "地   點";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.boxActLocation);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(188, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 26);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.boxActFee);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.boxActNMax);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(188, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 26);
            this.panel3.TabIndex = 11;
            // 
            // boxActFee
            // 
            this.boxActFee.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxActFee.Enabled = false;
            this.boxActFee.Font = new System.Drawing.Font("新細明體", 10F);
            this.boxActFee.Location = new System.Drawing.Point(267, 0);
            this.boxActFee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxActFee.Name = "boxActFee";
            this.boxActFee.Size = new System.Drawing.Size(134, 27);
            this.boxActFee.TabIndex = 3;
            this.boxActFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("新細明體", 10F);
            this.label4.Location = new System.Drawing.Point(178, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "報名費用";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxActNMax
            // 
            this.boxActNMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxActNMax.Enabled = false;
            this.boxActNMax.Font = new System.Drawing.Font("新細明體", 10F);
            this.boxActNMax.Location = new System.Drawing.Point(89, 0);
            this.boxActNMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxActNMax.Name = "boxActNMax";
            this.boxActNMax.Size = new System.Drawing.Size(89, 27);
            this.boxActNMax.TabIndex = 1;
            this.boxActNMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "人數上限";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.boxActEditorD);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.boxActAccount);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(188, 97);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 26);
            this.panel4.TabIndex = 12;
            // 
            // boxActEditorD
            // 
            this.boxActEditorD.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxActEditorD.Enabled = false;
            this.boxActEditorD.Font = new System.Drawing.Font("新細明體", 10F);
            this.boxActEditorD.Location = new System.Drawing.Point(267, 0);
            this.boxActEditorD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxActEditorD.Name = "boxActEditorD";
            this.boxActEditorD.Size = new System.Drawing.Size(134, 27);
            this.boxActEditorD.TabIndex = 3;
            this.boxActEditorD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("新細明體", 10F);
            this.label5.Location = new System.Drawing.Point(178, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "更新日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxActAccount
            // 
            this.boxActAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxActAccount.Enabled = false;
            this.boxActAccount.Font = new System.Drawing.Font("新細明體", 10F);
            this.boxActAccount.Location = new System.Drawing.Point(89, 0);
            this.boxActAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxActAccount.Name = "boxActAccount";
            this.boxActAccount.Size = new System.Drawing.Size(89, 27);
            this.boxActAccount.TabIndex = 1;
            this.boxActAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("新細明體", 10F);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "更新帳號";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.boxActCloseD);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.boxActStatus);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(188, 128);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(418, 26);
            this.panel5.TabIndex = 13;
            // 
            // boxActCloseD
            // 
            this.boxActCloseD.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxActCloseD.Enabled = false;
            this.boxActCloseD.Font = new System.Drawing.Font("新細明體", 10F);
            this.boxActCloseD.Location = new System.Drawing.Point(267, 0);
            this.boxActCloseD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxActCloseD.Name = "boxActCloseD";
            this.boxActCloseD.Size = new System.Drawing.Size(134, 27);
            this.boxActCloseD.TabIndex = 3;
            this.boxActCloseD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(178, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "結案日期";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxActStatus
            // 
            this.boxActStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.boxActStatus.Enabled = false;
            this.boxActStatus.Font = new System.Drawing.Font("新細明體", 10F);
            this.boxActStatus.Location = new System.Drawing.Point(89, 0);
            this.boxActStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxActStatus.Name = "boxActStatus";
            this.boxActStatus.Size = new System.Drawing.Size(89, 27);
            this.boxActStatus.TabIndex = 1;
            this.boxActStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("新細明體", 10F);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "公開狀態";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ActBox";
            this.Size = new System.Drawing.Size(924, 167);
            this.Load += new System.EventHandler(this.ActBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox boxActName;
        private System.Windows.Forms.Label labelActName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox boxActLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox boxActFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxActNMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox boxActEditorD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxActAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox boxActStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxActCloseD;
        private System.Windows.Forms.Label label1;
    }
}
