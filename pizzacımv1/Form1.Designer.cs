namespace pizzacımv1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginusername = new System.Windows.Forms.TextBox();
            this.loginpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginsubmit = new System.Windows.Forms.Button();
            this.adduser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginusername
            // 
            this.loginusername.Location = new System.Drawing.Point(142, 55);
            this.loginusername.Name = "loginusername";
            this.loginusername.Size = new System.Drawing.Size(147, 20);
            this.loginusername.TabIndex = 0;
            this.loginusername.Text = "Kulanıcı Adı";
            // 
            // loginpassword
            // 
            this.loginpassword.Location = new System.Drawing.Point(142, 95);
            this.loginpassword.Name = "loginpassword";
            this.loginpassword.Size = new System.Drawing.Size(147, 20);
            this.loginpassword.TabIndex = 1;
            this.loginpassword.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // loginsubmit
            // 
            this.loginsubmit.Location = new System.Drawing.Point(142, 136);
            this.loginsubmit.Name = "loginsubmit";
            this.loginsubmit.Size = new System.Drawing.Size(102, 31);
            this.loginsubmit.TabIndex = 4;
            this.loginsubmit.Text = "Giriş Yap";
            this.loginsubmit.UseVisualStyleBackColor = true;
            this.loginsubmit.Click += new System.EventHandler(this.loginsubmit_Click);
            // 
            // adduser
            // 
            this.adduser.Location = new System.Drawing.Point(469, 51);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(111, 41);
            this.adduser.TabIndex = 5;
            this.adduser.Text = "Kullanıcı Ekle ";
            this.adduser.UseVisualStyleBackColor = true;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.loginsubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginpassword);
            this.Controls.Add(this.loginusername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginusername;
        private System.Windows.Forms.TextBox loginpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginsubmit;
        private System.Windows.Forms.Button adduser;
    }
}

