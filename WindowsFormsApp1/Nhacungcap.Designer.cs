namespace WindowsFormsApp1
{
    partial class Nhacungcap
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
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemNhomNhaCungCap = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnExportNhaCungCap = new System.Windows.Forms.Button();
            this.btnThemNhaCungCap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbl_Sup = new System.Windows.Forms.DataGridView();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Sup)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(15, 121);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(106, 17);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Dừng Hoạt Động";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(15, 86);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(106, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Đang Hoạt Động";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(15, 52);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(57, 17);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Tất Cả";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.radioButton7);
            this.panel7.Controls.Add(this.radioButton8);
            this.panel7.Controls.Add(this.radioButton9);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(22, 219);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(161, 155);
            this.panel7.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhóm Nhà Cung Cấp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemNhomNhaCungCap);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(22, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 98);
            this.panel2.TabIndex = 24;
            // 
            // btnThemNhomNhaCungCap
            // 
            this.btnThemNhomNhaCungCap.Location = new System.Drawing.Point(126, 12);
            this.btnThemNhomNhaCungCap.Name = "btnThemNhomNhaCungCap";
            this.btnThemNhomNhaCungCap.Size = new System.Drawing.Size(24, 23);
            this.btnThemNhomNhaCungCap.TabIndex = 2;
            this.btnThemNhomNhaCungCap.Text = "+";
            this.btnThemNhomNhaCungCap.UseVisualStyleBackColor = true;
            this.btnThemNhomNhaCungCap.Click += new System.EventHandler(this.btnThemNhomNhaCungCap_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // btnExportNhaCungCap
            // 
            this.btnExportNhaCungCap.Location = new System.Drawing.Point(667, 9);
            this.btnExportNhaCungCap.Name = "btnExportNhaCungCap";
            this.btnExportNhaCungCap.Size = new System.Drawing.Size(85, 23);
            this.btnExportNhaCungCap.TabIndex = 4;
            this.btnExportNhaCungCap.Text = "Excel";
            this.btnExportNhaCungCap.UseVisualStyleBackColor = true;
            // 
            // btnThemNhaCungCap
            // 
            this.btnThemNhaCungCap.Location = new System.Drawing.Point(571, 9);
            this.btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            this.btnThemNhaCungCap.Size = new System.Drawing.Size(87, 23);
            this.btnThemNhaCungCap.TabIndex = 3;
            this.btnThemNhaCungCap.Text = "Thêm";
            this.btnThemNhaCungCap.UseVisualStyleBackColor = true;
            this.btnThemNhaCungCap.Click += new System.EventHandler(this.btnThemNhaCungCap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà Cung Cấp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnExportNhaCungCap);
            this.panel6.Controls.Add(this.btnThemNhaCungCap);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(22, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(761, 38);
            this.panel6.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tbl_Sup
            // 
            this.tbl_Sup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Sup.Location = new System.Drawing.Point(220, 85);
            this.tbl_Sup.Name = "tbl_Sup";
            this.tbl_Sup.Size = new System.Drawing.Size(563, 289);
            this.tbl_Sup.TabIndex = 28;
            // 
            // Nhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.tbl_Sup);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Name = "Nhacungcap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Nhacungcap_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Sup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExportNhaCungCap;
        private System.Windows.Forms.Button btnThemNhaCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnThemNhomNhaCungCap;
        public System.Windows.Forms.DataGridView tbl_Sup;
    }
}