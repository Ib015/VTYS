﻿namespace VTYS
{
    partial class arama
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
            label1 = new Label();
            txtKisiIDile = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(198, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(590, 426);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 40);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Kişi ID ile arama";
            // 
            // txtKisiIDile
            // 
            txtKisiIDile.Location = new Point(38, 63);
            txtKisiIDile.Name = "txtKisiIDile";
            txtKisiIDile.Size = new Size(125, 27);
            txtKisiIDile.TabIndex = 2;
            txtKisiIDile.TextChanged += txtKisiIDile_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(38, 96);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 3;
            button1.Text = "ARA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // arama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtKisiIDile);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "arama";
            Text = "Arama";
            Load += arama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtKisiIDile;
        private Button button1;
    }
}