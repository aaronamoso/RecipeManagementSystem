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
            searchBar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnViewAllRecipes = new Button();
            btnLogout = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(29, 25);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 60);
            label1.TabIndex = 0;
            label1.Text = "Mealz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(591, 87);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 1;
            label2.Text = "Recipes:";
            // 
            // lbRecipes
            // 
            lbRecipes.BackColor = Color.AliceBlue;
            lbRecipes.FormattingEnabled = true;
            lbRecipes.ItemHeight = 25;
            lbRecipes.Location = new Point(611, 125);
            lbRecipes.Margin = new Padding(1, 2, 1, 2);
            lbRecipes.Name = "lbRecipes";
            lbRecipes.Size = new Size(243, 329);
            lbRecipes.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 338);
            pictureBox1.Margin = new Padding(1, 2, 1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(331, 338);
            pictureBox2.Margin = new Padding(1, 2, 1, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(181, 213);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnAdvancedSearch
            // 
            btnAdvancedSearch.BackColor = Color.SteelBlue;
            btnAdvancedSearch.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdvancedSearch.ForeColor = Color.AliceBlue;
            btnAdvancedSearch.Location = new Point(29, 168);
            btnAdvancedSearch.Margin = new Padding(1, 2, 1, 2);
            btnAdvancedSearch.Name = "btnAdvancedSearch";
            btnAdvancedSearch.Size = new Size(301, 55);
            btnAdvancedSearch.TabIndex = 5;
            btnAdvancedSearch.Text = "More search options";
            btnAdvancedSearch.UseVisualStyleBackColor = false;
            btnAdvancedSearch.Click += btnAdvancedSearch_Click;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.AliceBlue;
            searchBar.Location = new Point(269, 114);
            searchBar.Margin = new Padding(1, 2, 1, 2);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(305, 31);
            searchBar.TabIndex = 6;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(40, 262);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(246, 27);
            label3.TabIndex = 8;
            label3.Text = "New recipes to try:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSlateGray;
            label4.Location = new Point(74, 308);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 9;
            label4.Text = "Chicken tortillas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightSlateGray;
            label5.Location = new Point(321, 308);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 10;
            label5.Text = "Chocolate cake:";
            // 
            // btnViewAllRecipes
            // 
            btnViewAllRecipes.BackColor = Color.SteelBlue;
            btnViewAllRecipes.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewAllRecipes.ForeColor = Color.AliceBlue;
            btnViewAllRecipes.Location = new Point(349, 168);
            btnViewAllRecipes.Margin = new Padding(1, 2, 1, 2);
            btnViewAllRecipes.Name = "btnViewAllRecipes";
            btnViewAllRecipes.Size = new Size(231, 55);
            btnViewAllRecipes.TabIndex = 11;
            btnViewAllRecipes.Text = "See all recipes";
            btnViewAllRecipes.UseVisualStyleBackColor = false;
            btnViewAllRecipes.Click += btnViewAllRecipes_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.AliceBlue;
            btnLogout.Location = new Point(659, 488);
            btnLogout.Margin = new Padding(1, 2, 1, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(151, 62);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(38, 116);
            label6.Name = "label6";
            label6.Size = new Size(203, 27);
            label6.TabIndex = 13;
            label6.Text = "Search recipes: ";
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(896, 612);
            Controls.Add(label6);
            Controls.Add(btnLogout);
            Controls.Add(btnViewAllRecipes);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(searchBar);
            Controls.Add(btnAdvancedSearch);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbRecipes);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(1, 2, 1, 2);
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox searchBar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnViewAllRecipes;
        private Button btnLogout;
        private Label label6;
    }
}