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
    public partial class MemberPosts : UserControl
    {
        private MemberHome parentHome;

        public void SetParentHome(MemberHome home)
        {
            parentHome = home;
        }
        public MemberPosts()
        {
            InitializeComponent();
        }


    }
}
