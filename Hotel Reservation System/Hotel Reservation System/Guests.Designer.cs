namespace Hotel_Reservation_System
{
    partial class Guests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guests));
            this.toolStripGuestsandBooking = new System.Windows.Forms.ToolStrip();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.dgvGuestsandBooking = new System.Windows.Forms.DataGridView();
            this.lblGuestNametext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRoomNumtext = new System.Windows.Forms.Label();
            this.lblEmailtext = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.txtBookingFrom = new System.Windows.Forms.TextBox();
            this.txtBookingTo = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripGuestsandBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestsandBooking)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripGuestsandBooking
            // 
            this.toolStripGuestsandBooking.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripGuestsandBooking.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripGuestsandBooking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnUpdate,
            this.toolStripSeparator1,
            this.toolStripButtonDelete});
            this.toolStripGuestsandBooking.Location = new System.Drawing.Point(0, 690);
            this.toolStripGuestsandBooking.Name = "toolStripGuestsandBooking";
            this.toolStripGuestsandBooking.Size = new System.Drawing.Size(1190, 25);
            this.toolStripGuestsandBooking.TabIndex = 1;
            this.toolStripGuestsandBooking.Text = "toolStrip1";
            // 
            // tsbtnUpdate
            // 
            this.tsbtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdate.Image")));
            this.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdate.Name = "tsbtnUpdate";
            this.tsbtnUpdate.Size = new System.Drawing.Size(136, 22);
            this.tsbtnUpdate.Text = "Update Guest Details";
            this.tsbtnUpdate.ToolTipText = "Update Details";
            this.tsbtnUpdate.Click += new System.EventHandler(this.tsbtnUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(163, 22);
            this.toolStripButtonDelete.Text = "Delete Guest and Booking";
            this.toolStripButtonDelete.ToolTipText = "Delete Guest & Booking";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // dgvGuestsandBooking
            // 
            this.dgvGuestsandBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuestsandBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestsandBooking.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvGuestsandBooking.Location = new System.Drawing.Point(12, 12);
            this.dgvGuestsandBooking.Name = "dgvGuestsandBooking";
            this.dgvGuestsandBooking.Size = new System.Drawing.Size(1141, 451);
            this.dgvGuestsandBooking.TabIndex = 0;
            this.dgvGuestsandBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuestsandBooking_CellContentClick);
            // 
            // lblGuestNametext
            // 
            this.lblGuestNametext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuestNametext.Location = new System.Drawing.Point(29, 53);
            this.lblGuestNametext.Name = "lblGuestNametext";
            this.lblGuestNametext.Size = new System.Drawing.Size(42, 20);
            this.lblGuestNametext.TabIndex = 2;
            this.lblGuestNametext.Text = "Name:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(680, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Booking To:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(680, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Booking From:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(322, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Guests #:";
            // 
            // lblRoomNumtext
            // 
            this.lblRoomNumtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomNumtext.Location = new System.Drawing.Point(331, 50);
            this.lblRoomNumtext.Name = "lblRoomNumtext";
            this.lblRoomNumtext.Size = new System.Drawing.Size(50, 20);
            this.lblRoomNumtext.TabIndex = 6;
            this.lblRoomNumtext.Text = "Room #:";
            // 
            // lblEmailtext
            // 
            this.lblEmailtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailtext.Location = new System.Drawing.Point(26, 88);
            this.lblEmailtext.Name = "lblEmailtext";
            this.lblEmailtext.Size = new System.Drawing.Size(42, 20);
            this.lblEmailtext.TabIndex = 7;
            this.lblEmailtext.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(77, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(77, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtRoom
            // 
            this.txtRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoom.Location = new System.Drawing.Point(399, 50);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(119, 20);
            this.txtRoom.TabIndex = 10;
            // 
            // txtGuests
            // 
            this.txtGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuests.Location = new System.Drawing.Point(399, 85);
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(119, 20);
            this.txtGuests.TabIndex = 11;
            // 
            // txtBookingFrom
            // 
            this.txtBookingFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookingFrom.Location = new System.Drawing.Point(795, 53);
            this.txtBookingFrom.Name = "txtBookingFrom";
            this.txtBookingFrom.Size = new System.Drawing.Size(123, 20);
            this.txtBookingFrom.TabIndex = 12;
            // 
            // txtBookingTo
            // 
            this.txtBookingTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookingTo.Location = new System.Drawing.Point(795, 88);
            this.txtBookingTo.Name = "txtBookingTo";
            this.txtBookingTo.Size = new System.Drawing.Size(123, 20);
            this.txtBookingTo.TabIndex = 13;
            // 
            // lblGuestID
            // 
            this.lblGuestID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(96, 111);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(49, 13);
            this.lblGuestID.TabIndex = 14;
            this.lblGuestID.Text = "Guest ID";
            this.lblGuestID.Visible = false;
            // 
            // lblBookingID
            // 
            this.lblBookingID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(831, 121);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 13);
            this.lblBookingID.TabIndex = 15;
            this.lblBookingID.Text = "Booking ID";
            this.lblBookingID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblBookingID);
            this.panel1.Controls.Add(this.lblGuestNametext);
            this.panel1.Controls.Add(this.lblGuestID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBookingTo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBookingFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGuests);
            this.panel1.Controls.Add(this.lblRoomNumtext);
            this.panel1.Controls.Add(this.txtRoom);
            this.panel1.Controls.Add(this.lblEmailtext);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Location = new System.Drawing.Point(65, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 157);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Guests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1190, 715);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripGuestsandBooking);
            this.Controls.Add(this.dgvGuestsandBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Guests";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guests";
            this.toolStripGuestsandBooking.ResumeLayout(false);
            this.toolStripGuestsandBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestsandBooking)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripGuestsandBooking;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.DataGridView dgvGuestsandBooking;
        private System.Windows.Forms.Label lblGuestNametext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRoomNumtext;
        private System.Windows.Forms.Label lblEmailtext;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.TextBox txtBookingFrom;
        private System.Windows.Forms.TextBox txtBookingTo;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Panel panel1;
    }
}