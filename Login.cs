using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RecipeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Add event handlers for KeyDown event
            txtUsername.KeyDown += TxtUsername_KeyDown;
            txtPassword.KeyDown += TxtPassword_KeyDown;
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick(); // Trigger the click event of the Submit button
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick(); // Trigger the click event of the Submit button
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Passwords just for an example, this should be replaced with a secure storage in a real app
            var users = new Dictionary<string, string>
            {
                { "user1", "password123" },
                { "user2", "password234" }
            };
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (users.TryGetValue(username, out string storedPassword) && storedPassword == password)
            {
                MessageBox.Show("Login successful! Welcome " + username + "!");

                //Navigate the user to their user dashboard in the Mealz recipe management system
                UserDashboard userDashboard = new UserDashboard();
                userDashboard.Show();

                //Close the login form 
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
