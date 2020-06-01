using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Nhaphang1 : Form
    {
        List<Customer> listCustomer = new List<Customer>();
        List<Import_Detail> listBill_Detail = new List<Import_Detail>();
        List<Employee> listEmployee = new List<Employee>();
        Import_Detail selectedBD { get; set; }
        Account currentAccount { get; set; }
        int bill_id { get; set; }
        double khachcantra { get; set; }
        double tongthanhtoan { get; set; }
        int maNhanVien { get; set; }
        int maKhach { get; set; }
        string today { get; set; }
        public Nhaphang1(Hoadonnhap hoadon)
        {
            InitializeComponent();
            this.cboAn.TextChanged += new System.EventHandler(this.cboAn_TextChanged);
            this.currentAccount = hoadon.curentAccount;
        }
        class SanPham
        {
            int product_id { get; set; }
            int category_id { get; set; }
            double price { get; set; }

            public SanPham(int product_id, int category_id, double price)
            {
                this.product_id = product_id;
                this.category_id = category_id;
                this.price = price;
            }
        } 


        public Nhaphang1()
        {
            InitializeComponent();
            this.cboAn.TextChanged += new System.EventHandler(this.cboAn_TextChanged);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
        }

        private void txtGhiChu_Enter(object sender, EventArgs e)
        {
            if (txtGhiChu.Text == "Ghi chú")
            {
                txtGhiChu.ForeColor = Color.Black;
                txtGhiChu.Text = "";
            }
        }

        private void txtGhiChu_Leave(object sender, EventArgs e)
        {
            if (txtGhiChu.Text == "")
            {
                txtGhiChu.Text = "Ghi chú";
                txtGhiChu.ForeColor = Color.Gray;
            }
        }

        private void Banhang_Load(object sender, EventArgs e)
        {
            txtGhiChu.Text = "Ghi chú";
            txtGhiChu.ForeColor = Color.Gray;
            lblPrice.Text = "";
            lblTonKho.Text = "";

            SqlConnection con = DataConnection.Connection;

            string sqlBill_Id = "select max(Import_Id)+1 from Import_Bill";
            SqlCommand cmd = new SqlCommand(sqlBill_Id, con);
            bill_id = (Int32)cmd.ExecuteScalar();
            lblBill_Id.Text = "Mã phiếu nhập : " + bill_id;
            
            string sqlNhanVien = "select Emp_Id, Name from Employee";
            cmd = new SqlCommand(sqlNhanVien, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cboNhanVien.DisplayMember = "Name";
            cboNhanVien.ValueMember = "Emp_Id";
            cboNhanVien.DataSource = dt;

            string sqlKhachHang = "select Supplier_Id, Name from Supplier";
            cmd = new SqlCommand(sqlKhachHang, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr2 = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            cboKhachHang.DisplayMember = "Name";
            cboKhachHang.ValueMember = "Supplier_Id";
            cboKhachHang.DataSource = dt2;

            cboChannel.SelectedIndex = 0;


            string sqlProduct = "select CONCAT(c.Code,p.Product_Id) 'Code',p.Product_Id,c.Category_Id, p.Name, p.Price, p.Quantity from Product p join Category c on c.Category_Id = p.Category_Id";
            cmd = new SqlCommand(sqlProduct, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr1 = cmd.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Load(dr1);
            cboTenHang.DisplayMember = "Name";
            cboTenHang.ValueMember = "Product_Id";
            cboMaHang.DisplayMember = "Code";
            cboMaHang.ValueMember = "Category_Id";
            cboAn.DisplayMember = "Quantity";
            cboAn.ValueMember = "Price";
            cboAn.DataSource = dt1;
            cboMaHang.DataSource = dt1;
            cboTenHang.DataSource = dt1;
            cboTenHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboTenHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMaHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboMaHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboNhanVien.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboKhachHang.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            // cboMaHang.ValueMember = "Emp_Id";
            //cboTenHang.ValueMember = "Emp_Id";
            con.Close();
            loadBangDuLieu();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void cboAn_TextChanged(object sender, EventArgs e)
        {
           // lblPrice.Text = cboAn.ValueMember;
        }

        private void cboTenHang_TextChanged(object sender, EventArgs e)
        {

            if (cboAn.SelectedValue != null)
            {
                lblTonKho.Text = cboAn.Text;
                lblPrice.Text = cboAn.SelectedValue.ToString();
            }
        }

        private void cboTenHang_ValueMemberChanged(object sender, EventArgs e)
        {
            if(cboAn.SelectedValue != null)
            {
                lblTonKho.Text = cboAn.Text;
                lblPrice.Text = cboAn.SelectedValue.ToString();
            }
        }

        private void loadBangDuLieu()
        {
            bangChiTietHoaDon.DataSource = new System.Windows.Forms.BindingSource { DataSource = listBill_Detail };
            bangChiTietHoaDon.Columns.Remove("product_id");
            bangChiTietHoaDon.Columns.Remove("category_id");
            bangChiTietHoaDon.Columns.Remove("import_id");
            bangChiTietHoaDon.Columns.Remove("select_idx");

            foreach (Import_Detail bd in listBill_Detail)
            {
                khachcantra += bd.total;
                tongthanhtoan += bd.quantity * bd.price;

            }
            lblKhachCanTra.Text = khachcantra.ToString();
            lblTongThanhToan.Text = tongthanhtoan.ToString();
            lblGiamThanhToan.Text = (tongthanhtoan - khachcantra).ToString();
            /*bangChiTietHoaDon.Columns.Add("STT", "STT");
            bangChiTietHoaDon.Columns.Add("Name", "Tên sản phẩm");
            bangChiTietHoaDon.Columns.Add("Quantity", "Số lượng");
            bangChiTietHoaDon.Columns.Add("Price", "Giá");
            bangChiTietHoaDon.Columns.Add("Discount", "Giảm giá(%)");
            bangChiTietHoaDon.Columns.Add("Total", "Thành tiền");*/
        }

        private void bangChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int select_idx = cboMaHang.SelectedIndex;
            int category_id = Convert.ToInt32(cboMaHang.SelectedValue.ToString());
            int product_id = Convert.ToInt32(cboTenHang.SelectedValue.ToString());
            int quantity = Convert.ToInt32(txtSoLuong.Value.ToString());
            // int emp_id = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
            // int customer_id = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
            string product_name = cboTenHang.Text;
            int discount = Convert.ToInt32(txtDiscount.Value.ToString());
            double price = Convert.ToDouble(lblPrice.Text);
            int tonKho = Convert.ToInt32(lblTonKho.Text);

            double total = price * quantity * (100 - discount) / 100;
            /*if(tonKho - quantity < 0)
            {
                MessageBox.Show("Kho không đủ hàng!", "Lỗi");
            }
            else*/ if (category_id != null && product_id != null && quantity >0 && price != null)
            {
                Import_Detail detail = new Import_Detail(quantity,bill_id, product_id, price, discount, category_id, product_name, total, select_idx);
                // bangChiTietHoaDon.Rows.Add(bangChiTietHoaDon.RowCount, cboTenHang.Text, quantity, price, discount, price*quantity*(100-discount)/100);
                
                bool add = true;
                foreach(Import_Detail bd in listBill_Detail)
                {
                    if(category_id == bd.category_id && product_id == bd.product_id)
                    {
                        add = false;
                        /*if((tonKho - bd.quantity - quantity) < 0)
                        {
                            MessageBox.Show("Kho không đủ hàng!", "Lỗi");
                            break;
                        }*/
                        bd.quantity += quantity;
                        bd.discount = discount;
                        bd.total = bd.price * bd.quantity * (100 - bd.discount) / 100;
                    }
                }
                if(add) listBill_Detail.Add(detail);
                loadBangDuLieu();
            }
        }

        private void cboMaHang_ValueMemberChanged(object sender, EventArgs e)
        {

            if (cboAn.SelectedValue != null)
            {
                lblTonKho.Text = cboAn.Text;
                lblPrice.Text = cboAn.SelectedValue.ToString();
            }
        }

        private void cboMaHang_TextChanged(object sender, EventArgs e)
        {

            if (cboAn.SelectedValue != null)
            {
                lblTonKho.Text = cboAn.Text;
                lblPrice.Text = cboAn.SelectedValue.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int select_idx = cboMaHang.SelectedIndex;
            int category_id = Convert.ToInt32(cboMaHang.SelectedValue.ToString());
            int product_id = Convert.ToInt32(cboTenHang.SelectedValue.ToString());
            int quantity = Convert.ToInt32(txtSoLuong.Value.ToString());
            // int emp_id = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
            // int customer_id = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
            string product_name = cboTenHang.Text;
            int discount = Convert.ToInt32(txtDiscount.Value.ToString());
            double price = Convert.ToDouble(lblPrice.Text);
            int tonKho = Convert.ToInt32(lblTonKho.Text);
            double total = price * quantity * (100 - discount) / 100;
           /* if (tonKho - quantity < 0)
            {
                MessageBox.Show("Kho không đủ hàng!", "Lỗi");
            }
            else*/ if (category_id != null && product_id != null && quantity > 0 && price != null && selectedBD != null)
            {
                // bangChiTietHoaDon.Rows.Add(bangChiTietHoaDon.RowCount, cboTenHang.Text, quantity, price, discount, price*quantity*(100-discount)/100);
                foreach (Import_Detail bd in listBill_Detail)
                {
                    if (category_id == bd.category_id && product_id == bd.product_id)
                    {
                        bd.quantity = quantity;
                        bd.discount = discount;
                        bd.total = bd.price * bd.quantity * (100 - bd.discount) / 100;
                    }
                }
                loadBangDuLieu();
            }
        }

        private void bangChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (bangChiTietHoaDon.RowCount > 0)
            {
                selectedBD = (Import_Detail)bangChiTietHoaDon.CurrentRow.DataBoundItem;
                cboTenHang.SelectedIndex = selectedBD.select_idx;
                txtDiscount.Value = selectedBD.discount;
                txtSoLuong.Value = selectedBD.quantity;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int select_idx = cboMaHang.SelectedIndex;
            int category_id = Convert.ToInt32(cboMaHang.SelectedValue.ToString());
            int product_id = Convert.ToInt32(cboTenHang.SelectedValue.ToString());
            if (category_id != null && product_id != null && selectedBD != null)
            {
                // bangChiTietHoaDon.Rows.Add(bangChiTietHoaDon.RowCount, cboTenHang.Text, quantity, price, discount, price*quantity*(100-discount)/100);
                foreach (Import_Detail bd in listBill_Detail)
                {
                    if (category_id == bd.category_id && product_id == bd.product_id)
                    {
                        listBill_Detail.Remove(bd);
                        break;
                    }
                }
                loadBangDuLieu();
            }

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (maNhanVien == null) ;
            else if (maKhach == null) ;
            else
            {
                SqlConnection con = DataConnection.Connection;
                string sqlINSERT = "INSERT INTO Import_Bill(Import_Id, Create_date, Update_date, Supplier_Id, Emp_Id, Total_Money, Debt, Status, Note)";
                sqlINSERT += " VALUES (@Import_Id, @Create_date, @Update_date, @Supplier_Id, @Emp_Id, @Total_Money, @Debt, @Status, @Note)";
                SqlCommand cmd = new SqlCommand(sqlINSERT, con);
                cmd.Parameters.AddWithValue("Import_Id", bill_id);
                cmd.Parameters.AddWithValue("Create_date", "05 - 19 - 2020 20:05");
                cmd.Parameters.AddWithValue("Update_date", "05 - 19 - 2020 20:05");
                cmd.Parameters.AddWithValue("Supplier_Id", maKhach);
                cmd.Parameters.AddWithValue("Emp_Id", maNhanVien);
                /*cmd.Parameters.AddWithValue("Sale_Channel", cboChannel.Text);*/
                cmd.Parameters.AddWithValue("Total_Money", khachcantra);
                cmd.Parameters.AddWithValue("Debt", Convert.ToDouble(lblTienThua.Text));
                cmd.Parameters.AddWithValue("Status", "Đã nhập hàng");
                cmd.Parameters.AddWithValue("Note", txtGhiChu.Text);
                cmd.ExecuteNonQuery();

                foreach(Import_Detail bd in listBill_Detail)
                {
                    sqlINSERT = "INSERT INTO Import_Detail(Import_Id, Product_Id, Category_Id, Price, Quantity, Discount)";
                    sqlINSERT += " VALUES (@Import_Id, @Product_Id, @Category_Id, @Price, @Quantity, @Discount)";
                    cmd = new SqlCommand(sqlINSERT, con);
                    cmd.Parameters.AddWithValue("Import_Id", bill_id);
                    cmd.Parameters.AddWithValue("Product_Id", bd.product_id);
                    cmd.Parameters.AddWithValue("Category_Id", bd.category_id);
                    cmd.Parameters.AddWithValue("Price", bd.price);
                    cmd.Parameters.AddWithValue("Quantity", bd.quantity);
                    cmd.Parameters.AddWithValue("Discount", bd.discount);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Nhập hàng thành công", "Thông báo");
                this.Close();
            }
        }

        private void cboNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue != null)
            {
                string sql = "select top 10 p.Name,Sum(bd.Quantity) 'Quantity' from Product p ";
                sql += " join Bill_Detail bd on p.Category_Id = bd.Category_Id AND p.Product_Id = bd.Product_Id";
                sql += " join Bill b on b.Bill_Id = bd.Bill_Id ";
                sql += " group by p.Product_Id, p.Category_Id, p.Name ";
                sql += " order by Sum(bd.Quantity) desc";

                maNhanVien = Convert.ToInt32(cboNhanVien.SelectedValue.ToString());
            }
        }

        private void cboKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue != null)
            {

                maKhach = Convert.ToInt32(cboKhachHang.SelectedValue.ToString());
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtKhachThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtKhachThanhToan_KeyUp(object sender, KeyEventArgs e)
        {
            if (lblKhachCanTra.Text != null &&Convert.ToDouble(lblKhachCanTra.Text) > 0 )
            {
                if (!String.IsNullOrEmpty(txtKhachThanhToan.Text))
                {
                    if(Convert.ToDouble(txtKhachThanhToan.Text) > 0)
                    {

                        double khachdua = Convert.ToDouble(txtKhachThanhToan.Text);
                        double cantra = Convert.ToDouble(lblKhachCanTra.Text);
                        lblTienThua.Text = (khachdua - cantra).ToString();
                    }
                } else txtKhachThanhToan.Text = "0"; 
            }
        }
    }
}
