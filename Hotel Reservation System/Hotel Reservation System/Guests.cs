using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    public partial class Guests : Form
    {
        public Guests()
        {
            InitializeComponent();
            ShowGuestsandBooking();
        }

        public void ShowGuestsandBooking() // displays the guests and booking details in the DGV
        {
            dgvGuestsandBooking.DataSource = DatabaseCalls.BookingandGuests();
            dgvGuestsandBooking.Columns[0].Visible = false; // makes GuestID not visible but it can still be used to Update
            dgvGuestsandBooking.Columns[3].Visible = false; // makes BookingID not visible but it can still be used to Update
        }

        private void dgvGuestsandBooking_CellContentClick(object sender, DataGridViewCellEventArgs e) // makes the data from the datagridview be displayed in the textboxes
        {
            
            lblGuestID.Text = dgvGuestsandBooking.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvGuestsandBooking.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvGuestsandBooking.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblBookingID.Text = dgvGuestsandBooking.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtGuests.Text = dgvGuestsandBooking.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtRoom.Text = dgvGuestsandBooking.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtBookingFrom.Text = dgvGuestsandBooking.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtBookingTo.Text = dgvGuestsandBooking.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void tsbtnUpdate_Click(object sender, EventArgs e) // Updates the database with the info entered in the text boxes
        {
            DatabaseCalls.UpdateGuests(txtName.Text, txtEmail.Text, Convert.ToInt32(lblGuestID.Text));
            DatabaseCalls.UpdateBookings(txtRoom.Text, txtGuests.Text, txtBookingFrom.Text, txtBookingTo.Text, Convert.ToInt32(lblBookingID.Text));
            ShowGuestsandBooking();
            Cleartxtboxes();
        }
        private void toolStripButtonDelete_Click(object sender, EventArgs e) // deletes seleted guest & booking from the Database8
        {
            DatabaseCalls.DeleteGuest(txtName.Text);
            DatabaseCalls.DeleteBooking(Convert.ToInt32(lblBookingID.Text));
            ShowGuestsandBooking();
            Cleartxtboxes();
        }
        private void Cleartxtboxes() // Clear All text boxes on the Guests & Billing Form after button clicks
        {
            txtName.Clear();
            txtEmail.Clear();
            txtGuests.Clear();
            txtRoom.Clear();
            txtBookingFrom.Clear();
            txtBookingTo.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
