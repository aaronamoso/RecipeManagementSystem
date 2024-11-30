namespace RecipeManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            btnSubmit = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleDescription = "Username label";
            label1.AccessibleName = "Username";
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Cooper Black", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(32, 361);
            label1.Name = "label1";
            label1.Size = new Size(167, 34);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AccessibleDescription = "Password label";
            label2.AccessibleName = "Password";
            label2.AutoSize = true;
            label2.BackColor = Color.Azure;
            label2.Font = new Font("Cooper Black", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(32, 419);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SteelBlue;
            btnSubmit.Font = new Font("Cooper Black", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.AliceBlue;
            btnSubmit.Location = new Point(174, 501);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(173, 73);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.AliceBlue;
            txtUsername.ForeColor = Color.SteelBlue;
            txtUsername.Location = new Point(214, 364);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(198, 31);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.AliceBlue;
            txtPassword.Location = new Point(214, 420);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(198, 31);
            txtPassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(187, 64);
            label3.TabIndex = 6;
            label3.Text = "Mealz";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(535, 603);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.SteelBlue;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSubmit;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Label label3;
    }
}