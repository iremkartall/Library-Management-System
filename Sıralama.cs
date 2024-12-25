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
    public partial class Sıralama : Form
    {
        public Sıralama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-CTC7A8E5;Database=KütüphaneOtomasyonu;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");

        DataSet dataSet = new DataSet();

        private void Sıralama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select *from uye order by okukitapsayisi desc", baglanti);
            sqlDataAdapter.Fill(dataSet, "Uye");
            dataGridView1.DataSource = dataSet.Tables["Uye"];
            baglanti.Close();

            label2.Text = "";
            label4.Text = "";
            label2.Text = dataSet.Tables["uye"].Rows[0]["adsoyad"].ToString()+"=";
            label2.Text += dataSet.Tables["uye"].Rows[0]["okukitapsayisi"].ToString();

            label4.Text = dataSet.Tables["uye"].Rows[dataGridView1.Rows.Count-2]["adsoyad"].ToString()+"=";
            label4.Text += dataSet.Tables["uye"].Rows[dataGridView1.Rows.Count - 2]["okukitapsayisi"].ToString();

        }
    }
}
