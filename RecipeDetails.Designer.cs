namespace RecipeManagementSystem
{
    partial class RecipeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeDetails));
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
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)pbRecipe).BeginInit();
            SuspendLayout();
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecipeName.ForeColor = Color.SteelBlue;
            lblRecipeName.Location = new Point(334, 59);
            lblRecipeName.Margin = new Padding(2, 0, 2, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(141, 26);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe name";
            // 
            // pbRecipe
            // 
            pbRecipe.Location = new Point(512, 155);
            pbRecipe.Margin = new Padding(2, 2, 2, 2);
            pbRecipe.Name = "pbRecipe";
            pbRecipe.Size = new Size(241, 172);
            pbRecipe.TabIndex = 1;
            pbRecipe.TabStop = false;
            // 
            // lblRecipeAuthor
            // 
            lblRecipeAuthor.AutoSize = true;
            lblRecipeAuthor.Font = new Font("Microsoft Sans Serif", 9F);
            lblRecipeAuthor.ForeColor = Color.LightSlateGray;
            lblRecipeAuthor.Location = new Point(359, 94);
            lblRecipeAuthor.Margin = new Padding(2, 0, 2, 0);
            lblRecipeAuthor.Name = "lblRecipeAuthor";
            lblRecipeAuthor.Size = new Size(84, 15);
            lblRecipeAuthor.TabIndex = 2;
            lblRecipeAuthor.Text = "Recipe author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(319, 175);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 3;
            label3.Text = "Time to cook:";
            // 
            // lblCookingTime
            // 
            lblCookingTime.AutoSize = true;
            lblCookingTime.Font = new Font("Microsoft Sans Serif", 10F);
            lblCookingTime.ForeColor = Color.LightSlateGray;
            lblCookingTime.Location = new Point(416, 175);
            lblCookingTime.Margin = new Padding(2, 0, 2, 0);
            lblCookingTime.Name = "lblCookingTime";
            lblCookingTime.Size = new Size(34, 17);
            lblCookingTime.TabIndex = 4;
            lblCookingTime.Text = "time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(319, 208);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 5;
            label5.Text = "Prep time: ";
            // 
            // lblPrepTime
            // 
            lblPrepTime.AutoSize = true;
            lblPrepTime.Font = new Font("Microsoft Sans Serif", 10F);
            lblPrepTime.ForeColor = Color.LightSlateGray;
            lblPrepTime.Location = new Point(393, 208);
            lblPrepTime.Margin = new Padding(2, 0, 2, 0);
            lblPrepTime.Name = "lblPrepTime";
            lblPrepTime.Size = new Size(34, 17);
            lblPrepTime.TabIndex = 6;
            lblPrepTime.Text = "time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(319, 244);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 17);
            label7.TabIndex = 7;
            label7.Text = "Difficulty level:";
            // 
            // lblDifficulty
            // 
            lblDifficulty.AutoSize = true;
            lblDifficulty.Font = new Font("Microsoft Sans Serif", 10F);
            lblDifficulty.ForeColor = Color.LightSlateGray;
            lblDifficulty.Location = new Point(421, 244);
            lblDifficulty.Margin = new Padding(2, 0, 2, 0);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(59, 17);
            lblDifficulty.TabIndex = 8;
            lblDifficulty.Text = "difficulty";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(319, 281);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 17);
            label9.TabIndex = 9;
            label9.Text = "Calories:";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Microsoft Sans Serif", 10F);
            lblCalories.ForeColor = Color.LightSlateGray;
            lblCalories.Location = new Point(386, 281);
            lblCalories.Margin = new Padding(2, 0, 2, 0);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(57, 17);
            lblCalories.TabIndex = 10;
            lblCalories.Text = "calories";
            // 
            // lblIngredients
            // 
            lblIngredients.AutoSize = true;
            lblIngredients.Font = new Font("Microsoft Sans Serif", 10F);
            lblIngredients.ForeColor = Color.SteelBlue;
            lblIngredients.Location = new Point(76, 138);
            lblIngredients.Margin = new Padding(2, 0, 2, 0);
            lblIngredients.Name = "lblIngredients";
            lblIngredients.Size = new Size(82, 17);
            lblIngredients.TabIndex = 11;
            lblIngredients.Text = "Ingredients:";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Microsoft Sans Serif", 10F);
            lblInstructions.ForeColor = Color.SteelBlue;
            lblInstructions.Location = new Point(74, 326);
            lblInstructions.Margin = new Padding(2, 0, 2, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(84, 17);
            lblInstructions.TabIndex = 12;
            lblInstructions.Text = "Instructions:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 44);
            label1.TabIndex = 13;
            label1.Text = "Mealz";
            // 
            // txtIngredients
            // 
            txtIngredients.BackColor = Color.AliceBlue;
            txtIngredients.Location = new Point(87, 155);
            txtIngredients.Margin = new Padding(2, 2, 2, 2);
            txtIngredients.Name = "txtIngredients";
            txtIngredients.Size = new Size(216, 172);
            txtIngredients.TabIndex = 14;
            txtIngredients.Text = "";
            // 
            // txtInstructions
            // 
            txtInstructions.BackColor = Color.AliceBlue;
            txtInstructions.Location = new Point(85, 343);
            txtInstructions.Margin = new Padding(2, 2, 2, 2);
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(668, 172);
            txtInstructions.TabIndex = 15;
            txtInstructions.Text = "";
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.SteelBlue;
            btnPrint.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.AliceBlue;
            btnPrint.Location = new Point(642, 110);
            btnPrint.Margin = new Padding(2, 2, 2, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(111, 27);
            btnPrint.TabIndex = 16;
            btnPrint.Text = "Print recipe";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // RecipeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(889, 592);
            Controls.Add(btnPrint);
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "RecipeDetails";
            Text = "Recipes";
            ((System.ComponentModel.ISupportInitialize)pbRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label lblRecipeName;
        //private PictureBox pbRecipe;
        //private Label lblRecipeAuthor;
        private Label label3;
        //private Label lblCookingTime;
        private Label label5;
        //private Label lblPrepTime;
        private Label label7;
        //private Label lblDifficulty;
        private Label label9;
        //private Label lblCalories;
        private Label lblIngredients;
        private Label lblInstructions;
        private Label label1;
        //private RichTextBox txtIngredients;
        //private RichTextBox txtInstructions;
        private Button btnPrint;

        internal Label lblRecipeName;
        internal PictureBox pbRecipe;
        internal Label lblRecipeAuthor;
        internal Label lblCalories;
        internal Label lblCookingTime;
        internal Label lblPrepTime;
        internal Label lblDifficulty;
        internal RichTextBox txtIngredients;
        internal RichTextBox txtInstructions;

    }
}