using MySql.Data.MySqlClient;
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
    public partial class MemberPosts : UserControl
    {
        private string connectionString = "server=localhost;database=togetherculturecrm;user=root;password=";
        private MemberHome parentHome;
        private DatabaseOperations dbOps;
        private LoggedInUser LoggedInMember;
        private int currentMemberID;

        public void SetParentHome(MemberHome home)
        {
            parentHome = home;
        }
        public MemberPosts(LoggedInUser loggedInMember)
        {
            InitializeComponent();

            // Initialize DatabaseOperations
            dbOps = new DatabaseOperations(
                server: "localhost",
                database: "togetherculturecrm",
                username: "root",
                password: ""
            );

            // Initialize with the logged in member
            LoggedInMember = loggedInMember;

            // Timer to poll posts
            updatePostsTimer.Tick += updatePostsTimer_Tick;
            updatePostsTimer.Start();

            Console.WriteLine($"LoggedInMember: {LoggedInMember?.MemberID ?? 0}");

            LoadPosts();
        }

        private void btnMakePost_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Success", "Connected");
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void updatePostsTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                DataTable posts = dbOps.RetreiveNewPosts(lastFetchedTime);

                foreach (DataRow row in posts.Rows)
                {
                    AddStyledPostToFlowLayout(
                        row["Username"].ToString(),
                        row["Content"].ToString(),
                        DateTime.Parse(row["CreatedAt"].ToString())
                    );

                    lastFetchedTime = DateTime.Parse(posts.Rows[0]["CreatedAt"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadPosts()
        {
            try
            {
                DataTable posts = dbOps.RetreivePosts();
                flowLayoutPosts.Controls.Clear();

                foreach (DataRow row in posts.Rows)
                {
                    AddStyledPostToFlowLayout(
                        row["Username"].ToString(),
                        row["Content"].ToString(),
                        DateTime.Parse(row["CreatedAt"].ToString())
                    );

                    lastFetchedTime = DateTime.Parse(posts.Rows[0]["CreatedAt"].ToString());

                }

                if (posts.Rows.Count > 0)
                {
                    lastFetchedTime = DateTime.Parse(posts.Rows[0]["CreatedAt"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddStyledPostToFlowLayout(string username, string content, DateTime createdAt)
        {
            // Clone the template panel
            Panel newPost = (Panel)postTemplate.Clone();

        }
    }
}
