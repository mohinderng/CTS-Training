using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CogniTask30
{
    public partial class AddData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {

            }
        }

        protected void ButtonCall(object sender, EventArgs e)
        {
            ADOLayer obj = new ADOLayer();

            string roll, name, addr;
            roll = TextBox1.Text.ToString();
            name = TextBox2.Text.ToString();
            addr = TextBox3.Text.ToString();

            try
            {
                obj.InsertData(roll, name, addr);
            }

            catch(Exception eee)
            {

            }
        }
    }
}