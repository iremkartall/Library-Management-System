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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection bagalanti = new SqlConnection("Server=LAPTOP-CTC7A8E5;Database=KütüphaneOtomasyonu;Trusted_Connection=True;TrustServerCertificate=True;");
        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            bagalanti.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into kitap(barkod,kitapadi,sayfasayisi,yazari,yayinevi,turu,stoksayisi,rafno,aciklama,kayittarihi) values(@barkod,@kitapadi,@sayfasayisi,@yazari,@yayinevi,@turu,@stoksayisi,@rafno,@aciklama,@kayittarihi)", bagalanti);
            sqlCommand.Parameters.AddWithValue("@barkod", txtBarkod.Text);
            sqlCommand.Parameters.AddWithValue("@kitapadi", txtBookName.Text);
            sqlCommand.Parameters.AddWithValue("@sayfasayisi", txtPageNumber.Text);
            sqlCommand.Parameters.AddWithValue("@yazari", txtAuthor.Text);
            sqlCommand.Parameters.AddWithValue("@yayinevi", txtPublishingHouse.Text);
            sqlCommand.Parameters.AddWithValue("@turu", comboBookType.Text);
            sqlCommand.Parameters.AddWithValue("@stoksayisi", txtStockNumber.Text);
            sqlCommand.Parameters.AddWithValue("@rafno", txtShelfNo.Text);
            sqlCommand.Parameters.AddWithValue("@aciklama", txtExplanation.Text);
            sqlCommand.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());



            sqlCommand.ExecuteNonQuery();
            bagalanti.Close();
            MessageBox.Show("Book registration completed successfully");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {


                    item.Text = "";


                }
            }
        }

        private void tctPublishingHouse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtExplanation_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBookType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtStockNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPageNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtShelfNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
