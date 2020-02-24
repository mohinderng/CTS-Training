using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CogniTask30
{
    public partial class NewForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                ADOLayer ad = new ADOLayer();
                var stlist = ad.GetRecords();
                GridView1.DataSource = stlist;
                GridView1.DataBind();
            }
        }
    }
}