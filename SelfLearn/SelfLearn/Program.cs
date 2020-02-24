using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SelfLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source = BLT1046\SQLEXPRESS2014; Initial Catalog = Restaurant; Integrated Security = True");
            //SqlCommand cmd = new SqlCommand("Insert Into Menu(FoodId,Name,Price,RegNo) Values(9,'Momos',50,'RES1001')",con);
            SqlCommand cmd1 = new SqlCommand("Select * From Menu",con);
            con.Open();
            //cmd.ExecuteNonQuery();
            cmd1.ExecuteReader();
        }
    }
}
