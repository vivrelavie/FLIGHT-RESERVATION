﻿using FLIGHT_RESERVATION.Flight_Booking.FlightBookings_GuestDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLIGHT_RESERVATION
{
    public partial class FlightBookings_GuestDetails : UserControl
    {
        public FlightBookings_GuestDetails()
        {
            InitializeComponent();
        }


        public Dictionary<String, GuestDetails> guestDetails = new Dictionary<string, GuestDetails>();
        private void InitializeGuestDetails()
        {
            this.SuspendLayout();

            try
            {



                int numAdults = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Number of Adults") ? int.Parse(FlightBooking_Session.Instance.FlightDetails["Number of Adults"]) : 0;
                int numChildren = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Number of Children") ? int.Parse(FlightBooking_Session.Instance.FlightDetails["Number of Children"]) : 0;
                int numInfants = FlightBooking_Session.Instance.FlightDetails.ContainsKey("Number of Infants") ? int.Parse(FlightBooking_Session.Instance.FlightDetails["Number of Infants"]) : 0;


                if (numAdults + numChildren + numInfants > 1)
                {
                    int total = numAdults + numChildren + numInfants;
                    if (total % 2 != 0) total += 1;
                    int numRows = (total / 2);

                    TableLayoutPanel GuestDetailsLayout = new TableLayoutPanel()
                    {
                        Width = pnlGuestDetails.Width,
                        AutoSize = true,
                        Dock = DockStyle.Top
                    };
                    int xCenter = (pnlGuestDetails.Width - GuestDetailsLayout.Width) / 2;
                    GuestDetailsLayout.Location = new Point(xCenter + 20, GuestDetailsLayout.Location.Y);

                    GuestDetailsLayout.Width = pnlGuestDetails.Width / 2;
                    GuestDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                    GuestDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));

                    int currentColumn = 0;
                    int currentRow = 0;

                    InitializeGuestDetails("Adult", numAdults);
                    InitializeGuestDetails("Child", numChildren);
                    InitializeGuestDetails("Infant", numInfants);


                    void InitializeGuestDetails(String type, int counter)
                    {
                        for (int i = 1; i <= counter; i++)
                        {
                            var GuestDetails = new GuestDetails(type, i) { Margin = new Padding(0, 25, 0, 0) };
                            GuestDetailsLayout.Controls.Add(GuestDetails, currentColumn, currentRow);
                            if (currentColumn == 1) { currentColumn = 0; currentRow++; }
                            else currentColumn++;
                            guestDetails[$"{type} {i}"] = GuestDetails;
                        }
                    }

                    pnlGuestDetails.Controls.Add(GuestDetailsLayout);
                }
                else
                {
                    var GuestDetails = new GuestDetails("Passenger", 0) { Margin = new Padding(0, 25, 0, 0) }; 
                    pnlGuestDetails.Controls.Add(GuestDetails);
                    //GuestDetails.AutoSize = true;
                    GuestDetails.Left = (pnlGuestDetails.Width - GuestDetails.Width) / 2;
                    //GuestDetails.Top = (pnlGuestDetails.Height - GuestDetails.Height) / 2;
                    guestDetails["Adult 1"] = GuestDetails;
                }
            }
            finally
            {
                this.ResumeLayout();
            }
        }


       new public Boolean Validate()
        {
            foreach (var item in guestDetails)
            {

                foreach (var txt in item.Value.Controls.OfType<CustomControls.RoundedTextBox>().ToArray())
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        MessageBox.Show($"Fill up all fields");
                        btnFocus.Focus();
                        return false;
                    }
                }

                var birthdateBox = item.Value.Controls.OfType<CustomControls.RoundedTextBox>().FirstOrDefault(t => t.Name == "txtBirthdate");
                if (birthdateBox != null &&
                    !DateTime.TryParseExact(birthdateBox.Text, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    MessageBox.Show("Birthdate must be in 'MM/dd/yyyy' format.\nExample: 01/01/2001.");
                    birthdateBox.Text = "";
                    btnFocus.Focus();
                    return false;
                }

                var txtAge = item.Value.Controls.OfType<CustomControls.RoundedTextBox>().FirstOrDefault(t => t.Name == "txtAge");

                if (string.IsNullOrWhiteSpace(txtAge.Text)) return false;

                if (!int.TryParse(txtAge.Text, out int num) || num < 0 || num > 110)
                {
                    txtAge.Text = "";
                    MessageBox.Show("Age must be from range 0 - 110 only");
                    btnFocus.Focus();
                    return false;
                }
            }

            

            return true;
        }

        private void FlightBookings_GuestDetails_Load(object sender, EventArgs e)
        {
            InitializeGuestDetails();
        }

        private void guestDetails1_Load(object sender, EventArgs e)
        {

        }
    }
}
