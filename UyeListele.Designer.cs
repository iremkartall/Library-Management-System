namespace VisualProje
{
    partial class UyeListele
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
            btnİptal = new Button();
            btnGuncelle = new Button();
            comboCinsiyet = new ComboBox();
            txtAdSoyad = new TextBox();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtOkuKitapSayisi = new TextBox();
            txtYas = new TextBox();
            txtTc = new TextBox();
            btnSil = new Button();
            txtAraTc = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(442, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(830, 453);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnİptal
            // 
            btnİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnİptal.Location = new Point(282, 498);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(100, 38);
            btnİptal.TabIndex = 37;
            btnİptal.Text = "CANCEL";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(151, 498);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 38);
            btnGuncelle.TabIndex = 36;
            btnGuncelle.Text = "UPDATE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // comboCinsiyet
            // 
            comboCinsiyet.FormattingEnabled = true;
            comboCinsiyet.Items.AddRange(new object[] { "Male", "Female" });
            comboCinsiyet.Location = new Point(207, 249);
            comboCinsiyet.Name = "comboCinsiyet";
            comboCinsiyet.Size = new Size(164, 28);
            comboCinsiyet.TabIndex = 35;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(207, 159);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(164, 27);
            txtAdSoyad.TabIndex = 26;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(207, 340);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(164, 27);
            txtAdres.TabIndex = 25;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(207, 394);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 27);
            txtEmail.TabIndex = 24;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(207, 295);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(165, 27);
            txtTelefon.TabIndex = 23;
            // 
            // txtOkuKitapSayisi
            // 
            txtOkuKitapSayisi.Location = new Point(207, 439);
            txtOkuKitapSayisi.Name = "txtOkuKitapSayisi";
            txtOkuKitapSayisi.Size = new Size(165, 27);
            txtOkuKitapSayisi.TabIndex = 22;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(207, 202);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(164, 27);
            txtYas.TabIndex = 21;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(208, 115);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(164, 27);
            txtTc.TabIndex = 20;
            txtTc.TextChanged += txtTc_TextChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1278, 99);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(99, 31);
            btnSil.TabIndex = 38;
            btnSil.Text = "Delete";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAraTc
            // 
            txtAraTc.Location = new Point(781, 40);
            txtAraTc.Name = "txtAraTc";
            txtAraTc.Size = new Size(164, 27);
            txtAraTc.TabIndex = 39;
            txtAraTc.TextChanged += txtAraTc_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(687, 43);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 40;
            label9.Text = "Search Id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 446);
            label10.Name = "label10";
            label10.Size = new Size(172, 20);
            label10.TabIndex = 48;
            label10.Text = "Number of Books Read";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(140, 398);
            label11.Name = "label11";
            label11.Size = new Size(53, 20);
            label11.TabIndex = 47;
            label11.Text = "E-mail";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(135, 306);
            label12.Name = "label12";
            label12.Size = new Size(53, 20);
            label12.TabIndex = 46;
            label12.Text = "Phone";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(128, 261);
            label13.Name = "label13";
            label13.Size = new Size(60, 20);
            label13.TabIndex = 45;
            label13.Text = "Gender";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(151, 209);
            label14.Name = "label14";
            label14.Size = new Size(37, 20);
            label14.TabIndex = 44;
            label14.Text = "Age";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(134, 347);
            label15.Name = "label15";
            label15.Size = new Size(59, 20);
            label15.TabIndex = 43;
            label15.Text = "Addres";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(71, 162);
            label16.Name = "label16";
            label16.Size = new Size(117, 20);
            label16.TabIndex = 42;
            label16.Text = "Name Surname";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(165, 118);
            label17.Name = "label17";
            label17.Size = new Size(23, 20);
            label17.TabIndex = 41;
            label17.Text = "Id";
            // 
            // UyeListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(1411, 696);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label9);
            Controls.Add(txtAraTc);
            Controls.Add(btnSil);
            Controls.Add(btnİptal);
            Controls.Add(btnGuncelle);
            Controls.Add(comboCinsiyet);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtAdres);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefon);
            Controls.Add(txtOkuKitapSayisi);
            Controls.Add(txtYas);
            Controls.Add(txtTc);
            Controls.Add(dataGridView1);
            Name = "UyeListele";
            Text = "UyeListele";
            Load += UyeListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnİptal;
        private Button btnGuncelle;
        private ComboBox comboCinsiyet;
        private TextBox txtAdSoyad;
        private TextBox txtAdres;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtOkuKitapSayisi;
        private TextBox txtYas;
        private TextBox txtTc;
        private Button btnSil;
        private TextBox txtAraTc;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}