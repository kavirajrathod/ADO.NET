using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Connnectivity
{
    class Program
    {


        static void Main(string[] args)
        {
            insert();
            /*string constr = @"Data Source=BLT1054\SQLEXPRESS2014;Initial Catalog=EmployeeDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string q = "select * from Course";
                try
                {
                    con.Open();
                    Console.WriteLine("Connected..\n");
                    SqlCommand cmd = new SqlCommand(q, con);
                    SqlDataReader datared = cmd.ExecuteReader();

                    while (datared.Read())
                    {
                        Console.WriteLine("{0}  {1}  {2}  {3}", datared[0], datared[1], datared[2], datared[3]);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }*/
        }



        public static void insert()
        {
            string con = @"Data Source=BLT1054\SQLEXPRESS2014;Initial Catalog=EmployeeDB;Integrated Security=True";
            using (SqlConnection c = new SqlConnection(con))
            {
                string qry = "insert into Emp values(22,'Raviraj','Leader',4)";


                try
                {
                    c.Open();
                    Console.WriteLine("Connected...\n");
                    SqlCommand cmd = new SqlCommand(qry, c);
                    Console.WriteLine("{0} Row Affected:", cmd.ExecuteNonQuery());


                }
                catch (Exception e)
                {
                             Console.WriteLine(e.Message);
                }

            }

        }
    }
}
        
    
