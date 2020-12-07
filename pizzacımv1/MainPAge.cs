using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        SqlConnection connectDb = new SqlConnection("Data Source=18.219.99.255,1433;Network Library = DBMSSOCN;Initial Catalog=pizzacimv1;User Id=pizzaci;Password=963852741");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader readData = null;
       
        private void MainPage_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Sipariş No",80);
            listView1.Columns.Add("Müşteri Ad", 100);
            listView1.Columns.Add("Sipariş Saati", 120);
            listView1.Columns.Add("Sipariş Tarihi", 120);
            listView1.Columns.Add("Sipariş Detayları",220);
            listView1.Columns.Add("Fiyat", 60);
            getOrders();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
        void getOrders()
        {
            cmd.CommandText = "SELECT * FROM orders WHERE order_status=1";
            cmd.Connection = connectDb;
            cmd.CommandType = CommandType.Text;
            connectDb.Open();
            readData = cmd.ExecuteReader();
            while (readData.Read())
            {
                String[] data = {readData["order_id"].ToString(),
                    readData["order_client"].ToString(),
                    readData["order_time"].ToString(),
                    readData["order_date"].ToString(),
                    readData["order_detail"].ToString(),
                    readData["order_amount"].ToString()
                };
                var row = new ListViewItem(data);
                listView1.Items.Add(row);
            }
            connectDb.Close();
            
        }
    }
}
