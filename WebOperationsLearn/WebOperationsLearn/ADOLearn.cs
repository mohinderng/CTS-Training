using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebOperationsLearn
{
    public class ADOLearn
    {
        string consta = "";

        public ADOLearn()
        {
            consta = ConfigurationManager.ConnectionStrings["linkstring"].ConnectionString;
         }

        public DataSet GetRecords()
        {
            DataSet d = new DataSet();
            string squery = "Select * From Students";

            try
            {
                using (SqlConnection scon = new SqlConnection(consta))
                {
                    SqlCommand sc = new SqlCommand(squery, scon);
                    SqlDataAdapter sda = new SqlDataAdapter(sc);
                    sda.Fill(d);
                }
            }

            catch(Exception ex)
            {

            }
            return d;
        }
    }
}