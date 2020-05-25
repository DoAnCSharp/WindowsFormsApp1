using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;
using Dapper;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller
{
    public class ProductDAO
    {
        public List<Product> GetProduct(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("QLHHVPP")))
            {
                var output = connection.Query<Product>($"SELECT * FROM Product WHERE Name = '{name}'").ToList();
                return output;
            }
        }
    }
}
