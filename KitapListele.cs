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
using System.Data.SqlClient;


namespace VisualProje
{
    public partial class KitapListele : Form
    {
        public KitapListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-CTC7A8E5;Database=KütüphaneOtomasyonu;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

        DataSet dataSet = new DataSet();
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("update kitap set barkod=@barkod,sayfasayisi=@sayfasayisi,yazari=@yazari,yayinevi=@yayinevi,turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama,kayittarihi=@kayittarihi where barkod=@barkod", baglanti);
            sqlCommand.Parameters.AddWithValue("@barkod", txtBarkod.Text);
            sqlCommand.Parameters.AddWithValue("@sayfasayisi", txtPageNumber.Text);
            sqlCommand.Parameters.AddWithValue("@yazari", txtAuthor.Text);
            sqlCommand.Parameters.AddWithValue("@yayinevi", txtPublishingHouse.Text);
            sqlCommand.Parameters.AddWithValue("@turu", comboBookType.Text);
            sqlCommand.Parameters.AddWithValue("@stoksayisi", txtStockNumber.Text);
            sqlCommand.Parameters.AddWithValue("@rafno", txtShelfNo.Text);
            sqlCommand.Parameters.AddWithValue("@aciklama", txtExplanation.Text);

            sqlCommand.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Update has been completed");
            dataSet.Tables["kitap"].Clear();
            kitapListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }

        }



        private void kitapListele()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from kitap ", baglanti);
            dataAdapter.Fill(dataSet, "kitap");
            dataGridView1.DataSource = dataSet.Tables["kitap"];
            baglanti.Close();
        }

        private void KitapListele_Load(object sender, EventArgs e)
        {
            kitapListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Do you want to delete this record?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from kitap where barkod=@barkod", baglanti);
                cmd.Parameters.AddWithValue("@barkod", dataGridView1.CurrentRow.Cells["barkod"].Value.ToString());
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Record deleted successfully.");
                dataSet.Tables["kitap"].Clear();
                kitapListele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = " ";
                    }
                }

            }

        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            dataSet.Tables["kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from kitap where barkod like '%" + txtBarkodAra.Text + "%' ", baglanti);
            adapter.Fill(dataSet, "kitap");
            dataGridView1.DataSource = dataSet.Tables["kitap"];
            baglanti.Close();
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            txtBarkod.TextChanged -= txtBarkod_TextChanged; // Olayı devre dışı bırak

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM kitap WHERE barkod = @barkod", baglanti);
            cmd.Parameters.AddWithValue("@barkod", txtBarkod.Text);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                txtBarkod.Text = rdr["barkod"].ToString();
                txtBookName.Text = rdr["kitapadi"].ToString();
                txtPageNumber.Text = rdr["sayfasayisi"].ToString();
                txtAuthor.Text = rdr["yazari"].ToString();
                txtPublishingHouse.Text = rdr["yayinevi"].ToString();
                comboBookType.Text = rdr["turu"].ToString();
                txtStockNumber.Text = rdr["stoksayisi"].ToString();
                txtShelfNo.Text = rdr["rafno"].ToString();
                txtExplanation.Text = rdr["aciklama"].ToString();
            }

            rdr.Close(); // Reader'ı kapat
            baglanti.Close();

            txtBarkod.TextChanged += txtBarkod_TextChanged; // Olayı yeniden etkinleştir
        }


        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
