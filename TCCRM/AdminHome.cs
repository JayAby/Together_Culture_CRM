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
    public partial class AdminHome : UserControl
    {
        private AdminMakeEvents makeEvents;
        private AdminViewEvents viewEvents;

        // Variables to manage the expand/collapse states of the sidebar and other containers
        bool eventsCollapse;
        bool sidebarExpand;
        public AdminHome()
        {
            InitializeComponent();

            makeEvents = new AdminMakeEvents() { 
                Dock = DockStyle.Fill,
                Visible = false
            };

            viewEvents = new AdminViewEvents()
            {
                Dock = DockStyle.Fill,
                Visible = false
            };

            // Add them to the mainContainer
            mainContainer.Controls.Add(makeEvents);
            mainContainer.Controls.Add(viewEvents);

            // Set the parent home for both controls so they can call methods in MemberHome
            makeEvents.SetParentHome(this);
            viewEvents.SetParentHome(this);
        }

        private void eventsTimer_Tick(object sender, EventArgs e)
        {
            // Expand or collapse the events container with each timer tick
            if (eventsCollapse)
            {
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
            eventsTimer.Start();
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
            sidebarTimer.Start();
        }

        private void btnMakeEvents_Click(object sender, EventArgs e)
        {
            foreach (Control control in mainContainer.Controls)
            {
                control.Visible = false;
            }

            makeEvents.Visible = true;
            makeEvents.BringToFront();
        }

        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            foreach(Control control in mainContainer.Controls)
            {
                control.Visible = false;
            }

            viewEvents.Visible = true;
            viewEvents.BringToFront();
        }
    }
}
