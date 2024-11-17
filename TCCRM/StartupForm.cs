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
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Hide the StartupForm
            this.Hide();

            // Open AdminMainForm
            using (AdminMainForm adminForm = new AdminMainForm())
            {
                adminForm.ShowDialog(); // Show AdminMainForm as a modal dialog
            }

            // Show the StartupForm again when AdminMainForm is closed
            this.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            // Hide the StartupForm
            this.Hide();

            // Open MemberMainForm
            using (MemberMainForm memberForm = new MemberMainForm())
            {
                memberForm.ShowDialog(); // Show MemberMainForm as a modal dialog
            }

            // Show the StartupForm again when MemberMainForm is closed
            this.Show();
        }

        private void StartupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ensure the application terminates when startupform is closed
            Application.Exit();
        }     
    }
}
