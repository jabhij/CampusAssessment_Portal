using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class CandidReg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Loading page
    }

    /// <summary>
    /// Takes the input details of the candidate registering and 
    /// stores it in the candidate database.The inputs are name, 
    /// roll no, password, jee rank, institute name, branch and email id
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Btnsubmit_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(Txtname.Text.Trim()) && !String.IsNullOrEmpty(Txtmail.Text.Trim()) && !String.IsNullOrEmpty(Txtroll.Text.Trim()))
        {
            // for inserting using simple sql query
            string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            DataSet ds = new DataSet();

            //Inserting values into the table
            SqlCommand cmd2 = new SqlCommand("insert into candidate (cand_name, roll_no, cand_pass, jee_rank, cand_institute, branch, cand_mail) " +
            "values ('" + Txtname.Text + "', '" + Convert.ToString(Txtroll.Text) + "', '" + Txtpass.Text + "', '" + Convert.ToString(Txtjee.Text) + "', '" + Txtinst.Text + "', '" + Txtbranch.Text + "', '" + Txtmail.Text + "')", con);
            cmd2.ExecuteNonQuery();
        }

        //Creating session attributes
        Session.Add("Response1", Txtname.Text);
        Session.Add("Response2", Txtroll.Text);
        Session.Add("Response3", Txtjee.Text);
        Session.Add("Response4", Txtinst.Text);
        Response.Redirect("CandidPro.aspx");
    }
}
