using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Bill_Detail
    {
        public int auantity { get; set; }
        public int bill_id { get; set; }
        public int product_id { get; set; }
        public double price { get; set; }
        public int discount { get; set; }
        public int category_id { get; set; }
        public Bill_Detail(int auantity, int bill_id, int product_id, double price, int discount, int category_id)
        {
            this.auantity = auantity;
            this.bill_id = bill_id;
            this.product_id = product_id;
            this.price = price;
            this.discount = discount;
            this.category_id = category_id;
        }
    }
}
