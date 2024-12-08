using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCRM
{
    public partial class MemberChat : UserControl
    {
        private MemberHome parentHome;
        private DatabaseOperations dbOps;
        private int currentMemberID;
        private LoggedInUser LoggedInMember;


        public void SetParentHome(MemberHome home)
        {
            parentHome = home;
        }

        public MemberChat(LoggedInUser loggedInMember)
        {
            InitializeComponent();

            // Initialize DatabaseOperations
            dbOps = new DatabaseOperations(
                server: "localhost",
                database: "togetherculturecrm",
                username: "root",
                password: ""
            );

            // Initialize with the logged in member
            LoggedInMember = loggedInMember;

            // Timer to poll messages
            messageTimer.Tick += messageTimer_Tick;
            messageTimer.Start();

            Console.WriteLine($"LoggedInMember: {LoggedInMember?.MemberID ?? 0}");

            LoadMembers();
        }

        // Use a combo-box to select who to chat with
        private void LoadMembers()
        {
            try
            {
                int memberID = LoggedInMember?.MemberID ?? 0;

                if (memberID <= 0)
                {
                    MessageBox.Show("Invalid Logged in member");
                    return;
                }

                cmbLoadMember.Items.Clear();

                var members = dbOps.GetAllMembers(memberID);

                if (members == null || members.Count == 0)
                {
                    MessageBox.Show("No members found.");
                    return;
                }

                foreach (var member in members)
                {
                    if (member.MemberID != memberID)
                    {
                        cmbLoadMember.Items.Add(new ComboBoxItem
                        {
                            Value = member.MemberID,
                            Text = member.Username
                        });
                    }
                }

                if (cmbLoadMember.Items.Count > 0)
                    cmbLoadMember.SelectedIndex = 0; // Select first member by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void messageTimer_Tick(object sender, EventArgs e)
        {
            if (currentMemberID > 0)
            {
                await LoadMessagesAsync(currentMemberID);
            }
        }

        // Asynchronous method to load the messages
        public async Task LoadMessagesAsync(int targetMemberID)
        {
            if (LoggedInMember.MemberID == 0)
            {
                MessageBox.Show("Invalid Logged in member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var messages = await dbOps.GetMessagesAsync(LoggedInMember.MemberID, targetMemberID);
                txtChatDisplay.Clear();

                foreach (var message in messages)
                {
                    string sender = message.SenderID == LoggedInMember.MemberID ? "You" : message.SenderName;
                    txtChatDisplay.AppendText($"[{message.SentTime:yyyy-MM-dd HH:mm}] {sender}: {message.MessageContent}\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading messages: {ex.Message}");
            }
        }

        private void cmbLoadMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoadMember.SelectedItem is ComboBoxItem selectedItem)
            {
                currentMemberID = selectedItem.Value;
                Console.WriteLine($"Selected Member for Chat: {selectedItem.Text} (ID: {currentMemberID})");
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string messageContent = txtMessage.Text.Trim();

            // Ensure a member is selected and message is not empty
            if (string.IsNullOrEmpty(messageContent) || currentMemberID == 0)
            {
                MessageBox.Show("Please select a member and enter a message.");
                return;
            }

            // Check if the selected member is not the logged-in member
            if (currentMemberID == LoggedInMember.MemberID)
            {
                MessageBox.Show("You cannot send a message to yourself.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int senderID = LoggedInMember.MemberID;

            try
            {
                // Save the message to the database asynchronously
                bool success = await dbOps.SendMessageAsync(senderID, currentMemberID, messageContent);

                if (success)
                {
                    // Clear the message input field
                    txtMessage.Clear();

                    // Optionally reload messages for the selected member
                    await LoadMessagesAsync(currentMemberID);

                    // Provide success feedback to the user
                    MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to send message. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the message sending process
                MessageBox.Show($"Error sending message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
