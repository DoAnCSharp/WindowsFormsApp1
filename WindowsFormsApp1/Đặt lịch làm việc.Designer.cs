namespace WindowsFormsApp1
{
    partial class frmDatlich
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBatdau = new System.Windows.Forms.DateTimePicker();
            this.dtKetthuc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCalv = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLư = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.ckbLaplai = new System.Windows.Forms.CheckBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đặt lịch làm việc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày bắt đầu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày kết thúc :";
            // 
            // dtBatdau
            // 
            this.dtBatdau.Location = new System.Drawing.Point(133, 147);
            this.dtBatdau.Margin = new System.Windows.Forms.Padding(2);
            this.dtBatdau.Name = "dtBatdau";
            this.dtBatdau.Size = new System.Drawing.Size(151, 20);
            this.dtBatdau.TabIndex = 7;
            // 
            // dtKetthuc
            // 
            this.dtKetthuc.Location = new System.Drawing.Point(133, 196);
            this.dtKetthuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtKetthuc.Name = "dtKetthuc";
            this.dtKetthuc.Size = new System.Drawing.Size(151, 20);
            this.dtKetthuc.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ca làm việc :";
            // 
            // cbbCalv
            // 
            this.cbbCalv.FormattingEnabled = true;
            this.cbbCalv.Location = new System.Drawing.Point(430, 146);
            this.cbbCalv.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCalv.Name = "cbbCalv";
            this.cbbCalv.Size = new System.Drawing.Size(151, 21);
            this.cbbCalv.TabIndex = 10;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.checkedListBox1.Location = new System.Drawing.Point(107, 246);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(151, 94);
            this.checkedListBox1.TabIndex = 11;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phòng ban :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 13;
            // 
            // btnLư
            // 
            this.btnLư.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLư.Location = new System.Drawing.Point(370, 275);
            this.btnLư.Margin = new System.Windows.Forms.Padding(2);
            this.btnLư.Name = "btnLư";
            this.btnLư.Size = new System.Drawing.Size(73, 24);
            this.btnLư.TabIndex = 14;
            this.btnLư.Text = "Lưu";
            this.btnLư.UseVisualStyleBackColor = true;
            this.btnLư.Click += new System.EventHandler(this.btnLư_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.Location = new System.Drawing.Point(508, 275);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(73, 24);
            this.btnBoqua.TabIndex = 15;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.button2_Click);
            // 
            // ckbLaplai
            // 
            this.ckbLaplai.AutoSize = true;
            this.ckbLaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLaplai.Location = new System.Drawing.Point(320, 196);
            this.ckbLaplai.Margin = new System.Windows.Forms.Padding(2);
            this.ckbLaplai.Name = "ckbLaplai";
            this.ckbLaplai.Size = new System.Drawing.Size(74, 19);
            this.ckbLaplai.TabIndex = 16;
            this.ckbLaplai.Text = "Lặp Lại";
            this.ckbLaplai.UseVisualStyleBackColor = true;
            this.ckbLaplai.CheckedChanged += new System.EventHandler(this.ckbLaplai_CheckedChanged);
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Location = new System.Drawing.Point(433, 60);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(67, 13);
            this.lblPhongBan.TabIndex = 17;
            this.lblPhongBan.Text = "lblPhongBan";
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(433, 110);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(55, 13);
            this.lblChucVu.TabIndex = 19;
            this.lblChucVu.Text = "lblChucVu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(317, 107);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Chức vụ :";
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Location = new System.Drawing.Point(155, 110);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(50, 13);
            this.lblTenNv.TabIndex = 21;
            this.lblTenNv.Text = "lblTenNv";
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.Location = new System.Drawing.Point(155, 63);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(46, 13);
            this.lblMaNv.TabIndex = 20;
            this.lblMaNv.Text = "lblMaNv";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 241);
            this.dataGridView1.TabIndex = 22;
            // 
            // frmDatlich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 627);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTenNv);
            this.Controls.Add(this.lblMaNv);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPhongBan);
            this.Controls.Add(this.ckbLaplai);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLư);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.cbbCalv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtKetthuc);
            this.Controls.Add(this.dtBatdau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDatlich";
            this.Text = "Đặt lịch làm việc";
            this.Load += new System.EventHandler(this.frmDatlich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBatdau;
        private System.Windows.Forms.DateTimePicker dtKetthuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCalv;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLư;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.CheckBox ckbLaplai;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}