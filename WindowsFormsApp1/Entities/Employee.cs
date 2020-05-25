using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Employee
    {
        public int emp_id { get; set; }
        public int account_id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string date_of_birth { get; set; }
        public string type { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string note { get; set; }
        public string location { get; set; }
        public string address { get; set; }
        public string card_id { get; set; }
        public int role_id { get; set; }
        public int department_id { get; set; }
        public string status { get; set; }
        public Employee(int emp_id, int account_id, string name, string phone, string date_of_birth, string type, string gender, string email, string note, string location, string address, string card_id, int role_id, int department_id, string status)
        {
            this.emp_id = emp_id;
            this.account_id = account_id;
            this.name = name;
            this.phone = phone;
            this.date_of_birth = date_of_birth;
            this.type = type;
            this.gender = gender;
            this.email = email;
            this.note = note;
            this.location = location;
            this.address = address;
            this.card_id = card_id;
            this.role_id = role_id;
            this.department_id = department_id;
            this.status = status;
        }
    }
}
