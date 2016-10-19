using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class CandidPro : System.Web.UI.Page
{
    /// <summary>
    /// This is the page load event which gathers the response from the
    /// candidate registration or login page and displays that values in this page. 
    /// It shows name, roll no., jee rank, emailid of candidate logged in. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // getting session values and displaying them. Also, performing for null exception
        Lbltxt1.Text = Session["Response1"] != null ? Session["Response1"].ToString() : null;
        Lbltxt2.Text = Session["Response2"] != null ? Session["Response2"].ToString() : null;
        Lbltxt3.Text = Session["Response3"] != null ? Session["Response3"].ToString() : null;
        Lbltxt4.Text = Session["Response4"] != null ? Session["Response4"].ToString() : null;
    }
    /// <summary>
    /// It redirects the candidate to give assessment on 
    /// CreateA.aspx page with its roll no.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Btnassessment_Click(object sender, EventArgs e)
    {
        string page;
        page = "candidate";
        Response.Redirect("CreateA.aspx?from=" + page);
    }

    // SingOut Option for Candidate
    protected void SignOut_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        FormsAuthentication.SignOut();       
        Response.Redirect("LogIn.aspx");
    }
}
