using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace VisualProje
{
    public partial class EmanetKitapVer : Form
    {
        public EmanetKitapVer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=LAPTOP-CTC7A8E5;Database=KütüphaneOtomasyonu;Trusted_Connection=True;TrustServerCertificate=True;");
        DataSet dataSet = new DataSet();

        private void EmanetKitapVer_Load(object sender, EventArgs e)
        {
            sepetListele();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void sepetListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM sepet", baglanti);
                dataSet.Tables.Clear();
                sqlDataAdapter.Fill(dataSet, "sepet");
                dataGridView1.DataSource = dataSet.Tables["sepet"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error listing cart: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void kitapSayisiBul()
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(kitapsayisi) FROM sepet", baglanti);
                object result = cmd.ExecuteScalar();
                lblKitapSayisi.Text = result != DBNull.Value ? result.ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating book count: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (ValidateKitapBilgiInputs())
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO sepet (barkodno, kitapadi, yazari, yayinevi, sayfasayisi, kitapsayisi, teslimtarihi, iadetarihi) VALUES (@barkodno, @kitapadi, @yazari, @yayinevi, @sayfasayisi, @kitapsayisi, @teslimtarihi, @iadetarihi)", baglanti);
                    cmd.Parameters.AddWithValue("@barkodno", txtBarkod.Text);
                    cmd.Parameters.AddWithValue("@kitapadi", txtKitapIsmi.Text);
                    cmd.Parameters.AddWithValue("@yazari", txtYazar.Text);
                    cmd.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                    cmd.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
                    cmd.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtKitapSayisi.Text));
                    cmd.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Value);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book added to cart.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding book to cart: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                    RefreshCartAndResetInputs();
                }
            }
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTcAra.Text))
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM uye WHERE tc = @tc", baglanti);
                    cmd.Parameters.AddWithValue("@tc", txtTcAra.Text);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        txtAdSoyad.Text = rdr["adsoyad"].ToString();
                        txtYas.Text = rdr["yas"].ToString();
                        txtTelNo.Text = rdr["telefon"].ToString();
                    }
                    rdr.Close();
                }
                else
                {
                    ResetUyeInputs();
                }

                SqlCommand cmd2 = new SqlCommand("SELECT SUM(kitapsayisi) FROM emanetKitaplar WHERE tc = @tc", baglanti);
                cmd2.Parameters.AddWithValue("@tc", txtTcAra.Text);
                object result = cmd2.ExecuteScalar();
                lblkayıtlıKitapSayısı.Text = result != DBNull.Value ? result.ToString() : "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading member data: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBarkod.Text))
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM kitap WHERE barkod = @barkod", baglanti);
                    cmd.Parameters.AddWithValue("@barkod", txtBarkod.Text);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        txtKitapIsmi.Text = rdr["kitapadi"].ToString();
                        txtYazar.Text = rdr["yazari"].ToString();
                        txtYayinevi.Text = rdr["yayinevi"].ToString();
                        txtSayfaSayisi.Text = rdr["sayfasayisi"].ToString();
                    }
                    rdr.Close();
                }
                else
                {
                    ResetKitapInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book data: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        baglanti.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM sepet WHERE barkodno = @barkodno", baglanti);
                        cmd.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Deletion successful.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                    finally
                    {
                        baglanti.Close();
                        RefreshCartAndResetInputs();
                    }
                }
            }
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            // Kitap sayısını kontrol et
            if (!string.IsNullOrEmpty(lblKitapSayisi.Text) && int.TryParse(lblKitapSayisi.Text, out int kitapSayisi) && kitapSayisi > 0)
            {
                int mevcutKitapSayisi = string.IsNullOrEmpty(lblkayıtlıKitapSayısı.Text) ? 0 : int.Parse(lblkayıtlıKitapSayısı.Text);

                // Mevcut kitap sayısının toplamı 3'ten fazla olamaz
                if (mevcutKitapSayisi + kitapSayisi <= 3)
                {
                    // Üye bilgilerinin eksiksiz girildiğini kontrol et
                    if (!string.IsNullOrEmpty(txtTcAra.Text) &&
                        !string.IsNullOrEmpty(txtAdSoyad.Text) &&
                        !string.IsNullOrEmpty(txtYas.Text) &&
                        !string.IsNullOrEmpty(txtTelNo.Text))
                    {
                        try
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.IsNewRow) continue;

                                // Kitap bilgilerini emanet listesine ekle
                                baglanti.Open();
                                SqlCommand cmd = new SqlCommand("INSERT INTO emanetKitaplar (tc, adsoyad, yas, telefon, barkodno, kitapadi, yazari, yayinevi, sayfasayisi, kitapsayisi, teslimtarihi, iadetarihi) VALUES (@tc, @adsoyad, @yas, @telefon, @barkodno, @kitapadi, @yazari, @yayinevi, @sayfasayisi, @kitapsayisi, @teslimtarihi, @iadetarihi)", baglanti);
                                cmd.Parameters.AddWithValue("@tc", txtTcAra.Text);
                                cmd.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                                cmd.Parameters.AddWithValue("@yas", txtYas.Text);
                                cmd.Parameters.AddWithValue("@telefon", txtTelNo.Text);
                                cmd.Parameters.AddWithValue("@barkodno", row.Cells["barkodno"].Value.ToString());
                                cmd.Parameters.AddWithValue("@kitapadi", row.Cells["kitapadi"].Value.ToString());
                                cmd.Parameters.AddWithValue("@yazari", row.Cells["yazari"].Value.ToString());
                                cmd.Parameters.AddWithValue("@yayinevi", row.Cells["yayinevi"].Value.ToString());
                                cmd.Parameters.AddWithValue("@sayfasayisi", row.Cells["sayfasayisi"].Value.ToString());
                                cmd.Parameters.AddWithValue("@kitapsayisi", int.Parse(row.Cells["kitapsayisi"].Value.ToString()));
                                cmd.Parameters.AddWithValue("@teslimtarihi", row.Cells["teslimtarihi"].Value);
                                cmd.Parameters.AddWithValue("@iadetarihi", row.Cells["iadetarihi"].Value);
                                cmd.ExecuteNonQuery();

                                // Üyenin okuduğu kitap sayısını güncelle
                                SqlCommand cmd2 = new SqlCommand("UPDATE uye SET okukitapsayisi = okukitapsayisi + @kitapSayisi WHERE tc = @tc", baglanti);
                                cmd2.Parameters.AddWithValue("@kitapSayisi", int.Parse(row.Cells["kitapsayisi"].Value.ToString()));
                                cmd2.Parameters.AddWithValue("@tc", txtTcAra.Text);
                                cmd2.ExecuteNonQuery();

                                // Kitap stok sayısını güncelle
                                SqlCommand cmd3 = new SqlCommand("UPDATE kitap SET stoksayisi = stoksayisi - @kitapSayisi WHERE barkod = @barkod", baglanti);
                                cmd3.Parameters.AddWithValue("@kitapSayisi", int.Parse(row.Cells["kitapsayisi"].Value.ToString()));
                                cmd3.Parameters.AddWithValue("@barkod", row.Cells["barkodno"].Value.ToString());
                                cmd3.ExecuteNonQuery();

                                baglanti.Close();
                            }

                            // Sepeti temizle
                            baglanti.Open();
                            SqlCommand cmd4 = new SqlCommand("DELETE FROM sepet", baglanti);
                            cmd4.ExecuteNonQuery();
                            MessageBox.Show("Books successfully delivered.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error processing delivery: " + ex.Message);
                        }
                        finally
                        {
                            baglanti.Close();
                            RefreshCartAndResetInputs();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must enter member information.", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("The total number of books cannot exceed 3.", "Warning");
                }
            }
            else
            {
                MessageBox.Show("You must add books to the cart first.", "Warning");
            }
        }


        private bool ValidateKitapBilgiInputs()
        {
            if (string.IsNullOrEmpty(txtBarkod.Text) ||
                string.IsNullOrEmpty(txtKitapIsmi.Text) ||
                string.IsNullOrEmpty(txtYazar.Text) ||
                string.IsNullOrEmpty(txtYayinevi.Text) ||
                string.IsNullOrEmpty(txtSayfaSayisi.Text) ||
                string.IsNullOrEmpty(txtKitapSayisi.Text) ||
                !int.TryParse(txtKitapSayisi.Text, out _))
            {
                MessageBox.Show("Please fill in all book details correctly.", "Warning");
                return false;
            }
            return true;
        }

        private void RefreshCartAndResetInputs()
        {
            dataSet.Tables["sepet"].Clear();
            sepetListele();
            lblKitapSayisi.Text = "";
            kitapSayisiBul();
            ResetKitapInputs();
        }

        private void ResetKitapInputs()
        {
            foreach (Control item in grpKitapBilgi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void ResetUyeInputs()
        {
            foreach (Control item in grpUyeBilgi.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            lblkayıtlıKitapSayısı.Text = "";
        }
    }
}
