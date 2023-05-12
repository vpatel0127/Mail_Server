using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.DataTable dt = dbo.getdata("Select * from Register");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if(dt.Rows[i]["Id"].ToString() == Session["uid"].ToString())
                continue;
            System.Data.DataTable dt1 = dbo.getdata("Select * from contact where myid = '" +Session["uid"].ToString ()+"' and friendid = '" + dt.Rows[i]["Id"].ToString ()+"'");
            if (dt1.Rows.Count > 0)
                continue;
            CheckBoxList1.Items.Add(dt.Rows[i]["username"].ToString());
            
          //  CheckBoxList1.Items[i].Value = dt.Rows[i]["Id"].ToString();

            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        for(int i = 0; i < CheckBoxList1.Items.Count;i++)
        {
            if (CheckBoxList1.Items[i].Selected)
            {
                System.Data.DataTable dt = dbo.getdata("Select * from Register where username = '" + CheckBoxList1.Items[i].Text + "'");

                dbo.setdata("insert into contact values('" + Session["uid"].ToString() + "','" + dt.Rows[0]["Id"].ToString () + "')");
            }
        }
        Response.Redirect("HomePage.aspx");    
    }
}