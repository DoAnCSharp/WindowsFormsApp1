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
    public partial class Hanghoa : Form
    {
        public Hanghoa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var m = new themMoiHangHoa();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Hanghoa_Load(object sender, EventArgs e)
        {
            loadListVierHangHoa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new ThemmoiNhomHang();
            m.Show();
        }

        private void loadListVierHangHoa()
        {
            List<String> myList = new List<String>();
            listViewHangHoa.Columns.Add
            listViewHangHoa.Items.Add(item2);

        }
    }
}
