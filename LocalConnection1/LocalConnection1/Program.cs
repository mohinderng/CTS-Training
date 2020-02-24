using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LocalConnection1
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Mohinder;
                            Integrated Security=True;Connect Timeout=30;Encrypt=False;
                            TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    string querystring = "select * from Student";
                    SqlCommand cmd = new SqlCommand(querystring, con);


                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader[0], reader[1], reader[2],reader[3],reader[4]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        }
    }


