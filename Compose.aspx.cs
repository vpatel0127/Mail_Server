using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Compose : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.DataTable dt = dbo.getdata("select * from contact where myid = '" + Session["uid"].ToString() + "'");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            System.Data.DataTable dt1 = dbo.getdata("select * from Register where Id = '" + dt.Rows[i]["friendid"].ToString () + "'");

            DropDownList1.Items.Add (dt1.Rows[0]["username"].ToString ());
            DropDownList1.Items[i].Value = dt1.Rows[0]["id"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string img ="";
        if (FileUpload1.FileName != "")
        {
            img = "~/attach/" + FileUpload1.FileName.ToString();
            FileUpload1.SaveAs(Server.MapPath("attach/") + FileUpload1.FileName);
        }
        DateTime str = DateTime.Now.Date;
        string s = str.Year+"-"+str.Month+"-"+str.Day;
        dbo.setdata("insert into mails values('" + Session["uid"].ToString() + "','" + DropDownList1.SelectedValue.ToString() + "','" + TextBox1.Text + "' , '" + TextBox2.Text + "','" + s + "','open','" + img + "')");
        dbo.setdata("insert into attachments values('" + Session["uid"].ToString() + "','" + img + "')");
        Response.Write("<script>alert('Mail Sent');window.location='HomePage.aspx'</script>");

    }
}