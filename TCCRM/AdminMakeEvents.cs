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
    public partial class AdminMakeEvents : UserControl
    {
        private AdminHome parentHome;

        public void SetParentHome(AdminHome home)
        {
            parentHome = home;
        }

        public AdminMakeEvents()
        {
            InitializeComponent();
        }

    }
}
