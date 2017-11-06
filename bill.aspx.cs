using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<string> lst;
        List<int> price;
        List<int> quantity;

        lst = (List<string>)Session["names"];
        price = (List<int>)Session["quantity"];
        quantity = (List<int>)Session["prices"];

        TableRow newrow1 = new TableRow();
        tbl.Controls.Add(newrow1);

        TableCell newcell1 = new TableCell();
        newcell1.Text = "DISH NAME";
        newcell1.BorderStyle = BorderStyle.Solid;
        newcell1.BorderStyle = BorderStyle.Double;
        newcell1.BorderWidth = Unit.Pixel(2);
        newrow1.Controls.Add(newcell1);

        TableCell newcell2 = new TableCell();
        newcell2.Text = "QUANTITY";
        newcell2.BorderStyle = BorderStyle.Solid;
        newcell2.BorderStyle = BorderStyle.Double;
        newcell2.BorderWidth = Unit.Pixel(2);
        newrow1.Controls.Add(newcell2);

        TableCell newcell3 = new TableCell();
        newcell3.Text = "PRICE";
        newcell3.BorderStyle = BorderStyle.Solid;
        newcell3.BorderStyle = BorderStyle.Double;
        newcell3.BorderWidth = Unit.Pixel(2);
        newrow1.Controls.Add(newcell3);

        int totprice = 0;
        for (int i=0;i<lst.Count;i++)
        {
            TableRow newrow = new TableRow();
            tbl.Controls.Add(newrow);
            
        TableCell newcell = new TableCell();
            newcell.Text = lst[i];
            newcell.BorderStyle = BorderStyle.Solid;
            newcell.BorderWidth = Unit.Pixel(1);
            newrow.Controls.Add(newcell);

         TableCell newcell12 = new TableCell();
            newcell12.Text = price[i].ToString();
            newcell12.BorderStyle = BorderStyle.Solid;
            newcell12.BorderWidth = Unit.Pixel(1);
            newrow.Controls.Add(newcell12);

         TableCell newcell13 = new TableCell();
            newcell13.Text = (quantity[i]*price[i]).ToString();
            newcell13.BorderStyle = BorderStyle.Solid;
            newcell13.BorderWidth = Unit.Pixel(1);
            totprice += quantity[i] * price[i];
            newrow.Controls.Add(newcell13);

        }

        string s = "TOTAL AMOUNT: " + totprice.ToString();
        l1.Text = s;

        /*
        string st=" ";

        for(int i=0;i<lst.Count;i++)
        {
            st += " "+lst[i]+" ";
            st += price[i] + " ";
            st += quantity[i] + " "; 
        }

        p1.Text = st;
        */
    }
}