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
        private DateTime lastFetchedTime = DateTime.MinValue;

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
            string postContent = txtPosts.Text;

            if (string.IsNullOrWhiteSpace(postContent))
            {
                MessageBox.Show("Blank Posts not allowed!");
                return;
            }

            try
            {
                dbOps.InsertPost(currentMemberID, postContent);
                txtPosts.Clear();
                MessageBox.Show("Posts Added Successfully");

                // Load
                LoadPosts();
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
            Panel postPanel = new Panel
            {
                Width = flowLayoutPosts.ClientSize.Width - 20,
                Height = 100,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
            };

            Label lbUsername = new Label
            {
                Text = username,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Dock = DockStyle.Top,
                ForeColor = Color.Blue,
            };

            Label lbDate = new Label
            {
                Text = createdAt.ToString("g"),
                Font = new Font("Arial", 8),
                Dock = DockStyle.Bottom,
                ForeColor = Color.Gray,
            };

            TextBox txtContent = new TextBox
            {
                Text = content,
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            postPanel.Controls.Add(txtContent);
            postPanel.Controls.Add(lbUsername);
            postPanel.Controls.Add(lbDate);

            flowLayoutPosts.Controls.Add(postPanel);

        }
    }
}
