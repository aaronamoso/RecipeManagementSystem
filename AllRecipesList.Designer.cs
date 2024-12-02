namespace RecipeManagementSystem
{
    partial class AllRecipesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllRecipesList));
            lbAllRecipes = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbAllRecipes
            // 
            lbAllRecipes.Font = new Font("Elephant", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAllRecipes.ForeColor = Color.SteelBlue;
            lbAllRecipes.FormattingEnabled = true;
            lbAllRecipes.Items.AddRange(new object[] { "Banana-Choco Apples", "Charcuterie Board", "Cheesy Crab Panini", "Chicken Curry", "Deluxe Pita Pizzas", "Dessert Bars", "Pasta-To-Go Sandwich", "Savory Mashed Potatoes", "Spaghetti Bolognese", "Taco Salad" });
            lbAllRecipes.Location = new Point(92, 119);
            lbAllRecipes.Name = "lbAllRecipes";
            lbAllRecipes.Size = new Size(319, 244);
            lbAllRecipes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(174, 60);
            label1.TabIndex = 1;
            label1.Text = "Mealz";
            // 
            // AllRecipesList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(517, 537);
            Controls.Add(label1);
            Controls.Add(lbAllRecipes);
            Name = "AllRecipesList";
            Text = "Recipes ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAllRecipes;
        private Label label1;
    }
}