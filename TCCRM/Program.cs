using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCRM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create the Tables
            //CreateCRMTables.CreateTables();

            // Initialize databaseOperations with connection parameters
            DatabaseOperations dbOps = new DatabaseOperations(
                server: "localhost",
                database: "togetherculturecrm",
                username: "root",
                password: ""
            );

            // Insert Member
            try
            {
                string firstName = "Silvia  ";
                string lastName = "Long";
                string userName = "Sl234";
                string email = "Silvong.test@co.uk";
                string password = "Pass13";
                string policyTitle = "Together Culture Cambridge Policy";
                string policyContent = "The impact we aim to have by 2033 is to tangibly create a more inclusive and ecological economy in Cambridge. " +
                    " \r\n\r\nThree outcomes (the circles) indicate our impact and shape our plan. " +
                    "The arrows in between represent the products and services that we’re iteratively co-creating with our members to deliver those outcomes. ";

                dbOps.InsertMemberWithPolicy(
                firstName,
                    lastName,
                    userName,
                    email,
                    password,
                    policyTitle,
                    policyContent
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting member: {ex.Message}");
            }

            // Insert Admin
            try
            {
                string fullName = "John Dufus";
                string userName = "Jfuss23";
                string password = "Pass123";

                //dbOps.InsertAdmin( fullName, userName, password );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting member: {ex.Message}");
            }
            // Start the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupForm());

        }

    }
}
