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
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Hoadonnhap : Form
    {
        private bool edit;
        public Account curentAccount { get; set; }

        public Hoadonnhap(Account curentAccount)
        {
            InitializeComponent();
            this.curentAccount = curentAccount;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            var m = new Nhaphang1(this);
            m.Show();
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Import_Bill";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ta = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ta.Fill(ds, "Import_Bill");
            tbl_Bill.DataSource = ds.Tables["Import_Bill"];
            edit = true;
            con.Close();
        }
    }
}
