namespace VisualProje
{
    partial class AdminPage
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
            txtKullanıcıAdı = new TextBox();
            txtSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtKullanıcıAdı
            // 
            txtKullanıcıAdı.Location = new Point(376, 293);
            txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            txtKullanıcıAdı.Size = new Size(192, 27);
            txtKullanıcıAdı.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(376, 353);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(192, 27);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(252, 292);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 2;
            label1.Text = "User name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(252, 349);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(453, 422);
            button1.Name = "button1";
            button1.Size = new Size(115, 45);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(217, 195);
            label3.Name = "label3";
            label3.Size = new Size(461, 41);
            label3.TabIndex = 5;
            label3.Text = "Welcome to Admin Login Panel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(127, 46);
            label4.Name = "label4";
            label4.Size = new Size(616, 60);
            label4.TabIndex = 6;
            label4.Text = "Library Management System";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            BackgroundImage = Properties.Resources.rfid_kutuphane_otomasyonu_kapak;
            ClientSize = new Size(858, 585);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanıcıAdı);
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullanıcıAdı;
        private TextBox txtSifre;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}