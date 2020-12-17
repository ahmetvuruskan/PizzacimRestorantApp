using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pizzacımv1
{

    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
       
        Form2 form2 = new Form2();
        Form1 form1 = new Form1();
        systemSettings systemSettings = new systemSettings();
        int index = 0;
        ArrayList idList = new ArrayList(); // Listeye gelen siparişlerin idsini sıra ile tutan ArrayList
        

        private void MainPage_Load(object sender, EventArgs e)
        {
            createView();
            getOrders(); // Siparişlerimizi listViewe ekleyen fonksiyon

        }

        private void createView() //Load kısmında çağırdığımız fonksiyon listViewin görünütüsünün oluimasını sağlıyor
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Sipariş No", 80);
            listView1.Columns.Add("Müşteri Ad", 100);
            listView1.Columns.Add("Sipariş Saati", 120);
            listView1.Columns.Add("Sipariş Detayları", 285);
            listView1.Columns.Add("Fiyat", 60);
            listView1.Columns.Add("İçecek", 100);
        }

   
        public void getOrders() // Aktif siparişlerimizi veritabanından çeken fonksiyon
        {
            idList.Clear();
            form1.cmd.CommandText = "SELECT * FROM orders WHERE order_status=1";
            form1.cmd.Connection = form1.connectDb;
            form1.cmd.CommandType = CommandType.Text;
            form1.connectDb.Open();
            form1.readData = form1.cmd.ExecuteReader();
            while (form1.readData.Read())
            {
                idList.Add(Convert.ToInt32(form1.readData["order_id"]));
                String[] data = {
                    form1.readData["order_id"].ToString(),
                    form1.readData["order_client"].ToString(),
                    form1.readData["order_time"].ToString(),
                    form1.readData["order_detail"].ToString(),
                    form1.readData["order_amount"].ToString(),
                    form1.readData["order_beverage"].ToString()
                };
                var row = new ListViewItem(data);
                listView1.Items.Add(row);
              
            }
            form1.connectDb.Close();
            
        }

        private void newOrder_Click(object sender, EventArgs e) //Yeni sipariş sayfasını açan buton 
        {
            yeniSiparis yeniSiparis = new yeniSiparis();
            yeniSiparis.Show();
        }

        private void refresh_Click(object sender, EventArgs e) // Listemizi Yenileyen buton
        {
            idList.Clear();
            listView1.Items.Clear();
            getOrders();
        }

        private void cash_Click(object sender, EventArgs e)
        {
            try
            {
                /*Hangi siparişin hesabının kapatılacağını belirlemek için id numarasını diğer forma gönderiyoruz id numarasına 
                göre veritabanında işlem yapacağız*/
                int i = listView1.SelectedItems[0].Index;
                index =(int)idList[i];
                kasa kasa = new kasa(index.ToString());
                kasa.Show();
            }
            catch
            {
                MessageBox.Show("Lütfen Listeden Sipariş Seçiniz","UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void systemSettingsBt_Click(object sender, EventArgs e)
        {
            systemSettings.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }
    }
}
