using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Customer
    {
        public int customer_id { get; set; }
        public int account_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string date_of_birth { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string note { get; set; }
        public string status { get; set; }
        public string address { get; set; }
        public Customer(int customer_id, int account_id, string name, string phone, string date_of_birth, string type, string gender, string email, string note, string status, string address)
        {
            this.customer_id = customer_id;
            this.account_id = account_id;
            this.name = name;
            this.phone = phone;
            this.date_of_birth = date_of_birth;
            this.type = type;
            this.gender = gender;
            this.email = email;
            this.note = note;
            this.status = status;
            this.address = address;
        }
    }
}
