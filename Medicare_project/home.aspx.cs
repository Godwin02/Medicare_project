using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medicare_project
{
    public partial class home : System.Web.UI.Page
    {
        List<string> card = new List<string> { "Sasi", "Ramanan", "suseela" };
        List<string> opt = new List<string> { "Ramu", "Venu", "Ravi" };
        List<string> derm = new List<string> { "Zacharias", "Godwin", "Sriram" };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["value"] = DropDownList1.SelectedItem;
            Session["doctor"] = DropDownList2.SelectedValue;
            Response.Redirect("appointment.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((DropDownList1.SelectedValue) == "1")
            {
                DropDownList2.Items.Clear();
                foreach(string i in card)
                {
                    DropDownList2.Items.Add(new ListItem(i));

                }
            }
            if ((DropDownList1.SelectedValue) == "2")
            {
                DropDownList2.Items.Clear();
                foreach (string i in opt)
                {
                    DropDownList2.Items.Add(new ListItem(i));

                }
            }
            if ((DropDownList1.SelectedValue) == "3")
            {
                DropDownList2.Items.Clear();
                foreach (string i in derm)
                {
                    DropDownList2.Items.Add(new ListItem(i));

                }
            }
        }
    }
}