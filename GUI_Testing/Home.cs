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
    public partial class Home : Form
    {
        bool sidebarExpand;
        bool connectionCollapse;
        bool profileExpand;
        public Home()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // If sidebar is expanded, minimize it
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width; // Ensure it doesn't go below minimum size
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                // If sidebar is minimized, maximize it
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width; // Ensure it doesn't exceed maximum size
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start(); 
        }

        private void connectionsTimer_Tick(object sender, EventArgs e)
        {
            if (connectionCollapse)
            {
                // Collapse the container
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
            connectionsTimer.Start();
        }

        private void profileTimer_Tick(object sender, EventArgs e)
        {
            if (profileExpand)
            {
                // If profile container is expanded, minimize it
                profileContainer.Width -= 10;
                if (profileContainer.Width <= profileContainer.MinimumSize.Width)
                {
                    profileContainer.Width = profileContainer.MinimumSize.Width; // Ensure it doesn't go below minimum size
                    profileExpand = false;
                    profileTimer.Stop();
                }
            }
            else
            {
                // If profile container is minimized, maximize it
                profileContainer.Width += 10;
                if (profileContainer.Width >= profileContainer.MaximumSize.Width)
                {
                    profileContainer.Width = profileContainer.MaximumSize.Width; // Ensure it doesn't exceed maximum size
                    profileExpand = true;
                    profileTimer.Stop();
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            profileTimer.Start();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            MemberDocuments md = new MemberDocuments();
            md.Show();
            Visible = false;
        }
    }
}
