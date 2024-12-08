using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCRM
{
    public partial class AdminMakeEvents : UserControl
    {
        private AdminHome parentHome;
        private LoggedInUser loggedInAdmin;

        public void SetParentHome(AdminHome home)
        {
            parentHome = home;
        }

        public AdminMakeEvents(LoggedInUser admin)
        {
            InitializeComponent();

            loggedInAdmin = admin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get entered fields
            string eventTitle = txtEventName.Text;
            string eventDescription = txtEventDescription.Text;
            DateTime eventDay = dtpEventDate.Value;
            DateTime startTime = dtpStartTime.Value;
            DateTime endTime = dtpEndTime.Value;
            string location = txtLocation.Text;
            int adminID = loggedInAdmin.AdminID;

            // Disallow empty fields
            if (string.IsNullOrWhiteSpace(eventTitle) || string.IsNullOrWhiteSpace(eventDescription) 
                || string.IsNullOrWhiteSpace(location) || startTime >= endTime)
            {
                MessageBox.Show("Please provide valid inputs");
                return;
            }

            // Initialize DBOps
            DatabaseOperations dbOps = new DatabaseOperations(
                server: "localhost",
                database: "togetherculturecrm",
                username: "root",
                password: ""
            );

            dbOps.MakeEvents(adminID, eventTitle, eventDescription, eventDay, startTime, endTime, location);

            // Reload data
            // Code to reload data so that view events can get new events

            MessageBox.Show("New Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the textbox
            txtEventDescription.Text = "";
            txtEventName.Text = "";
            txtLocation.Text = "";
        }
    }
}
