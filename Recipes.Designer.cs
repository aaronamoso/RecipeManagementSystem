namespace RecipeManagementSystem
{
    partial class Recipes
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
            lblRecipeName = new Label();
            pbRecipe = new PictureBox();
            lblRecipeAuthor = new Label();
            label3 = new Label();
            lblCookingTime = new Label();
            label5 = new Label();
            lblPrepTime = new Label();
            label7 = new Label();
            lblDifficulty = new Label();
            label9 = new Label();
            lblCalories = new Label();
            lblIngredients = new Label();
            lblInstructions = new Label();
            label1 = new Label();
            txtIngredients = new RichTextBox();
            txtInstructions = new RichTextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbRecipe).BeginInit();
            SuspendLayout();
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeName.ForeColor = Color.SteelBlue;
            lblRecipeName.Location = new Point(54, 104);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(218, 36);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe name";
            // 
            // pbRecipe
            // 
            pbRecipe.Location = new Point(347, 18);
            pbRecipe.Name = "pbRecipe";
            pbRecipe.Size = new Size(285, 204);
            pbRecipe.TabIndex = 1;
            pbRecipe.TabStop = false;
            // 
            // lblRecipeAuthor
            // 
            lblRecipeAuthor.AutoSize = true;
            lblRecipeAuthor.Font = new Font("Microsoft Sans Serif", 9F);
            lblRecipeAuthor.ForeColor = Color.LightSlateGray;
            lblRecipeAuthor.Location = new Point(67, 162);
            lblRecipeAuthor.Name = "lblRecipeAuthor";
            lblRecipeAuthor.Size = new Size(122, 22);
            lblRecipeAuthor.TabIndex = 2;
            lblRecipeAuthor.Text = "Recipe author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(23, 248);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 3;
            label3.Text = "Time to cook:";
            // 
            // lblCookingTime
            // 
            lblCookingTime.AutoSize = true;
            lblCookingTime.Font = new Font("Cooper Black", 10F);
            lblCookingTime.ForeColor = Color.LightSlateGray;
            lblCookingTime.Location = new Point(179, 248);
            lblCookingTime.Name = "lblCookingTime";
            lblCookingTime.Size = new Size(56, 23);
            lblCookingTime.TabIndex = 4;
            lblCookingTime.Text = "time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 10F);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(241, 248);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 5;
            label5.Text = "Prep time: ";
            // 
            // lblPrepTime
            // 
            lblPrepTime.AutoSize = true;
            lblPrepTime.Font = new Font("Cooper Black", 10F);
            lblPrepTime.ForeColor = Color.LightSlateGray;
            lblPrepTime.Location = new Point(366, 248);
            lblPrepTime.Name = "lblPrepTime";
            lblPrepTime.Size = new Size(56, 23);
            lblPrepTime.TabIndex = 6;
            lblPrepTime.Text = "time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(428, 248);
            label7.Name = "label7";
            label7.Size = new Size(169, 23);
            label7.TabIndex = 7;
            label7.Text = "Difficulty level:";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Cooper Black", 10F);
            lblDifficulty.ForeColor = Color.LightSlateGray;
            lblDifficulty.Location = new Point(603, 248);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(106, 23);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "difficulty";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cooper Black", 10F);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(720, 248);
            label9.Name = "label9";
            label9.Size = new Size(99, 23);
            label9.TabIndex = 9;
            label9.Text = "Calories:";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Cooper Black", 10F);
            lblCalories.ForeColor = Color.LightSlateGray;
            lblCalories.Location = new Point(825, 248);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(90, 23);
            lblCalories.TabIndex = 10;
            lblCalories.Text = "calories";
            // 
            // lblIngredients
            // 
            lblIngredients.AutoSize = true;
            lblIngredients.Font = new Font("Cooper Black", 10F);
            lblIngredients.ForeColor = Color.SteelBlue;
            lblIngredients.Location = new Point(23, 308);
            lblIngredients.Name = "lblIngredients";
            lblIngredients.Size = new Size(134, 23);
            lblIngredients.TabIndex = 11;
            lblIngredients.Text = "Ingredients:";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Cooper Black", 10F);
            lblInstructions.ForeColor = Color.SteelBlue;
            lblInstructions.Location = new Point(366, 308);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(143, 23);
            lblInstructions.TabIndex = 12;
            lblInstructions.Text = "Instructions:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 64);
            label1.TabIndex = 13;
            label1.Text = "Mealz";
            // 
            // txtIngredients
            // 
            txtIngredients.BackColor = Color.AliceBlue;
            txtIngredients.Location = new Point(38, 336);
            txtIngredients.Name = "txtIngredients";
            txtIngredients.Size = new Size(307, 284);
            txtIngredients.TabIndex = 14;
            txtIngredients.Text = "";
            // 
            // txtInstructions
            // 
            txtInstructions.BackColor = Color.AliceBlue;
            txtInstructions.Location = new Point(382, 336);
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(521, 284);
            txtInstructions.TabIndex = 15;
            txtInstructions.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(723, 28);
            button1.Name = "button1";
            button1.Size = new Size(158, 45);
            button1.TabIndex = 16;
            button1.Text = "Save recipe";
            button1.UseVisualStyleBackColor = false;
            // 
            // Recipes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(946, 648);
            Controls.Add(button1);
            Controls.Add(txtInstructions);
            Controls.Add(txtIngredients);
            Controls.Add(label1);
            Controls.Add(lblInstructions);
            Controls.Add(lblIngredients);
            Controls.Add(lblCalories);
            Controls.Add(label9);
            Controls.Add(lblDifficulty);
            Controls.Add(label7);
            Controls.Add(lblPrepTime);
            Controls.Add(label5);
            Controls.Add(lblCookingTime);
            Controls.Add(label3);
            Controls.Add(lblRecipeAuthor);
            Controls.Add(pbRecipe);
            Controls.Add(lblRecipeName);
            Name = "Recipes";
            Text = "Recipes";
            ((System.ComponentModel.ISupportInitialize)pbRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRecipeName;
        private PictureBox pbRecipe;
        private Label lblRecipeAuthor;
        private Label label3;
        private Label lblCookingTime;
        private Label label5;
        private Label lblPrepTime;
        private Label label7;
        private Label lblDifficulty;
        private Label label9;
        private Label lblCalories;
        private Label lblIngredients;
        private Label lblInstructions;
        private Label label1;
        private RichTextBox txtIngredients;
        private RichTextBox txtInstructions;
        private Button button1;
    }
}