using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void reguser(object sender, EventArgs e)
    {
        Response.Redirect("reguser.aspx");
    }

    protected void login(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
}