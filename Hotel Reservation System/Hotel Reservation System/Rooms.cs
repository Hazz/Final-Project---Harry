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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            RoomsStartup();
        }

        private void RoomsStartup()// displays the rooms in the dgv
        {
            dgvAllRooms.DataSource = DatabaseCalls.Rooms();
        }
        private void dgvAllRooms_CellContentClick(object sender, DataGridViewCellEventArgs e) // assigns the texts from the selected room to the text boxes
        {
            txtRoomID.Text = dgvAllRooms.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSingleBeds.Text = dgvAllRooms.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDoubleBeds.Text = dgvAllRooms.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTarrif1Person.Text = dgvAllRooms.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTarrif2People.Text = dgvAllRooms.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTarrifExtraPerson.Text = dgvAllRooms.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)//deletes the selected room on click
        {
            if (lblRoomID.Text == "RoomID")
            {
                MessageBox.Show("Please Select the room you want to delete");
            }
            else
            {
                DatabaseCalls.DeleteRoom(txtRoomID.Text);
            }
            RoomsStartup();
        }

        private void tsbtnUpdate_Click(object sender, EventArgs e)//updates the selected room with the data from the text boxes
        {
            try
            {
                DatabaseCalls.UpdateRoom(txtRoomID.Text, txtSingleBeds.Text, txtDoubleBeds.Text, txtTarrif1Person.Text,
                    txtTarrif2People.Text, txtTarrifExtraPerson.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not update make sure all text boxes have data in them");
            }
            RoomsStartup();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)//add a new room from the data entered in the text boxes
        {
            try
            {
            DatabaseCalls.AddRoom(txtRoomID.Text, txtSingleBeds.Text, txtDoubleBeds.Text, txtTarrif1Person.Text, txtTarrif2People.Text, txtTarrifExtraPerson.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not Add room, make sure all text boxes have data in them");

            }
            RoomsStartup();
        }
    }
}
