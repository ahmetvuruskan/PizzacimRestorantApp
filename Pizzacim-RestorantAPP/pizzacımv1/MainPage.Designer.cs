namespace pizzacımv1
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.listView1 = new System.Windows.Forms.ListView();
            this.cash = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.systemSettingsBt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 212);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(750, 211);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cash
            // 
            this.cash.Image = ((System.Drawing.Image)(resources.GetObject("cash.Image")));
            this.cash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cash.Location = new System.Drawing.Point(623, 110);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(137, 51);
            this.cash.TabIndex = 2;
            this.cash.Text = "HESABI KAPAT";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // newOrder
            // 
            this.newOrder.Image = ((System.Drawing.Image)(resources.GetObject("newOrder.Image")));
            this.newOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newOrder.Location = new System.Drawing.Point(623, 44);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(137, 51);
            this.newOrder.TabIndex = 3;
            this.newOrder.Text = "YENİ SİPARİŞ";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aktif Siparişler";
            // 
            // refresh
            // 
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.Location = new System.Drawing.Point(726, 178);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(34, 31);
            this.refresh.TabIndex = 6;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Listeyi Yenile";
            // 
            // systemSettingsBt
            // 
            this.systemSettingsBt.Image = ((System.Drawing.Image)(resources.GetObject("systemSettingsBt.Image")));
            this.systemSettingsBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.systemSettingsBt.Location = new System.Drawing.Point(43, 44);
            this.systemSettingsBt.Name = "systemSettingsBt";
            this.systemSettingsBt.Size = new System.Drawing.Size(137, 51);
            this.systemSettingsBt.TabIndex = 8;
            this.systemSettingsBt.Text = "Ayarlar";
            this.systemSettingsBt.UseVisualStyleBackColor = true;
            this.systemSettingsBt.Click += new System.EventHandler(this.systemSettingsBt_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(43, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Yeni Kullanıcı  Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.systemSettingsBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainPage";
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button systemSettingsBt;
        private System.Windows.Forms.Button button2;
    }
}