using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["NAME"] != null)
        {
            s = Session["NAME"].ToString();
        }
        else
        {
            Response.Redirect("login.aspx");
        }
        if (!IsPostBack)
        {
            l1.Text = "Welcome " + Session["NAME"]+"!";
            l2.Text = "What do you want to do?";
            ddl1.Items.Add("None");
            ddl1.Items.Add("Take Order");
            ddl1.Items.Add("Edit Inventory");
            ddl1.Items.Add("Show Shortage List");
        }
    }



    protected void next_page(object sender, EventArgs e)
    {

        if(ddl1.Text=="Take Order")
        {
            Response.Redirect("order_page.aspx");
        }
        else if(ddl1.Text == "Edit Inventory")
        {
            Response.Redirect("inventory.aspx");
        }
        else if(ddl1.Text == "Show Shortage List")
        {
            Response.Redirect("Shortage_list.aspx");
        }
    }

    protected void b1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
}