using MySql.Data.MySqlClient;
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
    public partial class MemberPosts : UserControl
    {
        private string connectionString = "server=localhost;database=togetherculturecrm;user=root;password=";
        private MemberHome parentHome;

        public void SetParentHome(MemberHome home)
        {
            parentHome = home;
        }
        public MemberPosts()
        {
            InitializeComponent();
        }

        private void btnMakePost_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Success", "Connected");
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
