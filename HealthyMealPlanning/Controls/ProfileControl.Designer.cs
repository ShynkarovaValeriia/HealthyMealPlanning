namespace HealthyMealPlanning
{
    partial class ProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAddRecipe = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.lblminutes = new System.Windows.Forms.Label();
            this.lblCookingTime = new System.Windows.Forms.Label();
            this.txtCookingTime = new System.Windows.Forms.TextBox();
            this.lblPortionsNumber = new System.Windows.Forms.Label();
            this.numUpDownPortionsNumber = new System.Windows.Forms.NumericUpDown();
            this.lblportions = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.lblSelectDescription = new System.Windows.Forms.Label();
            this.lblSelectIngredients = new System.Windows.Forms.Label();
            this.lblServings = new System.Windows.Forms.Label();
            this.lblSelectCookingTime = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblSelectDifficulty = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.flowLayoutPanelRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPortionsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(69, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 713);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Activity";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSelectCategory);
            this.tabPage2.Controls.Add(this.cbCategory);
            this.tabPage2.Controls.Add(this.lblCategory);
            this.tabPage2.Controls.Add(this.lblSelectDifficulty);
            this.tabPage2.Controls.Add(this.cbDifficulty);
            this.tabPage2.Controls.Add(this.lblDifficulty);
            this.tabPage2.Controls.Add(this.lblSelectCookingTime);
            this.tabPage2.Controls.Add(this.lblServings);
            this.tabPage2.Controls.Add(this.lblSelectIngredients);
            this.tabPage2.Controls.Add(this.lblSelectDescription);
            this.tabPage2.Controls.Add(this.btnAddPhoto);
            this.tabPage2.Controls.Add(this.lblSelectName);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.lblportions);
            this.tabPage2.Controls.Add(this.numUpDownPortionsNumber);
            this.tabPage2.Controls.Add(this.lblPortionsNumber);
            this.tabPage2.Controls.Add(this.txtCookingTime);
            this.tabPage2.Controls.Add(this.lblCookingTime);
            this.tabPage2.Controls.Add(this.lblminutes);
            this.tabPage2.Controls.Add(this.txtIngredients);
            this.tabPage2.Controls.Add(this.lblIngredients);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.lblDescription);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.lblAddRecipe);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 684);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create new recipe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanelRecipes);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(958, 684);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View own recipes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(958, 684);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage profile";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::HealthyMealPlanning.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(911, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(42, 35);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAddRecipe
            // 
            this.lblAddRecipe.AutoSize = true;
            this.lblAddRecipe.Location = new System.Drawing.Point(27, 17);
            this.lblAddRecipe.Name = "lblAddRecipe";
            this.lblAddRecipe.Size = new System.Drawing.Size(73, 16);
            this.lblAddRecipe.TabIndex = 1;
            this.lblAddRecipe.Text = "Add recipe";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(28, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(27, 184);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(28, 203);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(158, 22);
            this.txtDescription.TabIndex = 5;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(27, 263);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(73, 16);
            this.lblIngredients.TabIndex = 6;
            this.lblIngredients.Text = "Ingredients";
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(28, 282);
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(148, 22);
            this.txtIngredients.TabIndex = 7;
            // 
            // lblminutes
            // 
            this.lblminutes.AutoSize = true;
            this.lblminutes.Location = new System.Drawing.Point(337, 438);
            this.lblminutes.Name = "lblminutes";
            this.lblminutes.Size = new System.Drawing.Size(53, 16);
            this.lblminutes.TabIndex = 10;
            this.lblminutes.Text = "minutes";
            // 
            // lblCookingTime
            // 
            this.lblCookingTime.AutoSize = true;
            this.lblCookingTime.Location = new System.Drawing.Point(33, 416);
            this.lblCookingTime.Name = "lblCookingTime";
            this.lblCookingTime.Size = new System.Drawing.Size(91, 16);
            this.lblCookingTime.TabIndex = 11;
            this.lblCookingTime.Text = "Cooking Time";
            // 
            // txtCookingTime
            // 
            this.txtCookingTime.Location = new System.Drawing.Point(32, 435);
            this.txtCookingTime.Name = "txtCookingTime";
            this.txtCookingTime.Size = new System.Drawing.Size(281, 22);
            this.txtCookingTime.TabIndex = 12;
            // 
            // lblPortionsNumber
            // 
            this.lblPortionsNumber.AutoSize = true;
            this.lblPortionsNumber.Location = new System.Drawing.Point(28, 343);
            this.lblPortionsNumber.Name = "lblPortionsNumber";
            this.lblPortionsNumber.Size = new System.Drawing.Size(107, 16);
            this.lblPortionsNumber.TabIndex = 13;
            this.lblPortionsNumber.Text = "Portions Number";
            // 
            // numUpDownPortionsNumber
            // 
            this.numUpDownPortionsNumber.Location = new System.Drawing.Point(31, 362);
            this.numUpDownPortionsNumber.Name = "numUpDownPortionsNumber";
            this.numUpDownPortionsNumber.Size = new System.Drawing.Size(197, 22);
            this.numUpDownPortionsNumber.TabIndex = 14;
            // 
            // lblportions
            // 
            this.lblportions.AutoSize = true;
            this.lblportions.Location = new System.Drawing.Point(253, 364);
            this.lblportions.Name = "lblportions";
            this.lblportions.Size = new System.Drawing.Size(55, 16);
            this.lblportions.TabIndex = 15;
            this.lblportions.Text = "portions";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(324, 619);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 51);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Location = new System.Drawing.Point(27, 92);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(153, 16);
            this.lblSelectName.TabIndex = 17;
            this.lblSelectName.Text = "Give your recipe a name";
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(28, 121);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(148, 46);
            this.btnAddPhoto.TabIndex = 18;
            this.btnAddPhoto.Text = "Add photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // lblSelectDescription
            // 
            this.lblSelectDescription.AutoSize = true;
            this.lblSelectDescription.Location = new System.Drawing.Point(29, 228);
            this.lblSelectDescription.Name = "lblSelectDescription";
            this.lblSelectDescription.Size = new System.Drawing.Size(435, 16);
            this.lblSelectDescription.TabIndex = 19;
            this.lblSelectDescription.Text = "Introduce your recipe, add notes, cooking tips, serving suggestions, etc...";
            // 
            // lblSelectIngredients
            // 
            this.lblSelectIngredients.AutoSize = true;
            this.lblSelectIngredients.Location = new System.Drawing.Point(29, 307);
            this.lblSelectIngredients.Name = "lblSelectIngredients";
            this.lblSelectIngredients.Size = new System.Drawing.Size(202, 16);
            this.lblSelectIngredients.TabIndex = 20;
            this.lblSelectIngredients.Text = "Add one or pasete multiple items";
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Location = new System.Drawing.Point(29, 387);
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(392, 16);
            this.lblServings.TabIndex = 21;
            this.lblServings.Text = "This is used to scale the recipe and calculate nutrition per serving";
            // 
            // lblSelectCookingTime
            // 
            this.lblSelectCookingTime.AutoSize = true;
            this.lblSelectCookingTime.Location = new System.Drawing.Point(33, 460);
            this.lblSelectCookingTime.Name = "lblSelectCookingTime";
            this.lblSelectCookingTime.Size = new System.Drawing.Size(253, 16);
            this.lblSelectCookingTime.TabIndex = 22;
            this.lblSelectCookingTime.Text = "How long does it take to cook this recipe?";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(33, 496);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(56, 16);
            this.lblDifficulty.TabIndex = 23;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Difficult"});
            this.cbDifficulty.Location = new System.Drawing.Point(36, 515);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(121, 24);
            this.cbDifficulty.TabIndex = 24;
            // 
            // lblSelectDifficulty
            // 
            this.lblSelectDifficulty.AutoSize = true;
            this.lblSelectDifficulty.Location = new System.Drawing.Point(40, 542);
            this.lblSelectDifficulty.Name = "lblSelectDifficulty";
            this.lblSelectDifficulty.Size = new System.Drawing.Size(95, 16);
            this.lblSelectDifficulty.TabIndex = 25;
            this.lblSelectDifficulty.Text = "Select difficulty";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(33, 573);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 26;
            this.lblCategory.Text = "Category";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Dessert",
            "Fruits",
            "Main dish",
            "Salads",
            "Soups",
            "Vegetables"});
            this.cbCategory.Location = new System.Drawing.Point(36, 592);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 27;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Location = new System.Drawing.Point(34, 619);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(101, 16);
            this.lblSelectCategory.TabIndex = 28;
            this.lblSelectCategory.Text = "Select category";
            // 
            // flowLayoutPanelRecipes
            // 
            this.flowLayoutPanelRecipes.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanelRecipes.Name = "flowLayoutPanelRecipes";
            this.flowLayoutPanelRecipes.Size = new System.Drawing.Size(946, 672);
            this.flowLayoutPanelRecipes.TabIndex = 0;
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblUsername);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(966, 786);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPortionsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddRecipe;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblportions;
        private System.Windows.Forms.NumericUpDown numUpDownPortionsNumber;
        private System.Windows.Forms.Label lblPortionsNumber;
        private System.Windows.Forms.TextBox txtCookingTime;
        private System.Windows.Forms.Label lblCookingTime;
        private System.Windows.Forms.Label lblminutes;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Label lblSelectDescription;
        private System.Windows.Forms.Label lblSelectCookingTime;
        private System.Windows.Forms.Label lblServings;
        private System.Windows.Forms.Label lblSelectIngredients;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSelectDifficulty;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecipes;
    }
}
