﻿using System;
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
        private MemberHome parentHome;

        public void SetParentHome(MemberHome home)
        {
            parentHome = home;
        }

        public MemberKeyPolicies()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Return to MemberHome (reset view)
            parentHome?.ReturnHome();
        }

        // Method to Populate the form with Key Policy details
        public void PopulateKeyPolicy(KeyPolicy keyPolicy)
        {
            lblPolicyTitle.Text = keyPolicy.Title; // Display Title
            txtPolicyContent.Text = keyPolicy.Content; // Display Content
            txtPolicyContent.ReadOnly = true;
        }

    }
}