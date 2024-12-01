using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCCRM
{
    public class DatabaseOperations
    {
        private string connectionString;

        // Constructor to initialize the connection string
        public DatabaseOperations(string server, string database, string username, string password)
        {
            connectionString = $"server={server};database={database};user={username};password={password};";
        }

        #region Member and Key Policies

        // Method to Insert a Member with a Policy
        public void InsertMemberWithPolicy(
            string firstName,
            string lastName,
            string userName,
            string email,
            string password,
            string policyTitle,
            string policyContent)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a Transaction
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insert into Members Table
                            string insertMemberQuery = @"
                                INSERT INTO Members (first_name, last_name, user_name, email, password, join_date)
                                VALUES (@FirstName, @LastName, @UserName, @Email, @Password, @JoinDate);";

                            int memberID;

                            using (MySqlCommand memberCommand = new MySqlCommand(insertMemberQuery, connection, transaction))
                            {
                                memberCommand.Parameters.AddWithValue("@FirstName", firstName);
                                memberCommand.Parameters.AddWithValue("@LastName", lastName);
                                memberCommand.Parameters.AddWithValue("@UserName", userName);
                                memberCommand.Parameters.AddWithValue("@Email", email);
                                memberCommand.Parameters.AddWithValue("@Password", password);
                                memberCommand.Parameters.AddWithValue("@JoinDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                                memberCommand.ExecuteNonQuery();

                                // Get the last inserted member_id
                                memberID = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID();", connection, transaction).ExecuteScalar());
                            }

                            // Insert Key Policies for New Member
                            string insertPolicyQuery = @"
                                INSERT INTO KeyPolicies (title, content, created_at, updated_at, member_id)
                                VALUES (@PolicyTitle, @PolicyContent, @CreatedAt, @UpdatedAt, @MemberID);";

                            using (MySqlCommand policyCommand = new MySqlCommand(insertPolicyQuery, connection, transaction))
                            {
                                policyCommand.Parameters.AddWithValue("@PolicyTitle", policyTitle);
                                policyCommand.Parameters.AddWithValue("@PolicyContent", policyContent);
                                policyCommand.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                policyCommand.Parameters.AddWithValue("@UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                policyCommand.Parameters.AddWithValue("@MemberID", memberID);

                                policyCommand.ExecuteNonQuery();
                            }

                            // Commit Transaction
                            transaction.Commit();
                            Console.WriteLine("Member & Key Policy Added Successfully!");
                        }
                        catch (Exception ex)
                        {
                            // Rollback transaction in case of an error
                            transaction.Rollback();
                            Console.WriteLine($"Error during transaction: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection Error: {ex.Message}");
            }
        }

        // Method to Get a Specific Key Policy
        public KeyPolicy GetKeyPolicy(int memberID)
        {
            KeyPolicy keyPolicy = null;

            string query = @"
                SELECT policy_id, title, content
                FROM KeyPolicies
                WHERE member_id = @MemberID;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                keyPolicy = new KeyPolicy
                                {
                                    PolicyID = reader.GetInt32("policy_id"),
                                    Title = reader.GetString("title"),
                                    Content = reader.GetString("content")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving key policy: {ex.Message}");
            }

            return keyPolicy;
        }

        #endregion

        #region Project Plans

        // Method to Create a New Project Plan
        public void CreateProjectPlan(int memberID, string title, string description)
        {
            string projectPlanQuery = @"
                INSERT INTO ProjectPlans (created_by, title, description, created_at, updated_at)
                VALUES (@MemberID, @Title, @Description, @CreatedAt, NULL);";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(projectPlanQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberID);
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Description", description);
                        command.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        command.ExecuteNonQuery();
                    }
                }

                Console.WriteLine("Project Plan Created Successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating project plan: {ex.Message}");
            }
        }

        // Method to Retrieve Project Plans for a Member
        public List<ProjectPlan> GetProjectPlans(int memberID)
        {
            List<ProjectPlan> projectPlans = new List<ProjectPlan>();

            string projectPlanQuery = @"
                SELECT plan_id, title, description, created_at, updated_at
                FROM ProjectPlans
                WHERE created_by = @MemberID;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(projectPlanQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                projectPlans.Add(new ProjectPlan
                                {
                                    PlanID = reader.GetInt32("plan_id"),
                                    Title = reader.GetString("title"),
                                    Description = reader.GetString("description"),
                                    CreatedAt = reader.GetDateTime("created_at"),
                                    UpdatedAt = reader.IsDBNull(reader.GetOrdinal("updated_at"))
                                        ? (DateTime?)null
                                        : reader.GetDateTime("updated_at")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving project plans: {ex.Message}");
            }

            return projectPlans;
        }

        #endregion

        #region Chats
        // Method to Retreive all Members
        public List<LoggedInMember> GetAllMembers(int excludeMemberID)
        {
            var members = new List<LoggedInMember>();

            string retreiveMembersQuery = @"SELECT member_id, user_name
            FROM Members
            WHERE member_id != @ExcludeMemberID;";

            using (MySqlConnection connection = new MySqlConnection(connectionString)) 
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(@retreiveMembersQuery, connection))
                {
                    command.Parameters.AddWithValue("@ExcludeMemberID", excludeMemberID);

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        members.Add(new LoggedInMember
                        {
                            MemberID = reader.GetInt32("member_id"),
                            Username = reader.GetString("user_name")
                        });
                    }
                }

            }

            return members;
        }
        // Method to Send Messages
        public void SendMessage(int senderID, int receiverID, string messageContent)
        {
            string sendMessageQuery = @"
                INSERT INTO Chats (sender_id, receiver_id, message_content, sent_time)
                VALUES (@SenderID, @ReceiverID, @MessageContent, @SentTime);";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sendMessageQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SenderID", senderID);
                        command.Parameters.AddWithValue("@Receiver", receiverID);
                        command.Parameters.AddWithValue("@MessageContent", messageContent);
                        command.Parameters.AddWithValue("@SentTime", DateTime.Now);

                        command.ExecuteNonQuery();

                    }
                }

                Console.WriteLine("Sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }

        }

        // Retreive Messages
        public List<ChatMessage> GetMessages(int senderID, int receiverID)
        {
            List<ChatMessage> messages = new List<ChatMessage>();

            string retreiveMessagesQuery = @"
                SELECT
                    m.user_name AS sender_name,
                    c.message_content,
                    c.sent_time
                FROM Chats c
                JOIN Members m ON c.sender_id = m.user_id
                WHERE
                    (c.sender_id = @SenderID AND c.receiver_id = @ReceiverID) OR
                    (c.sender_id = @ReceiverID AND c.receiver_id = @SenderID)
                ORDER BY c.sent_time";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(retreiveMessagesQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SenderID", senderID);
                        command.Parameters.AddWithValue("@ReceiverID", receiverID);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                messages.Add(new ChatMessage
                                {
                                    //SenderID = reader.GetInt32("SenderID"),
                                    //ReceiverID = reader.GetInt32("ReceiverID"),
                                    SenderName = reader.GetString("sender_name"),
                                    MessageContent = reader.GetString("MessageContent"),
                                    SentTime = reader.GetDateTime("SentTime")

                                });
                            }
                        }
                    }

                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message} ");    
            }

            return messages; 
        }
        #endregion
    }
}


