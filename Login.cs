using System;
using System.Windows.Forms;

namespace RecipeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
