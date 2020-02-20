using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Connect
{
    class Program
    {
        static void Main(string[] args)
        {
            string Connectionstring;
            SqlConnection cnn;
           // SqlConnection sc = new SqlConnection();
            Connectionstring = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=kaviDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            cnn = new SqlConnection(Connectionstring);
            cnn.Open();
            Console.WriteLine("Connected...");
            string q = "select * from Student";
            SqlCommand cm = new SqlCommand(q,cnn);
            SqlDataReader sr = cm.ExecuteReader();

            while (sr.Read())
            {
                Console.WriteLine("{0}    {1}    {2}    {3}", sr[0], sr[1], sr[2], sr[3]);
            }
            cnn.Close();

            Console.ReadKey();


        }
    }
}
