using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medicare_project
{
    public partial class appointment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["value"].ToString() == "Cadiology") {
                desc.Text = "Your Appointment is Scheduled on Monday " + " with " + Session["doctor"] + " regarding " + Session["value"];
            }
            if (Session["value"].ToString() == "Optomology") {
                desc.Text = "Your Appointment is Scheduled on Monday " + " with " + Session["doctor"] + " regarding " + Session["value"];
            }
            if (Session["value"].ToString() == "Dermatology")
            {
                desc.Text = "Your Appointment is Scheduled on Monday " + " with " + Session["doctor"] + " regarding " + Session["value"];
            }
        }
    }
}