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
        // Replace with actual recipe fetching logic
        List<string> recipes = GetRecipesForCategory(category);

        // Display the recipes in the ListBox
        listBoxRecipes.Items.Clear();
        foreach (var recipe in recipes)
        {
            listBoxRecipes.Items.Add(recipe);
        }
    }

    private List<string> GetRecipesForCategory(string category)
    {
        // Sample data, replace with actual recipe fetching logic
        Dictionary<string, List<string>> recipes = new Dictionary<string, List<string>>
        {
            { "Special", new List<string> { "Special Recipe 1", "Special Recipe 2" } },
            { "Breakfast", new List<string> { "Pancakes", "Omelette" } },
            { "Lunch", new List<string> { "Sandwich", "Salad" } },
            { "Dinner", new List<string> { "Spaghetti", "Steak" } },
            { "Snacks", new List<string> { "Chips", "Fruit Salad" } },
            { "Dessert", new List<string> { "Ice Cream", "Cake" } }
        };

        return recipes.ContainsKey(category) ? recipes[category] : new List<string>();
    }
}
