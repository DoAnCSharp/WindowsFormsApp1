using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Import_Bill
    {
        public int import_id { get; set; }
        public string create_date { get; set; }
        public string update_date { get; set; }
        public double total_money { get; set; }
        public int emp_id { get; set; }
        public string note { get; set; }
        public string status { get; set; }
        public double debt { get; set; }
        public int supplier_id { get; set; }

        public Import_Bill(int import_id, string create_date, string update_date, double total_money, int emp_id, string note, string status, double debt, int supplier_id)
        {
            this.import_id = import_id;
            this.create_date = create_date;
            this.update_date = update_date;
            this.total_money = total_money;
            this.emp_id = emp_id;
            this.note = note;
            this.status = status;
            this.debt = debt;
            this.supplier_id = supplier_id;
        }
    }
}
