using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace RecipeManagementSystem
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Navigate the user to the login form
            Login loginForm = new Login();
            loginForm.Show();

            //Hide the home page
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            OpenRecipeList("Special");
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            OpenRecipeList("Breakfast");
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            OpenRecipeList("Lunch");
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            OpenRecipeList("Dinner");
        }

        private void btnSnacks_Click(object sender, EventArgs e)
        {
            OpenRecipeList("Snacks");
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            OpenRecipeList("Dessert");
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            OpenRecipeList("All");
        }

        private void OpenRecipeList(string category)
        {
            RecipeListForm recipeListForm = new RecipeListForm(category);
            recipeListForm.Show();
        }
    }
}
