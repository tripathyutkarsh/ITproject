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

    protected void b1_Click(object sender, EventArgs e)
    {
        List<string> lst = new List<string>();
        List<int> qty = new List<int>();
        List<int> price = new List<int>();
        
        foreach (GridViewRow row in gv1.Rows)
        {
            
            CheckBox chk = row.FindControl("cb1") as CheckBox;

            if (chk != null && chk.Checked)
            {
                int quant;
                string st = (row.FindControl("nameofdish") as Label).Text;
                if ((row.FindControl("tb1") as TextBox).Text == "")
                {
                    quant = 0;
                }
                else
                {
                    quant = int.Parse((row.FindControl("tb1") as TextBox).Text);
                }
                int pr = int.Parse((row.FindControl("price") as Label).Text);



                ////////////////////
                
                string con_string = @"Data Source=(localdb)\MSSQLlocalDB; Initial Catalog=restaurant; Integrated Security=SSPI";
                
                string select_sql = "select * from Menu where Dish=@d";
                SqlConnection con2 = new SqlConnection(con_string);
                SqlCommand cmd2 = new SqlCommand(select_sql,con2);
                cmd2.Parameters.AddWithValue("@d", st);
                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                con2.Open();
                adapter1.Fill(ds,"N_menu");
                con2.Close();




                string select_sql3 = "select * from Inventory";
                SqlConnection con3 = new SqlConnection(con_string);
                SqlCommand cmd3 = new SqlCommand(select_sql3,con3);
                SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
                DataSet ds3 = new DataSet();
                con3.Open();
                adapter3.Fill(ds3, "N_inventory");
                con3.Close();




                foreach (DataRow row1 in ds3.Tables["N_inventory"].Rows)
                {
                    string n = (row1["Product_name"].ToString()).Trim();
                    foreach(DataRow row2 in ds.Tables["N_menu"].Rows)
                    {
                        decimal q = decimal.Parse(row2[n].ToString());
                        q *= quant;




                        string con_string5 = @"Data Source=(localdb)\MSSQLlocalDB; Initial Catalog=restaurant; Integrated Security=SSPI";
                        SqlConnection con5 = new SqlConnection(con_string5);
                        string u_cmd = "update Inventory set Quantity=Quantity-@qq where Product_name=@nn";
                        SqlCommand cmd5 = new SqlCommand(u_cmd, con5);
                        cmd5.Parameters.AddWithValue("@qq", q);
                        cmd5.Parameters.AddWithValue("@nn", n);
                        con5.Open();
                        cmd5.ExecuteNonQuery();
                        con5.Close();



                    }
                }

                /////////////////////////////////////


                
                lst.Add(st);
                qty.Add(quant);
                price.Add(pr);
            }
        }

        Session["names"] = lst;
        Session["quantity"] = qty;
        Session["prices"] = price;
        Response.Redirect("bill.aspx");
    
    }
}