using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CogniTask30
{
    public class ADOLayer
    {
        string consta = "";

        public ADOLayer()
        {
            consta = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }

        public DataSet GetRecords()
        {
            DataSet d = new DataSet();
            string squery = "Select * From Student";

            try
            {
                using (SqlConnection scon = new SqlConnection(consta))
                {
                    SqlCommand cmd = new SqlCommand(squery,scon);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(d);
                    sda.Update(d);
                }
            }

            catch (Exception e)
            {

            }
            return d;
        }

        public void InsertData(string id,string name,string addr)
        {
            try
            {
                using (SqlConnection scon = new SqlConnection(consta))
                {
                    DataSet ds = new DataSet();
                    scon.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd.Parameters.AddWithValue("@id",id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@add", addr);
                    cmd.Connection = scon;
                    cmd.CommandText = "Procedure";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }

            catch(Exception ee)
            {

            }
        }

        public void UpdateData(int rollno,string address)
        {
            try
            {
                using (SqlConnection scon = new SqlConnection(consta))
                {
                    DataSet dd = new DataSet();
                    scon.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@id", rollno);
                    cmd.Parameters.AddWithValue("@addr", address);
                    cmd.Connection = scon;
                    cmd.CommandText = "Update";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dd);
                    sda.Update(dd);
                }
            }
            catch (Exception exe)
            {

            }
            }
        }
    }
