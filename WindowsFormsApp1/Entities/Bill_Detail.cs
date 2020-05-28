using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Bill_Detail
    {
        public int bill_id { get; set; }
        public string product_name { get; set; }
        public int product_id { get; set; }
        public int category_id { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public int discount { get; set; }
        public double total { get; set; }
        public int select_idx { get; set; }
        public Bill_Detail(int quantity, int bill_id, int product_id, double price, int discount, int category_id, string product_name, double total, int select_idx)
        {
            this.product_name = product_name;
            this.total = total;
            this.quantity = quantity;
            this.bill_id = bill_id;
            this.product_id = product_id;
            this.price = price;
            this.discount = discount;
            this.category_id = category_id;
            this.select_idx = select_idx;
        }
    }
}
