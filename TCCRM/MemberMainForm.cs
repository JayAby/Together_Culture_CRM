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
        private LoggedInUser loggedInMember;

        public MemberMainForm(LoggedInUser loggedInMember)
        {
            InitializeComponent();

            this.loggedInMember = loggedInMember;

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

        private void MemberMainForm_Load(object sender, EventArgs e)
        {
            // Check if the logged in meber is set correctly
            if (this.loggedInMember != null)
            {
                Console.WriteLine($"Logged in Member ID: {this.loggedInMember.MemberID}, Username: {this.loggedInMember.Username}");
            }
            else
            {
                Console.WriteLine("No logged in member");
            }
        }
    }
}