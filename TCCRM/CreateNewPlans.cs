using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCCRM
{
    public partial class CreateNewPlans : UserControl
    {
        private MemberHome parentHome;
        private ViewProjectPlan viewProjectPlan;
        private LoggedInUser loggedInMember;

        // Method to set a reference of view project plan
        public void SetViewProjectPlan(ViewProjectPlan view)
        {
            viewProjectPlan = view;
        }

        public void SetParentHome(MemberHome home)
        {
            parentHome = home;
        }
        public CreateNewPlans(LoggedInUser member)
        {
            InitializeComponent();

            // Store logged in member
            loggedInMember = member;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get entered fields
            string projectTitle = txtProjectTitle.Text;
            string projectDescription = txtProjectDescription.Text;

            // Reject Empty Fields
            if (string.IsNullOrWhiteSpace(projectTitle) || string.IsNullOrWhiteSpace(projectDescription))
            { 
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retreive ID of Logged in Member
            int MemberID = loggedInMember.MemberID;

            // Save the project plan to the DB
            DatabaseOperations dbOps = new DatabaseOperations(
                server: "localhost",
                database: "togetherculturecrm",
                username: "root",
                password: ""
            );

            dbOps.CreateProjectPlan(MemberID, projectTitle, projectDescription);

            // Notify ViewProjectPlan to reload the data
            viewProjectPlan?.LoadProjectPlans();

            MessageBox.Show("Project Plan added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the Textbox fields
            txtProjectTitle.Text = "";
            txtProjectDescription.Text = "";

        }
    }
}
