using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzacımv1
{
    public partial class kasa : Form
    {
        int orderId, amount;
        Form1 form1 = new Form1();
        public kasa(String index)
        {
           orderId = Convert.ToInt32(index);
            InitializeComponent();
        }



        private void kasa_Load(object sender, EventArgs e) 
        {
            getOrder();
        }
        void getOrder() //Gelen id değerine göre sipariş bilgilerini çeken fonksiyon
        {

            form1.cmd.CommandText = "SELECT * FROM orders Where order_id=" + orderId;
            form1.cmd.Connection = form1.connectDb;
            form1.cmd.CommandType = CommandType.Text;
            form1.connectDb.Open();
            form1.readData = form1.cmd.ExecuteReader();
            form1.readData.Read();
            textBox1.Text = form1.readData["order_id"].ToString();
            details.Text = form1.readData["order_detail"] + "\n \n" + form1.readData["order_beverage"];
            textBox2.Text = form1.readData["order_amount"].ToString();
            balance.Text = form1.readData["order_amount"].ToString();
            amount = Convert.ToInt32(form1.readData["order_amount"]);
            form1.connectDb.Close();
        }

        private void cash_Click(object sender, EventArgs e)
        {
            pay();
        }

        private void creditCard_Click(object sender, EventArgs e)
        {
            pay();
        }

        private void save_Click(object sender, EventArgs e) //amount kısmı sıfırsa order statusu 0 olarak değiştiren fonksiyon 
        {
            try
            {
                if (amount == 0)
                {
                    form1.cmd.CommandText = "UPDATE orders SET order_status=0 WHERE order_id=" + orderId;
                    form1.cmd.Connection = form1.connectDb;
                    form1.cmd.CommandType = CommandType.Text;
                    form1.connectDb.Open();
                    form1.cmd.ExecuteNonQuery();
                    form1.connectDb.Close();
                    MessageBox.Show("İşlem başarı ile kaydedildi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bakiye Kısmı Sıfır Olmalıdır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Veritabanı Hatası", "HATA", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        void pay() //Hesabı kapatan fonksiyon 
        {
            try
            {

                if (Convert.ToInt32(payment.Text) <= amount)
                {
                    balance.Text = (amount - Convert.ToInt32(payment.Text)).ToString();
                    amount = Convert.ToInt32(balance.Text);
                    payment.Clear();
                }
                else
                {
                    MessageBox.Show("Lütfen Sipariş Tutarından Az Değer Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Sadece Rakam Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
