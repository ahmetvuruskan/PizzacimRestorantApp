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
        SqlConnection connectDb = new SqlConnection("Data Source=AHMETFATIH\\MSSQLSERVER01;Initial Catalog=pizzacimv1;Integrated Security=True");
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
                    MessageBox.Show("Kullanici Adi Ve Sifreniz Dogru ");
                    MainPAge mainPAge = new MainPAge();
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

        public void adduser_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
            
        }
    }
}
