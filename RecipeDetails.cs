using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManagementSystem
{
    public partial class RecipeDetails : Form
    {
        private Recipe _recipe;
        private PrintDocument printDocument;
        public RecipeDetails(Recipe recipe)
        {
            InitializeComponent();
            _recipe = recipe;
            LoadRecipeDetails();
            InitializePrintDocument();
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

        // PRINT METHOD
        private void InitializePrintDocument()
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPosition = 10;
            float lineHeight = 20;
            Font printFont = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Print recipe details
            e.Graphics.DrawString("Recipe Name: " + _recipe.Name, printFont, brush, 10, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString("Author: " + _recipe.Author, printFont, brush, 10, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString("Calories: " + _recipe.Calories, printFont, brush, 10, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString("Cook Time: " + _recipe.CookTime + " mins", printFont, brush, 10, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString("Prep Time: " + _recipe.PrepTime + " mins", printFont, brush, 10, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString("Difficulty: " + _recipe.Difficulty, printFont, brush, 10, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString("Ingredients:", printFont, brush, 10, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString(_recipe.Ingredients, printFont, brush, 20, yPosition);
            yPosition += lineHeight * 3;

            e.Graphics.DrawString("Instructions:", printFont, brush, 10, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString(_recipe.Instructions, printFont, brush, 20, yPosition);
        }

    }
}
