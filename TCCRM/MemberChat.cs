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
    public partial class MemberChat : UserControl
    {
        private MemberHome parentHome;
        private DatabaseOperations dbOps;
        LoggedInMember LoggedInMember = new LoggedInMember();
        private int currentMemberID;
 
        public void SetParentHome(MemberHome home)
        {
            parentHome = home;
        }

        public MemberChat()
        {
            InitializeComponent();

            // Initialize DatabaseOperations
            dbOps = new DatabaseOperations(
                server: "localhost",
                database: "togetherculturecrm",
                username: "root",
                password: ""
            );

            // Timer to poll messages
            messageTimer.Tick += messageTimer_Tick;
            messageTimer.Start();


            LoadMembers();
        }

        // Use a combo-box to select who to chat with
        private void LoadMembers()
        {
            try
            {
                // Get Member_ID
                int memberID = LoggedInMember.MemberID;

                // Clear previoous items
                cmbLoadMember.Items.Clear();

                // Fetch all members excluding user from the db
                var members = dbOps.GetAllMembers(memberID);
                foreach (var member in members)
                {
                    // Add members to the combo-box
                    cmbLoadMember.Items.Add(new ComboBoxItem
                    {
                        Value = member.MemberID,
                        Text = member.Username
                    });
                }

                // Select the first member by default
                if (cmbLoadMember.Items.Count > 0) 
                {
                    cmbLoadMember.SelectedIndex = 0;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void messageTimer_Tick(object sender, EventArgs e)
        {
            if (currentMemberID > 0)
            {
                LoadMessages(currentMemberID);
            }
        }



        // Method to Load the messages
        public void LoadMessages(int targetMemberID)
        {
            int memberID = LoggedInMember.MemberID;

            // Fetch chat messages from the db
            var messages = dbOps.GetMessages(memberID, targetMemberID);

            // Display messages in the chat text box
            txtChatDisplay.Clear();
            foreach (var message in messages)
            {
                string sender = message.SenderID == memberID ? "You" : message.SenderName;
                txtChatDisplay.AppendText($"[{message.SentTime:yyyy-MM-dd HH:mm}] {sender}: {message.MessageContent}\r\n");

            }
        }

        private void cmbLoadMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoadMember.SelectedItem is ComboBoxItem selectedMember)
            {
                currentMemberID = selectedMember.Value;
                LoadMessages(currentMemberID);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string messageContent = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(messageContent) || currentMemberID == 0)
            {
                MessageBox.Show("Please select a member and enter a message");
                return;
            }

            int senderID = LoggedInMember.MemberID;

            // Save messages to db
            dbOps.SendMessage(senderID, currentMemberID, messageContent);

            txtMessage.Clear();
            LoadMessages(currentMemberID );

        }
    }
}
