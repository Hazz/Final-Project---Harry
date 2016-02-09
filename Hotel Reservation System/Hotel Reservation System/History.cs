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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            ShowHistory();
        }

        private void ShowHistory()//displays the history of all guests checked out in the DGV
        {
            dgvHistory.DataSource = DatabaseCalls.GuestandBookingHistory();
        }
    }
}
