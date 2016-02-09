using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    public partial class AvailableRooms : Form
    {
        public IEnumerable RoomsAvailable;
        public IEnumerable RoomCost;
        public DateTime BookedFrom;
        public DateTime BookedTo;
        public string Guests;
        public AvailableRooms()
        {
            InitializeComponent();
        }

        public void GetFreeRooms() // Displays the free rooms & their details into the data grid view on the Available Rooms Form
        {
            dgvAvailableRooms.DataSource = RoomsAvailable;
            lbxRoomPrices.DataSource = RoomCost;
            lblBookingDate.Text = DateTime.Today.ToString("dd-MM-yyyy");
            lblBookFrom.Text = BookedFrom.ToString("dd-MM-yyyy");
            lblBookTo.Text = BookedTo.ToString("dd-MM-yyyy");
            lblGuestsNumber.Text = Guests;

        }

        private void dgvAvailableRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblRoomNumber.Text = dgvAvailableRooms.Rows[e.RowIndex].Cells[0].Value.ToString(); // make it so that where ever you click on the row it displays room #

            lbxRoomPrices.SelectedIndex = e.RowIndex; // Gets the row index selected to set the price
           lblRoomCost.Text = lbxRoomPrices.SelectedItem.ToString(); // sets the price according to the room selected
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (AvailableRooms.ActiveForm != null) AvailableRooms.ActiveForm.Close();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e) // creates a booking if all details are filled in
        {
            if (Convert.ToInt32(lblRoomCost.Text) >= 30 && Convert.ToInt32(lblRoomNumber.Text) >= 0)
            {
                int BookingID = DatabaseCalls.InsertBookings(lblBookingDate.Text, lblBookFrom.Text, lblBookTo.Text,
                    lblRoomNumber.Text, lblGuestsNumber.Text, lblRoomCost.Text);
                DatabaseCalls.InsertGuest(txtFN.Text, txtLN.Text, txtEmail.Text, BookingID);
                this.Close();
              
            }
            else
            {
                MessageBox.Show("Please Select a room that the guest wants to book");
            }
        }

        private void AvailableRooms_Load(object sender, EventArgs e)
        {

        }
    }

    }

