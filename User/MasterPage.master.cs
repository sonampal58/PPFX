﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string str = Session["ADMIN"].ToString();
           
        }
        catch (Exception) { Response.Redirect("../Admin_login.aspx"); }
    }
}