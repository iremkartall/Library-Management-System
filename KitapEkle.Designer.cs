namespace VisualProje
{
    partial class KitapEkle
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
            btnİptal = new Button();
            btnUyeEkle = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBookName = new TextBox();
            txtStockNumber = new TextBox();
            txtPageNumber = new TextBox();
            txtShelfNo = new TextBox();
            txtAuthor = new TextBox();
            txtBarkod = new TextBox();
            txtExplanation = new TextBox();
            label9 = new Label();
            txtPublishingHouse = new TextBox();
            comboBookType = new ComboBox();
            SuspendLayout();
            // 
            // btnİptal
            // 
            btnİptal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnİptal.Location = new Point(351, 524);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(100, 38);
            btnİptal.TabIndex = 37;
            btnİptal.Text = "Cancel";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUyeEkle.Location = new Point(224, 524);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(94, 38);
            btnUyeEkle.TabIndex = 36;
            btnUyeEkle.Text = "Add";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(140, 391);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 34;
            label8.Text = "Shelf No";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(81, 343);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 33;
            label7.Text = "Number of Stock";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(81, 247);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 32;
            label6.Text = "Number of Pages";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(79, 198);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 31;
            label5.Text = "Publishing House";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(150, 151);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 30;
            label4.Text = "Author";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(128, 289);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 29;
            label3.Text = "Book Type";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 108);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 28;
            label2.Text = "Book name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 67);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 27;
            label1.Text = "Barcode Number";
            label1.Click += label1_Click;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(225, 108);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(226, 27);
            txtBookName.TabIndex = 26;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // txtStockNumber
            // 
            txtStockNumber.Location = new Point(225, 343);
            txtStockNumber.Name = "txtStockNumber";
            txtStockNumber.Size = new Size(226, 27);
            txtStockNumber.TabIndex = 24;
            txtStockNumber.TextChanged += txtStockNumber_TextChanged;
            // 
            // txtPageNumber
            // 
            txtPageNumber.Location = new Point(225, 244);
            txtPageNumber.Name = "txtPageNumber";
            txtPageNumber.Size = new Size(227, 27);
            txtPageNumber.TabIndex = 23;
            txtPageNumber.TextChanged += txtPageNumber_TextChanged;
            // 
            // txtShelfNo
            // 
            txtShelfNo.Location = new Point(225, 388);
            txtShelfNo.Name = "txtShelfNo";
            txtShelfNo.Size = new Size(227, 27);
            txtShelfNo.TabIndex = 22;
            txtShelfNo.TextAlign = HorizontalAlignment.Center;
            txtShelfNo.TextChanged += txtShelfNo_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(225, 151);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(227, 27);
            txtAuthor.TabIndex = 21;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(224, 64);
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(227, 27);
            txtBarkod.TabIndex = 20;
            txtBarkod.TextChanged += txtBarkod_TextChanged;
            // 
            // txtExplanation
            // 
            txtExplanation.Location = new Point(225, 441);
            txtExplanation.Multiline = true;
            txtExplanation.Name = "txtExplanation";
            txtExplanation.Size = new Size(227, 66);
            txtExplanation.TabIndex = 38;
            txtExplanation.TextAlign = HorizontalAlignment.Center;
            txtExplanation.TextChanged += txtExplanation_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(118, 444);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 39;
            label9.Text = "Explanation";
            label9.Click += label9_Click;
            // 
            // txtPublishingHouse
            // 
            txtPublishingHouse.Location = new Point(224, 198);
            txtPublishingHouse.Name = "txtPublishingHouse";
            txtPublishingHouse.Size = new Size(227, 27);
            txtPublishingHouse.TabIndex = 40;
            txtPublishingHouse.TextChanged += tctPublishingHouse_TextChanged;
            // 
            // comboBookType
            // 
            comboBookType.FormattingEnabled = true;
            comboBookType.Items.AddRange(new object[] { "Fiction", "", "Non-fiction", "", "Mystery", "", "Thriller", "", "Romance", "", "Fantasy", "", "Science Fiction", "", "Historical Fiction", "", "Biography", "", "Autobiography", "", "Memoir", "", "Poetry", "", "Drama", "", "Horror", "", "Adventure", "", "Self-help", "", "Travel", "", "Children's Books", "", "Young Adult", "", "Graphic ", "Novels", "", "Cookbooks", "", "Reference", "", "Spirituality", "", "Science", "", "Philosophy", "", "Art", "", "History", "", "Business", "", "Psychology" });
            comboBookType.Location = new Point(225, 289);
            comboBookType.Name = "comboBookType";
            comboBookType.Size = new Size(227, 28);
            comboBookType.TabIndex = 41;
            comboBookType.SelectedIndexChanged += comboBookType_SelectedIndexChanged;
            // 
            // KitapEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(575, 602);
            Controls.Add(comboBookType);
            Controls.Add(txtPublishingHouse);
            Controls.Add(label9);
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
            Controls.Add(label1);
            Controls.Add(txtBookName);
            Controls.Add(txtStockNumber);
            Controls.Add(txtPageNumber);
            Controls.Add(txtShelfNo);
            Controls.Add(txtAuthor);
            Controls.Add(txtBarkod);
            Name = "KitapEkle";
            Text = "KitapEkle";
            Load += KitapEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnİptal;
        private Button btnUyeEkle;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBookName;
        private TextBox txtStockNumber;
        private TextBox txtPageNumber;
        private TextBox txtShelfNo;
        private TextBox txtAuthor;
        private TextBox txtBarkod;
        private TextBox txtExplanation;
        private Label label9;
        private TextBox txtPublishingHouse;
        private ComboBox comboBookType;
    }
}