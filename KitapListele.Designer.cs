namespace VisualProje
{
    partial class KitapListele
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
            label9 = new Label();
            txtBarkodAra = new TextBox();
            btnSil = new Button();
            dataGridView1 = new DataGridView();
            comboBookType = new ComboBox();
            txtPublishingHouse = new TextBox();
            label1 = new Label();
            txtExplanation = new TextBox();
            btnİptal = new Button();
            btnUyeEkle = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            txtBookName = new TextBox();
            txtStockNumber = new TextBox();
            txtPageNumber = new TextBox();
            txtShelfNo = new TextBox();
            txtAuthor = new TextBox();
            txtBarkod = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(672, 73);
            label9.Name = "label9";
            label9.Size = new Size(116, 20);
            label9.TabIndex = 44;
            label9.Text = "Search Barcode";
            // 
            // txtBarkodAra
            // 
            txtBarkodAra.Location = new Point(805, 69);
            txtBarkodAra.Name = "txtBarkodAra";
            txtBarkodAra.Size = new Size(207, 27);
            txtBarkodAra.TabIndex = 43;
            txtBarkodAra.TextChanged += txtBarkodAra_TextChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1301, 129);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(99, 31);
            btnSil.TabIndex = 42;
            btnSil.Text = "Delete";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(465, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(830, 492);
            dataGridView1.TabIndex = 41;
            // 
            // comboBookType
            // 
            comboBookType.FormattingEnabled = true;
            comboBookType.Items.AddRange(new object[] { "Fiction", "Non-fiction", "Mystery", "Thriller", "Romance", "Fantasy", "Science Fiction", "Historical Fiction", "Biography", "Autobiography", "Memoir", "Poetry", "Drama", "Horror", "Adventure", "Self-help", "Travel", "Children's Books", "Young Adult", "Graphic ", "Novels", "Cookbooks", "Reference", "Spirituality", "Science", "Philosophy", "Art", "History", "Business", "Psychology" });
            comboBookType.Location = new Point(175, 353);
            comboBookType.Name = "comboBookType";
            comboBookType.Size = new Size(227, 28);
            comboBookType.TabIndex = 64;
            // 
            // txtPublishingHouse
            // 
            txtPublishingHouse.Location = new Point(174, 261);
            txtPublishingHouse.Name = "txtPublishingHouse";
            txtPublishingHouse.Size = new Size(227, 27);
            txtPublishingHouse.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 508);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 62;
            label1.Text = "Explanation";
            // 
            // txtExplanation
            // 
            txtExplanation.Location = new Point(175, 505);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.Size = new Size(227, 65);
            txtExplanation.TabIndex = 61;
            txtExplanation.TextAlign = HorizontalAlignment.Center;
            // 
            // btnİptal
            // 
            btnİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnİptal.Location = new Point(301, 588);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(101, 37);
            btnİptal.TabIndex = 60;
            btnİptal.Text = "CANCEL";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUyeEkle.Location = new Point(174, 588);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(94, 37);
            btnUyeEkle.TabIndex = 59;
            btnUyeEkle.Text = "UPDATE";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(90, 455);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 58;
            label8.Text = "Shelf No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(31, 407);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 57;
            label7.Text = "Number of Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 311);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 56;
            label6.Text = "Number of Pages";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 261);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 55;
            label5.Text = "Publishing House";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(101, 215);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 54;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(78, 353);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 53;
            label3.Text = "Book Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(71, 172);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 52;
            label2.Text = "Book name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(34, 131);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 51;
            label10.Text = "Barcode Number";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(175, 172);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(226, 27);
            txtBookName.TabIndex = 50;
            // 
            // txtStockNumber
            // 
            txtStockNumber.Location = new Point(175, 407);
            txtStockNumber.Name = "txtStockNumber";
            txtStockNumber.Size = new Size(226, 27);
            txtStockNumber.TabIndex = 49;
            // 
            // txtPageNumber
            // 
            txtPageNumber.Location = new Point(175, 308);
            txtPageNumber.Name = "txtPageNumber";
            txtPageNumber.Size = new Size(227, 27);
            txtPageNumber.TabIndex = 48;
            // 
            // txtShelfNo
            // 
            txtShelfNo.Location = new Point(175, 452);
            txtShelfNo.Name = "txtShelfNo";
            txtShelfNo.Size = new Size(227, 27);
            txtShelfNo.TabIndex = 47;
            txtShelfNo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(175, 215);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(227, 27);
            txtAuthor.TabIndex = 46;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(174, 128);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(227, 27);
            txtBarkod.TabIndex = 45;
            txtBarkod.TextChanged += txtBarkod_TextChanged;
            // 
            // KitapListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(1407, 715);
            Controls.Add(comboBookType);
            Controls.Add(txtPublishingHouse);
            Controls.Add(label1);
            Controls.Add(txtExplanation);
            Controls.Add(btnİptal);
            Controls.Add(btnUyeEkle);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(txtBookName);
            Controls.Add(txtStockNumber);
            Controls.Add(txtPageNumber);
            Controls.Add(txtShelfNo);
            Controls.Add(txtAuthor);
            Controls.Add(txtBarkod);
            Controls.Add(label9);
            Controls.Add(txtBarkodAra);
            Controls.Add(btnSil);
            Controls.Add(dataGridView1);
            Name = "KitapListele";
            Text = "Kitap Listeleme İşlemleri";
            Load += KitapListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txtBarkodAra;
        private Button btnSil;
        private DataGridView dataGridView1;
        private ComboBox comboBookType;
        private TextBox txtPublishingHouse;
        private Label label1;
        private TextBox txtExplanation;
        private Button btnİptal;
        private Button btnUyeEkle;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private TextBox txtBookName;
        private TextBox txtStockNumber;
        private TextBox txtPageNumber;
        private TextBox txtShelfNo;
        private TextBox txtAuthor;
        private TextBox txtBarkod;
    }
}