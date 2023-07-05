namespace Needleman_Wunsch_Algoritması
{
    partial class Form1
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
            this.btn_insert_data = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_match = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mismatch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_seq1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_seq2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_alignment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insert_data
            // 
            this.btn_insert_data.Location = new System.Drawing.Point(467, 363);
            this.btn_insert_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_insert_data.Name = "btn_insert_data";
            this.btn_insert_data.Size = new System.Drawing.Size(161, 69);
            this.btn_insert_data.TabIndex = 1;
            this.btn_insert_data.Text = "Tabloyu Doldur";
            this.btn_insert_data.UseVisualStyleBackColor = true;
            this.btn_insert_data.Click += new System.EventHandler(this.btn_insert_data_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 270);
            this.dataGridView1.TabIndex = 3;
            // 
            // txt_match
            // 
            this.txt_match.Location = new System.Drawing.Point(270, 346);
            this.txt_match.Name = "txt_match";
            this.txt_match.Size = new System.Drawing.Size(164, 30);
            this.txt_match.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Match Değeri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mismatch Değeri :";
            // 
            // txt_mismatch
            // 
            this.txt_mismatch.Location = new System.Drawing.Point(270, 382);
            this.txt_mismatch.Name = "txt_mismatch";
            this.txt_mismatch.Size = new System.Drawing.Size(164, 30);
            this.txt_mismatch.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gap Değeri :";
            // 
            // txt_gap
            // 
            this.txt_gap.Location = new System.Drawing.Point(270, 418);
            this.txt_gap.Name = "txt_gap";
            this.txt_gap.Size = new System.Drawing.Size(164, 30);
            this.txt_gap.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dizi 1: ";
            // 
            // txt_seq1
            // 
            this.txt_seq1.Location = new System.Drawing.Point(148, 12);
            this.txt_seq1.Name = "txt_seq1";
            this.txt_seq1.Size = new System.Drawing.Size(164, 30);
            this.txt_seq1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dizi 2:";
            // 
            // txt_seq2
            // 
            this.txt_seq2.Location = new System.Drawing.Point(467, 13);
            this.txt_seq2.Name = "txt_seq2";
            this.txt_seq2.Size = new System.Drawing.Size(164, 30);
            this.txt_seq2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Çalışma Süresi: ";
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(207, 521);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(17, 25);
            this.lbl_timer.TabIndex = 18;
            this.lbl_timer.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hizalama Puanı : ";
            // 
            // txt_alignment
            // 
            this.txt_alignment.Location = new System.Drawing.Point(270, 456);
            this.txt_alignment.Name = "txt_alignment";
            this.txt_alignment.Size = new System.Drawing.Size(164, 30);
            this.txt_alignment.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_alignment);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_seq2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_seq1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_gap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mismatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_match);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_insert_data);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_insert_data;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_match;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mismatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_gap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_seq1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_seq2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_alignment;
    }
}

