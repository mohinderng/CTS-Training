using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace UpdateData
{
    public partial class WebFormUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {

            }

        }

        protected void Updateit(object sender, EventArgs ex)
        {
            ConData obj = new ConData();
            string roll, adrs;
            roll = TextBox1.Text;
            adrs = TextBox2.Text;

            try
            {
                obj.UpdateData(roll, adrs);
            }

            catch(Exception exex)
            {
                Label3.Text = exex.ToString();
            }
        }
    }
}