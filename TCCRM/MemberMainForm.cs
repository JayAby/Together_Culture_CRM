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

        public MemberMainForm()
        {
            InitializeComponent();

            // Initialize MemberHome as the default view
            memberHome = new MemberHome
            {
                Dock = DockStyle.Fill
            };

            // Add MemberHome to MainForm
            this.Controls.Add(memberHome);
        }

    }
}