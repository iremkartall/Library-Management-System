using Microsoft.Data.SqlClient;

namespace VisualProje
{
    public partial class ÜyeEkle : Form
    {
        public ÜyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection bagalanti = new SqlConnection("Server=LAPTOP-CTC7A8E5;Database=KütüphaneOtomasyonu;Trusted_Connection=True;TrustServerCertificate=True;");
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            bagalanti.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into uye(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okukitapsayisi) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi)", bagalanti);
            sqlCommand.Parameters.AddWithValue("@tc", txtTc.Text);
            sqlCommand.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@yas", txtYas.Text);
            sqlCommand.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            sqlCommand.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@adres", txtAdres.Text);
            sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@okukitapsayisi", txtOkuKitapSayisi.Text);

            sqlCommand.ExecuteNonQuery();
            bagalanti.Close();
            MessageBox.Show("Kayıt başarıyla yapıldı.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtOkuKitapSayisi)
                    {
                        item.Text = "";

                    }
                }
            }

        }
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ÜyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

