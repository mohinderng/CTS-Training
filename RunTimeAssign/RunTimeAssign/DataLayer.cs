using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RunTimeAssign
{
    class DataLayer
    {
        public SqlConnection con;
       public DataLayer()
        {
            try {
               con = new SqlConnection(@"Data Source = BLT1046\SQLEXPRESS2014; Initial Catalog = Restaurant; Integrated Security = True");
                con.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            }
        public void GetData()
        {
            Console.WriteLine("Enter Reg No.");
            string g = Console.ReadLine();
            Console.WriteLine("Enter Restaurant Name");
            string n = Console.ReadLine();
            Console.WriteLine("Enter Restaurant Location");
            string l = Console.ReadLine();
            Console.WriteLine("Enter Cuisine Type");
            string c = Console.ReadLine();

            string sttr = string.Format("Insert Into Restaurant(RegNo,Name,Location,Cuisine) Values({0},{1},{2},{3})",g,n,l,c);

            SqlCommand cd = new SqlCommand(sttr,con);
            cd.ExecuteNonQuery();
              
        }

    }
}
