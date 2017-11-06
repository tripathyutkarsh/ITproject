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
        
    }

    protected void gv1_RowDataBound(object sender,GridViewRowEventArgs e)
    {
        if(e.Row.RowType==DataControlRowType.DataRow)
        {
            decimal left = (decimal)DataBinder.Eval(e.Row.DataItem, "Quantity");
            decimal min = (decimal)DataBinder.Eval(e.Row.DataItem, "Min_quantity");
            if(left<min)
            {
                e.Row.BackColor = System.Drawing.Color.Maroon;
                e.Row.Font.Bold = true;
                e.Row.ForeColor = System.Drawing.Color.White;
            }
        }
    }

    protected void gv1_RowDataBound1(object sender, GridViewRowEventArgs e)
    {

    }

    protected void b1_Click(object sender, EventArgs e)
    {
        Response.Redirect("menu_page.aspx");
    }
}