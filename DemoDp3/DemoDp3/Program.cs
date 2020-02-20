using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DemoDp3
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void show()
        {
            try
            {
                string constr = @"Data Source=BLT1054\SQLEXPRESS2014;Initial Catalog=DemoDp;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(constr))
                {
                    string qr = "select *from EmployeeDp";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qr, con);
                    SqlRead ada = cmd.ExecuteReader();
                    
                }
            }
        }
    }
}
