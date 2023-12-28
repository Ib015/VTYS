namespace VTYS
{
    partial class silme
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
            txtKisiNoSil = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 20);
            label1.TabIndex = 0;
            label1.Text = "Silmek İstediğiniz Kişinin KişiNo'sunu giriniz";
            // 
            // txtKisiNoSil
            // 
            txtKisiNoSil.Location = new Point(87, 47);
            txtKisiNoSil.Name = "txtKisiNoSil";
            txtKisiNoSil.Size = new Size(125, 27);
            txtKisiNoSil.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(65, 96);
            button1.Name = "button1";
            button1.Size = new Size(183, 80);
            button1.TabIndex = 2;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(315, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(473, 426);
            dataGridView1.TabIndex = 3;
            // 
            // silme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtKisiNoSil);
            Controls.Add(label1);
            Name = "silme";
            Text = "Silme";
            Load += silme_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKisiNoSil;
        private Button button1;
        private DataGridView dataGridView1;
    }
}