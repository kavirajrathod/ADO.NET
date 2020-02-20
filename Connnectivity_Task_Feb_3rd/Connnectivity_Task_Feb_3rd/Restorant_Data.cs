using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Connnectivity_Task_Feb_3rd
{
    class Restorant_Data
    {


        public static void Insert(Resto rt)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection())
                {
                    cn.Open();
                    string qry = "insert into Restorant values(Resto_name,Resto_Address,Rating)";
                    SqlCommand cmd = new SqlCommand(qry, cn);
                    SqlDataReader sr = cmd.ExecuteReader();

                    
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }
}
