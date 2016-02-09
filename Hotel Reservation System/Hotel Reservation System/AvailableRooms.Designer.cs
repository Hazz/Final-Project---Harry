namespace Hotel_Reservation_System
{
    partial class AvailableRooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAvailableRooms = new System.Windows.Forms.DataGridView();
            this.lblAvailableRoomsTitle = new System.Windows.Forms.Label();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRoomNumberWord = new System.Windows.Forms.Label();
            this.lblRoomCost = new System.Windows.Forms.Label();
            this.lblRoomCostText = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblEmailText = new System.Windows.Forms.Label();
            this.lblLNtext = new System.Windows.Forms.Label();
            this.lblFNText = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lbxRoomPrices = new System.Windows.Forms.ListBox();
            this.lblBookFrom = new System.Windows.Forms.Label();
            this.lblBookTo = new System.Windows.Forms.Label();
            this.lblToText = new System.Windows.Forms.Label();
            this.lblGuestsNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAvailableRooms
            // 
            this.dgvAvailableRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableRooms.Location = new System.Drawing.Point(12, 32);
            this.dgvAvailableRooms.Name = "dgvAvailableRooms";
            this.dgvAvailableRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableRooms.Size = new System.Drawing.Size(760, 296);
            this.dgvAvailableRooms.TabIndex = 0;
            this.dgvAvailableRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableRooms_CellClick);
            // 
            // lblAvailableRoomsTitle
            // 
            this.lblAvailableRoomsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableRoomsTitle.Location = new System.Drawing.Point(141, 9);
            this.lblAvailableRoomsTitle.Name = "lblAvailableRoomsTitle";
            this.lblAvailableRoomsTitle.Size = new System.Drawing.Size(313, 20);
            this.lblAvailableRoomsTitle.TabIndex = 1;
            this.lblAvailableRoomsTitle.Text = "Rooms Available On Selected Dates";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(74, 493);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(138, 28);
            this.btnCreateBooking.TabIndex = 2;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.btnCreateBooking_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(514, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRoomNumberWord
            // 
            this.lblRoomNumberWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumberWord.Location = new System.Drawing.Point(447, 341);
            this.lblRoomNumberWord.Name = "lblRoomNumberWord";
            this.lblRoomNumberWord.Size = new System.Drawing.Size(97, 23);
            this.lblRoomNumberWord.TabIndex = 4;
            this.lblRoomNumberWord.Text = "Selected Room:";
            // 
            // lblRoomCost
            // 
            this.lblRoomCost.Location = new System.Drawing.Point(447, 424);
            this.lblRoomCost.Name = "lblRoomCost";
            this.lblRoomCost.Size = new System.Drawing.Size(97, 23);
            this.lblRoomCost.TabIndex = 5;
            this.lblRoomCost.Text = "$";
            // 
            // lblRoomCostText
            // 
            this.lblRoomCostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCostText.Location = new System.Drawing.Point(447, 398);
            this.lblRoomCostText.Name = "lblRoomCostText";
            this.lblRoomCostText.Size = new System.Drawing.Size(97, 23);
            this.lblRoomCostText.TabIndex = 6;
            this.lblRoomCostText.Text = "Room Cost:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Location = new System.Drawing.Point(447, 364);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(97, 23);
            this.lblRoomNumber.TabIndex = 7;
            this.lblRoomNumber.Text = "Room #";
            // 
            // lblEmailText
            // 
            this.lblEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailText.Location = new System.Drawing.Point(82, 424);
            this.lblEmailText.Name = "lblEmailText";
            this.lblEmailText.Size = new System.Drawing.Size(97, 13);
            this.lblEmailText.TabIndex = 8;
            this.lblEmailText.Text = "Email:";
            // 
            // lblLNtext
            // 
            this.lblLNtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLNtext.Location = new System.Drawing.Point(82, 384);
            this.lblLNtext.Name = "lblLNtext";
            this.lblLNtext.Size = new System.Drawing.Size(97, 16);
            this.lblLNtext.TabIndex = 9;
            this.lblLNtext.Text = "Last Name:";
            // 
            // lblFNText
            // 
            this.lblFNText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNText.Location = new System.Drawing.Point(82, 341);
            this.lblFNText.Name = "lblFNText";
            this.lblFNText.Size = new System.Drawing.Size(97, 23);
            this.lblFNText.TabIndex = 10;
            this.lblFNText.Text = "First Name:";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(85, 361);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(115, 20);
            this.txtFN.TabIndex = 11;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(85, 401);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(115, 20);
            this.txtLN.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 444);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.Location = new System.Drawing.Point(520, 6);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(97, 23);
            this.lblBookingDate.TabIndex = 14;
            this.lblBookingDate.Text = "Booking Date";
            this.lblBookingDate.Visible = false;
            // 
            // lbxRoomPrices
            // 
            this.lbxRoomPrices.FormattingEnabled = true;
            this.lbxRoomPrices.Location = new System.Drawing.Point(289, 426);
            this.lbxRoomPrices.Name = "lbxRoomPrices";
            this.lbxRoomPrices.Size = new System.Drawing.Size(85, 95);
            this.lbxRoomPrices.TabIndex = 15;
            this.lbxRoomPrices.Visible = false;
            // 
            // lblBookFrom
            // 
            this.lblBookFrom.Location = new System.Drawing.Point(247, 350);
            this.lblBookFrom.Name = "lblBookFrom";
            this.lblBookFrom.Size = new System.Drawing.Size(154, 18);
            this.lblBookFrom.TabIndex = 16;
            this.lblBookFrom.Text = "label1";
            // 
            // lblBookTo
            // 
            this.lblBookTo.Location = new System.Drawing.Point(247, 398);
            this.lblBookTo.Name = "lblBookTo";
            this.lblBookTo.Size = new System.Drawing.Size(154, 21);
            this.lblBookTo.TabIndex = 17;
            this.lblBookTo.Text = "label1";
            // 
            // lblToText
            // 
            this.lblToText.Location = new System.Drawing.Point(225, 368);
            this.lblToText.Name = "lblToText";
            this.lblToText.Size = new System.Drawing.Size(68, 18);
            this.lblToText.TabIndex = 18;
            this.lblToText.Text = "To";
            this.lblToText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuestsNumber
            // 
            this.lblGuestsNumber.Location = new System.Drawing.Point(566, 364);
            this.lblGuestsNumber.Name = "lblGuestsNumber";
            this.lblGuestsNumber.Size = new System.Drawing.Size(97, 23);
            this.lblGuestsNumber.TabIndex = 19;
            this.lblGuestsNumber.Text = "Guest #";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(566, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Guests:";
            // 
            // AvailableRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGuestsNumber);
            this.Controls.Add(this.lblToText);
            this.Controls.Add(this.lblBookTo);
            this.Controls.Add(this.lblBookFrom);
            this.Controls.Add(this.lbxRoomPrices);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblFNText);
            this.Controls.Add(this.lblLNtext);
            this.Controls.Add(this.lblEmailText);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblRoomCostText);
            this.Controls.Add(this.lblRoomCost);
            this.Controls.Add(this.lblRoomNumberWord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateBooking);
            this.Controls.Add(this.lblAvailableRoomsTitle);
            this.Controls.Add(this.dgvAvailableRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AvailableRooms";
            this.Text = "Available Rooms";
            this.Load += new System.EventHandler(this.AvailableRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAvailableRooms;
        private System.Windows.Forms.Label lblAvailableRoomsTitle;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRoomNumberWord;
        private System.Windows.Forms.Label lblRoomCost;
        private System.Windows.Forms.Label lblRoomCostText;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblEmailText;
        private System.Windows.Forms.Label lblLNtext;
        private System.Windows.Forms.Label lblFNText;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.ListBox lbxRoomPrices;
        private System.Windows.Forms.Label lblBookFrom;
        private System.Windows.Forms.Label lblBookTo;
        private System.Windows.Forms.Label lblToText;
        private System.Windows.Forms.Label lblGuestsNumber;
        private System.Windows.Forms.Label label1;
    }
}