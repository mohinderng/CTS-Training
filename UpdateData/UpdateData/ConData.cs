using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace UpdateData
{
    public class ConData
    {
        string consta = "";

        public ConData()
        {
            consta = ConfigurationManager.ConnectionStrings["conmy"].ConnectionString;
        }

        public void UpdateData(string rollno,string address)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(consta))
                {
                    DataSet ds = new DataSet();
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@rollno",rollno);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.CommandText = "PUpdate";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sds = new SqlDataAdapter(cmd);
                    sds.Fill(ds);
                    sds.Update(ds);

                }
            }

            catch(Exception exx)
            {
            }
        }
    }
}