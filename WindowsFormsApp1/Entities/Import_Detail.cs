using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Import_Detail
    {
        public int quantity { get; set; }
        public int import_id { get; set; }
        public int product_id { get; set; }
        public double price { get; set; }
        public int discount { get; set; }
        public int category_id { get; set; }

        public Import_Detail(int quantity, int import_id, int product_id, double price, int discount, int category_id)
        {
            this.quantity = quantity;
            this.import_id = import_id;
            this.product_id = product_id;
            this.price = price;
            this.discount = discount;
            this.category_id = category_id;
        }
    }
}
