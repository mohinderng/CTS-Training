using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace StoredProcedureLearn
{
    public class DataCon
    {
        string constr = "";
        public DataCon()
        {
            constr = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        }

        public void InsertData(string rn,string n,string ad)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {

                    DataSet ds = new DataSet();
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@rollno", rn);
                    cmd.Parameters.AddWithValue("@name", n);
                    cmd.Parameters.AddWithValue("@adr", ad);
                    cmd.CommandText = "PrInsert";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter asd = new SqlDataAdapter(cmd);
                    asd.Fill(ds);
                    asd.Update(ds);
                }
            }

            catch(Exception ex)
            {
              
            }
        }
    }
}