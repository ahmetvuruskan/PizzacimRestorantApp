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
        
        Form1 form1 = new Form1();
        private void save_Click(object sender, EventArgs e)
        {
            String nameSurname = registerNameSurname.Text;
            String userName = registerUsername.Text;
            String passWord = registerPassword.Text;

            if (!(String.IsNullOrEmpty(nameSurname)) && !(String.IsNullOrEmpty(userName)) && !(String.IsNullOrEmpty(passWord)))    {
                try
                {

                    form1.cmd.Connection = form1.connectDb;
                    form1.cmd.Connection.Open();
                    form1.cmd.CommandText = "INSERT INTO users (admin_adsoyad,admin_kullaniciad,admin_sifre) VALUES (@adsoyad,@kullaniciad,@sifre)";
                    form1.cmd.Parameters.AddWithValue("@adsoyad", nameSurname);
                    form1.cmd.Parameters.AddWithValue("@kullaniciad", userName);
                    form1.cmd.Parameters.AddWithValue("@sifre", passWord);
                    form1.cmd.ExecuteNonQuery();
                    form1.cmd.Connection.Close();
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
