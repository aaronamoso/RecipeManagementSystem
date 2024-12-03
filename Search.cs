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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Clear previous search results
            listBox1.Items.Clear();

            // Get the filtered recipes based on the selected radio button
            var filteredRecipes = FilterRecipes();

            // Populate the ListBox with filtered recipes
            foreach (var recipe in filteredRecipes)
            {
                listBox1.Items.Add(recipe.Name);
            }
        }

        private IEnumerable<Recipe> FilterRecipes()
        {
            // Filter recipes based on the selected category
            if (rbtnBreakfast.Checked)
                return RecipeData.Recipes.Where(r => r.MealType.Equals("Breakfast", StringComparison.OrdinalIgnoreCase));

            if (rbtnLunch.Checked)
                return RecipeData.Recipes.Where(r => r.MealType.Equals("Lunch", StringComparison.OrdinalIgnoreCase));

            if (rbtnDinner.Checked)
                return RecipeData.Recipes.Where(r => r.MealType.Equals("Dinner", StringComparison.OrdinalIgnoreCase));

            if (btnSpecial.Checked)
                return RecipeData.Recipes.Where(r => r.Category.Equals("Special", StringComparison.OrdinalIgnoreCase));

            if (rbtnDesserts.Checked)
                return RecipeData.Recipes.Where(r => r.Category.Equals("Desserts", StringComparison.OrdinalIgnoreCase));

            if (rbtnSnacks.Checked)
                return RecipeData.Recipes.Where(r => r.MealType.Equals("Snack", StringComparison.OrdinalIgnoreCase));

            if (rbtnOneServing.Checked)
                return RecipeData.Recipes.Where(r => r.Servings.Contains("1"));

            if (rbtnFourServing.Checked)
                return RecipeData.Recipes.Where(r => r.Servings.Contains("4"));

            if (rbtnTwoServing.Checked)
                return RecipeData.Recipes.Where(r => r.Servings.Contains("2"));

            if (rbtnSixServing.Checked)
                return RecipeData.Recipes.Where(r => r.Servings.Contains("6"));

            if (rbtnGlutenFree.Checked)
                return RecipeData.Recipes.Where(r => r.DietaryInfo.Equals("Gluten-free", StringComparison.OrdinalIgnoreCase));

            if (rbtnVegan.Checked)
                return RecipeData.Recipes.Where(r => r.DietaryInfo.Equals("Vegan", StringComparison.OrdinalIgnoreCase));

            if (rbtnDairy.Checked)
                return RecipeData.Recipes.Where(r => r.DietaryInfo.Equals("Dairy-free", StringComparison.OrdinalIgnoreCase));

            if (rbtnVegetarian.Checked)
                return RecipeData.Recipes.Where(r => r.DietaryInfo.Equals("Vegetarian", StringComparison.OrdinalIgnoreCase));

            if (rbtnFall.Checked)
                return RecipeData.Recipes.Where(r => r.Season.Equals("Fall", StringComparison.OrdinalIgnoreCase));

            if (rbtnWinter.Checked)
                return RecipeData.Recipes.Where(r => r.Season.Equals("Winter", StringComparison.OrdinalIgnoreCase));

            if (rbtnSummer.Checked)
                return RecipeData.Recipes.Where(r => r.Season.Equals("Summer", StringComparison.OrdinalIgnoreCase));

            if (rbtnSpring.Checked)
                return RecipeData.Recipes.Where(r => r.Season.Equals("Spring", StringComparison.OrdinalIgnoreCase));

            // If no radio button is selected, return all recipes
            return RecipeData.Recipes;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all radio buttons
            rbtnBreakfast.Checked = false;
            rbtnLunch.Checked = false;
            rbtnDinner.Checked = false;
            btnSpecial.Checked = false;
            rbtnDesserts.Checked = false;
            rbtnSnacks.Checked = false;
            rbtnOneServing.Checked = false;
            rbtnFourServing.Checked = false;
            rbtnTwoServing.Checked = false;
            rbtnSixServing.Checked = false;
            rbtnGlutenFree.Checked = false;
            rbtnVegan.Checked = false;
            rbtnDairy.Checked = false;
            rbtnVegetarian.Checked = false;
            rbtnFall.Checked = false;
            rbtnWinter.Checked = false;
            rbtnSummer.Checked = false;
            rbtnSpring.Checked = false;

            // Clear the ListBox
            listBox1.Items.Clear();
        }

    }
}
