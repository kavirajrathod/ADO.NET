using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Rest
{
    class RestorentDataLayer
    {

        private string connection_string;

        public RestorentDataLayer()
        {
            connection_string = @"Data Source=BLT1054\SQLEXPRESS2014;Initial Catalog=Resto;Integrated Security=True";
        }

        // set restorent data
        public Restorent SetResrorentDetails()
        {
            Restorent rs = new Restorent();
            Console.WriteLine("Enter Id:");
            rs.Resto_name = Console.ReadLine();         

            Console.WriteLine("Enter location:");
            rs.Resto_Address = Console.ReadLine();

            Console.WriteLine("Enter rating 1-5:");
            rs.Rating = Console.ReadLine();

            return rs;

        }

        // insert data
        public void ToInsertRestorentDetails(Restorent r)
        {


            string query = "insert into Restorent values('" + r.Resto_name + "','" + r.Resto_Address + "','" + r.Rating + "')";
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    Console.WriteLine("{0} Rows inserted", command.ExecuteNonQuery());
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        //  return List of restorents 
        public List<Restorent> ToSelectRestorentDetails()
        {
            List<Restorent> rlist = new List<Restorent>();
            string query = "select * from Restorent";
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader sdr = command.ExecuteReader();



                    while (sdr.Read())
                    {
                        Restorent r = new Restorent();
                        r.Resto_name = sdr.GetString(0);
                        r.Resto_Address = sdr.GetString(1);                     
                        r.Rating = sdr.GetString(2);

                        rlist.Add(r);

                    }

                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return rlist;
        }

        // delete data
        public void ToDeleteRestorentDetails()
        {
            Console.WriteLine("Restorent Name ? ");
            string r_name_no = Console.ReadLine();

            string query = "delete from Restorent where Resto_name = '" + r_name_no + "' ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    Console.WriteLine("{0} Rows Deleted", command.ExecuteNonQuery());
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        //  display restorent list
        public void ShowRList(List<Restorent> rlist)
        {
            foreach (Restorent r in rlist)
            {
                Console.WriteLine("{0}\t{1}\t{2}", r.Resto_name, r.Resto_Address, r.Rating);
            }
        }
        //....


        //  search by rname or rid
        public List<Restorent> ToSearchBy()
        {

            List<Restorent> rlist = new List<Restorent>();

            Console.WriteLine("Enter  Name:");
            string Resto_name = Console.ReadLine();

            string query = "select * from Restorent where Resto_name = '" + Resto_name + "' ";
          
            try
            {
                using (SqlConnection connection = new SqlConnection(connection_string))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader sdr = command.ExecuteReader();



                    while (sdr.Read())
                    {
                        Restorent r = new Restorent();
                       
                        r.Resto_name = sdr.GetString(0);
                        r.Resto_Address = sdr.GetString(1);
                        r.Rating = sdr.GetString(2);
                        rlist.Add(r);

                    }

                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return rlist;
        }
    }
}