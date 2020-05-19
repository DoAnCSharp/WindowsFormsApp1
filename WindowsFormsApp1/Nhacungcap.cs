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
    public partial class Nhacungcap : Form
    {
        public Nhacungcap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNhomNhaCungCap_Click(object sender, EventArgs e)
        {
            var m = new ThemNhomNhaCungCap();
            m.Show();
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            var m = new Themmoinhacungcap();
            m.Show();
        }
    }
}
