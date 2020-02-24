using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }

        public void Connecting()
        {
            using (

                     SqlConnection con = new SqlConnection("data source =.;database = School1; integrated security = SSPI")
                )
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
        }
    }
}
