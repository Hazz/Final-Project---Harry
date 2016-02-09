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
    public partial class tsbtnHistory : Form
    {
        Guests GuestsForm = new Guests();
       public Reservations ReservationForm = new Reservations();
        Billings BillingForm = new Billings();
        History HistoryForm = new History();
        readonly Rooms RoomsForm = new Rooms();
        public tsbtnHistory()
        {
            InitializeComponent();
            //binds all the other forms to be a child of the main one
            GuestsForm.MdiParent = this;
            ReservationForm.MdiParent = this;
            RoomsForm.MdiParent = this;
            HistoryForm.MdiParent = this;

        }

        private void tsbtnGuests_Click(object sender, EventArgs e) // When Guests in Menu Bar is clicked it bring up the Guests Form and hides the rest
        {
            GuestsForm.Show();
            ReservationForm.Hide();
            BillingForm.Hide();
            GuestsForm.ShowGuestsandBooking();
            HistoryForm.Hide();
            pbxHome.Hide();
        }

        private void tsbtnHome_Click(object sender, EventArgs e)// When zhome in Menu Bar is clicked it bring up the Home Form and hides the rest
        {
            pbxHome.Show();
            ReservationForm.Hide();
            GuestsForm.Hide();
            BillingForm.Hide();
            RoomsForm.Hide();
            HistoryForm.Hide();
        }

        private void tsbtnReservations_Click(object sender, EventArgs e)// When Reservations in Menu Bar is clicked it bring up the Reservations Form and hides the rest
        {
            ReservationForm.Show();
            GuestsForm.Hide();
            BillingForm.Hide();
            RoomsForm.Hide();
            HistoryForm.Hide();
            pbxHome.Hide();
        }

        private void tsbtnRooms_Click(object sender, EventArgs e)// When Rooms in Menu Bar is clicked it bring up the Rooms Form and hides the rest
        {
            RoomsForm.Show();
            GuestsForm.Hide();
            ReservationForm.Hide();
            BillingForm.Hide();
            HistoryForm.Hide();
            pbxHome.Hide();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)// When History in Menu Bar is clicked it bring up the History Form and hides the rest
        {
            HistoryForm.Show();
            GuestsForm.Hide();
            BillingForm.Hide();
            RoomsForm.Hide();
            pbxHome.Hide();
        }
    }
}
