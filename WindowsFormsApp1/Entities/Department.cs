using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Department
    {
        public int department_id { get; set; }
        public string name { get; set; }
        public Department(int department_id, string name)
        {
            this.department_id = department_id;
            this.name = name;
        }
    }
}
