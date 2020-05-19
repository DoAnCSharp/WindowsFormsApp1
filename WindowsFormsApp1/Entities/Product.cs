using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    class Product
    {
        public int id_product { get; set; }
        public string name { get; set; }
        public int id_category { get; set; }
        public int quantity { get; set; }
        public int unit { get; set; }
        public double price { get; set; }
        public double sale_price { get; set; }
        public string note { get; set; }
        public int state { get; set; }

        public Product(int id_product, string name, int id_category, int quantity, int unit, double price, double sale_price, string note, int state)
        {
            this.id_product = id_product;
            this.name = name;
            this.id_category = id_category;
            this.quantity = quantity;
            this.unit = unit;
            this.price = price;
            this.sale_price = sale_price;
            this.note = note;
            this.state = state;
        }
        public Product(int id_product, string name, int quantity, double sale_price)
        {
            this.id_product = id_product;
            this.name = name;
            this.quantity = quantity;
            this.sale_price = sale_price;
        }
    }
}
