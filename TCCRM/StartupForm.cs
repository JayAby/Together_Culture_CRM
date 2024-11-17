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
            // If Admin is selcted, show AdminMainForm
            this.Hide();
            AdminMainForm adminForm = new AdminMainForm();
            adminForm.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            // If Member is selcted, show MemberMainForm
            this.Hide();
            MemberMainForm memberForm = new MemberMainForm();
            memberForm.Show();
        }

    }
}
