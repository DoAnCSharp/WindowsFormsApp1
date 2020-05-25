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
            SqlConnection con = DataConnection.Connection;
            string sqlINSERT = "INSERT INTO Customer (Customer_Id,Account_Id,Name,Phone,Date_Of_Birth,Type,Gender,Email,Note,Status,Address) VALUES(@Customer_Id,@Account_Id,@Name,@Phone,@Date_Of_Birth,@Type,@Gender,@Email,@Note,@Status,@Address)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("Customer_Id", txt_MaKhachHang.Text);
            cmd.Parameters.AddWithValue("Account_Id", "");
            cmd.Parameters.AddWithValue("Name",txt_Name.Text);
            cmd.Parameters.AddWithValue("Phone", txt_Phone.Text);
            cmd.Parameters.AddWithValue("Date_Of_Birth", txt_Birthday.Text);
            cmd.Parameters.AddWithValue("Type", txt_Type.Text);
            cmd.Parameters.AddWithValue("Gender", rdo_Male.Text);
            cmd.Parameters.AddWithValue("Email", txt_Email.Text);
            cmd.Parameters.AddWithValue("Note", txt_Note.Text);
            cmd.Parameters.AddWithValue("Status", txt_Note.Text);
            cmd.Parameters.AddWithValue("Address", txt_Address.Text);

            cmd.ExecuteNonQuery();
            ShowCustomer();
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
