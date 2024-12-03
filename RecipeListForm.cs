using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RecipeManagementSystem; 

public partial class RecipeListForm : Form
{
    private ListBox listBoxRecipes;

    public RecipeListForm(string category)
    {
        InitializeComponent();
        LoadRecipes(category);
    }

    private void InitializeComponent()
    {
        // Initialize the listBoxRecipes control
        listBoxRecipes = new ListBox();
        listBoxRecipes.Location = new Point(50, 50);
        listBoxRecipes.Size = new Size(300, 200);
        Controls.Add(listBoxRecipes);

        // Set the form's size
        this.Size = new Size(400, 400);
        this.Text = "Recipe List";
    }

    private void LoadRecipes(string category)
    {
        var recipes = GetRecipesForCategory(category);

        listBoxRecipes.Items.Clear();
        foreach (var recipe in recipes)
        {
            listBoxRecipes.Items.Add(recipe.Name); 
        }
    }

    private List<Recipe> GetRecipesForCategory(string category)
    {
        // Access the static Recipes property from RecipeData
        List<Recipe> allRecipes = RecipeData.Recipes;

        if (category == "All")
        {
            return allRecipes; 
        }

        // Filter by category 
        return allRecipes.Where(r => r.MealType.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
