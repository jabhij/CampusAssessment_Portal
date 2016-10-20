using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{

    /// <summary>
    /// In this load event of master page we applied cache-clear functionality 
    /// For not holding rough data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
    }
}
