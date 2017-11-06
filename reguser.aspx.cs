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

    protected void Createuser(object sender, EventArgs e)
    {
        if(Page.IsValid)
        {
            string con_string = @"Data Source=(localdb)\MSSQLlocalDB; Initial Catalog=restaurant; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(con_string);
            string cmd1 = "select * from waiter_details";
            SqlCommand c = new SqlCommand(cmd1, con);
            con.Open();
            SqlDataReader rd = c.ExecuteReader();
            while(rd.Read())
            {
                if(rd["Id"].ToString()==tb4.Text)
                {
                    warning.Text = "THIS ID IS ALREADY PRESENT";
                    return;
                }
            }
            con.Close();




            string ins_cmd = "insert into waiter_details (Id,Name,Password) values (@iden,@names,@pwd)";
            SqlCommand cmd = new SqlCommand(ins_cmd, con);
            cmd.Parameters.AddWithValue("@iden",tb4.Text);
            cmd.Parameters.AddWithValue("@names", tb1.Text);
            cmd.Parameters.AddWithValue("@pwd", tb2.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Default.aspx");
        }
    }
}