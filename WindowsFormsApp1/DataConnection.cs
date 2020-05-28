using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DataConnection
    {
        public static string ConnectionString
        {
            //Ket noi database may chiep
            //get { return @"Data Source=LAB06_PC08;Initial Catalog=QLHHVPP;Persist Security Info=True;User ID=sa;Password =1234$;"; }
            //Ket noi database may Khanh
            get { return @"Data Source=DESKTOP-PK90Q13\SQLEXPRESS;Initial Catalog=QLHHVPP;Persist Security Info=True;User ID=sa;Password =1234$;"; }
            // Ket noi database may Trong
            // get { return @"Data Source=DESKTOP-0GHN5JC\SQLEXPRESS;Initial Catalog=QLHHVPP;Persist Security Info=True;User ID=sa;Password = 1a;"; }
        }
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                return con;
            }
        }
    }
}
