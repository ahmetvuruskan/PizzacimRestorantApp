namespace pizzacımv1
{
    partial class kasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kasa));
            this.cash = new System.Windows.Forms.Button();
            this.creditCard = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(46, 337);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(128, 66);
            this.cash.TabIndex = 0;
            this.cash.Text = "Nakit";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // creditCard
            // 
            this.creditCard.Location = new System.Drawing.Point(262, 337);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(128, 66);
            this.creditCard.TabIndex = 1;
            this.creditCard.Text = "Kredi Kartı";
            this.creditCard.UseVisualStyleBackColor = true;
            this.creditCard.Click += new System.EventHandler(this.creditCard_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(40, 70);
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Size = new System.Drawing.Size(342, 96);
            this.details.TabIndex = 3;
            this.details.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sipariş No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sipariş Detayları ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(290, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tutar";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(290, 217);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(100, 20);
            this.balance.TabIndex = 8;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(336, 409);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(87, 34);
            this.save.TabIndex = 9;
            this.save.Text = "Hesabı Kapat";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kalan";
            // 
            // payment
            // 
            this.payment.Location = new System.Drawing.Point(133, 300);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(188, 20);
            this.payment.TabIndex = 1;
            // 
            // kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 464);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.save);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.details);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.creditCard);
            this.Controls.Add(this.cash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kasa";
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.kasa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Button creditCard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox payment;
    }
}