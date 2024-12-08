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
    public partial class AdminMainForm : Form
    {
        private AdminHome adminHome;
        private LoggedInUser loggedInAdmin;
        public AdminMainForm(LoggedInUser admin)
        {
            InitializeComponent();
            loggedInAdmin = admin;

            // Initialize AdminHome as the default View
            adminHome = new AdminHome(loggedInAdmin)
            {
                Dock = DockStyle.Fill
            };
            // Pass logged in admin to controls
            AdminMakeEvents makeEvents = new AdminMakeEvents(loggedInAdmin);

            // Add adminhome to mainform
            this.Controls.Add(adminHome);

        }



    }
}
