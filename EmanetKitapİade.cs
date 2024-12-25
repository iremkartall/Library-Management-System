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
    public partial class EmanetKitapİade : Form
    {
        public EmanetKitapİade()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-CTC7A8E5;Database=KütüphaneOtomasyonu;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

        DataSet dataSet = new DataSet();
        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from EmanetKitaplar", baglanti);
            sqlDataAdapter.Fill(dataSet, "EmanetKitaplar");
            dataGridView1.DataSource = dataSet.Tables["emanetKitaplar"];
            baglanti.Close();
        }
        private void EmanetKitapİade_Load(object sender, EventArgs e)
        {
            EmanetListele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataSet.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from emanetKitaplar where barkodno like '%" + txtBarkodAra.Text + "%'", baglanti);
            sqlDataAdapter.Fill(dataSet, "EmanetKitaplar");
            baglanti.Close();
            if (txtBarkodAra.Text == "")
            {
                dataSet.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }

        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            dataSet.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from emanetKitaplar where tc like '%" + txtTcAra.Text + "%'", baglanti);
            sqlDataAdapter.Fill(dataSet, "EmanetKitaplar");
            baglanti.Close();
            if (txtTcAra.Text == "")
            {
                dataSet.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from EmanetKitaplar where tc=@tc and barkodno=@barkodno ", baglanti);
            cmd.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            cmd.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            cmd.ExecuteNonQuery();
            baglanti.Close();


            baglanti.Open();

            SqlCommand cmd1 = new SqlCommand("update kitap set stoksayisi=stoksayisi+ '" + dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString() + "' where barkod=@barkod ", baglanti);
            cmd1.Parameters.AddWithValue("@barkod", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            cmd1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("The book(s) were returned :)");

            dataSet.Tables["EmanetKitaplar"].Clear();
            EmanetListele();


        }
    }
}
