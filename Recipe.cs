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
        public int PrepTime { get; set; }  // in minutes
        public int CookTime { get; set; }  // in minutes
        public string Servings { get; set; }
        public int Calories { get; set; }
        public string Difficulty { get; set; }
        public string DietaryRestrictions { get; set; }
        public string Season { get; set; }
        public string MealType { get; set; }

        public Recipe(string name, string author, string ingredients, string instructions, int prepTime, int cookTime, string servings, int calories, string difficulty, string dietaryRestrictions, string season, string mealType)
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
            DietaryRestrictions = dietaryRestrictions;
            Season = season;
            MealType = mealType;
        }
    }
}
