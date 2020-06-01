namespace WindowsFormsApp1
{
    partial class Banhang
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cboChannel = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.anhProduct = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.lblBill_Id = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cboAn = new System.Windows.Forms.ComboBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddNhanVien = new System.Windows.Forms.Button();
            this.btnAddKhachHang = new System.Windows.Forms.Button();
            this.bangChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.txtDiscount = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTienThua = new System.Windows.Forms.Label();
            this.lblKhachCanTra = new System.Windows.Forms.Label();
            this.lblGiamThanhToan = new System.Windows.Forms.Label();
            this.lblTongThanhToan = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtKhachThanhToan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.giảm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TabControl();
            this.lblTonKho = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tb.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(12, 30);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(311, 20);
            this.txtFind.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(624, 70);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(134, 21);
            this.cboNhanVien.TabIndex = 4;
            this.cboNhanVien.TextChanged += new System.EventHandler(this.cboNhanVien_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(741, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nợ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Điểm :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(586, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(686, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(101, 20);
            this.textBox5.TabIndex = 10;
            // 
            // cboChannel
            // 
            this.cboChannel.AutoCompleteCustomSource.AddRange(new string[] {
            "Trực tiếp",
            "Online"});
            this.cboChannel.FormattingEnabled = true;
            this.cboChannel.Items.AddRange(new object[] {
            "Trực tiếp",
            "Online"});
            this.cboChannel.Location = new System.Drawing.Point(556, 161);
            this.cboChannel.Name = "cboChannel";
            this.cboChannel.Size = new System.Drawing.Size(86, 21);
            this.cboChannel.TabIndex = 11;
            this.cboChannel.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(698, 165);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Giao hàng";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // anhProduct
            // 
            this.anhProduct.Location = new System.Drawing.Point(345, 396);
            this.anhProduct.Name = "anhProduct";
            this.anhProduct.Size = new System.Drawing.Size(184, 155);
            this.anhProduct.TabIndex = 17;
            this.anhProduct.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Giá bán";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tên hàng";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(72, 409);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(41, 13);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "lblPrice";
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(75, 369);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(105, 21);
            this.cboMaHang.TabIndex = 25;
            this.cboMaHang.ValueMemberChanged += new System.EventHandler(this.cboMaHang_ValueMemberChanged);
            this.cboMaHang.TextChanged += new System.EventHandler(this.cboMaHang_TextChanged);
            // 
            // cboTenHang
            // 
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Location = new System.Drawing.Point(262, 367);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(267, 21);
            this.cboTenHang.TabIndex = 26;
            this.cboTenHang.ValueMemberChanged += new System.EventHandler(this.cboTenHang_ValueMemberChanged);
            this.cboTenHang.TextChanged += new System.EventHandler(this.cboTenHang_TextChanged);
            // 
            // lblBill_Id
            // 
            this.lblBill_Id.AutoSize = true;
            this.lblBill_Id.Location = new System.Drawing.Point(51, 9);
            this.lblBill_Id.Name = "lblBill_Id";
            this.lblBill_Id.Size = new System.Drawing.Size(35, 13);
            this.lblBill_Id.TabIndex = 27;
            this.lblBill_Id.Text = "label8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(262, 450);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(46, 20);
            this.txtSoLuong.TabIndex = 29;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 517);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(121, 517);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(227, 517);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 452);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Giảm Giá (%)";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // cboAn
            // 
            this.cboAn.FormattingEnabled = true;
            this.cboAn.Location = new System.Drawing.Point(545, 30);
            this.cboAn.Name = "cboAn";
            this.cboAn.Size = new System.Drawing.Size(105, 21);
            this.cboAn.TabIndex = 35;
            this.cboAn.Visible = false;
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(624, 103);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(134, 21);
            this.cboKhachHang.TabIndex = 36;
            this.cboKhachHang.TextChanged += new System.EventHandler(this.cboKhachHang_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(553, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Khách hàng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(553, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Nhân viên";
            // 
            // btnAddNhanVien
            // 
            this.btnAddNhanVien.Location = new System.Drawing.Point(766, 70);
            this.btnAddNhanVien.Name = "btnAddNhanVien";
            this.btnAddNhanVien.Size = new System.Drawing.Size(48, 23);
            this.btnAddNhanVien.TabIndex = 39;
            this.btnAddNhanVien.Text = "Thêm";
            this.btnAddNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnAddKhachHang
            // 
            this.btnAddKhachHang.Location = new System.Drawing.Point(766, 101);
            this.btnAddKhachHang.Name = "btnAddKhachHang";
            this.btnAddKhachHang.Size = new System.Drawing.Size(48, 23);
            this.btnAddKhachHang.TabIndex = 40;
            this.btnAddKhachHang.Text = "Thêm";
            this.btnAddKhachHang.UseVisualStyleBackColor = true;
            // 
            // bangChiTietHoaDon
            // 
            this.bangChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangChiTietHoaDon.Location = new System.Drawing.Point(22, 70);
            this.bangChiTietHoaDon.Name = "bangChiTietHoaDon";
            this.bangChiTietHoaDon.Size = new System.Drawing.Size(507, 281);
            this.bangChiTietHoaDon.TabIndex = 41;
            this.bangChiTietHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangChiTietHoaDon_CellContentClick);
            this.bangChiTietHoaDon.Click += new System.EventHandler(this.bangChiTietHoaDon_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(95, 450);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(46, 20);
            this.txtDiscount.TabIndex = 42;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(261, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bổ sung";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTienThua);
            this.tabPage1.Controls.Add(this.lblKhachCanTra);
            this.tabPage1.Controls.Add(this.lblGiamThanhToan);
            this.tabPage1.Controls.Add(this.lblTongThanhToan);
            this.tabPage1.Controls.Add(this.btnThanhToan);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtGhiChu);
            this.tabPage1.Controls.Add(this.txtKhachThanhToan);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.giảm);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(261, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTienThua
            // 
            this.lblTienThua.AutoSize = true;
            this.lblTienThua.Location = new System.Drawing.Point(139, 150);
            this.lblTienThua.Name = "lblTienThua";
            this.lblTienThua.Size = new System.Drawing.Size(13, 13);
            this.lblTienThua.TabIndex = 18;
            this.lblTienThua.Text = "0";
            // 
            // lblKhachCanTra
            // 
            this.lblKhachCanTra.AutoSize = true;
            this.lblKhachCanTra.Location = new System.Drawing.Point(139, 73);
            this.lblKhachCanTra.Name = "lblKhachCanTra";
            this.lblKhachCanTra.Size = new System.Drawing.Size(13, 13);
            this.lblKhachCanTra.TabIndex = 17;
            this.lblKhachCanTra.Text = "0";
            // 
            // lblGiamThanhToan
            // 
            this.lblGiamThanhToan.AutoSize = true;
            this.lblGiamThanhToan.Location = new System.Drawing.Point(139, 35);
            this.lblGiamThanhToan.Name = "lblGiamThanhToan";
            this.lblGiamThanhToan.Size = new System.Drawing.Size(13, 13);
            this.lblGiamThanhToan.TabIndex = 16;
            this.lblGiamThanhToan.Text = "0";
            // 
            // lblTongThanhToan
            // 
            this.lblTongThanhToan.AutoSize = true;
            this.lblTongThanhToan.Location = new System.Drawing.Point(139, 12);
            this.lblTongThanhToan.Name = "lblTongThanhToan";
            this.lblTongThanhToan.Size = new System.Drawing.Size(13, 13);
            this.lblTongThanhToan.TabIndex = 15;
            this.lblTongThanhToan.Text = "0";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(152, 287);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(106, 23);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(12, 184);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(243, 97);
            this.txtGhiChu.TabIndex = 12;
            this.txtGhiChu.Enter += new System.EventHandler(this.txtGhiChu_Enter);
            this.txtGhiChu.Leave += new System.EventHandler(this.txtGhiChu_Leave);
            // 
            // txtKhachThanhToan
            // 
            this.txtKhachThanhToan.Location = new System.Drawing.Point(142, 110);
            this.txtKhachThanhToan.Name = "txtKhachThanhToan";
            this.txtKhachThanhToan.Size = new System.Drawing.Size(100, 20);
            this.txtKhachThanhToan.TabIndex = 10;
            this.txtKhachThanhToan.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            this.txtKhachThanhToan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhachThanhToan_KeyPress);
            this.txtKhachThanhToan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKhachThanhToan_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tiền thừa ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khách thanh toán ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Khách cần trả ";
            // 
            // giảm
            // 
            this.giảm.AutoSize = true;
            this.giảm.Location = new System.Drawing.Point(6, 35);
            this.giảm.Name = "giảm";
            this.giảm.Size = new System.Drawing.Size(50, 13);
            this.giảm.TabIndex = 1;
            this.giảm.Text = "Giảm Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng ";
            // 
            // tb
            // 
            this.tb.Controls.Add(this.tabPage1);
            this.tb.Controls.Add(this.tabPage2);
            this.tb.Location = new System.Drawing.Point(552, 203);
            this.tb.Name = "tb";
            this.tb.SelectedIndex = 0;
            this.tb.Size = new System.Drawing.Size(269, 348);
            this.tb.TabIndex = 14;
            // 
            // lblTonKho
            // 
            this.lblTonKho.AutoSize = true;
            this.lblTonKho.Location = new System.Drawing.Point(259, 409);
            this.lblTonKho.Name = "lblTonKho";
            this.lblTonKho.Size = new System.Drawing.Size(35, 13);
            this.lblTonKho.TabIndex = 44;
            this.lblTonKho.Text = "label4";
            this.lblTonKho.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Tồn kho";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 578);
            this.Controls.Add(this.lblTonKho);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.bangChiTietHoaDon);
            this.Controls.Add(this.btnAddKhachHang);
            this.Controls.Add(this.btnAddNhanVien);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.cboAn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBill_Id);
            this.Controls.Add(this.cboTenHang);
            this.Controls.Add(this.cboMaHang);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.anhProduct);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cboChannel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Banhang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Banhang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox anhProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.Label lblBill_Id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboAn;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddNhanVien;
        private System.Windows.Forms.Button btnAddKhachHang;
        private System.Windows.Forms.DataGridView bangChiTietHoaDon;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private System.Windows.Forms.ComboBox cboChannel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTienThua;
        private System.Windows.Forms.Label lblKhachCanTra;
        private System.Windows.Forms.Label lblGiamThanhToan;
        private System.Windows.Forms.Label lblTongThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtKhachThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label giảm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tb;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.Label label8;
    }
}

