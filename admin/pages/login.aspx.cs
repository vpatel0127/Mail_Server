using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_pages_login : System.Web.UI.Page
{
  
    protected void Unnamed3_Click(object sender, EventArgs e)
    {
        System.Data.DataTable dt = dbo.getdata("select * from admin where username = '" + t1.Text + "' and password = '" + t2.Text + "'");
        if (dt.Rows.Count > 0)
        {
            Response.Redirect("~/admin/pages/Home.aspx");
        }
    }
}