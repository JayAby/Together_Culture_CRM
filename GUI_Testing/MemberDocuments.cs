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
    public partial class MemberDocuments : Form
    {
        bool profileExpand;
        bool sidebarExpand;
        bool projectExpand;

        public MemberDocuments()
        {
            InitializeComponent();
            // Subscribe to the FormClosing event
            this.FormClosing += MemberDocuments_FormClosing;
        }

        // This method is triggered when the MemberDocuments form is closing
        private void MemberDocuments_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the main form when "Member Documents" form is closed
            Home mainForm = Application.OpenForms.OfType<Home>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.Show();
            }
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

        private void projectTimer_Tick(object sender, EventArgs e)
        {
            if (projectExpand)
            {
                // If project container is expanded, minimize it
                projectContainer.Width -= 10;
                if (projectContainer.Width <= projectContainer.MinimumSize.Width)
                {
                    projectContainer.Width = projectContainer.MinimumSize.Width; // Ensure it doesn't go below minimum size
                    projectExpand = false;
                    projectTimer.Stop();
                }
            }
            else
            {
                // If project container is minimized, maximize it
                projectContainer.Width += 10;
                if (projectContainer.Width >= projectContainer.MaximumSize.Width)
                {
                    projectContainer.Width = projectContainer.MaximumSize.Width; // Ensure it doesn't exceed maximum size
                    projectExpand = true;
                    projectTimer.Stop();
                }
            }
        }

        private void btnProjectPlans_Click(object sender, EventArgs e)
        {
            projectTimer.Start();
        }

        private void btnKeyPolicies_Click(object sender, EventArgs e)
        {
            MemberDocuments_KeyPolicies keyPolicies = new MemberDocuments_KeyPolicies();
            keyPolicies.Show();
            Visible = false;
        }
    }
}
