
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExternalDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {

                con = new SqlConnection(@"Data Source=BLT1046\SQLEXPRESS2014;Initial Catalog=School1;Integrated Security=True");
                con.Open();

                SqlCommand cm1 = new SqlCommand("Select * From Students",con);
                SqlDataReader rd = cm1.ExecuteReader();

                while(rd.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}",rd[0],rd[1],rd[2]);
                }
            }

            catch(Exception e)
            {
                Console.WriteLine("Something went wrong");
            }

            finally
            {
                con.Close();
            }
        }
    }
}
