namespace AProject
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.活動訂單ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.活動上架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.活動廣告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.btnProdManage = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEditProd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditProdStock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripDropDownButton();
            this.收驚管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.點燈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMatchMainten = new System.Windows.Forms.ToolStripSplitButton();
            this.會員偏好維護ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.手動配對管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配對狀態查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.廠商管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.會員管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.管理設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Chocolate;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton6,
            this.btnProdManage,
            this.toolStripButton8,
            this.btnMatchMainten,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 100);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(179, 501);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.活動訂單ToolStripMenuItem,
            this.活動上架ToolStripMenuItem,
            this.活動廣告ToolStripMenuItem});
            this.toolStripButton4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(180, 35);
            this.toolStripButton4.Text = "活動管理";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 活動訂單ToolStripMenuItem
            // 
            this.活動訂單ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.活動訂單ToolStripMenuItem.Name = "活動訂單ToolStripMenuItem";
            this.活動訂單ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.活動訂單ToolStripMenuItem.Text = "活動訂單";
            this.活動訂單ToolStripMenuItem.Click += new System.EventHandler(this.活動訂單ToolStripMenuItem_Click);
            // 
            // 活動上架ToolStripMenuItem
            // 
            this.活動上架ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.活動上架ToolStripMenuItem.Name = "活動上架ToolStripMenuItem";
            this.活動上架ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.活動上架ToolStripMenuItem.Text = "活動上架";
            this.活動上架ToolStripMenuItem.Click += new System.EventHandler(this.活動上架ToolStripMenuItem_Click);
            // 
            // 活動廣告ToolStripMenuItem
            // 
            this.活動廣告ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.活動廣告ToolStripMenuItem.Name = "活動廣告ToolStripMenuItem";
            this.活動廣告ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.活動廣告ToolStripMenuItem.Text = "活動廣告";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(180, 35);
            this.toolStripButton6.Text = "訂單管理";
            this.toolStripButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // btnProdManage
            // 
            this.btnProdManage.AutoSize = false;
            this.btnProdManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditProd,
            this.btnEditProdStock});
            this.btnProdManage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProdManage.Image = ((System.Drawing.Image)(resources.GetObject("btnProdManage.Image")));
            this.btnProdManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProdManage.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnProdManage.Name = "btnProdManage";
            this.btnProdManage.Size = new System.Drawing.Size(180, 35);
            this.btnProdManage.Text = "商品管理";
            this.btnProdManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEditProd
            // 
            this.btnEditProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(178, 30);
            this.btnEditProd.Text = "編輯商品";
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnEditProdStock
            // 
            this.btnEditProdStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditProdStock.Name = "btnEditProdStock";
            this.btnEditProdStock.Size = new System.Drawing.Size(178, 30);
            this.btnEditProdStock.Text = "編輯庫存";
            this.btnEditProdStock.Visible = false;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收驚管理ToolStripMenuItem,
            this.點燈ToolStripMenuItem});
            this.toolStripButton8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(180, 35);
            this.toolStripButton8.Text = "服務管理";
            this.toolStripButton8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 收驚管理ToolStripMenuItem
            // 
            this.收驚管理ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.收驚管理ToolStripMenuItem.Name = "收驚管理ToolStripMenuItem";
            this.收驚管理ToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.收驚管理ToolStripMenuItem.Text = "收驚";
            // 
            // 點燈ToolStripMenuItem
            // 
            this.點燈ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.點燈ToolStripMenuItem.Name = "點燈ToolStripMenuItem";
            this.點燈ToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.點燈ToolStripMenuItem.Text = "點燈";
            // 
            // btnMatchMainten
            // 
            this.btnMatchMainten.AutoSize = false;
            this.btnMatchMainten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.會員偏好維護ToolStripMenuItem,
            this.手動配對管理ToolStripMenuItem,
            this.配對狀態查看ToolStripMenuItem});
            this.btnMatchMainten.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMatchMainten.Image = ((System.Drawing.Image)(resources.GetObject("btnMatchMainten.Image")));
            this.btnMatchMainten.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMatchMainten.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnMatchMainten.Name = "btnMatchMainten";
            this.btnMatchMainten.Size = new System.Drawing.Size(180, 35);
            this.btnMatchMainten.Text = "配對管理";
            this.btnMatchMainten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 會員偏好維護ToolStripMenuItem
            // 
            this.會員偏好維護ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.會員偏好維護ToolStripMenuItem.Name = "會員偏好維護ToolStripMenuItem";
            this.會員偏好維護ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.會員偏好維護ToolStripMenuItem.Text = "會員偏好維護";
            this.會員偏好維護ToolStripMenuItem.Click += new System.EventHandler(this.會員偏好維護ToolStripMenuItem_Click);
            // 
            // 手動配對管理ToolStripMenuItem
            // 
            this.手動配對管理ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.手動配對管理ToolStripMenuItem.Name = "手動配對管理ToolStripMenuItem";
            this.手動配對管理ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.手動配對管理ToolStripMenuItem.Text = "自動配對管理";
            this.手動配對管理ToolStripMenuItem.Click += new System.EventHandler(this.自動配對管理ToolStripMenuItem_Click);
            // 
            // 配對狀態查看ToolStripMenuItem
            // 
            this.配對狀態查看ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.配對狀態查看ToolStripMenuItem.Name = "配對狀態查看ToolStripMenuItem";
            this.配對狀態查看ToolStripMenuItem.Size = new System.Drawing.Size(218, 30);
            this.配對狀態查看ToolStripMenuItem.Text = "配對狀態查看";
            this.配對狀態查看ToolStripMenuItem.Click += new System.EventHandler(this.配對狀態查看ToolStripMenuItem_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(180, 35);
            this.toolStripButton10.Text = "廣告管理";
            this.toolStripButton10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.AutoSize = false;
            this.toolStripButton11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(180, 35);
            this.toolStripButton11.Text = "問題管理";
            this.toolStripButton11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.廠商管理ToolStripMenuItem,
            this.會員管理ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.管理設定ToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(180, 35);
            this.toolStripDropDownButton1.Text = "後臺管理";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 廠商管理ToolStripMenuItem
            // 
            this.廠商管理ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.廠商管理ToolStripMenuItem.Name = "廠商管理ToolStripMenuItem";
            this.廠商管理ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.廠商管理ToolStripMenuItem.Text = "廠商管理";
            // 
            // 會員管理ToolStripMenuItem
            // 
            this.會員管理ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.會員管理ToolStripMenuItem.Name = "會員管理ToolStripMenuItem";
            this.會員管理ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.會員管理ToolStripMenuItem.Text = "會員管理";
            this.會員管理ToolStripMenuItem.Click += new System.EventHandler(this.會員管理ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // 管理設定ToolStripMenuItem
            // 
            this.管理設定ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.管理設定ToolStripMenuItem.Name = "管理設定ToolStripMenuItem";
            this.管理設定ToolStripMenuItem.Size = new System.Drawing.Size(178, 30);
            this.管理設定ToolStripMenuItem.Text = "管理設定";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 100);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1017, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 98);
            this.button1.TabIndex = 3;
            this.button1.Text = "離開";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1132, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "妙語服務整合平台後台管理系統";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 601);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 廠商管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 會員管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem 活動訂單ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 活動上架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 活動廣告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton8;
        private System.Windows.Forms.ToolStripMenuItem 收驚管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 點燈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnProdManage;
        private System.Windows.Forms.ToolStripMenuItem btnEditProd;
        private System.Windows.Forms.ToolStripMenuItem btnEditProdStock;
        private System.Windows.Forms.ToolStripSplitButton btnMatchMainten;
        private System.Windows.Forms.ToolStripMenuItem 會員偏好維護ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 手動配對管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配對狀態查看ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

