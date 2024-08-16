namespace AProject.FAd
{
    partial class Floading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Floading));
            this.panel1 = new System.Windows.Forms.Panel();
            this.adadd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myprogressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.run = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 535);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // adadd
            // 
            this.adadd.AutoSize = true;
            this.adadd.BackColor = System.Drawing.SystemColors.WindowText;
            this.adadd.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.adadd.ForeColor = System.Drawing.Color.YellowGreen;
            this.adadd.Location = new System.Drawing.Point(389, 473);
            this.adadd.Name = "adadd";
            this.adadd.Size = new System.Drawing.Size(376, 56);
            this.adadd.TabIndex = 0;
            this.adadd.Text = "廣告系統加載中....";
            this.adadd.Click += new System.EventHandler(this.adadd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // myprogressBar
            // 
            this.myprogressBar.Location = new System.Drawing.Point(-18, 530);
            this.myprogressBar.Name = "myprogressBar";
            this.myprogressBar.Size = new System.Drawing.Size(893, 42);
            this.myprogressBar.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // run
            // 
            this.run.AutoSize = true;
            this.run.BackColor = System.Drawing.Color.Black;
            this.run.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.run.ForeColor = System.Drawing.Color.YellowGreen;
            this.run.Location = new System.Drawing.Point(764, 473);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(64, 56);
            this.run.TabIndex = 4;
            this.run.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 120);
            this.label1.TabIndex = 5;
            this.label1.Text = "鹽";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(35, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 120);
            this.label2.TabIndex = 5;
            this.label2.Text = "水";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.YellowGreen;
            this.label3.Location = new System.Drawing.Point(35, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 120);
            this.label3.TabIndex = 5;
            this.label3.Text = "蜂";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowText;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.YellowGreen;
            this.label4.Location = new System.Drawing.Point(35, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 120);
            this.label4.TabIndex = 5;
            this.label4.Text = "炮";
            // 
            // Floading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(873, 565);
            this.Controls.Add(this.run);
            this.Controls.Add(this.myprogressBar);
            this.Controls.Add(this.adadd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Floading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Floading";
            this.Load += new System.EventHandler(this.Floading_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label adadd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar myprogressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label run;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}