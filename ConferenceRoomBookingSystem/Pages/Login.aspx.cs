using System;
using System.Web.UI;
using ConferenceRoomBookingSystem.Data;

namespace ConferenceRoomBookingSystem.Pages
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session["UserId"] != null)
                Response.Redirect("~/Pages/Default.aspx");
        }
    }
}