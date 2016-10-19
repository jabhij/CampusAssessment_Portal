using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class AdminReg : System.Web.UI.Page
{
    int count = 0;
    int count1 = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Loading the page
        Btnsubmit.Visible = true;
    }
    /// <summary>
    /// It takes admin id as input and checks from the admin_login table
    /// whether the entity is authorised to signup as an admin or not. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Txtid_TextChanged(object sender, EventArgs e)
    {
        //Checking whether the id exists or not
        //Creating connection
        string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con1 = new SqlConnection(strcon);
        con1.Open();
        SqlCommand cmd2 = new SqlCommand("select ADMIN_ID from ADMIN_LOGIN " +
              "where ADMIN_ID = '" + Txtid.Text + "'", con1);
        SqlDataAdapter adap = new SqlDataAdapter(cmd2);
        DataTable dt = new DataTable();
        try
        {
            adap.Fill(dt);
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Null value retreived')", true);
        }

        //To stop the candidate to signup as an admin
            if (dt.Rows.Count == 0)
            {
                count = 1;
                Btnsubmit.Visible = false;
            }
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Wrong Admin ID!!!')", true);
    }

    /// <summary>
    /// Takes the input details of the admin registering and 
    /// stores it in the admin database.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Btnsubmit_Click(object sender, EventArgs e)
    {
        // for inserting using simple sql query
        if(count == 0)
         {
            if (!String.IsNullOrEmpty(Txtname.Text.Trim()) && !String.IsNullOrEmpty(Txtmail.Text.Trim()) && !String.IsNullOrEmpty(Txtid.Text.Trim()))
            {
                // Connecting to the database
                string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(strcon);
                con.Open();

                // providing SQL Query to insert the values into the database
                try
                {
                    SqlCommand cmd2 = new SqlCommand("insert into ADMIN " +
                        "(ADMIN_ID, ADMIN_NAME, ADMIN_PASS, DESIGNATION, EMAIL_ID) " +
                   "values ('" + Txtid.Text + "', '" + Txtname.Text + "', '" + Txtpass.Text + "', '" + Txtdesig.Text + "', '" + Txtmail.Text + "')", con);
                    cmd2.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    count1 = 1;
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
                }

                // Creating session attributes to display the details to profile
                if (count1 == 0)
                {
                    Session.Add("Response5", Txtname.Text);
                    Session.Add("Response7", Txtmail.Text);
                    Session.Add("Response8", Txtid.Text);
                    Session.Add("Response9", Txtdesig.Text);
                    Response.Redirect("AdminPro.aspx");
                }
                else
                {
                    string message = "Existing profile!!!!!";
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.Append("<script type = 'text/javascript'>");
                    sb.Append("window.onload=function(){");
                    sb.Append("alert('");
                    sb.Append(message);
                    sb.Append("')};");
                    sb.Append("</script>");
                    ClientScript.RegisterOnSubmitStatement(this.GetType(), "alert", sb.ToString());
                }
            }
        }
        else
        {
            string message = "Please fill credentials!!!!!";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            Response.Redirect("AdminReg.aspx");
        }
    }
}
