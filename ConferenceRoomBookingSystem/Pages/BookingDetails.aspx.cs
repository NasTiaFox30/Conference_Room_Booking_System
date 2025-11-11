using System;
using System.Web.UI;
using ConferenceRoomBookingSystem.Models;
using ConferenceRoomBookingSystem.Data;

namespace ConferenceRoomBookingSystem.Pages
{
    public partial class BookingDetails : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private void LoadBookingDetails(int bookingId)
        {
            var bookingRepo = new BookingRepository();
            var booking = bookingRepo.GetBookingById(bookingId);

            if (booking == null)
            {
                Response.Redirect("~/Pages/MyBookings.aspx");
                return;
            }

            fvBookingDetails.DataSource = new[] { booking };
            fvBookingDetails.DataBind();

            // Only for future bookings:
            btnCancel.Visible = booking.Status == "Confirmed" &&
                              booking.StartTime > DateTime.Now.AddHours(24);
        }
    }
}