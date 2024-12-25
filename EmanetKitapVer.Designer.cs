namespace VisualProje
{
    partial class EmanetKitapVer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            grpUyeBilgi = new GroupBox();
            txtTelNo = new TextBox();
            txtYas = new TextBox();
            txtAdSoyad = new TextBox();
            txtTcAra = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpKitapBilgi = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtBarkod = new TextBox();
            txtKitapIsmi = new TextBox();
            txtKitapSayisi = new TextBox();
            txtSayfaSayisi = new TextBox();
            txtYayinevi = new TextBox();
            txtYazar = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnEkle = new Button();
            btnTeslimEt = new Button();
            btnIptal = new Button();
            btnSil = new Button();
            lblkayıtlıKitapSayısı = new Label();
            lblKayitliKitapSayisi = new Label();
            lblKitapSayisi = new Label();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpUyeBilgi.SuspendLayout();
            grpKitapBilgi.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(918, 166);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(899, 602);
            dataGridView1.TabIndex = 0;
            // 
            // grpUyeBilgi
            // 
            grpUyeBilgi.BackColor = Color.Chocolate;
            grpUyeBilgi.Controls.Add(txtTelNo);
            grpUyeBilgi.Controls.Add(txtYas);
            grpUyeBilgi.Controls.Add(txtAdSoyad);
            grpUyeBilgi.Controls.Add(txtTcAra);
            grpUyeBilgi.Controls.Add(label4);
            grpUyeBilgi.Controls.Add(label3);
            grpUyeBilgi.Controls.Add(label2);
            grpUyeBilgi.Controls.Add(label1);
            grpUyeBilgi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpUyeBilgi.ForeColor = Color.White;
            grpUyeBilgi.Location = new Point(82, 130);
            grpUyeBilgi.Margin = new Padding(4);
            grpUyeBilgi.Name = "grpUyeBilgi";
            grpUyeBilgi.Padding = new Padding(4);
            grpUyeBilgi.Size = new Size(442, 244);
            grpUyeBilgi.TabIndex = 1;
            grpUyeBilgi.TabStop = false;
            grpUyeBilgi.Text = "Member Information";
            // 
            // txtTelNo
            // 
            txtTelNo.Location = new Point(194, 187);
            txtTelNo.Margin = new Padding(4);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(171, 34);
            txtTelNo.TabIndex = 9;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(194, 142);
            txtYas.Margin = new Padding(4);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(171, 34);
            txtYas.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(194, 97);
            txtAdSoyad.Margin = new Padding(4);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(171, 34);
            txtAdSoyad.TabIndex = 7;
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(194, 45);
            txtTcAra.Margin = new Padding(4);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(171, 34);
            txtTcAra.TabIndex = 3;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 191);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 28);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 5;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 4;
            label2.Text = "Name Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 3;
            label1.Text = "Search Id";
            // 
            // grpKitapBilgi
            // 
            grpKitapBilgi.BackColor = Color.Chocolate;
            grpKitapBilgi.Controls.Add(label12);
            grpKitapBilgi.Controls.Add(label11);
            grpKitapBilgi.Controls.Add(dateTimePicker2);
            grpKitapBilgi.Controls.Add(dateTimePicker1);
            grpKitapBilgi.Controls.Add(label10);
            grpKitapBilgi.Controls.Add(label9);
            grpKitapBilgi.Controls.Add(label8);
            grpKitapBilgi.Controls.Add(label7);
            grpKitapBilgi.Controls.Add(label6);
            grpKitapBilgi.Controls.Add(label5);
            grpKitapBilgi.Controls.Add(txtBarkod);
            grpKitapBilgi.Controls.Add(txtKitapIsmi);
            grpKitapBilgi.Controls.Add(txtKitapSayisi);
            grpKitapBilgi.Controls.Add(txtSayfaSayisi);
            grpKitapBilgi.Controls.Add(txtYayinevi);
            grpKitapBilgi.Controls.Add(txtYazar);
            grpKitapBilgi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpKitapBilgi.ForeColor = Color.White;
            grpKitapBilgi.Location = new Point(82, 402);
            grpKitapBilgi.Margin = new Padding(4);
            grpKitapBilgi.Name = "grpKitapBilgi";
            grpKitapBilgi.Padding = new Padding(4);
            grpKitapBilgi.Size = new Size(442, 412);
            grpKitapBilgi.TabIndex = 2;
            grpKitapBilgi.TabStop = false;
            grpKitapBilgi.Text = "Book Information";
            
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(22, 348);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(118, 28);
            label12.TabIndex = 18;
            label12.Text = "Return date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(22, 308);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(134, 28);
            label11.TabIndex = 17;
            label11.Text = "Delivery Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(194, 343);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(171, 34);
            dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(194, 303);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 34);
            dateTimePicker1.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(22, 267);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(165, 28);
            label10.TabIndex = 7;
            label10.Text = "Number of Book";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(22, 220);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(137, 28);
            label9.TabIndex = 14;
            label9.Text = "Page Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(22, 174);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(173, 28);
            label8.TabIndex = 13;
            label8.Text = "Publishing House";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(22, 128);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 28);
            label7.TabIndex = 12;
            label7.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 82);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 11;
            label6.Text = "Book Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(22, 36);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 10;
            label5.Text = "Barcode No";
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(194, 31);
            txtBarkod.Margin = new Padding(4);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(171, 34);
            txtBarkod.TabIndex = 9;
            txtBarkod.TextChanged += txtBarkod_TextChanged;
            // 
            // txtKitapIsmi
            // 
            txtKitapIsmi.Location = new Point(194, 78);
            txtKitapIsmi.Margin = new Padding(4);
            txtKitapIsmi.Name = "txtKitapIsmi";
            txtKitapIsmi.Size = new Size(171, 34);
            txtKitapIsmi.TabIndex = 8;
            // 
            // txtKitapSayisi
            // 
            txtKitapSayisi.Location = new Point(194, 258);
            txtKitapSayisi.Margin = new Padding(4);
            txtKitapSayisi.Multiline = true;
            txtKitapSayisi.Name = "txtKitapSayisi";
            txtKitapSayisi.Size = new Size(171, 37);
            txtKitapSayisi.TabIndex = 7;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(194, 216);
            txtSayfaSayisi.Margin = new Padding(4);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(171, 34);
            txtSayfaSayisi.TabIndex = 6;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(194, 170);
            txtYayinevi.Margin = new Padding(4);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(171, 34);
            txtYayinevi.TabIndex = 5;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(194, 124);
            txtYazar.Margin = new Padding(4);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(171, 34);
            txtYazar.TabIndex = 4;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(418, 821);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(106, 46);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "SAVE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnTeslimEt
            // 
            btnTeslimEt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeslimEt.Location = new Point(1458, 795);
            btnTeslimEt.Name = "btnTeslimEt";
            btnTeslimEt.Size = new Size(106, 46);
            btnTeslimEt.TabIndex = 4;
            btnTeslimEt.Text = "RETURN";
            btnTeslimEt.UseVisualStyleBackColor = true;
            btnTeslimEt.Click += btnTeslimEt_Click;
            // 
            // btnIptal
            // 
            btnIptal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIptal.Location = new Point(1589, 795);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(106, 46);
            btnIptal.TabIndex = 5;
            btnIptal.Text = "CANCEL";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(1589, 96);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(106, 46);
            btnSil.TabIndex = 6;
            btnSil.Text = "DELETE";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblkayıtlıKitapSayısı
            // 
            lblkayıtlıKitapSayısı.AutoSize = true;
            lblkayıtlıKitapSayısı.BackColor = Color.Transparent;
            lblkayıtlıKitapSayısı.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblkayıtlıKitapSayısı.ForeColor = Color.White;
            lblkayıtlıKitapSayısı.Location = new Point(722, 775);
            lblkayıtlıKitapSayısı.Name = "lblkayıtlıKitapSayısı";
            lblkayıtlıKitapSayısı.Size = new Size(0, 28);
            lblkayıtlıKitapSayısı.TabIndex = 7;
            // 
            // lblKayitliKitapSayisi
            // 
            lblKayitliKitapSayisi.AutoSize = true;
            lblKayitliKitapSayisi.BackColor = Color.White;
            lblKayitliKitapSayisi.Location = new Point(990, 795);
            lblKayitliKitapSayisi.Name = "lblKayitliKitapSayisi";
            lblKayitliKitapSayisi.Size = new Size(0, 28);
            lblKayitliKitapSayisi.TabIndex = 9;
            // 
            // lblKitapSayisi
            // 
            lblKitapSayisi.AutoSize = true;
            lblKitapSayisi.BackColor = Color.White;
            lblKitapSayisi.Location = new Point(1311, 795);
            lblKitapSayisi.Name = "lblKitapSayisi";
            lblKitapSayisi.Size = new Size(0, 28);
            lblKitapSayisi.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(695, 795);
            label13.Name = "label13";
            label13.Size = new Size(276, 28);
            label13.TabIndex = 11;
            label13.Text = "Number of Registered Books";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(1113, 795);
            label14.Name = "label14";
            label14.Size = new Size(178, 28);
            label14.TabIndex = 12;
            label14.Text = "Number of Books";
            // 
            // EmanetKitapVer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            BackgroundImage = Properties.Resources.kutuphane_image_10;
            ClientSize = new Size(1707, 926);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(lblKitapSayisi);
            Controls.Add(lblKayitliKitapSayisi);
            Controls.Add(lblkayıtlıKitapSayısı);
            Controls.Add(btnSil);
            Controls.Add(btnIptal);
            Controls.Add(btnTeslimEt);
            Controls.Add(btnEkle);
            Controls.Add(grpKitapBilgi);
            Controls.Add(grpUyeBilgi);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "EmanetKitapVer";
            Text = "EmanetKitapVer";
            WindowState = FormWindowState.Maximized;
            Load += EmanetKitapVer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpUyeBilgi.ResumeLayout(false);
            grpUyeBilgi.PerformLayout();
            grpKitapBilgi.ResumeLayout(false);
            grpKitapBilgi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grpUyeBilgi;
        private GroupBox grpKitapBilgi;
        private TextBox txtTelNo;
        private TextBox txtYas;
        private TextBox txtAdSoyad;
        private TextBox txtTcAra;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtBarkod;
        private TextBox txtKitapIsmi;
        private TextBox txtKitapSayisi;
        private TextBox txtSayfaSayisi;
        private TextBox txtYayinevi;
        private TextBox txtYazar;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private Label label11;
        private Button btnEkle;
        private Button btnTeslimEt;
        private Button btnIptal;
        private Button btnSil;
        private Label lblkayıtlıKitapSayısı;
        private Label lblKayitliKitapSayisi;
        private Label lblKitapSayisi;
        private Label label13;
        private Label label14;
    }
}