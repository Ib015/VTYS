namespace VTYS
{
    partial class ekleme
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txttcno = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtKisiTuru = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txtTelNo = new TextBox();
            txtemail = new TextBox();
            txtadres = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtkisiNo = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "TCNo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 59);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 102);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 144);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Kişi Türü:";
            // 
            // txttcno
            // 
            txttcno.Location = new Point(97, 12);
            txttcno.Name = "txttcno";
            txttcno.Size = new Size(125, 27);
            txttcno.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(97, 56);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(97, 99);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtKisiTuru
            // 
            txtKisiTuru.Location = new Point(97, 141);
            txtKisiTuru.Name = "txtKisiTuru";
            txtKisiTuru.Size = new Size(125, 27);
            txtKisiTuru.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(97, 378);
            button1.Name = "button1";
            button1.Size = new Size(125, 60);
            button1.TabIndex = 8;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(228, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(691, 426);
            dataGridView1.TabIndex = 9;
            // 
            // txtTelNo
            // 
            txtTelNo.Location = new Point(97, 225);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(125, 27);
            txtTelNo.TabIndex = 11;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(97, 258);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(125, 27);
            txtemail.TabIndex = 12;
            // 
            // txtadres
            // 
            txtadres.Location = new Point(97, 291);
            txtadres.Name = "txtadres";
            txtadres.Size = new Size(125, 27);
            txtadres.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 228);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 14;
            label6.Text = "Tel No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 261);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 15;
            label7.Text = "email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 294);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 16;
            label8.Text = "adres";
            // 
            // txtkisiNo
            // 
            txtkisiNo.Location = new Point(97, 324);
            txtkisiNo.Name = "txtkisiNo";
            txtkisiNo.Size = new Size(125, 27);
            txtkisiNo.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Location = new Point(35, 327);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 18;
            label9.Text = "Kişi No";
            // 
            // ekleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 450);
            Controls.Add(label9);
            Controls.Add(txtkisiNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtadres);
            Controls.Add(txtemail);
            Controls.Add(txtTelNo);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtKisiTuru);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txttcno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ekleme";
            Text = "Ekleme";
            Load += ekleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTCNo;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtKisiTuru;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txtTelNo;
        private TextBox txtemail;
        private TextBox txtadres;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtkisiNo;
        private Label label9;
        private TextBox txttcno;
    }
}