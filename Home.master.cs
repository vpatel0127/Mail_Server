using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class Home : System.Web.UI.MasterPage

{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.DataTable dt = dbo.getdata("select * from Register where Id = '" + Session["uid"].ToString() + "'");
        Image1.ImageUrl = dt.Rows[0]["image"].ToString();
    }
    protected void btnfind_Click(object sender, EventArgs e)
    {
        Response.Redirect("search.aspx?t1=" + txtserch1.Text);
      }
    
}
