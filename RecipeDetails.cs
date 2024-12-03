using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManagementSystem
{
    public partial class RecipeDetails : Form
    {
        private Recipe _recipe;
        public RecipeDetails(Recipe recipe)
        {
            InitializeComponent();
            _recipe = recipe;
            LoadRecipeDetails();
        }

        private void LoadRecipeDetails()
        {

            if (_recipe == null) return; // Ensure the recipe is not null
            lblRecipeName.Text = _recipe.Name;
            lblRecipeAuthor.Text = $"{_recipe.Author}";
            lblCalories.Text = $"{_recipe.Calories}";
            lblCookingTime.Text = $"{_recipe.CookTime} mins";
            lblPrepTime.Text = $"{_recipe.PrepTime} mins";
            lblDifficulty.Text = $"{_recipe.Difficulty} cal";
            txtIngredients.Text = _recipe.Ingredients;
            txtInstructions.Text = _recipe.Instructions;

            if (!string.IsNullOrEmpty(_recipe.ImagePath))
            {
                pbRecipe.ImageLocation = _recipe.ImagePath; // Ensure the image file exists
            }
        }
    }
}
