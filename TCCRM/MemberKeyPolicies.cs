using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TCCRM;

namespace TCCRM
{
    public partial class MemberKeyPolicies : UserControl
    {
        private MainForm mainForm;

        public MemberKeyPolicies()
        {
            InitializeComponent();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (this.Parent is MainForm form)
            {
                mainForm = form;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Hide Key Policies and return to MemberHome
            mainForm.ShowMemberHome();
        }
    }
}
