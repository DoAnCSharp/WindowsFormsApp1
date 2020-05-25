using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Hanghoa : Form
    {

        List<Product> listProduct = new List<Product>();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new ThemmoiNhomHang();
            m.Show();
        }

        private void loadListVierHangHoa(List<Entities.Product> listItem)
        {
            listViewHangHoa.Clear();
            List<string> columns = new List<string>();
            listViewHangHoa.View = View.Details;
            listViewHangHoa.Columns.Add("Mã hàng");
            listViewHangHoa.Columns.Add("Tên hàng");
            listViewHangHoa.Columns.Add("Giá bán");
            listViewHangHoa.Columns.Add("Tồn kho");


            foreach(Entities.Product pro in listItem)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(pro.product_id));
              //  item.Items.Add(Convert.ToString(pro.id_product));
                item.SubItems.Add(Convert.ToString(pro.name));
                item.SubItems.Add(Convert.ToString(pro.sale_Price));
                item.SubItems.Add(Convert.ToString(pro.quantity));
                listViewHangHoa.Items.Add(item);
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
        }
    }
}
