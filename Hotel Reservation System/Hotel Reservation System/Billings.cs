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
    public partial class Billings : Form
    {
         private int Wifi;
        private int Bar;
        private int Room;
       private int Total;

        public Billings()
        {
            
            InitializeComponent();
            ShowCheckOuts();  
            
  
        }


   
        private void ShowCheckOuts()// displays the guests that are currently checked in in a Datadridview
        {
            dgvBilling.DataSource = DatabaseCalls.CurrentCheckedIn();

        }

        private void dgvBilling_CellContentClick(object sender, DataGridViewCellEventArgs e) // assigns text in specific row numbers to text boxes on DGV click
        {
            txtRoomCharge.Text = dgvBilling.Rows[e.RowIndex].Cells[7].Value.ToString();
            lblGuestID.Text = dgvBilling.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblBookedTo.Text = dgvBilling.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)//calculates the total cost of guests stay
        {
        Wifi = Convert.ToInt32(txtWifiCharge.Text);
        Bar = Convert.ToInt32(txtBarCharge.Text);
       Room = Convert.ToInt32(txtRoomCharge.Text);
       

            if (txtRoomCharge.Text != null && txtBarCharge.Text != null && txtWifiCharge.Text != null)
            {
                Total = Wifi + Bar + Room;
                lblTotalCost.Text = Total.ToString();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e) // adds todays date to checkout field and all the costs to the right tables in the database
        {
            if ((Convert.ToInt32(txtRoomCharge.Text) >= 30) && (Convert.ToInt32(txtWifiCharge.Text) >= 0) && (Convert.ToInt32(txtBarCharge.Text) >= 0 && lblBookedTo.Text == DateTime.Today.ToShortDateString()))
            { 
                CheckInandOutCalls.InsertBilling(Convert.ToInt32(lblGuestID.Text), Convert.ToInt32(txtWifiCharge.Text),
                    Convert.ToInt32(txtBarCharge.Text), Convert.ToInt32(txtRoomCharge.Text), Total);
                CheckInandOutCalls.InsertCheckOut(Room);
                this.Close();

            }
        else
            {
                MessageBox.Show("Please make sure bar and wifi charges are entered and Guest checking out has been selected.");
            }
        }
    }
}
