using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TCCRM
{
    class CreateCRMTables
    {

        // Connection string to connect to the database
        private static readonly string connectionString = "server=localhost;database=togetherculturecrm;user=root;password=";


        // Create Tables
        public static void CreateTables()
        {
            // Member Table
            string createMembersTable = @"
            CREATE TABLE IF NOT EXISTS Members(
                member_id INT AUTO_INCREMENT PRIMARY KEY,
                first_name VARCHAR(150) NOT NULL,
                last_name VARCHAR(150) NOT NULL,
                user_name VARCHAR(150) UNIQUE NOT NULL,
                email VARCHAR(150) NOT NULL,
                password VARCHAR(255) NOT NULL,
                join_date DATE NOT NULL
                
            );";

            // Admin Table
            string createAdminTable = @"
            CREATE TABLE IF NOT EXISTS Admin(
                admin_id INT AUTO_INCREMENT PRIMARY KEY,
                full_name VARCHAR(150) NOT NULL,
                user_name VARCHAR(150) UNIQUE NOT NULL,
                password VARCHAR(255) NOT NULL
            );";

            // Posts 
            string createPostsTable = @"
            CREATE TABLE IF NOT EXISTS Posts(
                post_id INT AUTO_INCREMENT PRIMARY KEY,
                member_id INT NOT NULL,
                content TEXT NOT NULL,
                media_url VARCHAR(500),
                created_at DATETIME NOT NULL,

                FOREIGN KEY (member_id) REFERENCES Members(member_id)
                
            );";

            // Chats
            string createChatsTable = @"
            CREATE TABLE IF NOT EXISTS Chats(
                chat_id INT AUTO_INCREMENT PRIMARY KEY,
                sender_id INT NOT NULL,
                receiver_id INT NOT NULL,
                message_content TEXT NOT NULL,
                sent_time DATETIME NOT NULL,

                FOREIGN KEY (sender_id) REFERENCES Members(member_id) ON DELETE CASCADE,
                FOREIGN KEY (receiver_id) REFERENCES Members(member_id) ON DELETE CASCADE

            );";

            // Adding Index for sender_id and receiver_id to improve query performance
            string createChatsIndex = @"
            CREATE INDEX IF NOT EXISTS idx_sender_receiver ON Chats(sender_id, receiver_id);";


            // Key Policies
            string createKeyPoliciesTable = @"
            CREATE TABLE IF NOT EXISTS KeyPolicies(
                policy_id INT AUTO_INCREMENT PRIMARY KEY,
                title VARCHAR(255) NOT NULL,
                content TEXT NOT NULL,
                created_at DATETIME,
                updated_at DATETIME,
                member_id INT NOT NULL,

                FOREIGN KEY (member_id) REFERENCES Members(member_id) ON DELETE CASCADE


            );";

            // ProjectPlans
            string createProjectPlansTable = @"
            CREATE TABLE IF NOT EXISTS ProjectPlans(
                plan_id INT AUTO_INCREMENT PRIMARY KEY,
                created_by INT NOT NULL,
                title VARCHAR(255) NOT NULL,
                description TEXT NOT NULL,
                created_at DATETIME NOT NULL,
                updated_at DATETIME NULL,

                FOREIGN KEY (created_by) REFERENCES Members(member_id) ON DELETE CASCADE           

            );";

            // Events Table
            string createEventsTable = @"
            CREATE TABLE IF NOT EXISTS Events(
                event_id INT AUTO_INCREMENT PRIMARY KEY,
                title VARCHAR(255) NOT NULL,
                description TEXT NOT NULL,
                event_date DATE NOT NULL,
                start_time DATETIME NOT NULL,
                end_time DATETIME NOT NULL,
                location VARCHAR(255) NOT NULL,
                created_by INT,

                FOREIGN KEY (created_by) references Admin (admin_id)
            );";

            // Event Registration
            string createEventRegistrationTable = @"
            CREATE TABLE IF NOT EXISTS EventRegistration(
                registration_id INT AUTO_INCREMENT PRIMARY KEY,
                member_id INT,
                event_id INT,
                registration_date DATE NOT NULL,
                attending_status VARCHAR(20),
                
                FOREIGN KEY (member_id) REFERENCES Members(member_id),
                FOREIGN KEY (event_id) REFERENCES Events(event_id),
                UNIQUE(member_id, event_id)

            );";

            // Event Attendees
            string viewEventAttendees = @"
            CREATE VIEW EventAttendees AS
            SELECT 
                e.event_id, 
                e.title, 
                m.member_id, 
                m.user_name,
                r.registration_date
            FROM 
                Events e
            JOIN 
                EventRegistration r ON e.event_id = r.event_id
            JOIN 
                Members m ON r.member_id = m.member_id;";


            try
            {
                // Open connection to the database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connected");

                    // Create Member Table
                    using (MySqlCommand command = new MySqlCommand(createMembersTable, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Members Table created successfully.");
                    }

                    // Create Admin Table
                    using (MySqlCommand command = new MySqlCommand(createAdminTable, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Admin Table created successfully.");
                    }


                    // Create Posts Table
                    using (MySqlCommand command = new MySqlCommand(createPostsTable, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Posts Table created successfully.");
                    }

                    // Create Chats Table
                    using (MySqlCommand command = new MySqlCommand(createChatsTable, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Chats Table created successfully.");
                    }

                    // Create Index on sender_id and receiver_id
                    using (MySqlCommand command = new MySqlCommand(createChatsIndex, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Index on sender_id and receiver_id created successfully.");
                    }

                    // Create Key Policies Table
                    using (MySqlCommand command = new MySqlCommand(createKeyPoliciesTable, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Key Policies Table created successfully.");
                    }

                    // Create Project Plans Table
                    using (MySqlCommand command = new MySqlCommand(createProjectPlansTable, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Project Plans Table created successfully.");
                    }

                    // Create Events Table
                    using (MySqlCommand command = new MySqlCommand(createEventsTable, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Events Table created successfully.");
                    }

                    // Create Events Registration
                    using (MySqlCommand command = new MySqlCommand(createEventRegistrationTable, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Events Registration Table created successfully.");
                    }

                    // Create Events Attendees
                    using (MySqlCommand command = new MySqlCommand(viewEventAttendees, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Event Attendees created successfully.");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
        
}

