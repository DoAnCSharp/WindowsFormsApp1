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
    public partial class Themmoinhacungcap : Form
    {
        Nhacungcap frmspu;
        private bool edit;

        public Themmoinhacungcap(Nhacungcap frmspu)
        {
            this.frmspu = frmspu;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Themmoinhacungcap_Load(object sender, EventArgs e)
        {
        
        }

        private void ShowSupplier()
        {
            SqlConnection con = DataConnection.Connection;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Supplier";
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter ta = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ta.Fill(ds, "Supplier");
            frmspu.tbl_Sup.DataSource = ds.Tables["Supplier"];
            edit = true;
            con.Close();
        }

        private void btnLuuNhaCungCap_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            string sqlINSERT = "INSERT INTO Customer (Customer_Id,Account_Id,Name,Phone,Date_Of_Birth,Type,Gender,Email,Note,Status,Address) VALUES(@Customer_Id,@Account_Id,@Name,@Phone,@Date_Of_Birth,@Type,@Gender,@Email,@Note,@Status,@Address)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("Customer_Id", txtMaNhaCungCap.Text);
            cmd.Parameters.AddWithValue("Account_Id", txtNhaCungCap.Text);
            cmd.Parameters.AddWithValue("Name", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("Phone", txtGhiChu.Text);
            cmd.Parameters.AddWithValue("Date_Of_Birth", txtStatus.Text);
            cmd.Parameters.AddWithValue("Type", txtDienThoai.Text);
            cmd.Parameters.AddWithValue("Gender", txtDienThoai.Text);
            cmd.Parameters.AddWithValue("Email", txtDienThoai.Text);
            cmd.Parameters.AddWithValue("Note", txtDienThoai.Text);
            cmd.Parameters.AddWithValue("Status", txtDienThoai.Text);
            cmd.Parameters.AddWithValue("Address", txtDienThoai.Text);

            cmd.ExecuteNonQuery();
            ShowSupplier();
            this.Close();

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
