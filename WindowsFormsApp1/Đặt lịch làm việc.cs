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
    public partial class frmDatlich : Form
    {
        public frmDatlich()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDatlich_Load(object sender, EventArgs e)
        {
            Employee employee = new Employee(1, 5, "Hoàng Nam Quang", "0952541236", "12-17-1996","null", "Nam", "namquang@gmail.com", "null","Cửa hàng Hà Nội", "Hà Nam", "588422356852", 1, 1, "Active");

            lblMaNv.Text = employee.emp_id.ToString();
            lblTenNv.Text = employee.name;
            lblPhongBan.Text = employee.department_id.ToString();
            lblChucVu.Text = employee.role_id.ToString();

            checkedListBox1.Hide();
            dtKetthuc.Hide();
            label5.Hide();

            SqlConnection con = DataConnection.Connection;
            string sqlCalam = "select Shift_Id, Name from Shift";
            SqlCommand cmd = new SqlCommand(sqlCalam, con);
            cmd.CommandType = CommandType.Text;
            cmd = new SqlCommand(sqlCalam, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr2 = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);
            cbbCalv.DisplayMember = "Name";
            cbbCalv.ValueMember = "Shift_Id";
            cbbCalv.DataSource = dt2;

           
            con.Close();

        }

        private void ckbLaplai_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLaplai.Checked)
            {
                checkedListBox1.Show();
                dtKetthuc.Show();
                label5.Show();
            }
            else
            {
                checkedListBox1.Hide();
                dtKetthuc.Hide();
                label5.Hide();
            }
        }

        private void btnLư_Click(object sender, EventArgs e)
        {
            string minDate = "20140201";
            string maxDate = "20140206";
            string sqlGet = "get_ngayLamViec";
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = new SqlCommand(sqlGet, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MinDate", minDate);
            cmd.Parameters.AddWithValue("@MaxDate", maxDate);
            SqlDataAdapter ta = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ta.Fill(ds, "date_table");
            string mon = "'Monday'";
            string namedate = "Name In ("+mon+",'Sunday')";
            DataTable dt = new DataTable();
            dt = ds.Tables["date_table"].Select(namedate).CopyToDataTable();
            dataGridView1.DataSource = dt;
            /*for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                
                ds.Tables[0].Rows[i][0].ToString();// = first name
                ds.Tables[0].Rows[i][1].ToString();// = last name
                ds.Tables[0].Rows[i][2].ToString();// = ---------
            } */
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            string s;
            s = "Checked items:\n";
            for (i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    if (i != 0) s += ",";
                    s+=checkedListBox1.Items[i].ToString();
                }
            }
            MessageBox.Show(s);
        }
    }
}
