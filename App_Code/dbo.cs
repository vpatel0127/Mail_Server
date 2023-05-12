using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
public class dbo
{
static    string str;
static SqlConnection con;
static SqlDataAdapter da;
static SqlCommand com;
static DataTable dt;
 public dbo()
	{
        
    }
    public static DataTable getdata(string query)
    {
        str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MailServerDb.mdf;Integrated Security=True";
       
        da = new SqlDataAdapter(query, str);
        dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    public static void setdata(string query)
    {
        str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MailServerDb.mdf;Integrated Security=True";
        con = new SqlConnection(str);
        con.Open();
        com = new SqlCommand(query, con);
        com.ExecuteNonQuery();
    }
        
}