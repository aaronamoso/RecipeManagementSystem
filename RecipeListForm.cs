using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;


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

    private async void LoadRecipes(string category)
    {
        var recipes = await GetRecipesForCategoryAsync(category);

        listBoxRecipes.Items.Clear();
        foreach (var recipe in recipes)
        {
            listBoxRecipes.Items.Add(recipe);
        }
    }

    private async Task<List<string>> GetRecipesForCategoryAsync(string category)
    {
        if (category == "All")
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = "https://www.themealdb.com/api/json/v1/1/search.php?s=";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    dynamic data = JsonConvert.DeserializeObject(responseBody);

                    var meals = ((IEnumerable<dynamic>)data.meals)
                        .Take(20)
                        .Select(meal => (string)meal.strMeal)
                        .ToList();

                    return meals;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to fetch recipes: " + ex.Message);
                    return new List<string> { "Error fetching recipes" };
                }
            }
        }

        // Fallback to local data for other categories
        Dictionary<string, List<string>> recipeDictionary = new Dictionary<string, List<string>>
    {
        { "Special", new List<string> { "Sushi", "Charcuterie" } },
        { "Breakfast", new List<string> { "Pancakes", "Omelette" } },
        { "Lunch", new List<string> { "Sandwich", "Salad" } },
        { "Dinner", new List<string> { "Spaghetti", "Steak" } },
        { "Snacks", new List<string> { "Chips", "Fruit Salad" } },
        { "Dessert", new List<string> { "Ice Cream", "Cake" } }
    };

        return recipeDictionary.ContainsKey(category) ? recipeDictionary[category] : new List<string>();
    }

}
