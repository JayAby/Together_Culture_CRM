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
    public partial class StartupForm : Form
    {
        private LoggedInMember loggedInMember;
        // Connection string to connect to the database
        string connectionString = "server=localhost;database=togetherculturecrm;user=root;password=";

        // Variables to hold the container expansion 
        bool adminExpand;
        bool memberExpand;
        public StartupForm()
        {
            InitializeComponent();
        }
        private void StartupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ensure the application terminates when startupform is closed
            Application.Exit();
        }

        private void AdminTimer_Tick(object sender, EventArgs e)
        {
            // Expand or collapse the admin container with each timer tick
            if (adminExpand)
            {
                adminContainer.Height -= 10;
                if (adminContainer.Height <= adminContainer.MinimumSize.Height)
                {
                    adminContainer.Height = adminContainer.MinimumSize.Height;
                    adminExpand = false;
                    adminTimer.Stop();
                }
            }
            else
            {
                adminContainer.Height += 10;
                if (adminContainer.Height >= adminContainer.MaximumSize.Height)
                {
                    adminContainer.Height = adminContainer.MaximumSize.Height;
                    adminExpand = true;
                    adminTimer.Stop();
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminTimer.Start();
            // Hide the StartupForm
            //this.Hide();

            //// Open AdminMainForm
            //using (AdminMainForm adminForm = new AdminMainForm())
            //{
            //    adminForm.ShowDialog(); // Show AdminMainForm as a modal dialog
            //}

            //// Show the StartupForm again when AdminMainForm is closed
            //this.Show();
        }

        private void memberTimer_Tick(object sender, EventArgs e)
        {
            // Expand or collapse the member container with each timer tick
            if (memberExpand)
            {
                memberContainer.Height -= 10;
                if (memberContainer.Height <= memberContainer.MinimumSize.Height)
                {
                    memberContainer.Height = memberContainer.MinimumSize.Height;
                    memberExpand = false;
                    memberTimer.Stop();
                }
            }
            else
            {
                memberContainer.Height += 10;
                if (memberContainer.Height >= memberContainer.MaximumSize.Height)
                {
                    memberContainer.Height = memberContainer.MaximumSize.Height;
                    memberExpand = true;
                    memberTimer.Stop();
                }
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            memberTimer.Start();
  
        }

        private void btnMemberLogin_Click(object sender, EventArgs e)
        {
            string username = txtMemberUsername.Text;
            string password = txtMemberPassword.Text;

            // Authenticate User
            LoggedInMember loggedinMember = ValidateMember(username, password);

            if (loggedinMember != null) 
            {
                // Successful Login
                MessageBox.Show("Success", "Login Successful!");
                // Hide the StartupForm
                this.Hide();

                // Open MemberMainForm
                using (MemberMainForm memberForm = new MemberMainForm(loggedinMember))
                {
                    memberForm.ShowDialog(); // Show MemberMainForm as a modal dialog
                }

                // Show the StartupForm again when MemberMainForm is closed
                this.Show();
            }
            else
            {
                // Error 
                MessageBox.Show("Error", "Invalid Details");
            }
        }

        // Method to Validate from DB
        private LoggedInMember ValidateMember(string username, string password)
        {
            LoggedInMember loggedinMember = null;

            string loginQuery = @"
                SELECT member_id, user_name, password
                FROM Members
                WHERE user_name = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            { 
                connection.Open();

                using (MySqlCommand insertLoginCommand = new MySqlCommand(loginQuery, connection)) 
                {
                    insertLoginCommand.Parameters.AddWithValue("@Username", username);

                    using (MySqlDataReader reader = insertLoginCommand.ExecuteReader()) 
                    {
                        if (reader.Read()) 
                        {
                            string storedPassword = reader.GetString("password");
                            int memberID = reader.GetInt32("member_id");

                            // Check if passwords match
                            if (storedPassword == password)
                            {
                                // Create a LoggedInMember Instance and set the properties
                                loggedInMember = new LoggedInMember
                                {
                                    MemberID = memberID,
                                    Username = username
                                };

                            }
                        }
                    }
                }
            }
            return loggedinMember;
        }
    }
}
