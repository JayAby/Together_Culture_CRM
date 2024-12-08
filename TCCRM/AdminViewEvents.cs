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
    public partial class AdminViewEvents : UserControl
    {
        private AdminHome parentHome;
        private DatabaseOperations dbOps;

        public void SetParentHome(AdminHome home)
        {
            parentHome = home;
        }
        public AdminViewEvents()
        {
            InitializeComponent();

            // Initialize Db Ops
            dbOps = new DatabaseOperations(
                server: "localhost",
                database: "togetherculturecrm",
                username: "root",
                password: ""
            ); 

            // Load All Events Upon Entry
            LoadAllEvents();

        }

        private void LoadAllEvents()
        {
            try
            {
                DataTable allEvents = dbOps.GetAllEvents();
                viewEvents.DataSource = allEvents;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error laoding events: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date must be before End date");
                return;
            }

            try
            {
                DataTable filteredEvents = dbOps.GetFilteredEvents(startDate, endDate);
                viewEvents.DataSource = filteredEvents;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error filtering events: {ex.Message}");
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadAllEvents();
        }
    }
}
