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
        public AdminMainForm()
        {
            InitializeComponent();

            // Initialize AdminHome as the default View
            adminHome = new AdminHome()
            {
                Dock = DockStyle.Fill
            };

            // Add adminhome to mainform
            this.Controls.Add(adminHome);

        }



    }
}
