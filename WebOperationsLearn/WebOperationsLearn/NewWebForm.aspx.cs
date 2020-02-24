using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOperationsLearn
{
    public partial class NewWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                ADOLearn ad = new ADOLearn();
                var stlist = ad.GetRecords();
                GridView2.DataSource = stlist;
                GridView2.DataBind();

            }
        }
    }
}