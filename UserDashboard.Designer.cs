namespace RecipeManagementSystem
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            label1 = new Label();
            label2 = new Label();
            lbRecipes = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnAdvancedSearch = new Button();
            textBox1 = new TextBox();
            btnSearch = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnViewAllRecipes = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 25);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 0;
            label1.Text = "Mealz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 80);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "Saved recipes:";
            // 
            // lbRecipes
            // 
            lbRecipes.FormattingEnabled = true;
            lbRecipes.ItemHeight = 25;
            lbRecipes.Location = new Point(612, 125);
            lbRecipes.Name = "lbRecipes";
            lbRecipes.Size = new Size(222, 279);
            lbRecipes.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 334);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(333, 334);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 214);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnAdvancedSearch
            // 
            btnAdvancedSearch.Location = new Point(125, 150);
            btnAdvancedSearch.Name = "btnAdvancedSearch";
            btnAdvancedSearch.Size = new Size(235, 34);
            btnAdvancedSearch.TabIndex = 5;
            btnAdvancedSearch.Text = "More search options";
            btnAdvancedSearch.UseVisualStyleBackColor = true;
            btnAdvancedSearch.Click += btnAdvancedSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 31);
            textBox1.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(349, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 252);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 8;
            label3.Text = "New recipes to try:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 306);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 9;
            label4.Text = "Chicken tortillas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 306);
            label5.Name = "label5";
            label5.Size = new Size(187, 25);
            label5.TabIndex = 10;
            label5.Text = "Chocolate fudge cake:";
            // 
            // btnViewAllRecipes
            // 
            btnViewAllRecipes.Location = new Point(321, 252);
            btnViewAllRecipes.Name = "btnViewAllRecipes";
            btnViewAllRecipes.Size = new Size(183, 34);
            btnViewAllRecipes.TabIndex = 11;
            btnViewAllRecipes.Text = "See all recipes";
            btnViewAllRecipes.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(665, 443);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 584);
            Controls.Add(btnLogout);
            Controls.Add(btnViewAllRecipes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(btnAdvancedSearch);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbRecipes);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserDashboard";
            Text = "UserDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lbRecipes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAdvancedSearch;
        private TextBox textBox1;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnViewAllRecipes;
        private Button btnLogout;
    }
}