namespace Hotel_Reservation_System
{
    partial class Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.numericUpDownGuests = new System.Windows.Forms.NumericUpDown();
            this.lblGuests = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.tabpagePending = new System.Windows.Forms.TabPage();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCheckIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvPending = new System.Windows.Forms.DataGridView();
            this.TabPending = new System.Windows.Forms.TabControl();
            this.tabControlCheckout = new System.Windows.Forms.TabControl();
            this.tabPageDepart = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCheckOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvCheckouts = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).BeginInit();
            this.tabpagePending.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).BeginInit();
            this.TabPending.SuspendLayout();
            this.tabControlCheckout.SuspendLayout();
            this.tabPageDepart.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckouts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearchTitle);
            this.panel1.Controls.Add(this.numericUpDownGuests);
            this.panel1.Controls.Add(this.lblGuests);
            this.panel1.Controls.Add(this.lblCheckOut);
            this.panel1.Controls.Add(this.dateTimePickerCheckOut);
            this.panel1.Controls.Add(this.lblCheckIn);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dateTimePickerCheckIn);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 680);
            this.panel1.TabIndex = 0;
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTitle.Location = new System.Drawing.Point(8, 11);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(219, 104);
            this.lblSearchTitle.TabIndex = 7;
            this.lblSearchTitle.Text = "Search For Rooms";
            this.lblSearchTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDownGuests
            // 
            this.numericUpDownGuests.Location = new System.Drawing.Point(27, 480);
            this.numericUpDownGuests.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownGuests.Name = "numericUpDownGuests";
            this.numericUpDownGuests.Size = new System.Drawing.Size(178, 20);
            this.numericUpDownGuests.TabIndex = 6;
            // 
            // lblGuests
            // 
            this.lblGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.Location = new System.Drawing.Point(51, 437);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(115, 26);
            this.lblGuests.TabIndex = 5;
            this.lblGuests.Text = "Guests:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(38, 240);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(105, 29);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "Check Out:";
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(27, 284);
            this.dateTimePickerCheckOut.MinDate = new System.DateTime(2015, 10, 27, 0, 0, 0, 0);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerCheckOut.TabIndex = 3;
            this.dateTimePickerCheckOut.Value = new System.DateTime(2015, 10, 27, 13, 29, 14, 0);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(38, 129);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(104, 30);
            this.lblCheckIn.TabIndex = 2;
            this.lblCheckIn.Text = "Check In:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(6, 558);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(221, 115);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(27, 175);
            this.dateTimePickerCheckIn.MinDate = new System.DateTime(2015, 10, 27, 0, 0, 0, 0);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerCheckIn.TabIndex = 0;
            this.dateTimePickerCheckIn.Value = new System.DateTime(2015, 10, 27, 13, 29, 14, 0);
            // 
            // tabpagePending
            // 
            this.tabpagePending.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabpagePending.Controls.Add(this.lblName);
            this.tabpagePending.Controls.Add(this.lblBookingID);
            this.tabpagePending.Controls.Add(this.toolStrip1);
            this.tabpagePending.Controls.Add(this.dgvPending);
            this.tabpagePending.Location = new System.Drawing.Point(4, 27);
            this.tabpagePending.Name = "tabpagePending";
            this.tabpagePending.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagePending.Size = new System.Drawing.Size(916, 316);
            this.tabpagePending.TabIndex = 0;
            this.tabpagePending.Text = "Data";
            // 
            // lblBookingID
            // 
            this.lblBookingID.Location = new System.Drawing.Point(603, 288);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(109, 22);
            this.lblBookingID.TabIndex = 2;
            this.lblBookingID.Text = "BookingID";
            this.lblBookingID.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbtnCheckIn,
            this.toolStripSeparator2,
            this.tsbtnDelete,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 288);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(910, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStripPending";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnCheckIn
            // 
            this.tsbtnCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbtnCheckIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnCheckIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCheckIn.Image")));
            this.tsbtnCheckIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckIn.Name = "tsbtnCheckIn";
            this.tsbtnCheckIn.Size = new System.Drawing.Size(64, 22);
            this.tsbtnCheckIn.Text = "Check In";
            this.tsbtnCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtnCheckIn.ToolTipText = "Check In";
            this.tsbtnCheckIn.Click += new System.EventHandler(this.tsbtnCheckIn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelete.Image")));
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(50, 22);
            this.tsbtnDelete.Text = "Delete";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvPending
            // 
            this.dgvPending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPending.Location = new System.Drawing.Point(0, 4);
            this.dgvPending.Name = "dgvPending";
            this.dgvPending.Size = new System.Drawing.Size(916, 281);
            this.dgvPending.TabIndex = 0;
            this.dgvPending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPending_CellContentClick);
            // 
            // TabPending
            // 
            this.TabPending.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabPending.Controls.Add(this.tabpagePending);
            this.TabPending.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPending.Location = new System.Drawing.Point(254, 21);
            this.TabPending.Name = "TabPending";
            this.TabPending.SelectedIndex = 0;
            this.TabPending.ShowToolTips = true;
            this.TabPending.Size = new System.Drawing.Size(924, 347);
            this.TabPending.TabIndex = 1;
            // 
            // tabControlCheckout
            // 
            this.tabControlCheckout.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlCheckout.Controls.Add(this.tabPageDepart);
            this.tabControlCheckout.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControlCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCheckout.Location = new System.Drawing.Point(254, 384);
            this.tabControlCheckout.Name = "tabControlCheckout";
            this.tabControlCheckout.SelectedIndex = 0;
            this.tabControlCheckout.ShowToolTips = true;
            this.tabControlCheckout.Size = new System.Drawing.Size(924, 306);
            this.tabControlCheckout.TabIndex = 2;
            // 
            // tabPageDepart
            // 
            this.tabPageDepart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageDepart.Controls.Add(this.toolStrip2);
            this.tabPageDepart.Controls.Add(this.dgvCheckouts);
            this.tabPageDepart.Location = new System.Drawing.Point(4, 27);
            this.tabPageDepart.Name = "tabPageDepart";
            this.tabPageDepart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepart.Size = new System.Drawing.Size(916, 275);
            this.tabPageDepart.TabIndex = 0;
            this.tabPageDepart.Text = "Departures";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.tsbtnCheckOut,
            this.toolStripSeparator5});
            this.toolStrip2.Location = new System.Drawing.Point(3, 247);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip2.Size = new System.Drawing.Size(910, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStripPending";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnCheckOut
            // 
            this.tsbtnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.tsbtnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbtnCheckOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnCheckOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCheckOut.Image")));
            this.tsbtnCheckOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckOut.Name = "tsbtnCheckOut";
            this.tsbtnCheckOut.Size = new System.Drawing.Size(75, 22);
            this.tsbtnCheckOut.Text = "Check Out";
            this.tsbtnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.tsbtnCheckOut.ToolTipText = "Check In";
            this.tsbtnCheckOut.Click += new System.EventHandler(this.tsbtnCheckOut_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvCheckouts
            // 
            this.dgvCheckouts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckouts.Location = new System.Drawing.Point(0, 2);
            this.dgvCheckouts.Name = "dgvCheckouts";
            this.dgvCheckouts.Size = new System.Drawing.Size(913, 242);
            this.dgvCheckouts.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(422, 288);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 22);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1190, 715);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlCheckout);
            this.Controls.Add(this.TabPending);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reservations";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).EndInit();
            this.tabpagePending.ResumeLayout(false);
            this.tabpagePending.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPending)).EndInit();
            this.TabPending.ResumeLayout(false);
            this.tabControlCheckout.ResumeLayout(false);
            this.tabPageDepart.ResumeLayout(false);
            this.tabPageDepart.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckouts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownGuests;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.TabPage tabpagePending;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvPending;
        private System.Windows.Forms.TabControl TabPending;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnCheckIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabControl tabControlCheckout;
        private System.Windows.Forms.TabPage tabPageDepart;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnCheckOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView dgvCheckouts;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblName;
    }
}