using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class changpassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Data.DataTable dt = dbo.getdata("select * from Register where Id = '" + Session["uid"].ToString() + "'");
        if (dt.Rows[0]["password"].ToString () != TextBox1.Text)
        {
            Response.Write("<script>alert('Old Password incorrect');</script>");
        }
        else if (TextBox2.Text != TextBox3.Text)
        {
            Response.Write("<script>alert('New Password and Confirm Password Does Not Match');</script>");
        }
        else
        {
            dbo.setdata("update Register set Password ='" + TextBox2.Text + "' where Id = '" + Session["uid"].ToString() + "'");
            Response.Write("<script>alert('Password Changed');window.location='HomePage.aspx'</script>");
        }
    }
}