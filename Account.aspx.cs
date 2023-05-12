using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            System.Data.DataTable dt = dbo.getdata("select * from Register where Username='" + Session["email"].ToString() + "'");
            TextBox1.Text = dt.Rows[0]["name"].ToString();
            TextBox2.Text = dt.Rows[0]["surname"].ToString();
            TextBox3.Text = dt.Rows[0]["mobile"].ToString();
            TextBox4.Text = dt.Rows[0]["address"].ToString();
            TextBox5.Text = dt.Rows[0]["city"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbo.setdata("update Register set name = '" + TextBox1.Text + "' ,surname= '" + TextBox2.Text + "' ,mobile= '" + TextBox3.Text + "', address = '" + TextBox4.Text + "', city = '" + TextBox5.Text + "' where Id = '" + Session["uid"].ToString() + "'");
        Response.Write("<script>alert('Profile Updated');window.location='HomePage.aspx';</script>");
    }
}