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
    public partial class Nhacungcap : Form
    {
        private bool edit;

        public Nhacungcap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNhomNhaCungCap_Click(object sender, EventArgs e)
        {
            var m = new ThemNhomNhaCungCap();
            m.Show();
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            var m = new Themmoinhacungcap(this);
            m.Show();
        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Supplier";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ta = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ta.Fill(ds, "Supplier");
            tbl_Sup.DataSource = ds.Tables["Supplier"];
            edit = true;
            con.Close();
        }

        private void tbl_Sup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
