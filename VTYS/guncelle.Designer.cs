namespace VTYS
{
    partial class guncelle
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
            label1 = new Label();
            txtGuncelle = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtNewisim = new TextBox();
            txtNewsoyisim = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(277, 20);
            label1.TabIndex = 0;
            label1.Text = "Güncellemek İstediğiniz Kişinin KişiNo'su";
            // 
            // txtGuncelle
            // 
            txtGuncelle.Location = new Point(76, 65);
            txtGuncelle.Name = "txtGuncelle";
            txtGuncelle.Size = new Size(125, 27);
            txtGuncelle.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(76, 294);
            button1.Name = "button1";
            button1.Size = new Size(125, 53);
            button1.TabIndex = 2;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(304, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(484, 426);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 132);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Yeni İsim";
            // 
            // txtNewisim
            // 
            txtNewisim.Location = new Point(123, 125);
            txtNewisim.Name = "txtNewisim";
            txtNewisim.Size = new Size(125, 27);
            txtNewisim.TabIndex = 5;
            // 
            // txtNewsoyisim
            // 
            txtNewsoyisim.Location = new Point(123, 182);
            txtNewsoyisim.Name = "txtNewsoyisim";
            txtNewsoyisim.Size = new Size(125, 27);
            txtNewsoyisim.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 185);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 8;
            label3.Text = "Yeni Soyisim";
            // 
            // guncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtNewsoyisim);
            Controls.Add(txtNewisim);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtGuncelle);
            Controls.Add(label1);
            Name = "guncelle";
            Text = "Güncelle";
            Load += guncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtGuncelle;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtNewisim;
        private TextBox txtNewsoyisim;
        private Label label3;
    }
}