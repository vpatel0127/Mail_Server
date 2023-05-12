using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["uid"] = 1;
        Session["email"] = "a";
       // Response.Redirect("HomePage.aspx");
    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        System.Data.DataTable dt = dbo.getdata("select * from Register where username = '" + txtuname.Text + "' and password ='" + txtupass.Text + "'");
            if(dt.Rows.Count > 0)
            {
                Session["uid"] = dt.Rows[0]["Id"].ToString ();
                Session["email"] = dt.Rows[0]["username"].ToString ();
                dbo.setdata("insert into login values('" + Session["uid"] + "','" + DateTime.Now.Date + "','" + DateTime.Now.Date + "')");

                Response.Redirect ("~/HomePage.aspx");
            }
    }
}