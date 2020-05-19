using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class themMoiHangHoa : Form
    {
        List<Object> listThuocTinh = new List<Object>();
        List<Object> listDonVi = new List<Object>();

        public themMoiHangHoa()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuThemHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soThuocTinh = listThuocTinh.Count;
            int soDonVi = listDonVi.Count;
            ComboBox thuocTinh = new System.Windows.Forms.ComboBox();
            ComboBox giaTri = new System.Windows.Forms.ComboBox();

            thuocTinh.FormattingEnabled = true;
            thuocTinh.Location = new System.Drawing.Point(12, 61 + soThuocTinh * 30);
            thuocTinh.Name = "comboBox2";
            thuocTinh.Size = new System.Drawing.Size(121, 23);
            thuocTinh.TabIndex = 2;
            this.panel2.Controls.Add(thuocTinh);
            giaTri.FormattingEnabled = true;
            giaTri.Location = new System.Drawing.Point(237, 61 + soThuocTinh * 30);
            giaTri.Name = "comboBox4";
            giaTri.Size = new System.Drawing.Size(121, 23);
            giaTri.TabIndex = 6;

            listThuocTinh.Add(thuocTinh);
            listThuocTinh.Add(giaTri);

        }
    }
}
