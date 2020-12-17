namespace pizzacımv1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.registerNameSurname = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerNameSurname
            // 
            this.registerNameSurname.Location = new System.Drawing.Point(108, 32);
            this.registerNameSurname.Name = "registerNameSurname";
            this.registerNameSurname.Size = new System.Drawing.Size(159, 20);
            this.registerNameSurname.TabIndex = 0;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(122, 169);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(117, 31);
            this.save.TabIndex = 5;
            this.save.Text = "Kaydet";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre";
            // 
            // registerUsername
            // 
            this.registerUsername.Location = new System.Drawing.Point(108, 76);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(159, 20);
            this.registerUsername.TabIndex = 9;
            // 
            // registerPassword
            // 
            this.registerPassword.Location = new System.Drawing.Point(108, 121);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.PasswordChar = '*';
            this.registerPassword.Size = new System.Drawing.Size(159, 20);
            this.registerPassword.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 248);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.registerNameSurname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(327, 287);
            this.MinimumSize = new System.Drawing.Size(327, 287);
            this.Name = "Form2";
            this.Text = "Yeni Kullanıcı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registerNameSurname;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registerUsername;
        private System.Windows.Forms.TextBox registerPassword;
    }
}