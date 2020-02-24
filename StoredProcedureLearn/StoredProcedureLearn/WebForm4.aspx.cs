using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoredProcedureLearn
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
            }

        }

        protected void Clickme(object sender, EventArgs exx)
        {

            DataCon obj = new DataCon();

            string roll, name, addr;
            roll = TextBox1.Text.ToString();
            name = TextBox2.Text.ToString();
            addr = TextBox3.Text.ToString();

            try
            {

                obj.InsertData(roll, name, addr);
            }
            catch (Exception eee) { Label4.Text = eee.ToString(); }
        }
    }
}