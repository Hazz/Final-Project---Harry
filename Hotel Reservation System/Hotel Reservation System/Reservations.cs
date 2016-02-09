using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    public partial class Reservations : Form
    {
        private Billings Billingform;
        private AvailableRooms AvailableForm;

        public Reservations()
        {
            
            InitializeComponent();
           CurrentBookings();
        }

        private void CurrentBookings() // displays the the bookings not yet checked in into the first DGV
        {
            dgvPending.DataSource = DatabaseCalls.CurrentNotCheckedIn();
            dgvPending.Columns[2].Visible = false; // makes it so i can use booking ID to help with checkin but not be visable
           
            dgvCheckouts.DataSource = DatabaseCalls.CurrentCheckedIn();
            dgvCheckouts.Columns[0].Visible = false; // makes the Guest ID not visable but helps with the checking out process

            dateTimePickerCheckIn.MinDate = DateTime.Today;
            dateTimePickerCheckOut.MinDate = DateTime.Today.AddDays(+1);
        }
        private void tsbtnCheckOut_Click(object sender, EventArgs e)//on clicking teh checkout button it will bring up the Billing Form
        {
            Billingform = new Billings();
            Billingform.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)// on clicking search it will show you avalible rooms for the selected dates and guest #
        {
          AvailableForm  = new AvailableRooms();
            AvailableForm.Show();
            AvailableForm.RoomsAvailable = RoomAvailableCalls.Add(dateTimePickerCheckIn.Value.Date, dateTimePickerCheckOut.Value.Date);
            AvailableForm.RoomCost = RoomAvailableCalls.RoomDetails(numericUpDownGuests.Text, dateTimePickerCheckOut.Value.Date, dateTimePickerCheckIn.Value.Date);
            
            AvailableForm.BookedFrom = dateTimePickerCheckIn.Value.Date;
            AvailableForm.BookedTo = dateTimePickerCheckOut.Value.Date;
            AvailableForm.Guests = numericUpDownGuests.Text;
            AvailableForm.GetFreeRooms();
        }


        private void tsbtnCheckIn_Click(object sender, EventArgs e)// on click of checkin it will add the checkin date to selected booking if the checkin is todays date
        {
            if (lblBookingID.Text == "BookingID")
            {
MessageBox.Show("Please select a guest to check out");
            }
            else
            {
                CheckInandOutCalls.InsertCheckin(Convert.ToInt16(lblBookingID.Text));
            CurrentBookings();  
                
            }

        }

        private void dgvPending_CellContentClick(object sender, DataGridViewCellEventArgs e) // used for check in & delete functions
        {
            lblBookingID.Text = dgvPending.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblName.Text = dgvPending.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)//deltes a guest and booking that is selected
        {
            if (lblBookingID.Text == "BookingID" || lblName.Text == "Name")
            {
                MessageBox.Show("Please select a guest to Delete");
            }
            else
            {
                DatabaseCalls.DeleteGuest(lblName.Text);
                DatabaseCalls.DeleteBooking(Convert.ToInt16(lblBookingID.Text));
            }
        }
    }
}
