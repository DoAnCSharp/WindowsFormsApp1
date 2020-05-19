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
            List<Entities.Product> listItem = new List<Entities.Product>();
            listItem.Add(new Entities.Product(9, "Máy phát điện Rato R7000d B1 5.5kva-k", 4, 16000000));
            loadListVierHangHoa(listItem);
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
                ListViewItem item = new ListViewItem(Convert.ToString(pro.id_product));
              //  item.Items.Add(Convert.ToString(pro.id_product));
                item.SubItems.Add(Convert.ToString(pro.name));
                item.SubItems.Add(Convert.ToString(pro.sale_price));
                item.SubItems.Add(Convert.ToString(pro.quantity));
                listViewHangHoa.Items.Add(item);
            }

        }
    }
}
