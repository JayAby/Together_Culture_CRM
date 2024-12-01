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
    public partial class MemberHome : UserControl
    {
        private MemberDocument memberDocument;
        private MemberKeyPolicies memberKeyPolicies;
        private MemberChat memberChat;
        private MemberPosts memberPosts;
        private CreateNewPlans createNewPlans;
        private ViewProjectPlan viewProjectPlan;
        private LoggedInMember loggedInMember;

        // Variables to manage the expand/collapse states of the sidebar and other containers
        bool sidebarExpand;
        bool eventsCollapse;
        bool connectionCollapse;
        bool profileExpand;

        public MemberHome(LoggedInMember member)
        {
            InitializeComponent();
            loggedInMember = member;

            // Initialize MemberDocument
            memberDocument = new MemberDocument
            {
                Dock = DockStyle.Fill,
                Visible = false // Hide initially
            };

            // Initialize MemberKeyPolicies
            memberKeyPolicies = new MemberKeyPolicies
            {
                Dock = DockStyle.Fill,
                Visible = false // Hide initially
            };

            // Initialize MemberChat
            memberChat = new MemberChat
            {
                Dock = DockStyle.Fill,
                Visible = false
            };

            // Initialize MemberPosts
            memberPosts = new MemberPosts
            {
                Dock = DockStyle.Fill,
                Visible = false
            };

            // Initialize Create New Plans
            createNewPlans = new CreateNewPlans(loggedInMember)
            {
                Dock = DockStyle.Fill,
                Visible = false
            };

            // Initialize View Project Plans
            viewProjectPlan = new ViewProjectPlan(loggedInMember)
            {
                Dock = DockStyle.Fill,
                Visible = false
            };


            // Add them to the main container
            mainContainer.Controls.Add(memberDocument);
            mainContainer.Controls.Add(memberKeyPolicies);
            mainContainer.Controls.Add(memberChat);
            mainContainer.Controls.Add(memberPosts);
            mainContainer.Controls.Add(createNewPlans);
            mainContainer.Controls.Add(viewProjectPlan);

            // Set the parent home for both controls so they can call methods in MemberHome
            memberDocument.SetParentHome(this);
            memberKeyPolicies.SetParentHome(this);
            memberChat.SetParentHome(this);
            memberPosts.SetParentHome(this);
            createNewPlans.SetParentHome(this);
            viewProjectPlan.SetParentHome(this);

            // Set the reference of ViewProjectPlan to CreateNewPlan
            createNewPlans.SetViewProjectPlan(viewProjectPlan);
        }
        
        // When Document button is clicked
        private void btnDocuments_Click(object sender, EventArgs e)
        {
            // Hide other controls and show MemberDocument
            foreach (Control control in mainContainer.Controls)
            {
                control.Visible = false;
            }

            memberDocument.Visible = true;
            memberDocument.BringToFront();
        }

        public void ShowMemberKeyPolicies()
        {
            if (loggedInMember == null)
            {
                MessageBox.Show("Log in please.");
                return;
            }
            // Get Member_ID
            int memberID = loggedInMember.MemberID;

            // Connect to the db
            DatabaseOperations dbOps = new DatabaseOperations(
                server: "localhost",
                database: "togetherculturecrm",
                username: "root",
                password: ""
            );

            // Retreive Specific Member Key Policy
            KeyPolicy keyPolicy = dbOps.GetKeyPolicy(memberID);

            // Hide other controls
            foreach(Control control in mainContainer.Controls)
            {
                control.Visible = false;
            }

            // if a key policy was found, populate the form with the retreived data
            if (keyPolicy != null)
            {
                memberKeyPolicies.PopulateKeyPolicy(keyPolicy);
                memberKeyPolicies.Visible = true;
                memberKeyPolicies.BringToFront();

            }
            else
            {
                MessageBox.Show("No Key Policy found for this member.", "Key Policies", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void CreateNewProjectPlan()
        {
            // Hide other controls
            foreach (Control control in mainContainer.Controls)
            {
                control.Visible = false;
            }

            createNewPlans.Visible = true;
            createNewPlans.BringToFront();
        }

        public void ShowProjectPlan()
        {
            // Hide other controls
            foreach (Control control in mainContainer.Controls)
            {
                control.Visible = false;
            }

            viewProjectPlan.Visible = true;
            viewProjectPlan.BringToFront();
        }


        public void ReturnHome()
        {
            // Hide MemberDocument and MemberKeyPolicies, show MemberHome (reset state)
            foreach (Control control in mainContainer.Controls)
            {
                control.Visible = false;
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // Expand or collapse the sidebar with each timer tick
            if (sidebarExpand)
            {
                // If sidebar is expanded, reduce its width to minimize it
                sidebar.Width -= 10;
                mainContainer.Width += 10;
                mainContainer.Location = new Point(sidebar.Right, mainContainer.Location.Y);

                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width;
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                // If sidebar is collapsed, increase its width to expand it
                sidebar.Width += 10;
                mainContainer.Width -= 10;
                mainContainer.Location = new Point(sidebar.Right, mainContainer.Location.Y);

                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width;
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // When menu button is clicked, start the timer to trigger sidebar expansion or collapse
            sidebarTimer.Start();
        }

        private void eventsTimer_Tick(object sender, EventArgs e)
        {
            // Expand or collapse the events container with each timer tick
            if (eventsCollapse)
            {
                eventsContainer.Height -= 10;
                if (eventsContainer.Height <= eventsContainer.MinimumSize.Height)
                {
                    eventsContainer.Height = eventsContainer.MinimumSize.Height;
                    eventsCollapse = false;
                    eventsTimer.Stop();
                }
            }
            else
            {
                eventsContainer.Height += 10;
                if (eventsContainer.Height >= eventsContainer.MaximumSize.Height)
                {
                    eventsContainer.Height = eventsContainer.MaximumSize.Height;
                    eventsCollapse = true;
                    eventsTimer.Stop();
                }
            }
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            // Start the timer to trigger event collapse or expand
            eventsTimer.Start();
        }

        private void connectionsTimer_Tick(object sender, EventArgs e)
        {
            // Expand or collapse the connection container with each timer tick
            if (connectionCollapse)
            {
                connectionContainer.Height -= 10;
                if (connectionContainer.Height <= connectionContainer.MinimumSize.Height)
                {
                    connectionContainer.Height = connectionContainer.MinimumSize.Height;
                    connectionCollapse = false;
                    connectionsTimer.Stop();
                }
            }
            else
            {
                connectionContainer.Height += 10;
                if (connectionContainer.Height >= connectionContainer.MaximumSize.Height)
                {
                    connectionContainer.Height = connectionContainer.MaximumSize.Height;
                    connectionCollapse = true;
                    connectionsTimer.Stop();
                }
            }
        }

        private void btnConnections_Click(object sender, EventArgs e)
        {
            // Start the timer to trigger event collapse or expand
            connectionsTimer.Start();
        }

        private void profileTimer_Tick(object sender, EventArgs e)
        {
            // Expand or collapse the profile Container with each timer tick
            if (profileExpand)
            {
                profileContainer.Width -= 10;
                if (profileContainer.Width <= profileContainer.MinimumSize.Width)
                {
                    profileContainer.Width = profileContainer.MinimumSize.Width;
                    profileExpand = false;
                    profileTimer.Stop();
                }
            }
            else
            {
                profileContainer.Width += 10;
                if (profileContainer.Width >= profileContainer.MaximumSize.Width)
                {
                    profileContainer.Width = profileContainer.MaximumSize.Width;
                    profileExpand = true;
                    profileTimer.Stop();
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profileTimer.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ReturnHome();
        }

        // When Chats button is clicked 
        private void btnChats_Click(object sender, EventArgs e)
        {
            // Hide other controls and show MemmberChats on the MainContainer
            foreach(Control control in mainContainer.Controls)
            {
                control.Visible = false;
            }

            memberChat.Visible = true;
            memberChat.BringToFront();
        }

        // When Posts Button is clicked
        private void btnPosts_Click(object sender, EventArgs e)
        {
            // Hide other controls and show MemberPosts on the MainContainer
            foreach(Control control in mainContainer.Controls)
            {
                control.Visible=false;
            }

            memberPosts.Visible = true;
            memberPosts.BringToFront();
        }
    }
}

