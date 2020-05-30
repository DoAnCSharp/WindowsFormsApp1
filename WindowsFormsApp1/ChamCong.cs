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
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {   

            DataTable dt = new DataTable();
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = new SqlCommand("sp_get_calender_by_month_and_year", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@year", 2020);
            cmd.Parameters.AddWithValue("@month", 4);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            bangChamCong.DataSource = dt;
            con.Close();
            bangChamCong.Rows[3].Cells[3].Style.BackColor = Color.Red;
            bangChamCong.Rows[4].Cells[2].Style.BackColor = Color.Green;
        }
    }
}
