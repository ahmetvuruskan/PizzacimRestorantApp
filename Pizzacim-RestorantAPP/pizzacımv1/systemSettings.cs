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
    public partial class systemSettings : Form
    {
        Form1 form1 = new Form1();
        public systemSettings()
        {

            InitializeComponent();
        }
        void get(String columnName, String columnPrice, String table, ListView listView) //Girilen parametrelere göre veritabanından veri çeken fonksiyon 
        {
            listView.Items.Clear();
            form1.cmd.CommandText = "SELECT * FROM " + table;
            form1.cmd.Connection = form1.connectDb;
            form1.cmd.CommandType = CommandType.Text;
            form1.connectDb.Open();
            form1.readData = form1.cmd.ExecuteReader();
            while (form1.readData.Read())
            {
                String[] data =
                 {
                    form1.readData[columnName].ToString(),
                    form1.readData[columnPrice].ToString()
                };
                var row = new ListViewItem(data);
                listView.Items.Add(row);

            }
            form1.connectDb.Close();
        }

     

        private void load(object sender, EventArgs e)
        {
            beverageList.Columns.Add("İçecek Adı", 120);
            beverageList.Columns.Add("Birim Fiyatı", 95);
            beverageList.FullRowSelect = true;
            productList.FullRowSelect = true;
            extraList.FullRowSelect = true;
        }

        private void selectedIndexChanged(object sender, EventArgs e) 
        {
            changeIndex(beverageList, updateBeverageTx, beverageId, updateBeverageNum);
           
        }
        void changeIndex(ListView lV, TextBox tBName, TextBox tbId, NumericUpDown num)
        {//Girilen parametlerele göre listViewlerde seçilen elemanın id sini textboxa yazan fonksiyon 
            if (lV.SelectedItems.Count > 0) 
            {
               tbId.Text= lV.SelectedItems[0].Index.ToString();
                 tBName.Text = lV.SelectedItems[0].Text;
                num.Value = Convert.ToDecimal(lV.SelectedItems[0].SubItems[1].Text);
            }
        }
        void update(String columnName, String columnPrice, String columnId, String table, String idText,TextBox textB,NumericUpDown numeric)
        {//Girilen parametlere göre veritabanında güncelleme yapan fonksiyon 
            if (textB.Text != "")
            {
                form1.cmd.Connection = form1.connectDb;
                form1.connectDb.Open();
                form1.cmd.CommandText = "UPDATE " + table + " SET " + columnName + " ='" + textB.Text + "'," + columnPrice + "='" + numeric.Value + "' Where " + columnId + " = " + idText;
                form1.cmd.ExecuteNonQuery();
                form1.connectDb.Close();
                MessageBox.Show("Güncelleme Başarı İle Yapıldı", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void insert(String columnName, String columnPrice, String table, TextBox tB1, NumericUpDown nM)
        {//Girilen parametrelere göre veritabanında  insert yapan fonksiyon 
            if (tB1.Text != "")
            {
                form1.cmd.Connection = form1.connectDb;
                form1.connectDb.Open();
                form1.cmd.CommandText = "INSERT INTO " + table + "(" + columnName + "," + columnPrice + ") VALUES ('" + tB1.Text + "','" + nM.Value + "')";
                form1.cmd.ExecuteNonQuery();
                form1.connectDb.Close();
                MessageBox.Show("Başarı İle Eklendi", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.None);
                tB1.Clear();
                nM.Value = 0;
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void getBeverageBt_Click(object sender, EventArgs e)
        {

            get("beverage_name", "beverage_price", "beverages", beverageList);
        }
        private void updateBeverage_Click(object sender, EventArgs e)
        {
            update("beverage_name","beverage_price", "beverage_id", "beverages", beverageId.Text,updateBeverageTx,updateBeverageNum);
            get("beverage_name", "beverage_price", "beverages", beverageList);
        }

        private void addBeverage_Click(object sender, EventArgs e)
        {
            insert("beverage_name", "beverage_price", "beverages",addBeverageTx,addBeverageNum);
            get("beverage_name", "beverage_price", "beverages", beverageList);
        }

        private void getProducts_Click(object sender, EventArgs e)
        {
            get("product_name", "product_price", "products",productList);
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIndex(productList, updateProductTx, productId, updateProductNum);
        }

        private void updateProduct_Click(object sender, EventArgs e)
        {
            update("product_name", "product_price", "product_id", "products", productId.Text,updateProductTx,updateProductNum);
            get("product_name", "product_price", "products", productList);
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            insert("product_name", "product_price", "products", addProductTx, addProductNum);
            get("product_name", "product_price", "products", productList);
        }

        private void getExtras_Click(object sender, EventArgs e)
        {
            get("extra_name", "extra_price", "extras", extraList);
        }

        private void extraList_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeIndex(extraList, updateExtraTx, extraId, updateExtraNum);
        }

        private void updateExtra_Click(object sender, EventArgs e)
        {
            update("extra_name", "extra_price", "extra_id", "extras", extraId.Text, updateExtraTx, updateExtraNum);
            get("extra_name", "extra_price", "extras", extraList);
        }

        private void addExtra_Click(object sender, EventArgs e)
        {
            insert("extra_name", "extra_price", "extras", addExtraTx, addExtraNum);
            get("extra_name", "extra_price", "extras", extraList);
        }
    }
}
