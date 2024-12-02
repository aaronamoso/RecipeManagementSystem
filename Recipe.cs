using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManagementSystem
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public string Servings { get; set; }
        public int Calories { get; set; }
        public string Difficulty { get; set; }
        public string DietaryInfo { get; set; }
        public string Season { get; set; }
        public string MealType { get; set; }
        public string Category { get; set; }

        public Recipe(string name, string author, string ingredients, string instructions,
                      int prepTime, int cookTime, string servings, int calories,
                      string difficulty, string dietaryInfo, string season, string mealType, string category)
        {
            Name = name;
            Author = author;
            Ingredients = ingredients;
            Instructions = instructions;
            PrepTime = prepTime;
            CookTime = cookTime;
            Servings = servings;
            Calories = calories;
            Difficulty = difficulty;
            DietaryInfo = dietaryInfo;
            Season = season;
            MealType = mealType;
            Category = category; 
        }
    }
}