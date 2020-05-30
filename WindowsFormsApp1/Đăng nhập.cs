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
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class frmDangnhap : Form
    {
        
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = DataConnection.Connection;
            if (txtTendangnhap.Text.Equals(""))
            {
                MessageBox.Show("Mời bạn nhập tên đăng nhập", "THÔNG BÁO");
            }
            else if (txtMatkhau.Text.Equals(""))
            {
                MessageBox.Show("Mời bạn nhập mật khẩu", "THÔNG BÁO");
            }
            else
            {
                try
                {
                     
                   
                    string tk = txtTendangnhap.Text;
                    string mk = txtMatkhau.Text;
                    string sql = "select * from Account where Username= '" + tk + "' and Password = '" + mk +"'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader dt = cmd.ExecuteReader();
                    if (dt.Read() == true)
                    {
                        var m = new Trangchu(this);
                        m.Show();
                        this.Hide();
                    }
                    else
                    {
                        txtTendangnhap.Clear();
                        txtMatkhau.Clear();
                        MessageBox.Show("Đăng nhập thất bại", "THÔNG BÁO");
                    }
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Thất bại", "THÔNG BÁO");
                }
                
               
                finally
                {
                    con.Close();
                }
                

            }

                
                
            
             
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không ?", "Thông  báo", MessageBoxButtons.YesNo);
            if (tb == DialogResult.OK) ;
            this.Close();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            txtTendangnhap.Text = Properties.Settings.Default.txtTendangnhap;
            txtMatkhau.Text = Properties.Settings.Default.txtMatkhau;
            string tmp = Properties.Settings.Default.chkLuumatkhau;
            if (tmp != null) chkLuumatkhau.Checked = Convert.ToBoolean(tmp);
            if (chkLuumatkhau.Checked)
            {
                Properties.Settings.Default.txtTendangnhap = txtTendangnhap.Text;
                Properties.Settings.Default.txtMatkhau = txtMatkhau.Text;
                Properties.Settings.Default.chkLuumatkhau = chkLuumatkhau.Checked.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void chkLuumatkhau_CheckedChanged(object sender, EventArgs e)
        {
            
    }

        private void chkLuumatkhau_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkLuumatkhau.Checked)
            {
                Properties.Settings.Default.txtTendangnhap = txtTendangnhap.Text;
                Properties.Settings.Default.txtMatkhau = txtMatkhau.Text;
                Properties.Settings.Default.chkLuumatkhau = chkLuumatkhau.Checked.ToString();
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.txtTendangnhap = "";
                Properties.Settings.Default.txtMatkhau = "";
                Properties.Settings.Default.chkLuumatkhau = "false";
                Properties.Settings.Default.Save();
            }
        }
    }
    }
