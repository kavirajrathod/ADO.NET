using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Connnectivity_Task_Feb_3rd
{
    class Program
    {
        static void Main(string[] args)
        {        
            bool e = true;
            Console.WriteLine("##### RESTORANT  #####\n");
           
            do
            {
                Console.WriteLine("1.Show Table:\n2.Add Data To Table:\n3.Delete Data From Table:\n4.Exit:");
                Console.WriteLine("\nEnter Choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        showdata();
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        InsertData();
                        break;

                    case 3:
                        DeleteData();
                        break;

                    case 4:
                        e = false;
                        break;


                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
                
                

            } while (e);
        }

             

        public static void showdata()
        {
            
                string str = @"Data Source=BLT1054\SQLEXPRESS2014;Initial Catalog=Resto;Integrated Security=True";
            try
            {
                using (SqlConnection cn = new SqlConnection(str))
                {
                    cn.Open();
                    string qry = "select Top 1 * from Restorant";
                    SqlCommand cmd = new SqlCommand(qry, cn);
                    SqlDataReader sr = cmd.ExecuteReader();

                    while (sr.Read())
                    {

                        Console.WriteLine("{0}  {1}  {2}", sr[0], sr[1], sr[2]);

                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
                
            }

        

        public static void InsertData()
        {
            string str = @"Data Source=BLT1054\SQLEXPRESS2014;Initial Catalog=Resto;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(str))
                {
                    cn.Open();
                    string qry = "insert into Restorant values('Bholenath','Latur-Maharashtra','3-Star')";
                    SqlCommand cmd = new SqlCommand(qry, cn);

                    Console.WriteLine("{0} Rows Affected", cmd.ExecuteNonQuery());
                    cn.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }


        public static void DeleteData()
        {
            string str = @"Data Source=BLT1054\SQLEXPRESS2014;Initial Catalog=Resto;Integrated Security=True";

            try
            {
                using (SqlConnection cn = new SqlConnection(str))
                {
                    cn.Open();
                    string qry = "delete from Restorant where Resto_name='bholenath'";
                    SqlCommand cmd = new SqlCommand(qry, cn);

                    Console.WriteLine("{0} Rows Affected", cmd.ExecuteNonQuery());
                    cn.Close();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
    }
}
