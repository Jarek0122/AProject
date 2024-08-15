using System;

namespace AProject.View
{
    partial class FrmActEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtActPic = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPanel = new System.Windows.Forms.Panel();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtActDescription = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtActSch = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BatchValue = new System.Windows.Forms.NumericUpDown();
            this.btnSaveAct = new System.Windows.Forms.Button();
            this.btnCancelAct = new System.Windows.Forms.Button();
            this.btnCloseAct = new System.Windows.Forms.Button();
            this.btnStatusT = new System.Windows.Forms.RadioButton();
            this.btnstatusF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actTextBoxNum = new AProject.Component.ActTextBox();
            this.txtActUserId = new AProject.Component.ActTextBox();
            this.txtActEditorD = new AProject.Component.ActTextBox();
            this.txtActFee = new AProject.Component.ActTextBox();
            this.txtActNMax = new AProject.Component.ActTextBox();
            this.txtActlocation = new AProject.Component.ActTextBox();
            this.txtActName = new AProject.Component.ActTextBox();
            this.txtActPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.txtPanel.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatchValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtActPic
            // 
            this.txtActPic.Controls.Add(this.pictureBox1);
            this.txtActPic.Location = new System.Drawing.Point(74, 528);
            this.txtActPic.Name = "txtActPic";
            this.txtActPic.Size = new System.Drawing.Size(545, 149);
            this.txtActPic.TabIndex = 11;
            this.txtActPic.TabStop = false;
            this.txtActPic.Text = "活動圖片";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(3, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // txtPanel
            // 
            this.txtPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPanel.Controls.Add(this.GroupBox3);
            this.txtPanel.Controls.Add(this.groupBox2);
            this.txtPanel.Location = new System.Drawing.Point(678, 75);
            this.txtPanel.Name = "txtPanel";
            this.txtPanel.Size = new System.Drawing.Size(630, 520);
            this.txtPanel.TabIndex = 12;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtActDescription);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox3.Location = new System.Drawing.Point(0, 260);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(630, 260);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "活動說明";
            // 
            // txtActDescription
            // 
            this.txtActDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtActDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtActDescription.Font = new System.Drawing.Font("微軟正黑體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.txtActDescription.Location = new System.Drawing.Point(3, 35);
            this.txtActDescription.Multiline = true;
            this.txtActDescription.Name = "txtActDescription";
            this.txtActDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActDescription.Size = new System.Drawing.Size(624, 222);
            this.txtActDescription.TabIndex = 15;
            this.txtActDescription.Text = "徒步遶境";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtActSch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 260);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "活動行程";
            // 
            // txtActSch
            // 
            this.txtActSch.BackColor = System.Drawing.SystemColors.Control;
            this.txtActSch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActSch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtActSch.Font = new System.Drawing.Font("微軟正黑體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.txtActSch.Location = new System.Drawing.Point(3, 35);
            this.txtActSch.Multiline = true;
            this.txtActSch.Name = "txtActSch";
            this.txtActSch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActSch.Size = new System.Drawing.Size(624, 222);
            this.txtActSch.TabIndex = 14;
            this.txtActSch.Text = "北港-大甲";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(74, 354);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(74, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "活動批次";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BatchValue
            // 
            this.BatchValue.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.BatchValue.Location = new System.Drawing.Point(172, 296);
            this.BatchValue.Name = "BatchValue";
            this.BatchValue.Size = new System.Drawing.Size(102, 34);
            this.BatchValue.TabIndex = 16;
            this.BatchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BatchValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BatchValue.ValueChanged += new System.EventHandler(this.BatchValue_ValueChanged);
            // 
            // btnSaveAct
            // 
            this.btnSaveAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveAct.Location = new System.Drawing.Point(1058, 637);
            this.btnSaveAct.Name = "btnSaveAct";
            this.btnSaveAct.Size = new System.Drawing.Size(100, 40);
            this.btnSaveAct.TabIndex = 17;
            this.btnSaveAct.Text = "儲存";
            this.btnSaveAct.UseVisualStyleBackColor = true;
            this.btnSaveAct.Click += new System.EventHandler(this.btnSaveAct_Click);
            // 
            // btnCancelAct
            // 
            this.btnCancelAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancelAct.Location = new System.Drawing.Point(911, 637);
            this.btnCancelAct.Name = "btnCancelAct";
            this.btnCancelAct.Size = new System.Drawing.Size(100, 40);
            this.btnCancelAct.TabIndex = 17;
            this.btnCancelAct.Text = "取消";
            this.btnCancelAct.UseVisualStyleBackColor = true;
            this.btnCancelAct.Click += new System.EventHandler(this.btnCancelAct_Click);
            // 
            // btnCloseAct
            // 
            this.btnCloseAct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCloseAct.Location = new System.Drawing.Point(1205, 637);
            this.btnCloseAct.Name = "btnCloseAct";
            this.btnCloseAct.Size = new System.Drawing.Size(100, 40);
            this.btnCloseAct.TabIndex = 17;
            this.btnCloseAct.Text = "結案";
            this.btnCloseAct.UseVisualStyleBackColor = true;
            this.btnCloseAct.Click += new System.EventHandler(this.btnCloseAct_Click);
            // 
            // btnStatusT
            // 
            this.btnStatusT.AutoSize = true;
            this.btnStatusT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatusT.Location = new System.Drawing.Point(136, 55);
            this.btnStatusT.Name = "btnStatusT";
            this.btnStatusT.Size = new System.Drawing.Size(87, 35);
            this.btnStatusT.TabIndex = 10;
            this.btnStatusT.TabStop = true;
            this.btnStatusT.Text = "公開";
            this.btnStatusT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatusT.UseVisualStyleBackColor = true;
            // 
            // btnstatusF
            // 
            this.btnstatusF.AutoSize = true;
            this.btnstatusF.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnstatusF.Location = new System.Drawing.Point(31, 55);
            this.btnstatusF.Name = "btnstatusF";
            this.btnstatusF.Size = new System.Drawing.Size(87, 35);
            this.btnstatusF.TabIndex = 11;
            this.btnstatusF.TabStop = true;
            this.btnstatusF.Text = "下架";
            this.btnstatusF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnstatusF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStatusT);
            this.groupBox1.Controls.Add(this.btnstatusF);
            this.groupBox1.Location = new System.Drawing.Point(376, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 120);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "公開狀態";
            // 
            // actTextBoxNum
            // 
            this.actTextBoxNum.fEnable = false;
            this.actTextBoxNum.fLabelText = "流水碼";
            this.actTextBoxNum.fLabelWidth = 100;
            this.actTextBoxNum.fTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.actTextBoxNum.fTextSize = 10F;
            this.actTextBoxNum.fTxtBoxValue = "";
            this.actTextBoxNum.fVisiable = true;
            this.actTextBoxNum.Location = new System.Drawing.Point(1812, 16);
            this.actTextBoxNum.Margin = new System.Windows.Forms.Padding(797, 1257, 797, 1257);
            this.actTextBoxNum.Name = "actTextBoxNum";
            this.actTextBoxNum.Size = new System.Drawing.Size(500, 31);
            this.actTextBoxNum.TabIndex = 4;
            this.actTextBoxNum.Visible = false;
            // 
            // txtActUserId
            // 
            this.txtActUserId.fEnable = false;
            this.txtActUserId.fLabelText = "更新帳號";
            this.txtActUserId.fLabelWidth = 100;
            this.txtActUserId.fTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtActUserId.fTextSize = 10F;
            this.txtActUserId.fTxtBoxValue = "";
            this.txtActUserId.fVisiable = true;
            this.txtActUserId.Location = new System.Drawing.Point(33, 21);
            this.txtActUserId.Margin = new System.Windows.Forms.Padding(478, 730, 478, 730);
            this.txtActUserId.Name = "txtActUserId";
            this.txtActUserId.Size = new System.Drawing.Size(275, 31);
            this.txtActUserId.TabIndex = 4;
            // 
            // txtActEditorD
            // 
            this.txtActEditorD.fEnable = false;
            this.txtActEditorD.fLabelText = "更新日期";
            this.txtActEditorD.fLabelWidth = 100;
            this.txtActEditorD.fTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtActEditorD.fTextSize = 10F;
            this.txtActEditorD.fTxtBoxValue = "";
            this.txtActEditorD.fVisiable = true;
            this.txtActEditorD.Location = new System.Drawing.Point(349, 21);
            this.txtActEditorD.Margin = new System.Windows.Forms.Padding(287, 424, 287, 424);
            this.txtActEditorD.Name = "txtActEditorD";
            this.txtActEditorD.Size = new System.Drawing.Size(275, 31);
            this.txtActEditorD.TabIndex = 4;
            // 
            // txtActFee
            // 
            this.txtActFee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtActFee.fEnable = true;
            this.txtActFee.fLabelText = "報名費用";
            this.txtActFee.fLabelWidth = 100;
            this.txtActFee.fTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtActFee.fTextSize = 10F;
            this.txtActFee.fTxtBoxValue = "2000";
            this.txtActFee.fVisiable = true;
            this.txtActFee.Location = new System.Drawing.Point(74, 194);
            this.txtActFee.Margin = new System.Windows.Forms.Padding(5);
            this.txtActFee.Name = "txtActFee";
            this.txtActFee.Size = new System.Drawing.Size(200, 31);
            this.txtActFee.TabIndex = 4;
            // 
            // txtActNMax
            // 
            this.txtActNMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtActNMax.fEnable = true;
            this.txtActNMax.fLabelText = "人數上限";
            this.txtActNMax.fLabelWidth = 100;
            this.txtActNMax.fTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtActNMax.fTextSize = 10F;
            this.txtActNMax.fTxtBoxValue = "38";
            this.txtActNMax.fVisiable = true;
            this.txtActNMax.Location = new System.Drawing.Point(74, 249);
            this.txtActNMax.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
            this.txtActNMax.Name = "txtActNMax";
            this.txtActNMax.Size = new System.Drawing.Size(200, 31);
            this.txtActNMax.TabIndex = 5;
            // 
            // txtActlocation
            // 
            this.txtActlocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtActlocation.fEnable = true;
            this.txtActlocation.fLabelText = "地     點";
            this.txtActlocation.fLabelWidth = 100;
            this.txtActlocation.fTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtActlocation.fTextSize = 10F;
            this.txtActlocation.fTxtBoxValue = "北港";
            this.txtActlocation.fVisiable = true;
            this.txtActlocation.Location = new System.Drawing.Point(74, 139);
            this.txtActlocation.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtActlocation.Name = "txtActlocation";
            this.txtActlocation.Size = new System.Drawing.Size(545, 31);
            this.txtActlocation.TabIndex = 3;
            // 
            // txtActName
            // 
            this.txtActName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtActName.fEnable = true;
            this.txtActName.fLabelText = "活動名稱";
            this.txtActName.fLabelWidth = 100;
            this.txtActName.fTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtActName.fTextSize = 10F;
            this.txtActName.fTxtBoxValue = "北港繞境";
            this.txtActName.fVisiable = true;
            this.txtActName.Location = new System.Drawing.Point(74, 84);
            this.txtActName.Margin = new System.Windows.Forms.Padding(5);
            this.txtActName.Name = "txtActName";
            this.txtActName.Size = new System.Drawing.Size(545, 31);
            this.txtActName.TabIndex = 3;
            // 
            // FrmActEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseAct);
            this.Controls.Add(this.btnCancelAct);
            this.Controls.Add(this.btnSaveAct);
            this.Controls.Add(this.BatchValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.actTextBoxNum);
            this.Controls.Add(this.txtPanel);
            this.Controls.Add(this.txtActUserId);
            this.Controls.Add(this.txtActEditorD);
            this.Controls.Add(this.txtActPic);
            this.Controls.Add(this.txtActFee);
            this.Controls.Add(this.txtActNMax);
            this.Controls.Add(this.txtActlocation);
            this.Controls.Add(this.txtActName);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmActEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmActEditor_Load);
            this.txtActPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.txtPanel.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatchValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private Component.ActTextBox txtActName;
        private Component.ActTextBox txtActlocation;
        private Component.ActTextBox txtActFee;
        private Component.ActTextBox txtActNMax;
        private Component.ActTextBox txtActEditorD;
        private System.Windows.Forms.GroupBox txtActPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel txtPanel;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtActSch;
        private System.Windows.Forms.TextBox txtActDescription;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BatchValue;
        private Component.ActTextBox actTextBoxNum;
        private System.Windows.Forms.Button btnSaveAct;
        private System.Windows.Forms.Button btnCancelAct;
        private System.Windows.Forms.Button btnCloseAct;
        private System.Windows.Forms.RadioButton btnStatusT;
        private System.Windows.Forms.RadioButton btnstatusF;
        private System.Windows.Forms.GroupBox groupBox1;
        private Component.ActTextBox txtActUserId;
    }
}