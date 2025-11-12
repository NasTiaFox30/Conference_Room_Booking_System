using System;

namespace ConferenceRoomBookingSystem
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                phAuth.Visible = true;
                phGuest.Visible = false;
                lblUserName.Text = Session["FullName"]?.ToString() ?? Session["Username"]?.ToString();
                AdminLink.Visible = Session["IsAdmin"] != null && (bool)Session["IsAdmin"];
            }
            else
            {
                phAuth.Visible = false;
                phGuest.Visible = true;
                AdminLink.Visible = false;
            }
        }
    }
}