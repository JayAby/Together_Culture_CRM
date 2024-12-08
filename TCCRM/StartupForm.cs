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
        private LoggedInUser loggedInMember;
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
            // Ensure the application terminates when StartupForm is closed
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
            try
            {
                string username = txtMemberUsername.Text;
                string password = txtMemberPassword.Text;

                // Authenticate User
                LoggedInUser loggedInMember = ValidateMember(username, password);

                if (loggedInMember != null)
                {
                    // Successful Login
                    MessageBox.Show("Success", "Login Successful!");

                    // Store the logged in member in the global context
                    AppContext.LoggedInMember = loggedInMember;
                    Console.WriteLine($"LoggedInMember set: {AppContext.LoggedInMember.MemberID}, {AppContext.LoggedInMember.Username}");

                    // Hide the StartupForm
                    this.Hide();

                    // Open MemberMainForm and pass the logged-in member
                    using (MemberMainForm memberForm = new MemberMainForm(loggedInMember))
                    {
                        memberForm.ShowDialog(); // Show MemberMainForm as a modal dialog
                    }

                    // Show the StartupForm again when MemberMainForm is closed
                    this.Show();
                }
                else
                {
                    // Error: Invalid credentials
                    MessageBox.Show("Error", "Invalid Details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        // Method to validate the user from the database
        private LoggedInUser ValidateMember(string username, string password)
        {
            try
            {
                LoggedInUser loggedInMember = null;
                string loginQuery = @"
                    SELECT member_id, user_name, password
                    FROM Members
                    WHERE user_name = @Username";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Database connection successful.");

                    using (MySqlCommand command = new MySqlCommand(loginQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Console.WriteLine("User found.");
                                string storedPassword = reader.GetString("password");
                                int memberID = reader.GetInt32("member_id");

                                // Check if passwords match
                                if (storedPassword == password)
                                {
                                    loggedInMember = new LoggedInUser
                                    {
                                        MemberID = memberID,
                                        Username = username
                                    };
                                    Console.WriteLine($"Authentication successful. MemberID: {loggedInMember.MemberID}, Username: {loggedInMember.Username}");
                                }
                                else
                                {
                                    Console.WriteLine("Password mismatch.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No matching user found.");
                            }
                        }
                    }
                }
                return loggedInMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
                return null;
            }
        }

        // Method to validate the admin from the db
        private LoggedInUser ValidateAdmin(string username, string password)
        {
            try
            {
                LoggedInUser loggedInAdmin = null;
                string adminLoginQuery = @"
                    SELECT admin_id, user_name, password
                    FROM Admin
                    WHERE user_name = @UserName";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(adminLoginQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", username);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Console.WriteLine("User found");
                                string storedPassword = reader.GetString("password");
                                int adminID = reader.GetInt32("admin_id");

                                // Password checker
                                if (storedPassword == password)
                                {
                                    loggedInAdmin = new LoggedInUser
                                    {
                                        AdminID = adminID,
                                        Username = username,
                                    };
                                }
                                else
                                {
                                    Console.WriteLine("Password Mismatch");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No matching users found");
                            }
                        }
                    }
                }
                return loggedInAdmin;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
                return null;
            }
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtAdminUsername.Text;
                string password = txtAdminPassword.Text;

                // Authenticate user
                LoggedInUser loggedInAdmin = ValidateAdmin(username, password);

                if (loggedInAdmin != null)
                {
                    MessageBox.Show("Success");

                    // Store loggedin Admin
                    AppContext.LoggedInAdmin = loggedInAdmin;
                    Console.WriteLine($"Logged in Admin set: {AppContext.LoggedInAdmin.AdminID}, {AppContext.LoggedInAdmin.Username}");

                    // Hide the StartupForm and open AdminMainForm
                     this.Hide();

                     using (AdminMainForm adminForm = new AdminMainForm(AppContext.LoggedInAdmin))
                     {
                        adminForm.ShowDialog(); // Show AdminMainForm as a modal dialog
                     }
                    this.Show();
                }
                else
                {
                    // Invalid Login
                    MessageBox.Show("Error", "Invalid Details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}


