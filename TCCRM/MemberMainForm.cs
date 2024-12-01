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
    public partial class MemberMainForm : Form
    {
        private MemberHome memberHome;
        private MemberKeyPolicies memberKeyPolicies;

        public MemberMainForm(LoggedInMember loggedInMember)
        {
            InitializeComponent();

            // Initialize MemberHome as the default view
            memberHome = new MemberHome(loggedInMember)
            {
                Dock = DockStyle.Fill
            };

            // Add MemberHome to MainForm
            this.Controls.Add(memberHome);

            // Initialize MemberKeyPolices
            memberKeyPolicies = new MemberKeyPolicies
            {
                Dock = DockStyle.Fill,
                Visible = false
            };
        }


        // Return Home
        public void ReturnHome()
        {
            memberHome.Visible = true;
            memberKeyPolicies.Visible= false;
        }

    }
}