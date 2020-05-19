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
    public partial class TongQuat : Form
    {
        public TongQuat()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new themMoiNhanVien();
            m.Show();
        }
    }
}
