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
    public partial class MemberDocument : UserControl
    {
        private MainForm mainForm;

        public MemberDocument()
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

        private void btnKeyPolicies_Click(object sender, EventArgs e)
        {
            // Show Key Policies when the Key Policies button is clicked
            mainForm.ShowKeyPolicies();
        }
    }
}
