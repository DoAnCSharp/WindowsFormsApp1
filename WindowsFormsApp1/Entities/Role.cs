using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Role
    {
        public int role_id { get; set; }
        public string name { get; set; }
        public Role(int role_id, string name)
        {
            this.role_id = role_id;
            this.name = name;

        }

    }
}
