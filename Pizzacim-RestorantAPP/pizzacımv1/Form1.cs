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
     // Veritabanı ayarları 
          public  SqlConnection connectDb = new SqlConnection("Data Source=18.217.13.40,1433;Network Library = DBMSSOCN;Initial Catalog=pizzacimv1;User Id=pizzaci;Password=963852741");
           public SqlCommand cmd = new SqlCommand();
           public SqlDataReader readData = null;
        
        public void loginsubmit_Click(object sender, EventArgs e) // Veritabanı Kullanıcı Doğrulaması 
        {
           
            try
            {
               
              
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM users WHERE admin_kullaniciad='" + loginusername.Text + "'AND admin_sifre='" + loginpassword.Text + "'", connectDb);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    MessageBox.Show("Kullanici Adi Ve Sifreniz Dogru ","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MainPage mainPage = new MainPage();
                    mainPage.Show();
                    

                }
                else
                {
                    MessageBox.Show("Lutfen Kullanici Adi ve parolanizi kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Veritabanı hatası","HATA");
            }
           
           
        }

    }
}
