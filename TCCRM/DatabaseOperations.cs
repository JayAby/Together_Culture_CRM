using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

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
        public List<LoggedInUser> GetAllMembers(int excludeMemberID)
        {
            var members = new List<LoggedInUser>();

            try
            {
                string retreiveMembersQuery = @"
                    SELECT member_id, user_name
                    FROM Members
                    WHERE member_id != @ExcludeMemberID;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(@retreiveMembersQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ExcludeMemberID", excludeMemberID);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                members.Add(new LoggedInUser
                                {
                                    MemberID = reader.GetInt32("member_id"),
                                    Username = reader.GetString("user_name")
                                });
                            }
                        }
                    }

                }
            }
            catch (Exception ex)    
            {
                MessageBox.Show($"Error : {ex.Message}");
                return new List<LoggedInUser>();
            }

            return members;


        }
        // Method to Send Messages
        public async Task<bool> SendMessageAsync(int senderID, int receiverID, string messageContent)
        {
            try
            {
                // Debugging: Log senderID
                Console.WriteLine($"Attempting to send message from Sender ID: {senderID}, Receiver ID: {receiverID}");

                // Connection string and SQL queries
                string checkMemberQuery = "SELECT COUNT(*) FROM Members WHERE member_id = @MemberID";
                string insertChatQuery = @"
                    INSERT INTO Chats (sender_id, receiver_id, message_content, sent_time)
                    VALUES (@SenderID, @ReceiverID, @MessageContent, @SentTime);";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // Check if the sender exists
                    using (MySqlCommand checkSenderCommand = new MySqlCommand(checkMemberQuery, connection))
                    {
                        checkSenderCommand.Parameters.AddWithValue("@MemberID", senderID);
                        int senderCount = Convert.ToInt32(await checkSenderCommand.ExecuteScalarAsync());
                        if (senderCount == 0)
                        {
                            Console.WriteLine($"Sender ID {senderID} does not exist in the Members table.");
                            return false; // Sender does not exist
                        }
                    }

                    // Check if the receiver exists
                    using (MySqlCommand checkReceiverCommand = new MySqlCommand(checkMemberQuery, connection))
                    {
                        checkReceiverCommand.Parameters.AddWithValue("@MemberID", receiverID);
                        int receiverCount = Convert.ToInt32(await checkReceiverCommand.ExecuteScalarAsync());
                        if (receiverCount == 0)
                        {
                            Console.WriteLine($"Receiver ID {receiverID} does not exist in the Members table.");
                            return false; // Receiver does not exist
                        }
                    }

                    // Insert the message into the Chats table
                    using (MySqlCommand insertCommand = new MySqlCommand(insertChatQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@SenderID", senderID);
                        insertCommand.Parameters.AddWithValue("@ReceiverID", receiverID);
                        insertCommand.Parameters.AddWithValue("@MessageContent", messageContent);
                        insertCommand.Parameters.AddWithValue("@SentTime", DateTime.Now);

                        await insertCommand.ExecuteNonQueryAsync();
                    }

                    return true; // Message sent successfully
           

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message: {ex.Message}");
                return false;
            }

        }


        // Retreive Messages
        public async Task<List<ChatMessage>> GetMessagesAsync(int senderID, int receiverID)
        {
            try
            {
                List<ChatMessage> messages = new List<ChatMessage>();

                string retreiveMessagesQuery = @"
                SELECT
                    m.user_name AS sender_name,
                    c.message_content,
                    c.sent_time
                FROM Chats c
                JOIN Members m ON c.sender_id = m.member_id
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
                                        MessageContent = reader.GetString("message_content"),
                                        SentTime = reader.GetDateTime("sent_time")

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
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new List<ChatMessage>();
            }
        }
        #endregion

        #region Admin
        // Method to insert Admin Record
        public void InsertAdmin(
            string fullName,
            string userName,
            string password)
        {
            string insertAdminQuery = @"
            INSERT INTO Admin (full_name, user_name, password)
            VALUES (@FullName, @UserName, @Password);";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand insertAdminCommand = new MySqlCommand(insertAdminQuery, connection))
                    {
                        insertAdminCommand.Parameters.AddWithValue("@FullName", fullName);
                        insertAdminCommand.Parameters.AddWithValue("@UserName", userName);
                        insertAdminCommand.Parameters.AddWithValue("@Password", password);

                        insertAdminCommand.ExecuteNonQuery();

                    }
                }
                Console.WriteLine("Admin added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection Error: {ex.Message}");
            }
        }


        #endregion

        #region Events
        public void MakeEvents(
            int adminID,
            string title,
            string description,
            DateTime eventDate,
            DateTime startTime, 
            DateTime endTime, 
            string location)
        {
            string insertEventsQuery = @"
            INSERT INTO Events (created_by, title, description, event_date, start_time, end_time, location)
            VALUES (@CreatedBy, @Title, @Description, @EventDate, @StartTime, @EndTime, @Location);";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand insertEventsCommand = new MySqlCommand(insertEventsQuery, connection))
                    {
                        insertEventsCommand.Parameters.AddWithValue("@CreatedBy", adminID);
                        insertEventsCommand.Parameters.AddWithValue("@Title", title);
                        insertEventsCommand.Parameters.AddWithValue("@Description", description);
                        insertEventsCommand.Parameters.AddWithValue("@EventDate", eventDate);
                        insertEventsCommand.Parameters.AddWithValue("@StartTime", startTime);
                        insertEventsCommand.Parameters.AddWithValue("@EndTime", endTime);
                        insertEventsCommand.Parameters.AddWithValue("@Location", location);

                        insertEventsCommand.ExecuteNonQuery();

                    }
                }
                Console.WriteLine("Events Table created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating Event: {ex.Message}");
            }
        }

        public DataTable GetAllEvents()
        {
            string getAllEventQuery = @"
            SELECT event_id, title, description, event_date, start_time, end_time, location FROM Events";

            DataTable eventsTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString)) 
                {
                    connection.Open();

                    using (MySqlCommand getEventsCommand = new MySqlCommand(getAllEventQuery, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(getEventsCommand);
                        adapter.Fill(eventsTable);   // Fill the DataTable
                    }
                }

                return eventsTable;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving event table: {ex.Message}");
                return null;
            }

        }

        public DataTable GetFilteredEvents(DateTime startDate, DateTime endDate)
        {
            string getFilteredEventQuery = @"
            SELECT event_id, title, description, event_date, start_time, end_time, location
            FROM Events
            WHERE event_date BETWEEN @StartDate AND @EndDate";

            DataTable eventsTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand getEventsCommand = new MySqlCommand(getFilteredEventQuery, connection))
                    {
                        getEventsCommand.Parameters.AddWithValue("@StartDate", startDate);
                        getEventsCommand.Parameters.AddWithValue("@EndDate", endDate);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(getEventsCommand);
                        adapter.Fill(eventsTable);

                    }
                }

                return eventsTable;
                
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error retrieving event table: {ex.Message}");
                return null;
            }
        }

        #endregion

        #region Posts
        public DataTable RetreivePosts()
        {
            try
            {
                string retrievePostsQuery = @"
                    SELECT m.user_name, p.content, p.created_at
                    FROM Posts p
                    INNER JOIN Members m ON p.member_id = m.member_id
                    ORDER BY p.created_at DESC";

                DataTable postsTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand retrievePostsCommand = new MySqlCommand(retrievePostsQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(retrievePostsCommand))
                        {
                            adapter.Fill(postsTable);
                        }
                    }
                }
                return postsTable;
            }
            catch (Exception ex)
            {
                // Log error (consider a logging library like NLog or Serilog)
                Console.WriteLine($"Error retrieving all posts: {ex.Message}");
                return null;
            }
        }


        public DataTable RetreiveNewPosts(DateTime lastFetchedTime)
        {
            try
            {
                string retrieveNewPostsQuery = @"
                    SELECT m.user_name, p.content, p.created_at
                    FROM Posts p
                    INNER JOIN Members m ON p.member_id = m.member_id
                    WHERE p.created_at > @LastFetched
                    ORDER BY p.created_at";

                DataTable postsTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand retrieveNewPostsCommand = new MySqlCommand(retrieveNewPostsQuery, connection))
                    {
                        retrieveNewPostsCommand.Parameters.AddWithValue("@LastFetched", lastFetchedTime);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(retrieveNewPostsCommand))
                        {
                            adapter.Fill(postsTable);
                        }
                    }
                }
                return postsTable;
            }
            catch (Exception ex)
            {
                // Log error
                Console.WriteLine($"Error retrieving new posts: {ex.Message}");
                return null;
            }
        }


        public void InsertPost(int memberID, string content)
        {
            try
            {
                string insertPostQuery = @"
                    INSERT INTO Posts (member_id, content, created_at)
                    VALUES (@MemberID, @Content, NOW())";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand insertPostCommand = new MySqlCommand(insertPostQuery, connection))
                    {
                        insertPostCommand.Parameters.AddWithValue("@MemberID", memberID);
                        insertPostCommand.Parameters.AddWithValue("@Content", content);

                        insertPostCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log error
                Console.WriteLine($"Error inserting new posts: {ex.Message}");
            }
        }


        #endregion
    }
}


