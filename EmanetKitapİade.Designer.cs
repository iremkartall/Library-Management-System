namespace VisualProje
{
    partial class EmanetKitapİade
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
            button1 = new Button();
            button2 = new Button();
            txtTcAra = new TextBox();
            txtBarkodAra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(220, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1026, 514);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(816, 629);
            button1.Name = "button1";
            button1.Size = new Size(147, 65);
            button1.TabIndex = 1;
            button1.Text = "Receive";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1009, 629);
            button2.Name = "button2";
            button2.Size = new Size(147, 65);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(729, 32);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(189, 27);
            txtTcAra.TabIndex = 3;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // txtBarkodAra
            // 
            txtBarkodAra.Location = new Point(1083, 32);
            txtBarkodAra.Name = "txtBarkodAra";
            txtBarkodAra.Size = new Size(163, 27);
            txtBarkodAra.TabIndex = 4;
            txtBarkodAra.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(640, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "Search TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(961, 35);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 6;
            label2.Text = "Search Barcode";
            // 
            // EmanetKitapİade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(1362, 706);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBarkodAra);
            Controls.Add(txtTcAra);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "EmanetKitapİade";
            Text = "EmanetKitapİade";
            Load += EmanetKitapİade_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox txtTcAra;
        private TextBox txtBarkodAra;
        private Label label1;
        private Label label2;
    }
}