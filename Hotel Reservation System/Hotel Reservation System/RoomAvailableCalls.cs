using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
   static class RoomAvailableCalls
    {
        public static IEnumerable Add(DateTime startdate, DateTime enddate) // works out what rooms are free and returns them in a data grid view
        {
            using (var context = new Hotel_Reservation_System())
               
            {
                var bookings = context.Bookings.ToList()
                    .Where(b =>
                        (startdate >= Convert.ToDateTime(b.BookingFrom) &&
                         enddate <= Convert.ToDateTime(b.BookingTo) ||
                         startdate <= Convert.ToDateTime(b.BookingFrom) &&
                         Convert.ToDateTime(b.BookingTo) <= enddate));

                if (bookings != null)
                {
                    var bookingList = bookings.ToList();
                    var theRooms = context.Rooms.ToList();

                    FreeRoomDetails = theRooms;

                    for (var i = 0; i < theRooms.Count; i++)
                    {
                        for (var j = 0; j < bookingList.Count; j++)
                        {
                            if (theRooms[i].RoomID == bookingList[j].RoomIDFK)
                                theRooms.Remove(theRooms[i]);
                        }
                    }

                    var dgvRooms = from r in theRooms
                                   select
                                       new
                                       {
                                           r.RoomID,
                                           r.SingleBeds,
                                           r.DoubleBeds,
                                           r.Tarrif1Person,
                                           r.Tarrif2People,
                                           r.TarrifExtraPerson
                                       };
                    MessageBox.Show("There Are " + Convert.ToInt16(theRooms.Count) + " " + "  Rooms Available");
                    return dgvRooms.ToList();
                }
            }
          return new List<string>();
            
        }

        public static List<Room> FreeRoomDetails; // a list of all the free rooms & their details to be used for pricing

        public static IEnumerable RoomDetails(string Guests, DateTime enddate, DateTime startdate) // works out the cost of each room depending on how many guests are selected
        {
            var inttotaldays = enddate - startdate;
            var days = inttotaldays.Days;
            List<string> roomcosts = new List<string>();
            foreach (var room in FreeRoomDetails)
            {
                int guestsstore = Convert.ToInt16(Guests);
                int doublebeds = Convert.ToInt16(room.DoubleBeds);
                int singlebeds = Convert.ToInt16(room.SingleBeds);
                int price = 0;
                int extrabeds = 2;

                while (doublebeds > 0 && guestsstore >= 2)
                {
                    if (guestsstore == 0)
                    {
                        
                        break;
                    }
                    price += (Convert.ToInt16(room.Tarrif2People) * days);
                    guestsstore -= 2;
                    doublebeds -= 1;
                }

                while (singlebeds > 0)
                {
                    if (guestsstore == 0)
                    {
                        break;
                    }
                    price += (Convert.ToInt16(room.Tarrif1Person) * days);
                    guestsstore -= 1;
                    singlebeds -= 1;
                }
                while (extrabeds > 0)
                {
                    if (guestsstore == 0)
                    {
                        break;
                    }
                    price += (Convert.ToInt16(room.TarrifExtraPerson) * days);
                    guestsstore -= 1;
                    extrabeds -= 1;

                    
                }
                // foreach (var room in FreeRoomDetails)  
                roomcosts.Add(price.ToString());
               

                //  yield return mylbx.Items.Add("$" + price + " " + "Room:" + room.RoomID + " " + guestsstore + " Guests need to stay in another room");
            }
            return roomcosts.ToList();

        }
    }
}
