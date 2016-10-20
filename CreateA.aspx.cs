using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class CreateA : System.Web.UI.Page
{
    string frompage,inst;
    RadioButton RdbA, RdbB, RdbC, RdbD;
    /// <summary>
    /// It takes input of institute name from the previous page and shows 
    /// set of questions regarding that institute in the grid view with the 
    /// four radio buttons generated dynamically for the  options to give 
    /// test. While for admin it simply shows the questions in the grid 
    /// view being selcted for a particular institute.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Page_Load(object sender, EventArgs e)
    {
        // Candidate Option
        candidout.Text = Session["Response1"] != null ? Session["Response1"].ToString() : null;

        inst = Request.QueryString["institute"];
        frompage = Request.QueryString["from"];
        if (frompage == "candidate")
        {
            Txtrow.Visible = false;
            Lblrow.Visible = false;
            Btnsave.Visible = true;
            btnBack.Visible = false;
            //CONNECTING PAGE TO THE DATABASE
            string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            // SHOWING PAPER IN THE GRID VIEW
            DataSet ds3 = new DataSet();
            SqlCommand cmd3 = new SqlCommand("select DISTINCT QUES_ID as QNo, QUESTION, OPT_A as A, OPT_B as B, OPT_C as C, OPT_D as D" +
                " from PAPER P, CANDIDATE C " +
                " where P.INSTITUTE_NAME = C. CAND_INSTITUTE ", con);
            SqlDataAdapter adap3 = new SqlDataAdapter(cmd3);
            try
            {
                adap3.Fill(ds3);
            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Null value retreived')", true);
            }
            Grvassessment1.DataSource = ds3;
            Grvassessment1.DataBind();

            // Providing radio buttons to the option coloumns
            foreach (GridViewRow gvr in Grvassessment1.Rows)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        TableCell tbc = new TableCell();
                        tbc.Text = "A";
                        RadioButton RdbA = new RadioButton();
                        RdbA.ID = "RdbA";
                        tbc.Controls.Add(RdbA);
                        RdbA.Checked = false;
                        gvr.Cells.Add(tbc);
                    }
                    if (i==1)
                    {
                        TableCell tbc = new TableCell();
                        tbc.Text = "B";
                        RadioButton RdbB = new RadioButton();
                        RdbB.ID = "RdbB";
                        tbc.Controls.Add(RdbB);
                        RdbB.Checked = false;
                        gvr.Cells.Add(tbc);
                    }
                    if(i==2)
                    {
                        TableCell tbc = new TableCell();
                        tbc.Text = "C";
                        RadioButton RdbC = new RadioButton();
                        RdbC.ID = "RdbC";
                        tbc.Controls.Add(RdbC);
                        RdbC.Checked = false;
                        gvr.Cells.Add(tbc);
                    }
                    if(i==3)
                    {
                        TableCell tbc = new TableCell();
                        tbc.Text = "D ";
                        RadioButton RdbD = new RadioButton();
                        RdbD.ID = "RdbD";
                        tbc.Controls.Add(RdbD);
                        RdbD.Checked = false;
                        gvr.Cells.Add(tbc);
                    }
                }
            }
        }
        else
        {
            Txtrow.Visible = true;
            Lblrow.Visible = true;
            Btnsave.Visible = false;
            btnBack.Visible = true;
            // displaying the no. of rows
            this.Txtrow.Text = Request.QueryString["count"];

            //CONNECTING PAGE TO THE DATABASE
            string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            // SHOWING PAPER IN THE GRID VIEW
            DataSet ds3 = new DataSet();
            SqlCommand cmd3 = new SqlCommand("select Ques_Id as QNo, Question, Opt_a as A, Opt_b as B, Opt_c as C, Opt_d as D, Institute_name as Institute from PAPER" +
                " where ( INSTITUTE_NAME = '" + inst + "') ", con);
            SqlDataAdapter adap3 = new SqlDataAdapter(cmd3);
            try
            {
                adap3.Fill(ds3);
            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Null value retreived')", true);
            }
            Grvassessment.DataSource = ds3;
            Grvassessment.DataBind();
        }
    }
    /// <summary>
    /// This event reads the gridview and stores the data into a candiadate_answer
    /// table with the radiobutton value clicked by the candidate as opted answer.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Btnsave_Click(object sender, EventArgs e)
    {
        int roll;
        string correct = null;
        roll = Convert.ToInt32(Session["Response2"] != null ? Session["Response2"].ToString() : null);
        foreach (GridViewRow row1 in Grvassessment1.Rows)
        {
            RadioButton RdbA = (RadioButton)(row1.FindControl("RdbA"));
            RadioButton RdbB = (RadioButton)(row1.FindControl("RdbB"));
            RadioButton RdbC = (RadioButton)(row1.FindControl("RdbC"));
            RadioButton RdbD = (RadioButton)(row1.FindControl("RdbD"));   
            RdbA_CheckedChanged(null, null);
            RdbB_CheckedChanged(null, null);
            RdbC_CheckedChanged(null, null);
            RdbD_CheckedChanged(null, null);
            if ((RdbA.Checked) || (RdbB.Checked) || (RdbC.Checked) || (RdbD.Checked))
            {
                if (RdbA.Checked)
                {
                    correct = "A";
                }
                else if (RdbB.Checked)
                {
                    correct = "B";
                }
                else if (RdbC.Checked)
                {
                    correct = "C";
                }
                else if (RdbD.Checked)
                {
                    correct = "D";
                }
            }

            //CONNECTING PAGE TO THE DATABASE
            string strcon = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            //Inserting the selected values into another table
            DataSet ds = new DataSet();
            SqlCommand cmd2 = new SqlCommand("insert into CANDIDATE_ANSWER (QUES_ID, ANSWER_OPTED, ROLL_NO) " +
            "values ('" + row1.Cells[0].Text + "', '" + correct + "', '" + roll + "')", con);

            try
           {
                cmd2.ExecuteNonQuery();
           }

           catch(Exception)
           {
               Console.WriteLine("Try Again!");
           }
            string message = "Thankyou";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }
        Response.Redirect("CandidPro.aspx");
    }

    protected void RdbA_CheckedChanged(object sender, EventArgs e)
    {
        //RdbB.Checked = false;
        //RdbC.Checked = false;
        //RdbD.Checked = false;  
    }
    protected void RdbB_CheckedChanged(object sender, EventArgs e)
    {
            //RdbA.Checked = false;
            //RdbC.Checked = false;
            //RdbD.Checked = false;
    }
    protected void RdbC_CheckedChanged(object sender, EventArgs e)
    {
            //RdbB.Checked = false;
            //RdbA.Checked = false;
            //RdbD.Checked = false;
    }
    protected void RdbD_CheckedChanged(object sender, EventArgs e)
    {
            //RdbB.Checked = false;
            //RdbC.Checked = false;
            //RdbA.Checked = false;
    }

    // Redirecting to Paper page
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Paper.aspx");
    }
    protected void candidout_Click(object sender, EventArgs e)
    {
        Response.Redirect("CandidPro.aspx");
    }
}
