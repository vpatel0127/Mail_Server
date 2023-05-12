using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string img = "~/img/"+FileUpload1.FileName.ToString ();
        FileUpload1.SaveAs(Server.MapPath("~/img/")+FileUpload1.FileName);
        dbo.setdata("update Register set image = '" + img + "' where Id = '" + Session["uid"].ToString() + "'");
        Response.Redirect("HomePage.aspx");
    }
}