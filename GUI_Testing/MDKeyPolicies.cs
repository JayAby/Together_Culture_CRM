using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI_Testing
{
    public partial class MemberDocuments_KeyPolicies : Form
    {
        public MemberDocuments_KeyPolicies()
        {
            InitializeComponent();
            // Subscribe to the FormClosing event
            this.FormClosing += MemberDocuments_KeyPolicies_FormClosing;
        }

        // This method is triggered when the MemberDocuments_KeyPolicies form is closing
        private void MemberDocuments_KeyPolicies_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Show the MemberDocuments form when this form is closed
            MemberDocuments memberDocuments = Application.OpenForms.OfType<MemberDocuments>().FirstOrDefault();
            if (memberDocuments != null)
            {
                memberDocuments.Show();
            }
        }
    }
}
