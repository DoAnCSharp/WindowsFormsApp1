using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Account
    {
        public int account_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string note { get; set; }
        public string status { get; set; }

        public Account(int account_id, string username, string password, string phone, string email, string note, string status)
        {
            this.account_id = account_id;
            this.username = username;
            this.password = password;
            this.phone = phone;
            this.email = email;
            this.note = note;
            this.status = status;
        }
    }
}
