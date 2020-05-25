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
    public partial class frmAddnewusers : Form
    {
        bool edit = true;
        private SqlConnection con;

        public frmAddnewusers()
        {
            InitializeComponent();
        }
        private void ShowAccount()
        {
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Account";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ta = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ta.Fill(ds, "Account");
            dgvAccount.DataSource = ds.Tables["Account"];
            edit = true;
            con.Close();
        }
        private void frmAddnewusers_Load(object sender, EventArgs e)
        {
            ShowAccount();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Text = txtTendangnhap.Text = txtMatkhau.Text = txtDienthoai.Text = txtEmail.Text = txtGhichu.Text = txtTrangthai.Text = "";
            txtMa.Focus();
            edit = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTrangthai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            string sqlINSERT = "INSERT INTO Account (Account_Id,Username,Password,Phone,Email,Note,Status) VALUES(@Account_Id,@Username,@Password,@Phone,@Email,@Note,@Status)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("Account_Id", txtMa.Text);
            cmd.Parameters.AddWithValue("Username", txtTendangnhap.Text);
            cmd.Parameters.AddWithValue("Password", txtMatkhau.Text);
            cmd.Parameters.AddWithValue("Phone", txtDienthoai.Text);
            cmd.Parameters.AddWithValue("Email", txtTrangthai.Text);
            cmd.Parameters.AddWithValue("Note", txtGhichu.Text);
            cmd.Parameters.AddWithValue("Status", txtTrangthai.Text);
            cmd.ExecuteNonQuery();
            ShowAccount();
            txtMa.Text = txtTendangnhap.Text = txtMatkhau.Text = txtDienthoai.Text = txtEmail.Text = txtGhichu.Text = txtTrangthai.Text = "";
            txtMa.Focus();
           

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            string sqlEdit = "UPDATE Account SET Username=@Username,Password=@Password,Phone=@Phone,Email=@Email,Note=@Note,Status=@Status WHERE Account_Id=@Account_Id";
            SqlCommand cmd = new SqlCommand(sqlEdit, con);
            cmd.Parameters.AddWithValue("Account_Id", txtMa.Text);
            cmd.Parameters.AddWithValue("Username", txtTendangnhap.Text);
            cmd.Parameters.AddWithValue("Password", txtMatkhau.Text);
            cmd.Parameters.AddWithValue("Phone", txtDienthoai.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("Note", txtGhichu.Text);
            cmd.Parameters.AddWithValue("Status", txtTrangthai.Text);
            cmd.ExecuteNonQuery();
            ShowAccount();
            txtMa.Text = txtTendangnhap.Text = txtMatkhau.Text = txtDienthoai.Text = txtEmail.Text = txtGhichu.Text = txtTrangthai.Text = "";
            txtMa.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            string sqlDELETE = "DELETE FROM Account WHERE Account_Id=@Account_Id";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("Account_Id", txtMa.Text);
            cmd.Parameters.AddWithValue("Username", txtTendangnhap.Text);
            cmd.Parameters.AddWithValue("Password", txtMatkhau.Text);
            cmd.Parameters.AddWithValue("Phone", txtDienthoai.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("Note", txtGhichu.Text);
            cmd.Parameters.AddWithValue("Status", txtTrangthai.Text);
            cmd.ExecuteNonQuery();
            ShowAccount();
            txtMa.Text = txtTendangnhap.Text = txtMatkhau.Text = txtDienthoai.Text = txtEmail.Text = txtGhichu.Text = txtTrangthai.Text = "";
            txtMa.Focus();

        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            string sqlTIMKIEM = "select * from Account WHERE Account_Id=@Account_Id";
            SqlCommand cmd = new SqlCommand(sqlTIMKIEM, con);
            cmd.Parameters.AddWithValue("Account_Id", txtMacantim.Text);
            cmd.Parameters.AddWithValue("Username", txtTendangnhap.Text);
            cmd.Parameters.AddWithValue("Password", txtMatkhau.Text);
            cmd.Parameters.AddWithValue("Phone", txtDienthoai.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("Note", txtGhichu.Text);
            cmd.Parameters.AddWithValue("Status", txtTrangthai.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvAccount.DataSource = dt;
        }

        private void dgvAccount_MouseClick(object sender, MouseEventArgs e)
        {
            txtMa.Text = dgvAccount.CurrentRow.Cells[0].Value.ToString();
            txtTendangnhap.Text = dgvAccount.CurrentRow.Cells[1].Value.ToString();
            txtMatkhau.Text = dgvAccount.CurrentRow.Cells[2].Value.ToString();
            txtDienthoai.Text = dgvAccount.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvAccount.CurrentRow.Cells[4].Value.ToString();
            txtGhichu.Text = dgvAccount.CurrentRow.Cells[5].Value.ToString();
            txtTrangthai.Text = dgvAccount.CurrentRow.Cells[6].Value.ToString();

        }
        
    }
}

