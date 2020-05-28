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

namespace WindowsFormsApp1
{
    public partial class themMoiHangHoa : Form
    {
        Hanghoa frmProduct;
        List<Object> listThuocTinh = new List<Object>();
        List<Object> listDonVi = new List<Object>();
        private bool edit;

        public themMoiHangHoa(Hanghoa frmProduct)
        {
            this.frmProduct =frmProduct;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ShowProduct()
        {
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Product";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ta = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ta.Fill(ds, "Product");
            frmProduct.tbl_Product.DataSource = ds.Tables["Product"];
            edit = true;
            con.Close();

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuThemHangHoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            string sqlINSERT = "INSERT INTO Product (Product_Id,Category_Id,Name,Quantity,Unit,Price,Sale_Price,Note,Status,Img_Product) VALUES(@Product_Id,@Category_Id,@Name,@Quantity,@Unit,@Price,@Sale_Price,@Note,@Status,@Img_Product)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("Product_Id", txtMaHangHoa.Text);
            cmd.Parameters.AddWithValue("Category_Id", cboNhomHang.Text);
            cmd.Parameters.AddWithValue("Name", txtTenHang.Text);
            cmd.Parameters.AddWithValue("Quantity", txtTonKho.Text);
            cmd.Parameters.AddWithValue("Unit", cbo_Donvi.Text);
            cmd.Parameters.AddWithValue("Price", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("Sale_Price", txtGiaBan.Text);
            cmd.Parameters.AddWithValue("Note", txtTrongLuong.Text);
            cmd.Parameters.AddWithValue("Status", txtTrongLuong.Text);
            cmd.Parameters.AddWithValue("Img_Product", txtTrongLuong.Text);

            cmd.ExecuteNonQuery();
            ShowProduct();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soThuocTinh = listThuocTinh.Count;
            int soDonVi = listDonVi.Count;
            ComboBox thuocTinh = new System.Windows.Forms.ComboBox();
            ComboBox giaTri = new System.Windows.Forms.ComboBox();

            thuocTinh.FormattingEnabled = true;
            thuocTinh.Location = new System.Drawing.Point(12, 61 + soThuocTinh * 30);
            thuocTinh.Name = "comboBox2";
            thuocTinh.Size = new System.Drawing.Size(121, 23);
            thuocTinh.TabIndex = 2;
            this.panel2.Controls.Add(thuocTinh);
            giaTri.FormattingEnabled = true;
            giaTri.Location = new System.Drawing.Point(237, 61 + soThuocTinh * 30);
            giaTri.Name = "comboBox4";
            giaTri.Size = new System.Drawing.Size(121, 23);
            giaTri.TabIndex = 6;

            listThuocTinh.Add(thuocTinh);
            listThuocTinh.Add(giaTri);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
