using System;
using System.Windows.Forms;

namespace RecipeManagementSystem
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
            LoadRecipes();
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

        private void btnViewAllRecipes_Click(object sender, EventArgs e)
        {
            AllRecipesList allRecipesListForm = new AllRecipesList();
            allRecipesListForm.Show();

            searchBar.Clear();
            LoadRecipes();
        }

        // CHANGESS -- AARON
        private void LoadRecipes()
        {
            lbRecipes.Items.Clear();
            foreach (var recipe in RecipeData.Recipes)
            {
                lbRecipes.Items.Add(recipe.Name);
            }
        }

        // ADD LOGIC HERE WHEN AN ITEM IS CLICKED WITHIN THE LISTBOX, SHOULD DIRECT TO RECIPE DETAILS
        private void lbRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item
 
     

            if (lbRecipes.SelectedItem != null)
            {
                string selectedRecipeName = lbRecipes.SelectedItem.ToString();
                //Recipe selectedRecipe = RecipeData.Recipes.Find(r => r.Name == selectedRecipeName);

                var selectedRecipe = RecipeData.Recipes.FirstOrDefault(r => r.Name == selectedRecipeName);
                if (selectedRecipe != null)
            {
                // Open RecipeDetails form and pass the recipe data
                RecipeDetails detailsForm = new RecipeDetails(selectedRecipe);
                detailsForm.ShowDialog();
            }

            }

           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = searchBar.Text.ToLower();
            lbRecipes.Items.Clear();

            foreach (var recipe in RecipeData.Recipes)
            {
                // Check if the recipe name or its ingredients match the search query
                if (recipe.Name.ToLower().Contains(searchQuery) ||
                    recipe.Ingredients.ToLower().Contains(searchQuery))
                {
                    lbRecipes.Items.Add(recipe.Name); // Add matching recipes to the ListBox
                }
            }

            if (lbRecipes.Items.Count == 0)
            {
                MessageBox.Show("No recipes found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchBar.Text.ToLower();
            lbRecipes.Items.Clear();

            foreach (var recipe in RecipeData.Recipes)
            {
                if (recipe.Name.ToLower().Contains(searchQuery) ||
                    recipe.Ingredients.ToLower().Contains(searchQuery) ||
                    recipe.Author.ToLower().Contains(searchQuery) ||
                    recipe.Category.ToLower().Contains(searchQuery))
                {
                    lbRecipes.Items.Add(recipe.Name);
                }
            }

            if (lbRecipes.Items.Count == 0 && !string.IsNullOrEmpty(searchQuery))
            {
                lbRecipes.Items.Add("No recipes found.");
            }
        }
    }
}

