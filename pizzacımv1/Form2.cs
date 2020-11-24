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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connectDb = new SqlConnection("Data Source=AHMETFATIH\\MSSQLSERVER01;Initial Catalog=pizzacimv1;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader readData;
        
        private void save_Click(object sender, EventArgs e)
        {
            String nameSurname = registerNameSurname.Text;
            String userName = registerUsername.Text;
            String passWord = registerPassword.Text;

            try
            {

                cmd.Connection = connectDb;
                cmd.Connection.Open();
                cmd.CommandText = "INSERT INTO users (admin_adsoyad,admin_kullaniciad,admin_sifre) VALUES (@adsoyad,@kullaniciad,@sifre)";
                cmd.Parameters.AddWithValue("@adsoyad", nameSurname);
                cmd.Parameters.AddWithValue("@kullaniciad", userName);
                cmd.Parameters.AddWithValue("@sifre", passWord);
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch
            {
                MessageBox.Show("Veritabanı Hatası","HATA");
            }
            
          
         
        }
    }
}
