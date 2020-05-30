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
using System.Timers;
namespace WindowsFormsApp1
{
    public partial class Trangchu : Form
    {

        public Trangchu()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            //lbl_Date.Text = DateTime.Now.ToString();
            Chart_TopProduct.ChartAreas[0].AxisX.Maximum = 10;

            //Chart_revenue.ChartAreas[0].AxisX.Maximum = 7;
            SqlConnection con = DataConnection.Connection;
            string sql = "select top 10 p.Name,Sum(bd.Quantity) 'Quantity' from Product p ";
            sql += " join Bill_Detail bd on p.Category_Id = bd.Category_Id AND p.Product_Id = bd.Product_Id";
            sql += " join Bill b on b.Bill_Id = bd.Bill_Id ";
            sql += " group by p.Product_Id, p.Category_Id, p.Name ";
            sql += " order by Sum(bd.Quantity) Asc";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                this.Chart_TopProduct.Series["TopProduct"].Points.AddXY(myReader.GetString(0), myReader.GetInt32(1));

            }
            con.Close();

            con.Open();
            string sql2 = "SELECT max(day(Create_date)) FROM  Bill ";
            sql2 += " WHERE Create_date >= DATEADD(day,-30,GETDATE()) ";
            sql2 += " and Create_date <= getdate()";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            Chart_revenue.ChartAreas[0].AxisX.Maximum = (Int32)cmd2.ExecuteScalar();

            con.Close();

            con.Open();
            String sql1 = "SELECT convert(int,Sum(Total_Money)),day(Create_date) as day FROM Bill ";
            sql1 += " WHERE Create_date >= DATEADD(day,-30,GETDATE()) ";
            sql1 += " and   Create_date <= getdate() group by Create_date ";
            sql1 += " order by Create_date ";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            SqlDataReader myReader1;
            myReader1 = cmd1.ExecuteReader();
            while (myReader1.Read())
            {
                // MessageBox.Show(myReader1.GetInt32(1).ToString());
                this.Chart_revenue.Series["revenue"].Points.AddXY(myReader1.GetInt32(1), myReader1.GetInt32(0));

            }

            con.Close();


            //timer
            timer1.Start();


            //Chart_revenue.Series["revenue"].Points.AddXY("7", 345354);
        }
       
        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {

            var m = new Banhang();
            m.Show();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            var m = new Hanghoa();
            m.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

            var m = new Hoadon();
            m.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            var m = new KhachHang();
            m.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {

            var m = new Nhacungcap();
            m.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

            var m = new frmAddnewusers();
            m.Show();
        }

        private void chart2_Click(object sender, EventArgs e)
        {
           
        }

        private void Bieudongang_Click(object sender, EventArgs e)
        {

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            string sql = "select top 10 p.Name,Sum(bd.Quantity) 'Quantity' from Product p ";
            sql += " join Bill_Detail bd on p.Category_Id = bd.Category_Id AND p.Product_Id = bd.Product_Id";
            sql += " join Bill b on b.Bill_Id = bd.Bill_Id ";
            sql += " group by p.Product_Id, p.Category_Id, p.Name ";
            sql += " order by Sum(bd.Quantity) Asc";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read()) {
               this.Chart_TopProduct.Series["TopProduct"].Points.AddXY(myReader.GetString(0), myReader.GetInt32(1));

            }
            con.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lbl_Date.Text = dateTime.ToString();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            var m = new Bill();
            m.Show();
        }
    }
}
