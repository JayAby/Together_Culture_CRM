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
    public partial class MainForm : Form
    {
        private MemberHome memberHome;
        private MemberDocument memberDocument;
        private MemberKeyPolicies memberKeyPolicies;

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize MemberHome
            memberHome = new MemberHome()
            {
                Dock = DockStyle.Fill,
                Visible = true
            };

            // Initialize MemberDocument (Initially hidden)
            memberDocument = new MemberDocument()
            {
                Dock = DockStyle.Fill,
                Visible = false
            };

            // Initialize MemberKeyPolicies (Initially hidden)
            memberKeyPolicies = new MemberKeyPolicies()
            {
                Dock = DockStyle.Fill,
                Visible = false
            };

            // Add all to MainForm
            this.Controls.Add(memberHome);
            this.Controls.Add(memberDocument);
            this.Controls.Add(memberKeyPolicies);
        }

        // Method to show MemberDocument
        public void ShowMemberDocument()
        {
            memberHome.Visible = false;
            memberDocument.Visible = true;
            memberDocument.BringToFront();
        }

        // Method to show MemberKeyPolicies
        public void ShowKeyPolicies()
        {
            memberDocument.Visible = false;
            memberKeyPolicies.Visible = true;
            memberKeyPolicies.BringToFront();
        }

        // Method to show MemberHome (Return from Key Policies)
        public void ShowMemberHome()
        {
            memberKeyPolicies.Visible = false;
            memberHome.Visible = true;
            memberHome.BringToFront();
        }
    }
}
