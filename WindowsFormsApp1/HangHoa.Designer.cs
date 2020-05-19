namespace WindowsFormsApp1
{
    partial class Hanghoa
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExportHangHoa = new System.Windows.Forms.Button();
            this.btnImportHangHoa = new System.Windows.Forms.Button();
            this.btnThemHangHoa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemNhomHang = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewHangHoa = new System.Windows.Forms.ListView();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnExportHangHoa);
            this.panel6.Controls.Add(this.btnImportHangHoa);
            this.panel6.Controls.Add(this.btnThemHangHoa);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(783, 38);
            this.panel6.TabIndex = 14;
            // 
            // btnExportHangHoa
            // 
            this.btnExportHangHoa.Location = new System.Drawing.Point(688, 9);
            this.btnExportHangHoa.Name = "btnExportHangHoa";
            this.btnExportHangHoa.Size = new System.Drawing.Size(88, 23);
            this.btnExportHangHoa.TabIndex = 15;
            this.btnExportHangHoa.Text = "Excel";
            this.btnExportHangHoa.UseVisualStyleBackColor = true;
            this.btnExportHangHoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImportHangHoa
            // 
            this.btnImportHangHoa.Location = new System.Drawing.Point(585, 9);
            this.btnImportHangHoa.Name = "btnImportHangHoa";
            this.btnImportHangHoa.Size = new System.Drawing.Size(87, 23);
            this.btnImportHangHoa.TabIndex = 4;
            this.btnImportHangHoa.Text = "Import";
            this.btnImportHangHoa.UseVisualStyleBackColor = true;
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.Location = new System.Drawing.Point(491, 9);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(75, 23);
            this.btnThemHangHoa.TabIndex = 3;
            this.btnThemHangHoa.Text = "Thêm mới";
            this.btnThemHangHoa.UseVisualStyleBackColor = true;
            this.btnThemHangHoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hàng Hóa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemNhomHang);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 326);
            this.panel1.TabIndex = 15;
            // 
            // btnThemNhomHang
            // 
            this.btnThemNhomHang.Location = new System.Drawing.Point(108, 12);
            this.btnThemNhomHang.Name = "btnThemNhomHang";
            this.btnThemNhomHang.Size = new System.Drawing.Size(38, 23);
            this.btnThemNhomHang.TabIndex = 2;
            this.btnThemNhomHang.Text = "+";
            this.btnThemNhomHang.UseVisualStyleBackColor = true;
            this.btnThemNhomHang.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(134, 244);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm Hàng";
            // 
            // listViewHangHoa
            // 
            this.listViewHangHoa.HideSelection = false;
            this.listViewHangHoa.Location = new System.Drawing.Point(204, 75);
            this.listViewHangHoa.Name = "listViewHangHoa";
            this.listViewHangHoa.Size = new System.Drawing.Size(567, 326);
            this.listViewHangHoa.TabIndex = 16;
            this.listViewHangHoa.UseCompatibleStateImageBehavior = false;
            // 
            // Hanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewHangHoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Name = "Hanghoa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hanghoa_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnImportHangHoa;
        private System.Windows.Forms.Button btnThemHangHoa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportHangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemNhomHang;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewHangHoa;
    }
}