namespace VisualProje
{
    partial class ÜyeEkle
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
            txtTc = new TextBox();
            txtYas = new TextBox();
            txtOkuKitapSayisi = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboCinsiyet = new ComboBox();
            btnUyeEkle = new Button();
            btnİptal = new Button();
            label3 = new Label();
            txtAdres = new TextBox();
            SuspendLayout();
            // 
            // txtTc
            // 
            txtTc.Location = new Point(207, 40);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(164, 27);
            txtTc.TabIndex = 0;
            txtTc.TextChanged += txtTc_TextChanged;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(207, 127);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(164, 27);
            txtYas.TabIndex = 1;
            // 
            // txtOkuKitapSayisi
            // 
            txtOkuKitapSayisi.Location = new Point(207, 364);
            txtOkuKitapSayisi.Name = "txtOkuKitapSayisi";
            txtOkuKitapSayisi.Size = new Size(165, 27);
            txtOkuKitapSayisi.TabIndex = 2;
            txtOkuKitapSayisi.Text = "0";
            txtOkuKitapSayisi.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(207, 220);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(165, 27);
            txtTelefon.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(207, 319);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(207, 84);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(164, 27);
            txtAdSoyad.TabIndex = 7;
            txtAdSoyad.TextChanged += textBox8_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 47);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 9;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 87);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 10;
            label2.Text = "Name Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(142, 130);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 12;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(119, 182);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 13;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(126, 227);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 14;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(131, 319);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 15;
            label7.Text = "E-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 367);
            label8.Name = "label8";
            label8.Size = new Size(172, 20);
            label8.TabIndex = 16;
            label8.Text = "Number of Books Read";
            // 
            // comboCinsiyet
            // 
            comboCinsiyet.FormattingEnabled = true;
            comboCinsiyet.Items.AddRange(new object[] { "Male", "Female" });
            comboCinsiyet.Location = new Point(207, 174);
            comboCinsiyet.Name = "comboCinsiyet";
            comboCinsiyet.Size = new Size(164, 28);
            comboCinsiyet.TabIndex = 17;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUyeEkle.Location = new Point(126, 423);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(94, 38);
            btnUyeEkle.TabIndex = 18;
            btnUyeEkle.Text = "Register";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // btnİptal
            // 
            btnİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnİptal.Location = new Point(257, 423);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(100, 38);
            btnİptal.TabIndex = 19;
            btnİptal.Text = "Cancel";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(125, 268);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 11;
            label3.Text = "Addres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(207, 265);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(164, 27);
            txtAdres.TabIndex = 6;
            // 
            // ÜyeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(512, 507);
            Controls.Add(btnİptal);
            Controls.Add(btnUyeEkle);
            Controls.Add(comboCinsiyet);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtAdres);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefon);
            Controls.Add(txtOkuKitapSayisi);
            Controls.Add(txtYas);
            Controls.Add(txtTc);
            Name = "ÜyeEkle";
            Text = "ÜyeEkle";
            Load += ÜyeEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTc;
        private TextBox txtYas;
        private TextBox txtOkuKitapSayisi;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtAdSoyad;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboCinsiyet;
        private Button btnUyeEkle;
        private Button btnİptal;
        private Label label3;
        private TextBox txtAdres;
    }
}