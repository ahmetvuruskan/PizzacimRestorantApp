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
        SqlConnection connectDb = new SqlConnection("Data Source=18.219.99.255,1433;Network Library = DBMSSOCN;Initial Catalog=pizzacimv1;User Id=pizzaci;Password=963852741");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader readData;

        private void save_Click(object sender, EventArgs e)
        {
            String nameSurname = registerNameSurname.Text;
            String userName = registerUsername.Text;
            String passWord = registerPassword.Text;

            if (!(String.IsNullOrEmpty(nameSurname)) && !(String.IsNullOrEmpty(userName)) && !(String.IsNullOrEmpty(passWord)))    {
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
                    MessageBox.Show("KULLANICI KAYDI BAŞARI İLE OLUŞRULDU", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();

                }
                catch
                {
                    MessageBox.Show("BAĞLANTI KURULURKEN HATA OLUŞTU", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("LÜTFEN  BOŞ ALAN BIRAKMAYINIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        void clear()
        {
            registerNameSurname.Text = "";
            registerUsername.Text = "";
            registerPassword.Text = "";
        }

        private void registerUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
