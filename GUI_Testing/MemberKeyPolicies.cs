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
    public partial class MemberKeyPolicies : UserControl
    {
        private MembersDocument parentDocument;
        public MemberKeyPolicies(MembersDocument parent
            )
        {
            InitializeComponent();
            parentDocument = parent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Call the method in MembersDocument to switch back to home
            parentDocument.ShowMemberHome();
        }
    }
}
