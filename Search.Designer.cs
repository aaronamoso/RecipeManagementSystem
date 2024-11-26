namespace RecipeManagementSystem
{
    partial class Search
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
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            rbtnBreakfast = new RadioButton();
            rbtnLunch = new RadioButton();
            rbtnDinner = new RadioButton();
            btnSpecial = new RadioButton();
            rbtnDesserts = new RadioButton();
            rbtnSnacks = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Search for:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 242);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 1;
            label2.Text = "All recipes:";
            // 
            // listView1
            // 
            listView1.Location = new Point(33, 281);
            listView1.Name = "listView1";
            listView1.Size = new Size(182, 146);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // rbtnBreakfast
            // 
            rbtnBreakfast.AutoSize = true;
            rbtnBreakfast.Location = new Point(59, 74);
            rbtnBreakfast.Name = "rbtnBreakfast";
            rbtnBreakfast.Size = new Size(109, 29);
            rbtnBreakfast.TabIndex = 3;
            rbtnBreakfast.TabStop = true;
            rbtnBreakfast.Text = "Breakfast";
            rbtnBreakfast.UseVisualStyleBackColor = true;
            // 
            // rbtnLunch
            // 
            rbtnLunch.AutoSize = true;
            rbtnLunch.Location = new Point(59, 119);
            rbtnLunch.Name = "rbtnLunch";
            rbtnLunch.Size = new Size(83, 29);
            rbtnLunch.TabIndex = 4;
            rbtnLunch.TabStop = true;
            rbtnLunch.Text = "Lunch";
            rbtnLunch.UseVisualStyleBackColor = true;
            // 
            // rbtnDinner
            // 
            rbtnDinner.AutoSize = true;
            rbtnDinner.Location = new Point(59, 163);
            rbtnDinner.Name = "rbtnDinner";
            rbtnDinner.Size = new Size(89, 29);
            rbtnDinner.TabIndex = 5;
            rbtnDinner.TabStop = true;
            rbtnDinner.Text = "Dinner";
            rbtnDinner.UseVisualStyleBackColor = true;
            // 
            // btnSpecial
            // 
            btnSpecial.AutoSize = true;
            btnSpecial.Location = new Point(222, 71);
            btnSpecial.Name = "btnSpecial";
            btnSpecial.Size = new Size(92, 29);
            btnSpecial.TabIndex = 6;
            btnSpecial.TabStop = true;
            btnSpecial.Text = "Special";
            btnSpecial.UseVisualStyleBackColor = true;
            // 
            // rbtnDesserts
            // 
            rbtnDesserts.AutoSize = true;
            rbtnDesserts.Location = new Point(222, 119);
            rbtnDesserts.Name = "rbtnDesserts";
            rbtnDesserts.Size = new Size(104, 29);
            rbtnDesserts.TabIndex = 7;
            rbtnDesserts.TabStop = true;
            rbtnDesserts.Text = "Desserts";
            rbtnDesserts.UseVisualStyleBackColor = true;
            // 
            // rbtnSnacks
            // 
            rbtnSnacks.AutoSize = true;
            rbtnSnacks.Location = new Point(222, 163);
            rbtnSnacks.Name = "rbtnSnacks";
            rbtnSnacks.Size = new Size(91, 29);
            rbtnSnacks.TabIndex = 8;
            rbtnSnacks.TabStop = true;
            rbtnSnacks.Text = "Snacks";
            rbtnSnacks.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbtnSnacks);
            Controls.Add(rbtnDesserts);
            Controls.Add(btnSpecial);
            Controls.Add(rbtnDinner);
            Controls.Add(rbtnLunch);
            Controls.Add(rbtnBreakfast);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Search";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListView listView1;
        private RadioButton rbtnBreakfast;
        private RadioButton rbtnLunch;
        private RadioButton rbtnDinner;
        private RadioButton btnSpecial;
        private RadioButton rbtnDesserts;
        private RadioButton rbtnSnacks;
    }
}