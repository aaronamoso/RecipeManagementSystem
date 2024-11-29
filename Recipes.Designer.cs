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
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbRecipe).BeginInit();
            SuspendLayout();
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecipeName.Location = new Point(66, 45);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(121, 25);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe name";
            // 
            // pbRecipe
            // 
            pbRecipe.Location = new Point(268, 23);
            pbRecipe.Name = "pbRecipe";
            pbRecipe.Size = new Size(187, 86);
            pbRecipe.TabIndex = 1;
            pbRecipe.TabStop = false;
            // 
            // lblRecipeAuthor
            // 
            lblRecipeAuthor.AutoSize = true;
            lblRecipeAuthor.Location = new Point(66, 84);
            lblRecipeAuthor.Name = "lblRecipeAuthor";
            lblRecipeAuthor.Size = new Size(120, 25);
            lblRecipeAuthor.TabIndex = 2;
            lblRecipeAuthor.Text = "Recipe author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(32, 141);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 3;
            label3.Text = "Time to cook:";
            // 
            // lblCookingTime
            // 
            lblCookingTime.AutoSize = true;
            lblCookingTime.Location = new Point(189, 141);
            lblCookingTime.Name = "lblCookingTime";
            lblCookingTime.Size = new Size(116, 25);
            lblCookingTime.TabIndex = 4;
            lblCookingTime.Text = "cooking time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(453, 141);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 5;
            label5.Text = "Prep time: ";
            // 
            // lblPrepTime
            // 
            lblPrepTime.AutoSize = true;
            lblPrepTime.Location = new Point(563, 141);
            lblPrepTime.Name = "lblPrepTime";
            lblPrepTime.Size = new Size(144, 25);
            lblPrepTime.TabIndex = 6;
            lblPrepTime.Text = "preparation time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(32, 177);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 7;
            label7.Text = "Difficulty level:";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Location = new Point(189, 177);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(243, 25);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "beginner, experienced, expert";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(453, 177);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 9;
            label9.Text = "Calories:";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(564, 177);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(113, 25);
            lblCalories.TabIndex = 10;
            lblCalories.Text = "calorie count";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 242);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 11;
            label1.Text = "Ingredients:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 242);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 12;
            label2.Text = "Instructions:";
            // 
            // Recipes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
    }
}