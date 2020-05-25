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
    public partial class themMoiKhachHang : Form
    {
        KhachHang frm_Customer;
        private bool edit;

        public themMoiKhachHang(KhachHang frm_Customer)
        {   
            this.frm_Customer = frm_Customer;
            InitializeComponent();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void themMoiKhachHang_Load(object sender, EventArgs e)
        {

        }
        private void ShowCustomer()
        {
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Customer";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ta = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ta.Fill(ds, "Customer");
            frm_Customer.tbl_Customer.DataSource = ds.Tables["Customer"];
            edit = true;
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
