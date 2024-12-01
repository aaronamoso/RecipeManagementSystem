using System;
using System.Windows.Forms;

namespace RecipeManagementSystem
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
        
            foreach (Form form in Application.OpenForms)
            {
                if (form is Search)
                {
                    form.Focus();
                    return;
                }
            }

         
            Search searchForm = new Search();
            searchForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {              
                this.Hide();
                HomePage homePageForm = new HomePage();
                homePageForm.Show();
            }
        }

     }
}
