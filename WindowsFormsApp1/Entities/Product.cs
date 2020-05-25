using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Product
    {
        public int product_id { get; set; }
        public int category_id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string unit { get; set; }
        public double price { get; set; }
        public double sale_Price { get; set; }
        public string note { get; set; }
        public string status { get; set; }
        public string image_product { get; set; }

        public Product(int product_id, int category_id, string name, int quantity, string unit, double price, double sale_Price, string note, string status, string image_product)
        {
            this.product_id = product_id;
            this.category_id = category_id;
            this.name = name;
            this.quantity = quantity;
            this.unit = unit;
            this.price = price;
            this.sale_Price = sale_Price;
            this.note = note;
            this.status = status;
            this.image_product = image_product;
        }

    }
}
