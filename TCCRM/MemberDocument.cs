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
    public partial class MemberDocument : UserControl
    {
        private MemberHome parentHome;


        // Variables to manage the expand/collapse states of the sidebar and other containers
        bool projectExpand;

        public void SetParentHome(MemberHome home)
        {
            parentHome = home;
        }

        public MemberDocument()
        {
            InitializeComponent();
        }

        private void btnKeyPolicies_Click(object sender, EventArgs e)
        {
            parentHome.ShowMemberKeyPolicies();
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

        private void btnNewPlans_Click(object sender, EventArgs e)
        {
            parentHome.CreateNewProjectPlan();
        }

        private void btnViewPlans_Click(object sender, EventArgs e)
        {
            parentHome.ShowProjectPlan();
        }
    }
}