using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Inbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["delid"] != null)
            dbo.setdata("update mails set status = 'deleted' where id = '" + Request["delid"].ToString() + "'");

        System.Data.DataTable dt = dbo.getdata("Select * from mails where toid = '" + Session["uid"].ToString() + "' and status='open'");
        string s = "<table width=100% border =1>";
        s += "<tr><td>Srno.<td> Sender Email<td>Subject<td>Message<td>Action</tr>";
         for (int i = 0; i < dt.Rows.Count; i++)
        {
            s += "<tr><td>"+(i+1);
            System.Data.DataTable dt1 = dbo.getdata("select * from Register where id = '" + dt.Rows[i]["fromid"].ToString() + "'");
            //s += "<td>" + dt1.Rows[0]["name"] + " " + dt1.Rows[0]["surname"].ToString();
            s += "<td>" + dt1.Rows[0]["username"].ToString();
            s += "<td>" + dt.Rows[i]["subject"].ToString();
            string st = dt.Rows[i]["detail"].ToString();
            st = st.Substring(0, 10) + "....";
            s += "<td>" + st;
        //    s += "<td>" + DateTime.Parse(dt.Rows[i]["mdate"].ToString ()).ToShortDateString();
           // s += "<td><a href='/Mail_Server" + dt.Rows[i]["attach"].ToString() + "'>View</a>";
            s += "<td><a href='Inbox.aspx?delid=" + dt.Rows[i]["Id"].ToString() + "'>Delete</a>";
            s += "<td><a href='readmail.aspx?t1=" + dt.Rows[i]["Id"].ToString() + "'>Read</a>";
            s += "</tr>";
        }
        s += "</table>";
        Literal1.Text = s;
    }
}