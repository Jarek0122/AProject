namespace AProject.FAd
{
    partial class FrmAdverTisement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdverTisement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.adadd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbNet = new System.Windows.Forms.TextBox();
            this.LbImagepath = new System.Windows.Forms.TextBox();
            this.Btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.Choosetype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdDGV = new System.Windows.Forms.DataGridView();
            this.廣告名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.會員名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.廣告類型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.圖片路徑 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.網站連結 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adDataSet = new AProject.adDataSet();
            this.btnreset = new System.Windows.Forms.Button();
            this.Btnwrite = new System.Windows.Forms.Button();
            this.Btnsave = new System.Windows.Forms.Button();
            this.SelectAd = new System.Windows.Forms.ComboBox();
            this.Lbadtype = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBad = new System.Windows.Forms.TextBox();
            this.Lbuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.廣告名稱 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.adadd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 507);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 247);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.ForeColor = System.Drawing.Color.YellowGreen;
            this.exit.Location = new System.Drawing.Point(63, 247);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(112, 55);
            this.exit.TabIndex = 0;
            this.exit.Text = "離開";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // adadd
            // 
            this.adadd.AutoSize = true;
            this.adadd.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.adadd.ForeColor = System.Drawing.Color.YellowGreen;
            this.adadd.Location = new System.Drawing.Point(63, 11);
            this.adadd.Name = "adadd";
            this.adadd.Size = new System.Drawing.Size(200, 55);
            this.adadd.TabIndex = 0;
            this.adadd.Text = "廣告上架";
            this.adadd.Click += new System.EventHandler(this.adadd_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.LbNet);
            this.panel2.Controls.Add(this.LbImagepath);
            this.panel2.Controls.Add(this.Btnupdate);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.Choosetype);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AdDGV);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.Btnwrite);
            this.panel2.Controls.Add(this.Btnsave);
            this.panel2.Controls.Add(this.SelectAd);
            this.panel2.Controls.Add(this.Lbadtype);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LBad);
            this.panel2.Controls.Add(this.Lbuser);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.廣告名稱);
            this.panel2.Location = new System.Drawing.Point(212, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 507);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LbNet
            // 
            this.LbNet.Location = new System.Drawing.Point(422, 117);
            this.LbNet.Name = "LbNet";
            this.LbNet.Size = new System.Drawing.Size(239, 39);
            this.LbNet.TabIndex = 10;
            // 
            // LbImagepath
            // 
            this.LbImagepath.Location = new System.Drawing.Point(89, 117);
            this.LbImagepath.Name = "LbImagepath";
            this.LbImagepath.Size = new System.Drawing.Size(239, 39);
            this.LbImagepath.TabIndex = 10;
            // 
            // Btnupdate
            // 
            this.Btnupdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btnupdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btnupdate.ForeColor = System.Drawing.SystemColors.Window;
            this.Btnupdate.Location = new System.Drawing.Point(419, 209);
            this.Btnupdate.Name = "Btnupdate";
            this.Btnupdate.Size = new System.Drawing.Size(106, 42);
            this.Btnupdate.TabIndex = 9;
            this.Btnupdate.Text = "更新";
            this.Btnupdate.UseVisualStyleBackColor = false;
            this.Btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btndelete.Location = new System.Drawing.Point(347, 155);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(106, 42);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "刪除";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Choosetype
            // 
            this.Choosetype.FormattingEnabled = true;
            this.Choosetype.Items.AddRange(new object[] {
            "逾時廣告",
            "常駐廣告"});
            this.Choosetype.Location = new System.Drawing.Point(267, 217);
            this.Choosetype.Name = "Choosetype";
            this.Choosetype.Size = new System.Drawing.Size(121, 38);
            this.Choosetype.TabIndex = 7;
            this.Choosetype.Text = "選定分類";
            this.Choosetype.SelectionChangeCommitted += new System.EventHandler(this.Choosetype_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(118, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 55);
            this.label4.TabIndex = 6;
            this.label4.Text = "廣告列表";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(286, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "賺錢囉";
            // 
            // AdDGV
            // 
            this.AdDGV.AutoGenerateColumns = false;
            this.AdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.AdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.廣告名,
            this.會員名稱,
            this.廣告類型,
            this.圖片路徑,
            this.網站連結});
            this.AdDGV.DataSource = this.adDataSetBindingSource;
            this.AdDGV.EnableHeadersVisualStyles = false;
            this.AdDGV.GridColor = System.Drawing.Color.LightGray;
            this.AdDGV.Location = new System.Drawing.Point(7, 257);
            this.AdDGV.Name = "AdDGV";
            this.AdDGV.ReadOnly = true;
            this.AdDGV.RowHeadersVisible = false;
            this.AdDGV.RowHeadersWidth = 62;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.AdDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AdDGV.RowTemplate.Height = 24;
            this.AdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdDGV.Size = new System.Drawing.Size(643, 244);
            this.AdDGV.TabIndex = 5;
            this.AdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 廣告名
            // 
            this.廣告名.DataPropertyName = "AdName";
            this.廣告名.HeaderText = "廣告名";
            this.廣告名.MinimumWidth = 8;
            this.廣告名.Name = "廣告名";
            this.廣告名.ReadOnly = true;
            // 
            // 會員名稱
            // 
            this.會員名稱.DataPropertyName = "UserName";
            this.會員名稱.HeaderText = "會員名稱";
            this.會員名稱.MinimumWidth = 8;
            this.會員名稱.Name = "會員名稱";
            this.會員名稱.ReadOnly = true;
            // 
            // 廣告類型
            // 
            this.廣告類型.DataPropertyName = "Adtype";
            this.廣告類型.HeaderText = "廣告類型";
            this.廣告類型.MinimumWidth = 8;
            this.廣告類型.Name = "廣告類型";
            this.廣告類型.ReadOnly = true;
            // 
            // 圖片路徑
            // 
            this.圖片路徑.DataPropertyName = "ImagePath";
            this.圖片路徑.HeaderText = "圖片路徑";
            this.圖片路徑.MinimumWidth = 8;
            this.圖片路徑.Name = "圖片路徑";
            this.圖片路徑.ReadOnly = true;
            // 
            // 網站連結
            // 
            this.網站連結.DataPropertyName = "Link";
            this.網站連結.HeaderText = "網站連結";
            this.網站連結.MinimumWidth = 8;
            this.網站連結.Name = "網站連結";
            this.網站連結.ReadOnly = true;
            // 
            // adDataSetBindingSource
            // 
            this.adDataSetBindingSource.DataSource = this.adDataSet;
            this.adDataSetBindingSource.Position = 0;
            // 
            // adDataSet
            // 
            this.adDataSet.DataSetName = "adDataSet";
            this.adDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnreset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.Window;
            this.btnreset.Location = new System.Drawing.Point(484, 155);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(106, 42);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "重置";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Btnwrite
            // 
            this.Btnwrite.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btnwrite.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btnwrite.ForeColor = System.Drawing.SystemColors.Window;
            this.Btnwrite.Location = new System.Drawing.Point(208, 155);
            this.Btnwrite.Name = "Btnwrite";
            this.Btnwrite.Size = new System.Drawing.Size(106, 42);
            this.Btnwrite.TabIndex = 4;
            this.Btnwrite.Text = "編輯";
            this.Btnwrite.UseVisualStyleBackColor = false;
            this.Btnwrite.Click += new System.EventHandler(this.Btnwrite_Click);
            // 
            // Btnsave
            // 
            this.Btnsave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Btnsave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btnsave.ForeColor = System.Drawing.SystemColors.Window;
            this.Btnsave.Location = new System.Drawing.Point(61, 155);
            this.Btnsave.Name = "Btnsave";
            this.Btnsave.Size = new System.Drawing.Size(106, 42);
            this.Btnsave.TabIndex = 3;
            this.Btnsave.Text = "新增";
            this.Btnsave.UseVisualStyleBackColor = false;
            this.Btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // SelectAd
            // 
            this.SelectAd.FormattingEnabled = true;
            this.SelectAd.Items.AddRange(new object[] {
            "逾時廣告",
            "常駐廣告"});
            this.SelectAd.Location = new System.Drawing.Point(310, 73);
            this.SelectAd.Name = "SelectAd";
            this.SelectAd.Size = new System.Drawing.Size(121, 38);
            this.SelectAd.TabIndex = 2;
            this.SelectAd.TabStop = false;
            this.SelectAd.Text = "全部分類";
            // 
            // Lbadtype
            // 
            this.Lbadtype.AutoSize = true;
            this.Lbadtype.BackColor = System.Drawing.SystemColors.Window;
            this.Lbadtype.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lbadtype.ForeColor = System.Drawing.Color.Black;
            this.Lbadtype.Location = new System.Drawing.Point(305, 50);
            this.Lbadtype.Name = "Lbadtype";
            this.Lbadtype.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbadtype.Size = new System.Drawing.Size(109, 30);
            this.Lbadtype.TabIndex = 1;
            this.Lbadtype.Text = "廣告類型";
            this.Lbadtype.Click += new System.EventHandler(this.廣告名稱_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(152, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "會員名稱";
            this.label1.Click += new System.EventHandler(this.廣告名稱_Click);
            // 
            // LBad
            // 
            this.LBad.Location = new System.Drawing.Point(7, 72);
            this.LBad.Name = "LBad";
            this.LBad.Size = new System.Drawing.Size(122, 39);
            this.LBad.TabIndex = 0;
            this.LBad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Lbuser
            // 
            this.Lbuser.Location = new System.Drawing.Point(156, 73);
            this.Lbuser.Name = "Lbuser";
            this.Lbuser.Size = new System.Drawing.Size(122, 39);
            this.Lbuser.TabIndex = 0;
            this.Lbuser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(343, 120);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "網站連結";
            this.label5.Click += new System.EventHandler(this.廣告名稱_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "圖片路徑";
            this.label2.Click += new System.EventHandler(this.廣告名稱_Click);
            // 
            // 廣告名稱
            // 
            this.廣告名稱.AutoSize = true;
            this.廣告名稱.BackColor = System.Drawing.SystemColors.Window;
            this.廣告名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.廣告名稱.ForeColor = System.Drawing.Color.Black;
            this.廣告名稱.Location = new System.Drawing.Point(10, 50);
            this.廣告名稱.Name = "廣告名稱";
            this.廣告名稱.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.廣告名稱.Size = new System.Drawing.Size(109, 30);
            this.廣告名稱.TabIndex = 1;
            this.廣告名稱.Text = "廣告名稱";
            this.廣告名稱.Click += new System.EventHandler(this.廣告名稱_Click);
            // 
            // FrmAdverTisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAdverTisement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmAdverTisement";
            this.Load += new System.EventHandler(this.FrmAdverTisement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label adadd;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label 廣告名稱;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lbuser;
        private System.Windows.Forms.Label Lbadtype;
        private System.Windows.Forms.ComboBox SelectAd;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button Btnwrite;
        private System.Windows.Forms.Button Btnsave;
        private System.Windows.Forms.DataGridView AdDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Choosetype;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button Btnupdate;
        private System.Windows.Forms.TextBox LBad;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox LbNet;
        private System.Windows.Forms.TextBox LbImagepath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource adDataSetBindingSource;
        private adDataSet adDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn 廣告名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 會員名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 廣告類型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 圖片路徑;
        private System.Windows.Forms.DataGridViewTextBoxColumn 網站連結;
    }
}