namespace AProject.FUser
{
    partial class FrmLogin
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
            this.fbPassword = new AProject.ComponetUser.FieldBox();
            this.fbEmail = new AProject.ComponetUser.FieldBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fbPassword
            // 
            this.fbPassword.fieldName = "密碼:";
            this.fbPassword.fieldValue = "qwer1234";
            this.fbPassword.Location = new System.Drawing.Point(139, 99);
            this.fbPassword.Name = "fbPassword";
            this.fbPassword.Size = new System.Drawing.Size(353, 34);
            this.fbPassword.TabIndex = 1;
            // 
            // fbEmail
            // 
            this.fbEmail.fieldName = "信箱:";
            this.fbEmail.fieldValue = "focus911209@gmail.com";
            this.fbEmail.Location = new System.Drawing.Point(139, 41);
            this.fbEmail.Name = "fbEmail";
            this.fbEmail.Size = new System.Drawing.Size(353, 34);
            this.fbEmail.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 273);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fbEmail);
            this.Controls.Add(this.fbPassword);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理員登入";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponetUser.FieldBox fbPassword;
        private ComponetUser.FieldBox fbEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}