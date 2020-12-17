namespace pizzacımv1
{
    partial class yeniSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yeniSiparis));
            this.pizzaType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.addBeverage = new System.Windows.Forms.Button();
            this.deleteBeverage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pizzaType
            // 
            this.pizzaType.FormattingEnabled = true;
            this.pizzaType.Items.AddRange(new object[] {
            "Büyük boy",
            "Orta boy",
            "Küçük boy"});
            this.pizzaType.Location = new System.Drawing.Point(221, 57);
            this.pizzaType.Name = "pizzaType";
            this.pizzaType.Size = new System.Drawing.Size(140, 21);
            this.pizzaType.TabIndex = 0;
            this.pizzaType.SelectedIndexChanged += new System.EventHandler(this.pizzaType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lutfen Boy Pizza Boyunu Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün Seçiniz";
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(12, 57);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(140, 21);
            this.products.TabIndex = 7;
            this.products.SelectedIndexChanged += new System.EventHandler(this.products_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 238);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(244, 131);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(154, 238);
            this.listBox2.TabIndex = 9;
            // 
            // addBeverage
            // 
            this.addBeverage.Location = new System.Drawing.Point(184, 196);
            this.addBeverage.Name = "addBeverage";
            this.addBeverage.Size = new System.Drawing.Size(54, 32);
            this.addBeverage.TabIndex = 10;
            this.addBeverage.Text = "->";
            this.addBeverage.UseVisualStyleBackColor = true;
            this.addBeverage.Click += new System.EventHandler(this.addBeverage_Click);
            // 
            // deleteBeverage
            // 
            this.deleteBeverage.Location = new System.Drawing.Point(184, 256);
            this.deleteBeverage.Name = "deleteBeverage";
            this.deleteBeverage.Size = new System.Drawing.Size(54, 32);
            this.deleteBeverage.TabIndex = 11;
            this.deleteBeverage.Text = "Sil";
            this.deleteBeverage.UseVisualStyleBackColor = true;
            this.deleteBeverage.Click += new System.EventHandler(this.deleteBeverage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(738, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tutar";
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(727, 352);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(122, 41);
            this.addOrder.TabIndex = 14;
            this.addOrder.Text = "Kaydet";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Extralar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(456, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(154, 238);
            this.listBox3.TabIndex = 20;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(700, 12);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(154, 238);
            this.listBox4.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(727, 264);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Teslim Alacak Kişi";
            // 
            // yeniSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(866, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteBeverage);
            this.Controls.Add(this.addBeverage);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.products);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pizzaType);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yeniSiparis";
            this.Text = "Yeni Sipariş";
            this.Load += new System.EventHandler(this.yeniSiparis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pizzaType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox products;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button addBeverage;
        private System.Windows.Forms.Button deleteBeverage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}