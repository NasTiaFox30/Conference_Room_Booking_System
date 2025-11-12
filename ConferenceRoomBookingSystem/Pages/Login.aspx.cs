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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var repo = new UsersRepository();
            if (repo.ValidateUser(txtUsername.Text.Trim(), txtPassword.Text))
            {
                var user = repo.GetUserByUsername(txtUsername.Text.Trim());
                Session["UserId"] = user.UserId;
                Session["Username"] = user.Username;
                Session["IsAdmin"] = user.IsAdmin;
                Session["FullName"] = user.FullName;

                Response.Redirect("~/Pages/Default.aspx");
            }
            else
            {
                lblMessage.Text = "Невірний логін або пароль.";
                lblMessage.Visible = true;
            }
        }
    }
}