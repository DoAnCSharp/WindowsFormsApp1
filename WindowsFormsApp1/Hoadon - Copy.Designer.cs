﻿namespace WindowsFormsApp1
{
    partial class Hoadonnhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExportHoaDon = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThemKenhBan = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbl_Bill = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbl_Bill);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 653);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnExportHoaDon);
            this.panel6.Controls.Add(this.btnThemHoaDon);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(15, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(761, 38);
            this.panel6.TabIndex = 13;
            // 
            // btnExportHoaDon
            // 
            this.btnExportHoaDon.Location = new System.Drawing.Point(673, 9);
            this.btnExportHoaDon.Name = "btnExportHoaDon";
            this.btnExportHoaDon.Size = new System.Drawing.Size(85, 23);
            this.btnExportHoaDon.TabIndex = 4;
            this.btnExportHoaDon.Text = "Excel";
            this.btnExportHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Location = new System.Drawing.Point(571, 9);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(87, 23);
            this.btnThemHoaDon.TabIndex = 3;
            this.btnThemHoaDon.Text = "Thêm mới";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(15, 486);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 100);
            this.panel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThemKenhBan);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(15, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 100);
            this.panel4.TabIndex = 10;
            // 
            // btnThemKenhBan
            // 
            this.btnThemKenhBan.Location = new System.Drawing.Point(102, 13);
            this.btnThemKenhBan.Name = "btnThemKenhBan";
            this.btnThemKenhBan.Size = new System.Drawing.Size(75, 23);
            this.btnThemKenhBan.TabIndex = 11;
            this.btnThemKenhBan.Text = "+";
            this.btnThemKenhBan.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kênh bán";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(15, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 122);
            this.panel3.TabIndex = 9;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(22, 82);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 20);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Đã Hủy";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(22, 47);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 20);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Hoàn Thành";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng Thái";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(15, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 127);
            this.panel2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(22, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // tbl_Bill
            // 
            this.tbl_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Bill.Location = new System.Drawing.Point(213, 63);
            this.tbl_Bill.Name = "tbl_Bill";
            this.tbl_Bill.Size = new System.Drawing.Size(560, 281);
            this.tbl_Bill.TabIndex = 14;
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 722);
            this.Controls.Add(this.panel1);
            this.Name = "Hoadon";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemKenhBan;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExportHoaDon;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView tbl_Bill;
    }
}