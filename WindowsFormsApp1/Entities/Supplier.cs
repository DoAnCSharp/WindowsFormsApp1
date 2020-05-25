using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Supplier
    {
        public int supplier_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string note { get; set; }
        public string status { get; set; }
        public string phone { get; set; }
        public string create_date { get; set; }
        public string update_date { get; set; }
        public Supplier(int supplier_id, string name, string address, string note, string status, string phone, string create_date, string update_date)
        {
            this.supplier_id = supplier_id;
            this.name = name;
            this.address = address;
            this.note = note;
            this.status = status;
            this.phone = phone;
            this.create_date = create_date;
            this.update_date = update_date;

        }
    }
}
