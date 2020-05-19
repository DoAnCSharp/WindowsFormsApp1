namespace WindowsFormsApp1
{
    partial class TongQuat
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
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBanHang
            // 
            this.btnBanHang.Location = new System.Drawing.Point(50, 36);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(75, 23);
            this.btnBanHang.TabIndex = 0;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Location = new System.Drawing.Point(173, 36);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(75, 23);
            this.btnHangHoa.TabIndex = 1;
            this.btnHangHoa.Text = "Hàng Hóa";
            this.btnHangHoa.UseVisualStyleBackColor = true;
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(304, 36);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnHoaDon.TabIndex = 2;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(415, 36);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Location = new System.Drawing.Point(526, 36);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Size = new System.Drawing.Size(75, 23);
            this.btnNhaCungCap.TabIndex = 4;
            this.btnNhaCungCap.Text = "Nhà cung cấp";
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(111, 180);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.button1_Click);
            // 
            // TongQuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnNhaCungCap);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnHangHoa);
            this.Controls.Add(this.btnBanHang);
            this.Name = "TongQuat";
            this.Text = "TongQuat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhaCungCap;
        private System.Windows.Forms.Button btnNhanVien;
    }
}