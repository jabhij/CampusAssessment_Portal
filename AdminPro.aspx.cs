using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using Microsoft.SqlServer.Dts.Runtime;
using System.Configuration.Provider;
using System.Web.Security;

public partial class AdminPro : System.Web.UI.Page
{
    string page;
    /// <summary>
    /// This is the page load event which gathers the response from the
    /// admin registration page and displays that values in this page. 
    /// It shows name, designation, adminid, emailid of admin logged in. 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    protected void Page_Load(object sender, EventArgs e)
    {
        // In Proc session 
        Lbltxt1.Text = Session["Response5"] != null ? Session["Response5"].ToString() : null;
        Lbltxt3.Text = Session["Response9"] != null ? Session["Response9"].ToString() : null;
        Lbltxt4.Text = Session["Response7"] != null ? Session["Response7"].ToString() : null;
        Lbltxt2.Text = Session["Response5"] != null ? Session["Response8"].ToString() : null;
    }

    // Upload and Save options in table 
    // Aptitude Section
    protected void Btnapp_Click(object sender, EventArgs e)
    {
        Application app = new Application();
        Package package = null;
        package = app.LoadPackage(@"C:\Users\abhishekj\Documents\Visual Studio 2008\Projects\CA\CA\Package.dtsx", null);
        DTSExecResult results = package.Execute();
    }

  // Technical Section 
    protected void Btntech_Click(object sender, EventArgs e)
    {
        Application app = new Application();
        Package package = null;
        package = app.LoadPackage(@"C:\Users\abhishekj\Documents\Visual Studio 2008\Projects\CA\CA\Package.dtsx", null);
        DTSExecResult results = package.Execute(); 
    } 

    // English Section 
    protected void Btncom_Click(object sender, EventArgs e)
    {
        Application app = new Application();
        Package package = null;
        package = app.LoadPackage(@"C:\Users\abhishekj\Documents\Visual Studio 2008\Projects\CA\CA\Package.dtsx", null);
        DTSExecResult results = package.Execute();
    }

    protected void Btncreate_Click(object sender, EventArgs e)
    {
        Response.Redirect("paper.aspx");
    }


    //SignOut Option
    protected void SignOut_Click(object sender, EventArgs e)
    {
        string message = "You are logged out. If you want to continue login again";
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("return confirm('");
        sb.Append(message);
        sb.Append("');");
        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        Session.Clear();
        Session.Abandon();
        FormsAuthentication.SignOut();
        Response.Redirect("LogIn.aspx");
    }

    // Score of candidate
    protected void btnScore_Click(object sender, EventArgs e)
    {
        Response.Redirect("Score.aspx");
    }
}
