using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class readmail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.DataTable dt = dbo.getdata("Select * from mails where Id = '" + Request["t1"] + "'");
        string s = "<table width=100% border =1>";
            System.Data.DataTable dt1 = dbo.getdata("select * from Register where id = '" + dt.Rows[0]["fromid"].ToString() + "'");
            s += "<tr><td>Sender"; 
            s += "<td>" + dt1.Rows[0]["name"] + " " + dt1.Rows[0]["surname"].ToString()+"</tr>";
            s += "<tr><td>Email Id ";
            s += "<td>" + dt1.Rows[0]["username"].ToString();
            s += "</tr><tr><td> Subject ";
            s += "<td>" + dt.Rows[0]["subject"].ToString();
            s += "<tr><td> Message :-";

            s += "<td>" + dt.Rows[0]["detail"].ToString(); ;
            s += "</tR>";
            s += "<tR><td> Message Date :-";
            s += "<td>" + DateTime.Parse(dt.Rows[0]["mdate"].ToString ()).ToShortDateString();
            s += "</tr><tr><td> Attachment ";
            s += "<td><a href='/Mail_Server" + dt.Rows[0]["attach"].ToString() + "'>View</a>";
            s += "</tr>";
            
        s += "</table>";
        s += "<br><h3><a href=Inbox.aspx>Back To Inbox </a></h3>";
        Literal1.Text = s;
    }
}