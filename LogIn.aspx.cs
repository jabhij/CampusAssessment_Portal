using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class LogIn : System.Web.UI.Page
{
    int a;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Loading page
    }
    /// <summary>
    /// It takes the data from the textbox at GUI and checks by mapping 
    /// the values to the database to authenticate the user of the page
    /// for admin by table admin.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Btnlogin_Click(object sender, EventArgs e)
    {
        if ((!String.IsNullOrEmpty(Txtid.Text.Trim())) && (!String.IsNullOrEmpty(Txtpass.Text.Trim())))
        {

            //Connecting to the Database
            string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            DataTable dt1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand("SELECT ADMIN_ID, ADMIN_PASS, ADMIN_NAME, DESIGNATION, EMAIL_ID " +
                "FROM ADMIN where ADMIN_ID ='" + Txtid.Text + "'" +
                "and ADMIN_PASS ='" + Txtpass.Text + "'", con);
            SqlDataAdapter adap1 = new SqlDataAdapter(cmd1);
            adap1.Fill(dt1);
            a = dt1.Rows.Count;
           if (a != 0)
            {
                foreach (DataRow dr1 in dt1.Rows)
                {

                    // Session for Admin
                    Session.Add("Response5", dr1["admin_name"]);
                    Session.Add("Response8", dr1["admin_id"]);
                    Session.Add("Response9", dr1["designation"]);
                    Session.Add("Response7", dr1["email_id"]);
                    Response.Redirect("AdminPro.aspx");
                }
            }
               
               // Applying validation
            else
            {
                string message = "Please fill correct entries!!!!!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }
        }

        else
        {
            // Alert Messages
            if ((String.IsNullOrEmpty(Txtid.Text.Trim())) && String.IsNullOrEmpty(Txtpass.Text.Trim()))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please enter the credentials')", true);
            }
            else if (String.IsNullOrEmpty(Txtid.Text.Trim()))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill admin id')", true);
            }
            else if (String.IsNullOrEmpty(Txtpass.Text.Trim()))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please enter the password')", true);
            }
        }
    }


    /// <summary>
    /// It takes the data from the textbox at GUI and checks by mapping 
    /// the values to the database to authenticate the user of the page
    /// for candidate by table candidate.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Btnlogin1_Click(object sender, EventArgs e)
    {
        if ((!String.IsNullOrEmpty(Txtroll.Text.Trim())) && (!String.IsNullOrEmpty(Txtname.Text.Trim())))
        {

            //Connecting to the database
            string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            DataTable dt2 = new DataTable();
            SqlCommand cmd2 = new SqlCommand("SELECT CAND_NAME, CAND_PASS, ROLL_NO, JEE_RANK, CAND_INSTITUTE " +
                " FROM CANDIDATE where ROLL_NO ='" + Txtroll.Text + "'" +
                "and CAND_PASS ='" + Txtname.Text + "'", con);
            SqlDataAdapter adap2 = new SqlDataAdapter(cmd2);
            adap2.Fill(dt2);
            a = dt2.Rows.Count;
            if (a != 0)
            {
                // Session for candidate
                foreach (DataRow dr2 in dt2.Rows)
                {
                    Session.Add("Response1", dr2["CAND_NAME"]);
                    Session.Add("Response2", dr2["ROLL_NO"]);
                    Session.Add("Response4", dr2["CAND_INSTITUTE"]);
                    Session.Add("Response3", dr2["JEE_RANK"]);
                    Response.Redirect("CandidPro.aspx");
                }
            }

                //Alert message
            else
            {
                string message = "Please fill correct entries!!!!!";
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload=function(){");
                sb.Append("alert('");
                sb.Append(message);
                sb.Append("')};");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
            }
        }

            //Alert messages
        else
        {
            if ((String.IsNullOrEmpty(Txtroll.Text.Trim())) && String.IsNullOrEmpty(Txtname.Text.Trim()))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please enter the credentials')", true);
            }
            else if (String.IsNullOrEmpty(Txtroll.Text.Trim()))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please fill roll no.')", true);
            }
            else if (String.IsNullOrEmpty(Txtname.Text.Trim()))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('please enter the password')", true);
            }
        }
    }
}
