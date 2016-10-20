using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class paper : System.Web.UI.Page
{
    int i;
    string institute;
    /// <summary>
    /// This event selects the distinct name of institutes from the 
    /// database and display them in the drop down list of GUI page
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //Admin Name
        admPro.Text = Session["Response5"] != null ? Session["Response5"].ToString() : null;

        // connecting the page with the database
        string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        con.Open();

        // connecting the dropdown list with the database for institute names
        DataTable dt = new DataTable();
        SqlCommand cmd1 = new SqlCommand("select distinct cand_institute from candidate", con);
        SqlDataAdapter dr = new SqlDataAdapter(cmd1);
        try
        {
            dr.Fill(dt);
        }
        catch (NullReferenceException)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Null value retreived')", true);
        }
        Drpdwn.DataSource = dt;
        Drpdwn.DataValueField = "cand_institute";
        Drpdwn.DataBind();

        // Selecting one of the institute for a set of questions
            institute = Drpdwn.SelectedItem.Text;

            Btnapp_Click(Btnapp, null);
            Btntech_Click(Btntech, null);
            Btncom_Click(Btncom, null);
            
    }
  
    /// <summary>
    /// Displays the set of questions being stored in the 
    /// database in the table of Technical questions with 
    /// checkboxes to select questions for creating a paper
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Btntech_Click(object sender, EventArgs e)
    {
        i = 1;
        lblTxt1.Text = "Technical";
        Btntech.Visible = false;
        Btncom.Visible = true;
        Btnapp.Visible = true;
        AptView.Visible = false;
        EngView.Visible = false;
        TechView.Visible = true;

        // Providing connectivity with the database
        string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        con.Open();

        // TO Display data in the second grid view
        DataSet ds2 = new DataSet();
        SqlCommand cmd2 = new SqlCommand("select * from TECHNICAL", con);
        SqlDataAdapter adap2 = new SqlDataAdapter(cmd2);
        try
        {
            adap2.Fill(ds2);
        }
        catch (Exception)
        {
            
        }
        TechView.DataSource = ds2;
        TechView.DataBind();
        Btntech.Visible = false;

        // creating checkboxes dynamically in the gridview
        foreach (GridViewRow gvr in TechView.Rows)
        {
            TableHeaderCell thc = new TableHeaderCell();
            thc.Text = "Select";
            TableCell tbc = new TableCell();
            CheckBox chk1 = new CheckBox();
            chk1.ID = "chk1";
            chk1.EnableViewState = true;
            chk1.AutoPostBack = false;
            tbc.Controls.Add(chk1);
            gvr.Cells.Add(tbc);
        }
    }

    /// <summary>
    /// Displays the set of questions being stored in the 
    /// database in the table of Comprehensive questions with 
    /// checkboxes to select questions for creating a paper
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Btncom_Click(object sender, EventArgs e)
    {
        i = 2;
        lblTxt1.Text = "English";
        Btntech.Visible = true;
        Btncom.Visible = false;
        Btnapp.Visible = true;
        AptView.Visible = false;
        TechView.Visible = false;
        EngView.Visible = true;

        // Providing connectivity with the database 
        string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        con.Open();

        // TO display data in the second grid view 
        DataSet ds3 = new DataSet();
        SqlCommand cmd3 = new SqlCommand("select * from ENGLISH", con);

        SqlDataAdapter adap3 = new SqlDataAdapter(cmd3);
        try
        {
            adap3.Fill(ds3);
        }
        catch(Exception)
        { 
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Null value retrieved')", true);
        }
        EngView.DataSource = ds3;
        EngView.DataBind();
        Btncom.Visible = false;

        // creating checkboxes dynamically in the gridview
        foreach (GridViewRow gvr1 in EngView.Rows)
        {
            TableCell tbc = new TableCell();
            CheckBox chk2 = new CheckBox();
            chk2.ID = "chk2";
            chk2.EnableViewState = true;
            chk2.AutoPostBack = false;
            tbc.Controls.Add(chk2);
            gvr1.Cells.Add(tbc);
        }
    }

    /// <summary>
    /// Displays the set of questions being stored in the 
    /// database in the table of Apptitude questions with 
    /// checkboxes to select questions for creating a paper
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Btnapp_Click(object sender, EventArgs e)
    {
        i = 3;
        lblTxt1.Text = "Aptitude";
        Btntech.Visible = true;
        Btncom.Visible = true;
        Btnapp.Visible = false;
        AptView.Visible = true;
        TechView.Visible = false;
        EngView.Visible = false;

        // Providing connectivity with the database
        string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        con.Open();

        // To Display data in the first grid view
        DataSet ds1 = new DataSet();
        SqlCommand cmd1 = new SqlCommand("select * from APTITUDE", con);

        SqlDataAdapter adap1 = new SqlDataAdapter(cmd1);
        try
        {
            adap1.Fill(ds1);
        }
        catch(Exception)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Null value retreived')", true);
        }
        AptView.DataSource = ds1;
        AptView.DataBind();
        Btnapp.Visible = false;

        // creating checkboxes dynamically in the gridview
        foreach (GridViewRow gvr2 in AptView.Rows)
        {
            TableCell tbc = new TableCell();
            CheckBox chk3 = new CheckBox();
            chk3.ID = "chk3";
            chk3.EnableViewState = false;
            chk3.AutoPostBack = false;
            tbc.Controls.Add(chk3);
            gvr2.Cells.Add(tbc);
        }
    }

    /// <summary>
    /// Inserts the rows selcted by the admin for 
    /// creating a paper into a table named paper
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Btnadd_Click(object sender, EventArgs e)
    {
        int count = 0;
        string page = "admin";
        foreach (GridViewRow row in TechView.Rows)
        {
            //Checking for the checkbox that are selected
            CheckBox chk1 = (CheckBox)(row.FindControl("chk1"));
            if ((chk1 != null) && (chk1.Checked))
            {
                count++;
                //Connecting with the database
                string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(strcon);
                con.Open();

                //Inserting the selected values into another table
                DataSet ds = new DataSet();
                SqlCommand cmd2 = new SqlCommand("insert into PAPER (QUES_ID, QUESTION, OPT_A, OPT_B, OPT_C, OPT_D, INSTITUTE_NAME) " +
                "values ('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "', '" + row.Cells[2].Text + "', '" + row.Cells[3].Text + "', '" + row.Cells[4].Text + "', '" + row.Cells[5].Text + "', '" + Drpdwn.SelectedItem.Text + "')", con);
                try
                {
                    cmd2.ExecuteNonQuery();
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Primarykey violation')", true);
                }
            }
        }
        foreach (GridViewRow row in AptView.Rows)
        {
            //Checking for the checkbox that are selected
            CheckBox chk3 = (CheckBox)(row.FindControl("chk3"));
            if ((chk3 != null) && (chk3.Checked))
            {
                count++;

                //Connecting with the database
                string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(strcon);
                con.Open();

                //Inserting the selected values into another table
                DataSet ds = new DataSet();
                SqlCommand cmd2 = new SqlCommand("insert into PAPER (QUES_ID, QUESTION, OPT_A, OPT_B, OPT_C, OPT_D, INSTITUTE_NAME) " +
                "values ('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "', '" + row.Cells[2].Text + "', '" + row.Cells[3].Text + "', '" + row.Cells[4].Text + "', '" + row.Cells[5].Text + "', '" + Drpdwn.SelectedItem.Text + "')", con);
                try
                {
                    cmd2.ExecuteNonQuery();
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Primarykey violation')", true);
                }
            }
        }
        foreach (GridViewRow row in EngView.Rows)
        {
            //Checking for the checkbox that are selected
            CheckBox chk2 = (CheckBox)(row.FindControl("chk2"));
            if ((chk2 != null) && (chk2.Checked))
            {
                count++;

                //Connecting with the database
                string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
                SqlConnection con = new SqlConnection(strcon);
                con.Open();

                //Inserting the selected values into another table
                DataSet ds = new DataSet();
                SqlCommand cmd2 = new SqlCommand("insert into PAPER (QUES_ID, QUESTION, OPT_A, OPT_B, OPT_C, OPT_D, INSTITUTE_NAME) " +
                "values ('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "', '" + row.Cells[2].Text + "', '" + row.Cells[3].Text + "', '" + row.Cells[4].Text + "', '" + row.Cells[5].Text + "', '" + Drpdwn.SelectedItem.Text + "')", con);
                try
                {
                    cmd2.ExecuteNonQuery();
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Primarykey violation')", true);
                }
            }
        }
        Response.Redirect("CreateA.aspx?count=" + count + "&page=" + page + "&institute=" + institute);
    }

    // Admin Profile access
    protected void admPro_Click(object sender, EventArgs e)
    {
        Response.Redirect("AdminPro.aspx");
    }
}
