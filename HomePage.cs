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
        private static readonly HttpClient client = new HttpClient();

        public HomePage()
        {
            InitializeComponent();
            LoadMealCategoriesAsync();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Navigate the user to the login form
            Login loginForm = new Login();
            loginForm.Show();

            //Hide the home page
            this.Hide();
        }

        // Method to fetch meal categories from TheMealDB API
        private async Task LoadMealCategoriesAsync()
        {
            try
            {
                // TheMealDB API URL for fetching categories
                string url = "https://www.themealdb.com/api/json/v1/1/categories.php";
                var response = await client.GetStringAsync(url);
                var categories = JsonConvert.DeserializeObject<MealCategoriesResponse>(response);

                // Populate buttons and images with the fetched data
                PopulateCategoryButtons(categories);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching categories: {ex.Message}");
            }
        }

        // Method to populate buttons and images based on the fetched meal categories
        private void PopulateCategoryButtons(MealCategoriesResponse categories)
        {
            if (categories != null && categories.Meals.Count >= 6)
            {
                // Populate the buttons with category names
                btnSpecial.Text = categories.Meals[0].StrCategory;
                btnBreakfast.Text = categories.Meals[1].StrCategory;
                btnLunch.Text = categories.Meals[2].StrCategory;
                btnDinner.Text = categories.Meals[3].StrCategory;
                btnSnacks.Text = categories.Meals[4].StrCategory;
                btnDessert.Text = categories.Meals[5].StrCategory;

                // Set the images of the picture boxes based on category thumbnails
                pictureBox1.ImageLocation = categories.Meals[0].StrCategoryThumb;
                pictureBox2.ImageLocation = categories.Meals[1].StrCategoryThumb;
                pictureBox3.ImageLocation = categories.Meals[2].StrCategoryThumb;
            }
        }

    }

    // Helper classes to deserialize the API response
    public class MealCategoriesResponse
    {
        [JsonProperty("categories")]
        public List<MealCategory> Meals { get; set; }
    }

    public class MealCategory
    {
        [JsonProperty("strCategory")]
        public string StrCategory { get; set; }

        [JsonProperty("strCategoryThumb")]
        public string StrCategoryThumb { get; set; }
    }
}
