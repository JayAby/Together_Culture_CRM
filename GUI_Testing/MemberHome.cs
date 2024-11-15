using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Testing
{
    public partial class MemberHome : UserControl
    {
        private MembersDocument membersDocument;

        // Variables to manage the expand/collapse states of the sidebar and other containers
        bool sidebarExpand;
        bool eventsCollapse;
        bool connectionCollapse;
        bool profileExpand;

        public MemberHome()
        {
            InitializeComponent();

            // Intialize MembersDocuments
            membersDocument = new MembersDocument()
            {
                Size = new System.Drawing.Size(1035, 646),
                Location = new System.Drawing.Point(0,3),
                Visible = false // Hide member document panel
            };

            // Add MemberDocument to the main Container Panel
            mainContainer.Controls.Add(membersDocument);
        }  
        private void btnDocuments_Click(object sender, EventArgs e)
        {
            // Toggle Visibility of MemberDocuments when Document button is clicked
            membersDocument.Visible = !membersDocument.Visible;

            // Bring to front only when visible
            if (membersDocument.Visible)
            {
                membersDocument.BringToFront();
            }

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // Expand or collapse the sidebar with each timer tick
            if (sidebarExpand)
            {
                // If sidebar is expanded, reduce it's width to minimize it
                sidebar.Width -= 10; 
                // 
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
                // If sidebar is collapsed, increase it's width to expand it
                sidebar.Width += 10;
                // 
                mainContainer.Width -= 10;
                mainContainer.Location = new Point (sidebar.Right, mainContainer.Location.Y);

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
            if (eventsCollapse) {
                // If event container is expanded reduce height to collapse the events container
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
                // If event container is collapsed increase height to expand the container
                eventsContainer.Height += 10;
                if(eventsContainer.Height >= eventsContainer.MaximumSize.Height)
                {
                    eventsContainer.Height= eventsContainer.MaximumSize.Height;
                    eventsCollapse= true;
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
                // If connection container is expanded reduce height to collapse the connection container
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
                // If connection container is collapsed increase height to expand the container
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
            connectionsTimer.Start();
        }

        private void profileTimer_Tick(object sender, EventArgs e)
        {
            // Expand or collapse the profile Container with each timer tick
            if (profileExpand)
            {
                // If profile container is expanded, reduce it's width to minimize it
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
                // If profile container is collapsed, increase it's width to expand it
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

   
    }
}
