using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    internal static class DatabaseCalls
    {

        public static IEnumerable BookingandGuests() // displays Guest + booking details from the database in the Guests + Booking Form
        {
            using (var context = new Hotel_Reservation_System())
            {
                var bookingandguests = from b in context.Bookings
                    join g in context.Guests
                        on b.BookingID equals g.BookingIDFK
                    where b.CheckedOut == null
                    select new
                    {
                        g.GuestID,
                        g.Name,
                        g.Email,
                        b.BookingID,
                        b.NumOfGuests,
                        b.RoomBooked,
                        b.BookingFrom,
                        b.BookingTo,
                        b.RoomCost,
                        b.CheckedIn

                    };

                return bookingandguests.ToList();

            }
        }

        public static IEnumerable GuestandBookingHistory() // displays the history of who has checked out in the history Form
        {
            using (var context = new Hotel_Reservation_System())
            {
                var history = from h in context.HistoryViews
                              where h.BookingFrom == h.CheckedIn
                    select h;
                return history.ToList();
            }
           
        } 
        public static IEnumerable CurrentNotCheckedIn() // displays created booking that havnt yet checked in in a DGV on the reservations form
        {
            using (var context = new Hotel_Reservation_System())
            {
                var Notcheckedin = from b in context.Bookings
                    join g in context.Guests
                        on b.BookingID equals g.BookingIDFK
                    where b.CheckedIn == null
                    select
                        new
                        {

                            g.Name,
                            g.Email,
                            b.BookingID,
                            b.NumOfGuests,
                            b.RoomBooked,
                            b.BookingFrom,
                            b.BookingTo,
                            b.CheckedIn
                        };
                return Notcheckedin.ToList();
            }
        }

        public static IEnumerable CurrentCheckedIn() // displays booking that have check in entered in a DGV on the reservations Form
        {
            using (var context = new Hotel_Reservation_System())
            {
                var CurrentCheckedin = from b in context.Bookings
                    join g in context.Guests
                        on b.BookingID equals g.BookingIDFK
                    where b.CheckedOut == null && b.CheckedIn != null
                    select
                        new
                        {
                            g.GuestID,
                            g.Name,
                            g.Email,
                            b.NumOfGuests,
                            b.RoomBooked,
                            b.BookingFrom,
                            b.BookingTo,
                            b.RoomCost,
                            b.CheckedIn
                        };
                return CurrentCheckedin.ToList();
            }
        }

        public static IEnumerable Rooms() // displays the list of rooms in the Rooms Form
        {
            using (var context = new Hotel_Reservation_System())
            {
                var rooms = from r in context.Rooms
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

                return rooms.ToList();
            }
        }

        public static void InsertGuest(string FN, string LN, string Email, int bookingIDFK)
            // inserts guests details into database on click of Create Booking
        {
            using (var context = new Hotel_Reservation_System())
            {
                var Guests = new Guest();


                Guests.Name = FN + " " + LN;
                Guests.Email = Email;
                Guests.BookingIDFK = bookingIDFK;
                context.Guests.Add(Guests);
                context.SaveChanges();
                MessageBox.Show("Booking Successfully Created!");
            }
        }

        public static int InsertBookings(string BookingDate, string BookFrom, string BookTo, string Room, string Guests, string Cost)
            // inserts the guests booking details into the database on click of Create Booking
        {
            using (var context = new Hotel_Reservation_System())
            {
                var Bookings = new Booking();


                Bookings.BookingDate = BookingDate;
                Bookings.BookingFrom = BookFrom;
                Bookings.BookingTo = BookTo;
                Bookings.RoomIDFK = Convert.ToInt16(Room);
                Bookings.RoomBooked = Room;
                Bookings.NumOfGuests = Guests;
               Bookings.RoomCost = Cost;
                context.Bookings.Add(Bookings);
                context.SaveChanges();
                return Bookings.BookingID;
            }
        }



        public static void UpdateGuests(string Name, string Email, int GuestID) // Update Guests part of CRUD 
        {
            using (var context = new Hotel_Reservation_System())
            {
                var UpdateGuests = from g in context.Guests
                        where g.GuestID == GuestID
                    select g;
                var guests = UpdateGuests.FirstOrDefault();

                    guests.Name = Name;
                    guests.Email = Email;
                context.SaveChanges();

            }
        }

        public static void UpdateBookings(string Room, string Guests,string BookingFrom, string BookingTo, int BookingID) // Update Booking part of CRUD
        {
            using (var context = new Hotel_Reservation_System())
            {
                var UpdateBookings = from b in context.Bookings
                                   where b.BookingID == BookingID
                                   select b;
                var bookings = UpdateBookings.FirstOrDefault();

                bookings.RoomBooked = Room;
                bookings.NumOfGuests = Guests;
                bookings.BookingFrom = BookingFrom;
                bookings.BookingTo = BookingTo;
                context.SaveChanges();

            }
        }
        public static void DeleteGuest(string Name) // Delete Guest Part of CRUD
        {
            var namedelete = Name;

            if (
                MessageBox.Show("Do you REALLY want to delete " + namedelete + "?", "Delete Record",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                using (var context = new Hotel_Reservation_System())
                {
                    var name = Name;
                    var Guest = (from g in context.Guests where g.Name == name select g).SingleOrDefault();

                    context.Guests.Remove(Guest);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Guest has already been deleted or another error has occured");
               
            }
        }
        public static void DeleteBooking(int ID) // Delete Booking Part of CRUD
        {
            try
            {
                using (var context = new Hotel_Reservation_System())
                {
                    int BookingID = ID;
                    var Booking = (from b in context.Bookings where b.BookingID == BookingID select b).SingleOrDefault();

                    context.Bookings.Remove(Booking);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Booking has already been deleted or another error has occured");

            }
        }

        public static void AddRoom(string roomID, string SingleBeds, string DoubleBeds, string Tarrif1person, string Tarrif2People, string TarrifExtraPerson)
            // Adds a room on click of add Button in the Rooms Form as long as all text boxes are full
        {
            using (var context = new Hotel_Reservation_System())
            {
                var rooms = new Room();
                rooms.RoomID = Convert.ToInt32(roomID);
                rooms.SingleBeds = SingleBeds;
                rooms.DoubleBeds = DoubleBeds;
                rooms.Tarrif1Person = Tarrif1person;
                rooms.Tarrif2People = Tarrif2People;
                rooms.TarrifExtraPerson = TarrifExtraPerson;
                context.Rooms.Add(rooms);
                context.SaveChanges();
                MessageBox.Show("Room Added Successfully!");

            }
        }

        public static void UpdateRoom(string roomID, string SingleBeds, string DoubleBeds, string Tarrif1person, string Tarrif2People, string TarrifExtraPerson) // Update part of CRUD for rooms on update click in Rooms Form
        {
            int Roomid = Convert.ToInt32(roomID);
            using (var context = new Hotel_Reservation_System())
            {
                var updaterooms = from r in context.Rooms
                    where r.RoomID == Roomid
                    select r;
                var rooms = updaterooms.FirstOrDefault();

                rooms.RoomID = Roomid;
                rooms.SingleBeds = SingleBeds;
                rooms.DoubleBeds = DoubleBeds;
                rooms.Tarrif1Person = Tarrif1person;
                rooms.Tarrif2People = Tarrif2People;
                rooms.TarrifExtraPerson = TarrifExtraPerson;
                context.SaveChanges();

                MessageBox.Show("Room Updated Successfully!");
            }
        }


        public static void DeleteRoom(string ID) // Delete Rooms part of CRUD
        {
            var roomdelete = Convert.ToInt32(ID);

            if (
                MessageBox.Show("Do you REALLY want to delete Room " + roomdelete + "?", "Delete Record",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                using (var context = new Hotel_Reservation_System())
                {
                    int RoomID = Convert.ToInt32(ID);
                    var room = (from r in context.Rooms where r.RoomID == RoomID select r).SingleOrDefault();

                    context.Rooms.Remove(room);
                    context.SaveChanges();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Room has already been deleted or another error has occured");

            }
        }
    }
}
