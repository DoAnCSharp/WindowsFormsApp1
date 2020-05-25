using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Bill
    {
        public int bill_id { get; set; }
        public int customer_id { get; set; }
        public int emp_id { get; set; }
        public string sale_Channel { get; set; }
        public string note { get; set; }
        public double total_money { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string emai { get; set; }
        public string create_date { get; set; }
        public string cpdate_date { get; set; }
        public double debt { get; set; }

        public Bill(int bill_id, int customer_id, int emp_id, string sale_Channel, string note, double total_money, string address, string phone, string emai, string create_date, string cpdate_date, double debt)
        {
            this.bill_id = bill_id;
            this.customer_id = customer_id;
            this.emp_id = emp_id;
            this.sale_Channel = sale_Channel;
            this.note = note;
            this.total_money = total_money;
            this.address = address;
            this.phone = phone;
            this.emai = emai;
            this.create_date = create_date;
            this.cpdate_date = cpdate_date;
            this.debt = debt;
        }
    }
}
