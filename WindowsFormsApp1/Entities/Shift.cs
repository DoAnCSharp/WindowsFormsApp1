using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Shift
    {
        public int shift_id { get; set; }
        public string name { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public Shift(int shift_id, string name, string start, string end)
        {
            this.shift_id = shift_id;
            this.name = name;
            this.start = start;
            this.end = end;

        }
    }
}
