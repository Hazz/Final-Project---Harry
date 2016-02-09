using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
   internal static class CheckInandOutCalls
    {
        public static void InsertCheckin(int bookingid) // Inserts all details into the database when create booking is clicked
        {
            using (var context = new Hotel_Reservation_System())
            {
                var checkin = from b in context.Bookings where b.BookingID == bookingid select b;
       
                var booking = checkin.FirstOrDefault();

                if (booking.BookingFrom == DateTime.Today.ToString("dd/MM/yyyy"))
                {
 
                    booking.CheckedIn = DateTime.Now.ToString("dd/MM/yyyy");
                    context.SaveChanges();
                }
                if (DateTime.Today > Convert.ToDateTime(booking.BookingFrom))
                {
                    MessageBox.Show("Guests arrived too late, Please make a new booking.");
                    //you cannot checkin Late
                }

                if (DateTime.Today < Convert.ToDateTime(booking.BookingFrom))
                    MessageBox.Show("Please Come back on " + booking.BookingFrom + " You Can't check in Guests early!");
                //you cannot check in early
            }
        }

       public static void InsertCheckOut(int roomcharge) // inserts checkout date into the booking table of the database on click of checkout
       {
           using (var context = new Hotel_Reservation_System())
           {
               var roomcost = from b in context.Bookings where b.RoomCost == roomcharge.ToString() select b;

               var booking = roomcost.FirstOrDefault();
               if (booking.BookingTo == DateTime.Today.ToString("dd/MM/yyyy"))
               {
                   booking.CheckedOut = DateTime.Today.ToString("dd/MM/yyyy");
                   context.SaveChanges();
                   MessageBox.Show("Guest Sucessfully Checked out! :D");

               }
               if (DateTime.Today < Convert.ToDateTime(booking.BookingTo))
               {
                   MessageBox.Show("You Cannot Check guests out early, please go and change the BookingTo date in Guests and Booking");
               }
                if (DateTime.Today > Convert.ToDateTime(booking.BookingTo))
                {
                   MessageBox.Show("Guests over stayed please create a new booking for the extra nights");
               }
           }
       }

       public static void InsertBilling(int GuestID, int Wifi, int Bar, int Room, int Total)// inserts all the costs into the billing table of the database on the click of checkout
       {
           using (var context = new Hotel_Reservation_System())
           {
               var billing = new Billing();

               billing.GuestIDFK = GuestID;
               billing.WifiCharge = Wifi;
               billing.BarCharge = Bar;
               billing.RoomCharge = Room;
               billing.TotalCharge = Total;
               context.Billings.Add(billing);
               context.SaveChanges();

           }
       }
    }
}
