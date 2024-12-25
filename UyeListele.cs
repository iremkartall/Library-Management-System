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
using System.Runtime.Intrinsics.Arm;

namespace VisualProje
{
    public partial class UyeListele : Form
    {
        public UyeListele()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();

        }
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-CTC7A8E5;Database=KütüphaneOtomasyonu;Trusted_Connection=True;TrustServerCertificate=True;");
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select *from uye where tc=@tc ", baglanti);
            cmd.Parameters.AddWithValue("@tc", txtTc.Text);
            SqlDataReader rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                txtAdSoyad.Text = rdr1["adsoyad"].ToString();
                txtYas.Text = rdr1["yas"].ToString();
                comboCinsiyet.Text = rdr1["cinsiyet"].ToString();
                txtTelefon.Text = rdr1["telefon"].ToString();
                txtAdres.Text = rdr1["adres"].ToString();
                txtEmail.Text = rdr1["email"].ToString();
                txtOkuKitapSayisi.Text = rdr1["okukitapsayisi"].ToString();

            }

            baglanti.Close();

        }
        DataSet dataSet = new DataSet();
        private void txtAraTc_TextChanged(object sender, EventArgs e)
        {
            dataSet.Tables["uye"].Clear();
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select *from uye where tc like '%" + txtAraTc.Text + "%' ", baglanti);
            adapter.Fill(dataSet, "uye");
            dataGridView1.DataSource = dataSet.Tables["uye"];
            baglanti.Close();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Do you want to delete this record?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from uye where tc=@tc", baglanti);
                cmd.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Record deleted successfully.");
                dataSet.Tables["uye"].Clear();
                uyeListele();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = " ";
                    }
                }

            }

        }
        private void uyeListele()
        {
            baglanti.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select *from uye ", baglanti);
            dataAdapter.Fill(dataSet, "uye");
            dataGridView1.DataSource = dataSet.Tables["uye"];
            baglanti.Close();
        }

        private void UyeListele_Load(object sender, EventArgs e)
        {
            uyeListele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("update uye set adsoyad=@adsoyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,adres=@adres,email=@email,okukitapsayisi=@okukitapsayisi where tc=@tc", baglanti);
            sqlCommand.Parameters.AddWithValue("@tc", txtTc.Text);
            sqlCommand.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@yas", txtYas.Text);
            sqlCommand.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            sqlCommand.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@adres", txtAdres.Text);
            sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@okukitapsayisi", int.Parse(txtOkuKitapSayisi.Text));

            sqlCommand.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Update has been completed");
            dataSet.Tables["uye"].Clear();
            uyeListele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }

        }
    }
}
