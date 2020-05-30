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
    public partial class Bill : Form
    {
        private bool edit;

        public Bill()
        {
            InitializeComponent();
        }

        private void tbl_Bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Bill";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ta = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ta.Fill(ds, "Bill");
            tbl_Bill.DataSource = ds.Tables["Bill"];
            edit = true;
            con.Close();
        }
    }
}
