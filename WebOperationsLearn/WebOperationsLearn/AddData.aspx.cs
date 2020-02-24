using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace WebOperationsLearn
{
    public partial class AddData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void ButtonCall(object sender, EventArgs e)
        {
            string consta = "";
            consta = ConfigurationManager.ConnectionStrings["linkstring"].ConnectionString;
            string roll, nam, adr;
            roll = TextBox1.Text;
            nam = TextBox2.Text;
            adr = TextBox3.Text;
            try
            {
                using (SqlConnection con = new SqlConnection(consta))
                {
                    con.Open();
                    string query = string.Format("Insert Into Students(RollNo,Name,Addr) values('" + roll + "','" + nam + "','" + adr + "')");
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();

                }
            }
            catch(Exception ee)
            {
                Label4.Text = ee.ToString();
            }

        }
    }
}