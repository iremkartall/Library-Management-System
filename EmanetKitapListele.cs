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
    public partial class EmanetKitapListele : Form
    {
        public EmanetKitapListele()
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

        private void EmanetKitapListele_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataSet.Tables["EmanetKitaplar"].Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                // Tüm emanet kitapları listele
                EmanetListele();
            }
            else
            {
                string query;
                if (comboBox1.SelectedIndex == 1)
                {
                    // Gecikmiş emanet kitaplar
                    query = "SELECT * FROM EmanetKitaplar WHERE iadetarihi < @bugun";
                }
                else
                {
                    // Teslim tarihi henüz geçmemiş kitaplar
                    query = "SELECT * FROM EmanetKitaplar WHERE iadetarihi >= @bugun";
                }

                try
                {
                    baglanti.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, baglanti);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@bugun", DateTime.Now.Date); // Sadece tarih karşılaştırması yapılır
                    sqlDataAdapter.Fill(dataSet, "EmanetKitaplar");
                    dataGridView1.DataSource = dataSet.Tables["EmanetKitaplar"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while listing books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();
                }
            }

        }
    }
}
