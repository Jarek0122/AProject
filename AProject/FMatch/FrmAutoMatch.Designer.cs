namespace AProject.FMatch
{
    partial class FrmAutoMatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoMatch));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAutoMatch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMatchedTraits = new System.Windows.Forms.Label();
            this.lblMatchedHobbies = new System.Windows.Forms.Label();
            this.lblMatchedGender = new System.Windows.Forms.Label();
            this.lblMatchedHeight = new System.Windows.Forms.Label();
            this.lblMatchedAge = new System.Windows.Forms.Label();
            this.lblMatchedName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendNotification = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(913, 468);
            this.splitContainer1.SplitterDistance = 502;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Panel1.Controls.Add(this.dgvMembers);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.btnAutoMatch);
            this.splitContainer2.Size = new System.Drawing.Size(502, 468);
            this.splitContainer2.SplitterDistance = 340;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.Location = new System.Drawing.Point(0, 49);
            this.dgvMembers.MultiSelect = false;
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 27;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(502, 291);
            this.dgvMembers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "配對會員列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(39, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "離開";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAutoMatch
            // 
            this.btnAutoMatch.AutoSize = true;
            this.btnAutoMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAutoMatch.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAutoMatch.Location = new System.Drawing.Point(256, 16);
            this.btnAutoMatch.Name = "btnAutoMatch";
            this.btnAutoMatch.Size = new System.Drawing.Size(193, 46);
            this.btnAutoMatch.TabIndex = 0;
            this.btnAutoMatch.Text = "開始自動配對";
            this.btnAutoMatch.UseVisualStyleBackColor = false;
            this.btnAutoMatch.Click += new System.EventHandler(this.btnAutoMatch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMatchedTraits);
            this.groupBox1.Controls.Add(this.lblMatchedHobbies);
            this.groupBox1.Controls.Add(this.lblMatchedGender);
            this.groupBox1.Controls.Add(this.lblMatchedHeight);
            this.groupBox1.Controls.Add(this.lblMatchedAge);
            this.groupBox1.Controls.Add(this.lblMatchedName);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配對結果";
            // 
            // lblMatchedTraits
            // 
            this.lblMatchedTraits.AutoSize = true;
            this.lblMatchedTraits.Location = new System.Drawing.Point(26, 259);
            this.lblMatchedTraits.Name = "lblMatchedTraits";
            this.lblMatchedTraits.Size = new System.Drawing.Size(145, 29);
            this.lblMatchedTraits.TabIndex = 4;
            this.lblMatchedTraits.Text = "特質匹配數 : ";
            // 
            // lblMatchedHobbies
            // 
            this.lblMatchedHobbies.AutoSize = true;
            this.lblMatchedHobbies.Location = new System.Drawing.Point(26, 213);
            this.lblMatchedHobbies.Name = "lblMatchedHobbies";
            this.lblMatchedHobbies.Size = new System.Drawing.Size(145, 29);
            this.lblMatchedHobbies.TabIndex = 4;
            this.lblMatchedHobbies.Text = "興趣匹配數 : ";
            // 
            // lblMatchedGender
            // 
            this.lblMatchedGender.AutoSize = true;
            this.lblMatchedGender.Location = new System.Drawing.Point(26, 161);
            this.lblMatchedGender.Name = "lblMatchedGender";
            this.lblMatchedGender.Size = new System.Drawing.Size(76, 29);
            this.lblMatchedGender.TabIndex = 4;
            this.lblMatchedGender.Text = "性別 : ";
            // 
            // lblMatchedHeight
            // 
            this.lblMatchedHeight.AutoSize = true;
            this.lblMatchedHeight.Location = new System.Drawing.Point(26, 118);
            this.lblMatchedHeight.Name = "lblMatchedHeight";
            this.lblMatchedHeight.Size = new System.Drawing.Size(76, 29);
            this.lblMatchedHeight.TabIndex = 4;
            this.lblMatchedHeight.Text = "身高 : ";
            // 
            // lblMatchedAge
            // 
            this.lblMatchedAge.AutoSize = true;
            this.lblMatchedAge.Location = new System.Drawing.Point(26, 81);
            this.lblMatchedAge.Name = "lblMatchedAge";
            this.lblMatchedAge.Size = new System.Drawing.Size(76, 29);
            this.lblMatchedAge.TabIndex = 4;
            this.lblMatchedAge.Text = "年齡 : ";
            // 
            // lblMatchedName
            // 
            this.lblMatchedName.AutoSize = true;
            this.lblMatchedName.Location = new System.Drawing.Point(26, 41);
            this.lblMatchedName.Name = "lblMatchedName";
            this.lblMatchedName.Size = new System.Drawing.Size(76, 29);
            this.lblMatchedName.TabIndex = 4;
            this.lblMatchedName.Text = "姓名 : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSendNotification);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 63);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "寄送推薦通知";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendNotification.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendNotification.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendNotification.Image = ((System.Drawing.Image)(resources.GetObject("btnSendNotification.Image")));
            this.btnSendNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendNotification.Location = new System.Drawing.Point(276, 0);
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(125, 63);
            this.btnSendNotification.TabIndex = 2;
            this.btnSendNotification.Text = "寄送";
            this.btnSendNotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendNotification.UseVisualStyleBackColor = true;
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // FrmAutoMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 468);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmAutoMatch";
            this.Text = "FrmManualMatch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAutoMatch_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmAutoMatch_Paint);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Button btnAutoMatch;
        private System.Windows.Forms.Button btnSendNotification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMatchedHeight;
        private System.Windows.Forms.Label lblMatchedAge;
        private System.Windows.Forms.Label lblMatchedName;
        private System.Windows.Forms.Label lblMatchedGender;
        private System.Windows.Forms.Label lblMatchedHobbies;
        private System.Windows.Forms.Label lblMatchedTraits;
    }
}