using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CogniTask30
{
    public partial class UpdateData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {

            }
        }

        protected void UpdateButton(object sender, EventArgs e)
        {
            ADOLayer obj = new ADOLayer();
            string name;
            int roll;
            roll = int.Parse(TextBox1.Text.ToString());
            name = TextBox2.Text.ToString();

            try
            {
                obj.UpdateData(roll,name);
            }

            catch(Exception ex)
            {

            }
        }
    }
}