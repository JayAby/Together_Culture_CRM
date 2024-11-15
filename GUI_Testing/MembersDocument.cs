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
    public partial class MembersDocument : UserControl
    {
        private MemberKeyPolicies memberKeyPolicies;
        private MemberHome memberHome;

        public MembersDocument()
        {
            InitializeComponent();

            // Intialize MemberKey Policies
            memberKeyPolicies = new MemberKeyPolicies(this)
            {
                Dock = DockStyle.Fill,
                Visible = false
            };

            // Add MemberKeyPolicies to MemberDocument
            this.Controls.Add(memberKeyPolicies);

            // Initialize memberHome
            memberHome = new MemberHome()
            {
                Dock = DockStyle.Fill,
                Visible = true
            };
            this.Controls.Add(memberHome);
        }

        private void btnKeyPolicies_Click(object sender, EventArgs e)
        {
            // Hide Member Home and show only Key Policies
            memberHome.Visible = false;
            memberKeyPolicies.Visible = true;
            memberKeyPolicies.BringToFront();
        }

        public void ShowMemberHome()
        {
            // Hide Key Policies and show Member Home with Documents Open
            memberKeyPolicies.Visible = false;
            memberHome.Visible = true;
            this.BringToFront();
        }
    }
}
