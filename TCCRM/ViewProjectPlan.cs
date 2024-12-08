using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCCRM
{
    public partial class ViewProjectPlan : UserControl
    {
        private List<ProjectPlan> projectPlans;
        private DatabaseOperations dbOps;
        private MemberHome parentHome;
        private LoggedInUser loggedInMember; // Store the logged in member

        public void SetParentHome(MemberHome home)
        {
            parentHome = home;
        }

        public ViewProjectPlan(LoggedInUser member)
        {
            InitializeComponent();

            // Initialize DatabaseOperations
            dbOps = new DatabaseOperations(
                server: "localhost",
                database: "togetherculturecrm",
                username: "root",
                password: ""
            );

            // Store the Logged in Member
            loggedInMember = member;

            // Load project plans when the form is loaded
            LoadProjectPlans();

            // Initially hide the panelEdit
            panelEdit.Visible = false;
        }

        public void LoadProjectPlans()
        {
            // Fetch project plans from DB
            projectPlans = dbOps.GetProjectPlans(loggedInMember.MemberID);

            // Populate the DataGridView
            dataGridViewProjectPlans.Rows.Clear(); // Clear previous rows
            foreach (var plan in projectPlans)
            {
                dataGridViewProjectPlans.Rows.Add(plan.PlanID, plan.Title, plan.Description);
            }
        }

        // When the DataGridView is clicked, fill the text boxes with the data
        private void dataGridViewProjectPlans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ignore header row click
            {
                var selectedRow = dataGridViewProjectPlans.Rows[e.RowIndex];

                // Set the textboxes with the selected record's details
                txtTitle.Text = selectedRow.Cells["Title"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();

                // Make TextBox Uneditable
                txtTitle.ReadOnly = true;
                txtDescription.ReadOnly = true;

                // Show the edit panel 
                panelEdit.Visible = true;
            }
        }
    }
}



