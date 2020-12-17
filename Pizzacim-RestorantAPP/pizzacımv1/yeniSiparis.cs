using System;
using System.Collections;
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
    public partial class yeniSiparis : Form
    {
        ArrayList extrasPriceList = new ArrayList();
        ArrayList productsPriceList = new ArrayList();
        ArrayList beveragePriceList = new ArrayList();
        int amount = 0, index;
        string orderDetail;
        String beverageDetail;
        MainPage main = new MainPage();
        public yeniSiparis()
        {
            InitializeComponent();
            listBox1.SelectionMode = SelectionMode.One;
        }
        Form1 form1 = new Form1();

        private void yeniSiparis_Load(object sender, EventArgs e)
        {
            getProducts();
            getBeverages();
            getExtras();
           
        }

        void getExtras()
        {
            form1.cmd.CommandText = "SELECT * FROM extras";
            form1.cmd.Connection = form1.connectDb;
            form1.cmd.CommandType = CommandType.Text;
            form1.connectDb.Open();
            form1.readData = form1.cmd.ExecuteReader();
            while (form1.readData.Read())
            {
                listBox3.Items.Add(form1.readData["extra_name"]);
                extrasPriceList.Add(Convert.ToInt32(form1.readData["extra_price"]));


            }
            form1.connectDb.Close();

        }

        void getProducts()
        {
            form1.cmd.CommandText = "SELECT * FROM products";
            form1.cmd.Connection = form1.connectDb;
            form1.connectDb.Open();
            form1.readData = form1.cmd.ExecuteReader();
            while (form1.readData.Read())
            {
                products.Items.Add(form1.readData["product_name"]);
                productsPriceList.Add(Convert.ToInt32(form1.readData["product_price"]));
            }
            form1.connectDb.Close();
        }
        void getBeverages()
        {
            form1.cmd.CommandText = "SELECT * FROM beverages";
            form1.cmd.Connection = form1.connectDb;
            form1.connectDb.Open();
            form1.readData = form1.cmd.ExecuteReader();
            while (form1.readData.Read())
            {
                listBox1.Items.Add(form1.readData["beverage_name"]);
                beveragePriceList.Add(Convert.ToInt32(form1.readData["beverage_price"]));
            }
            form1.connectDb.Close();
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                createOrder();
            }
            else
            {
                MessageBox.Show("Müşteri Adı Boş Bırakılmamalıdır", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (products.SelectedIndex != null)
            {
                for (int i = 0; i < products.Items.Count; i++)
                {
                    if (products.SelectedIndex == i)
                    {
                        amount += Convert.ToInt32(productsPriceList[i]);
                    }
                }
            }
            products.Enabled = false;
            textBox1.Text = amount.ToString();
        }

        

        private void pizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pizzaType.SelectedIndex == 0)
            {
                amount += 15;
            }
            else if (pizzaType.SelectedIndex == 1)
            {
                amount += 10;
            }
            else
            {
                amount += 7;
            }
            pizzaType.Enabled = false;
            textBox1.Text = amount.ToString();
        }



        private void addBeverage_Click(object sender, EventArgs e)
        {
            sum(listBox1, listBox2, beveragePriceList);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sum(listBox3, listBox4, extrasPriceList);
        }
        void sum(ListBox listBox, ListBox listBox1, ArrayList arrayList)
        {
            try {

                listBox1.Items.Add(listBox.SelectedItem);
                for (int i = 0; i <100; i++)
                {
                    if (listBox.SelectedIndex == i)
                    {
                        amount += Convert.ToInt32(arrayList[i]);
                    }
                }
                textBox1.Text = amount.ToString();
            }
             catch
            {
                MessageBox.Show("SİLİNECEK ÖĞE BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    
        void delete(ListBox lB,ListBox lB1, ArrayList arrayList)
        {
            try
            {

                index = lB.FindString(lB1.SelectedItem.ToString());
                amount -= Convert.ToInt32(arrayList[index]);
                lB1.Items.Remove(lB1.SelectedItem);
                textBox1.Text = amount.ToString();
            }
            catch
            {
                MessageBox.Show("SİLİNECEK ÖĞE BULUNAMADI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteBeverage_Click(object sender, EventArgs e)
        {
            delete(listBox1,listBox2, beveragePriceList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           delete(listBox3,listBox4, extrasPriceList);
        }

        void createOrder()
        {
            if (amount!=0&&amount>0&&textBox2.Text!=" ") {
                orderDetail = products.SelectedItem.ToString() + "" + pizzaType.SelectedItem.ToString();
                foreach (var item in listBox4.Items)
                {
                    orderDetail += "" + item;
                }
                foreach (var item in listBox2.Items)
                {
                    beverageDetail += "" + item;
                }
                form1.cmd.Connection = form1.connectDb;
                form1.cmd.Connection.Open();
                form1.cmd.CommandText = "INSERT INTO orders (order_detail,order_amount,order_client,order_time,order_beverage) VALUES (@orderdetail,@amount,@client,@time,@beverage)";
                form1.cmd.Parameters.AddWithValue("@orderdetail", orderDetail);
                form1.cmd.Parameters.AddWithValue("@amount", amount);
                form1.cmd.Parameters.AddWithValue("@client", textBox2.Text);
                form1.cmd.Parameters.AddWithValue("@time", DateTime.Now);
                form1.cmd.Parameters.AddWithValue("@beverage", beverageDetail);
                form1.cmd.ExecuteNonQuery();
                form1.cmd.Connection.Close();
              
                MessageBox.Show("Siparis Olusturuldu", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
     
    }
}
