using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void user_login(object sender, EventArgs e)
    {
        string con_string = @"Data Source=(localdb)\MSSQLlocalDB; Initial Catalog=restaurant; Integrated Security=SSPI";
        SqlConnection con = new SqlConnection(con_string);
        string read_cmd = "select Id,Name,Password from waiter_details";
        SqlCommand cmd = new SqlCommand(read_cmd, con);
        con.Open();
        SqlDataReader reader = cmd.ExecuteReader();
        int f = 0;
        while(reader.Read())
        {
            if(tb1.Text==(string)reader["Name"] && tb2.Text==(string)reader["Password"])
            {
                f = 1;
                break;
            }
        }

        if(f==1)
        {
            Session["NAME"] = tb1.Text;
            Response.Redirect("menu_page.aspx");
        }
        else
        {
            lb3.Text = "WRONG USERNAME OR PASSWORD";
        }
        con.Close();
    }
}