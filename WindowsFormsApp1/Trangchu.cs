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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {

        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {

            var m = new Banhang();
            m.Show();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            var m = new Hanghoa();
            m.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {

            var m = new Hoadon();
            m.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            var m = new KhachHang();
            m.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {

            var m = new Nhacungcap();
            m.Show();
        }
    }
}
