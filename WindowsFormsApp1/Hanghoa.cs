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
    public partial class Hanghoa : Form
    {

        List<Product> listProduct = new List<Product>();
        private bool edit;

        public Hanghoa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var m = new themMoiHangHoa(this);
            m.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Hanghoa_Load(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Product";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ta = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ta.Fill(ds, "Product");
            tbl_Product.DataSource = ds.Tables["Product"];
            edit = true;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new ThemmoiNhomHang();
            m.Show();
        }

       

        private void btnFind_Click(object sender, EventArgs e)
        {
           
        }
    }
}
