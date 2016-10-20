using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Collections.Generic;

public partial class Score : System.Web.UI.Page
{
    string institute;

    protected void Page_Load(object sender, EventArgs e)
    {
        // connecting the page with the database
        string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        con.Open();

        // connecting the dropdown list with the database for institute names
        DataTable dt = new DataTable();
        SqlCommand cmd1 = new SqlCommand("select distinct cand_institute from Candidate", con);
        SqlDataAdapter dr = new SqlDataAdapter(cmd1);
        try
        {
            dr.Fill(dt);
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Null value retreived')", true);
        }
        drpDwnInstitute.DataSource = dt;
        drpDwnInstitute.DataValueField = "cand_institute";
        drpDwnInstitute.DataBind();
        institute = drpDwnInstitute.SelectedItem.Text;
    }

    protected void btnShow_Click(object sender, EventArgs e)
    {
        // Connecting to the Database
        string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        con.Open();
        // Providing dat set to store values of table
        DataSet ds1 = new DataSet();
        // Joining tables to access the values 
        SqlCommand cmd3 = new SqlCommand("SELECT CAND_NAME,COUNT(*) AS SCORE" +
        " FROM ENGLISH E" +
        " JOIN CANDIDATE_ANSWER C1 ON(E.Eng_Id = C1.QUES_ID)" +
        " JOIN CANDIDATE C2 ON (C2.ROLL_NO = C1.ROLL_NO)" +
        " WHERE E.answer = C1.ANSWER_OPTED" +
        " AND C2. CAND_INSTITUTE = '" + institute + "' " +
        " GROUP BY CAND_NAME", con);
        SqlDataAdapter adap1 = new SqlDataAdapter(cmd3);
        try
        {
            adap1.Fill(ds1);
        }
        catch (Exception)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Null value retreived')", true);
        }
        Grdscore.DataSource = ds1;
        Grdscore.DataBind();
        con.Close();
    }
    protected void drpDwnInstitute_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}
