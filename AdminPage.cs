using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProje
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-CTC7A8E5;Database=KütüphaneOtomasyonu;Trusted_Connection=True;TrustServerCertificate=True;");


        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select COUNT(*) from Admin where kullanıcıAdi=@kullanıcıAdi and sifre=@sifre ", baglanti);
            cmd.Parameters.AddWithValue("@kullanıcıAdi", txtKullanıcıAdı.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

            object result = cmd.ExecuteScalar(); // Sorgu sonucunu al
            int sonuc = result != null ? Convert.ToInt32(result) : 0; // Null kontrolü yap ve int'e dönüştür


            if (sonuc > 0)
            {
                // Giriş başarılı
                MessageBox.Show("Login successful!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AnaSayfa anaSayfa = new AnaSayfa();
                this.Hide(); // LoginForm'u gizle
                anaSayfa.ShowDialog();
            }
            else
            {
                // Hatalı giriş
                MessageBox.Show("Username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }
    }
}
