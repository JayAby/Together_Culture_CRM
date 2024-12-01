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

                FOREIGN KEY (sender_id) REFERENCES Members(member_id),
                FOREIGN KEY (receiver_id) REFERENCES Members(member_id)               

            );";

            // Key Policies
            string createKeyPoliciesTable = @"
            CREATE TABLE IF NOT EXISTS KeyPolicies(
                policy_id INT AUTO_INCREMENT PRIMARY KEY,
                title VARCHAR(255) NOT NULL,
                content TEXT NOT NULL,
                created_at DATETIME,
                updated_at DATETIME,
                member_id INT NOT NULL,

                FOREIGN KEY (member_id) REFERENCES Members(member_id)


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

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
        
}

