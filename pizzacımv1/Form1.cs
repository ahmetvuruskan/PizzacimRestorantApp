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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       
        }
        SqlConnection connectDb = new SqlConnection("Data Source=18.219.99.255,1433;Network Library = DBMSSOCN;Initial Catalog=pizzacimv1;User Id=pizzaci;Password=963852741");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader readData = null;
        public void loginsubmit_Click(object sender, EventArgs e)
        {
            String userName = loginusername.Text;
            String passWd = loginpassword.Text;
            var baglanti = connectDb;
            try
            {
               
              
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM users WHERE admin_kullaniciad='" + loginusername.Text + "'AND admin_sifre='" + loginpassword.Text + "'", connectDb);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    MessageBox.Show("Kullanici Adi Ve Sifreniz Dogru ","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MainPage mainPAge = new MainPage();
                    mainPAge.Show();
                    

                }
                else
                {
                    MessageBox.Show("Lutfen Kullanici Adi ve parolanizi kontrol ediniz");
                }
            }
            catch
            {
                MessageBox.Show("Veritabanı hatası","HATA");
            }
           
           
        }


        private void loginusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
