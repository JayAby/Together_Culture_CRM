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
    public partial class MainForm : Form
    {
        private MemberHome memberHomeControl;

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create an instance of MemberHome
            memberHomeControl = new MemberHome()
            {
                Dock = DockStyle.Fill
            };

            // Add member home to Mainforms control
            this.Controls.Add(memberHomeControl);
        }


    }
}
