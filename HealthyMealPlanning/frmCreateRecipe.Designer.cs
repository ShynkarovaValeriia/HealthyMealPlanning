namespace HealthyMealPlanning
{
    partial class frmCreateRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateRecipe));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogo = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSelectDifficulty = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblSelectCookingTime = new System.Windows.Forms.Label();
            this.lblServings = new System.Windows.Forms.Label();
            this.lblSelectIngredients = new System.Windows.Forms.Label();
            this.lblSelectDescription = new System.Windows.Forms.Label();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.lblSelectName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblportions = new System.Windows.Forms.Label();
            this.numUpDownPortionsNumber = new System.Windows.Forms.NumericUpDown();
            this.lblPortionsNumber = new System.Windows.Forms.Label();
            this.txtCookingTime = new System.Windows.Forms.TextBox();
            this.lblCookingTime = new System.Windows.Forms.Label();
            this.lblminutes = new System.Windows.Forms.Label();
            this.txtIngredients = new System.Windows.Forms.TextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddRecipe = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPortionsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogo,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLogo
            // 
            this.btnLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(29, 24);
            this.btnLogo.Text = "toolStripButton1";
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::HealthyMealPlanning.Properties.Resources.close;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 24);
            this.btnClose.Text = "toolStripButton2";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Location = new System.Drawing.Point(49, 647);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(101, 16);
            this.lblSelectCategory.TabIndex = 54;
            this.lblSelectCategory.Text = "Select category";
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
            this.cbCategory.Location = new System.Drawing.Point(51, 620);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 53;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(48, 601);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 52;
            this.lblCategory.Text = "Category";
            // 
            // lblSelectDifficulty
            // 
            this.lblSelectDifficulty.AutoSize = true;
            this.lblSelectDifficulty.Location = new System.Drawing.Point(55, 570);
            this.lblSelectDifficulty.Name = "lblSelectDifficulty";
            this.lblSelectDifficulty.Size = new System.Drawing.Size(95, 16);
            this.lblSelectDifficulty.TabIndex = 51;
            this.lblSelectDifficulty.Text = "Select difficulty";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Difficult"});
            this.cbDifficulty.Location = new System.Drawing.Point(51, 543);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(121, 24);
            this.cbDifficulty.TabIndex = 50;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(48, 524);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(56, 16);
            this.lblDifficulty.TabIndex = 49;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // lblSelectCookingTime
            // 
            this.lblSelectCookingTime.AutoSize = true;
            this.lblSelectCookingTime.Location = new System.Drawing.Point(48, 488);
            this.lblSelectCookingTime.Name = "lblSelectCookingTime";
            this.lblSelectCookingTime.Size = new System.Drawing.Size(253, 16);
            this.lblSelectCookingTime.TabIndex = 48;
            this.lblSelectCookingTime.Text = "How long does it take to cook this recipe?";
            // 
            // lblServings
            // 
            this.lblServings.AutoSize = true;
            this.lblServings.Location = new System.Drawing.Point(44, 415);
            this.lblServings.Name = "lblServings";
            this.lblServings.Size = new System.Drawing.Size(392, 16);
            this.lblServings.TabIndex = 47;
            this.lblServings.Text = "This is used to scale the recipe and calculate nutrition per serving";
            // 
            // lblSelectIngredients
            // 
            this.lblSelectIngredients.AutoSize = true;
            this.lblSelectIngredients.Location = new System.Drawing.Point(44, 335);
            this.lblSelectIngredients.Name = "lblSelectIngredients";
            this.lblSelectIngredients.Size = new System.Drawing.Size(202, 16);
            this.lblSelectIngredients.TabIndex = 46;
            this.lblSelectIngredients.Text = "Add one or pasete multiple items";
            // 
            // lblSelectDescription
            // 
            this.lblSelectDescription.AutoSize = true;
            this.lblSelectDescription.Location = new System.Drawing.Point(44, 256);
            this.lblSelectDescription.Name = "lblSelectDescription";
            this.lblSelectDescription.Size = new System.Drawing.Size(435, 16);
            this.lblSelectDescription.TabIndex = 45;
            this.lblSelectDescription.Text = "Introduce your recipe, add notes, cooking tips, serving suggestions, etc...";
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(43, 149);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(148, 46);
            this.btnAddPhoto.TabIndex = 44;
            this.btnAddPhoto.Text = "Add photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // lblSelectName
            // 
            this.lblSelectName.AutoSize = true;
            this.lblSelectName.Location = new System.Drawing.Point(42, 120);
            this.lblSelectName.Name = "lblSelectName";
            this.lblSelectName.Size = new System.Drawing.Size(153, 16);
            this.lblSelectName.TabIndex = 43;
            this.lblSelectName.Text = "Give your recipe a name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(340, 663);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(235, 51);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblportions
            // 
            this.lblportions.AutoSize = true;
            this.lblportions.Location = new System.Drawing.Point(268, 392);
            this.lblportions.Name = "lblportions";
            this.lblportions.Size = new System.Drawing.Size(55, 16);
            this.lblportions.TabIndex = 41;
            this.lblportions.Text = "portions";
            // 
            // numUpDownPortionsNumber
            // 
            this.numUpDownPortionsNumber.Location = new System.Drawing.Point(46, 390);
            this.numUpDownPortionsNumber.Name = "numUpDownPortionsNumber";
            this.numUpDownPortionsNumber.Size = new System.Drawing.Size(197, 22);
            this.numUpDownPortionsNumber.TabIndex = 40;
            // 
            // lblPortionsNumber
            // 
            this.lblPortionsNumber.AutoSize = true;
            this.lblPortionsNumber.Location = new System.Drawing.Point(43, 371);
            this.lblPortionsNumber.Name = "lblPortionsNumber";
            this.lblPortionsNumber.Size = new System.Drawing.Size(107, 16);
            this.lblPortionsNumber.TabIndex = 39;
            this.lblPortionsNumber.Text = "Portions Number";
            // 
            // txtCookingTime
            // 
            this.txtCookingTime.Location = new System.Drawing.Point(47, 463);
            this.txtCookingTime.Name = "txtCookingTime";
            this.txtCookingTime.Size = new System.Drawing.Size(281, 22);
            this.txtCookingTime.TabIndex = 38;
            // 
            // lblCookingTime
            // 
            this.lblCookingTime.AutoSize = true;
            this.lblCookingTime.Location = new System.Drawing.Point(48, 444);
            this.lblCookingTime.Name = "lblCookingTime";
            this.lblCookingTime.Size = new System.Drawing.Size(91, 16);
            this.lblCookingTime.TabIndex = 37;
            this.lblCookingTime.Text = "Cooking Time";
            // 
            // lblminutes
            // 
            this.lblminutes.AutoSize = true;
            this.lblminutes.Location = new System.Drawing.Point(352, 466);
            this.lblminutes.Name = "lblminutes";
            this.lblminutes.Size = new System.Drawing.Size(53, 16);
            this.lblminutes.TabIndex = 36;
            this.lblminutes.Text = "minutes";
            // 
            // txtIngredients
            // 
            this.txtIngredients.Location = new System.Drawing.Point(43, 310);
            this.txtIngredients.Name = "txtIngredients";
            this.txtIngredients.Size = new System.Drawing.Size(148, 22);
            this.txtIngredients.TabIndex = 35;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(42, 291);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(73, 16);
            this.lblIngredients.TabIndex = 34;
            this.lblIngredients.Text = "Ingredients";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(43, 231);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(158, 22);
            this.txtDescription.TabIndex = 33;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(42, 212);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 32;
            this.lblDescription.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(43, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 22);
            this.txtName.TabIndex = 31;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
            // 
            // lblAddRecipe
            // 
            this.lblAddRecipe.AutoSize = true;
            this.lblAddRecipe.Location = new System.Drawing.Point(42, 45);
            this.lblAddRecipe.Name = "lblAddRecipe";
            this.lblAddRecipe.Size = new System.Drawing.Size(73, 16);
            this.lblAddRecipe.TabIndex = 29;
            this.lblAddRecipe.Text = "Add recipe";
            // 
            // frmCreateRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 736);
            this.Controls.Add(this.lblSelectCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSelectDifficulty);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblSelectCookingTime);
            this.Controls.Add(this.lblServings);
            this.Controls.Add(this.lblSelectIngredients);
            this.Controls.Add(this.lblSelectDescription);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.lblSelectName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblportions);
            this.Controls.Add(this.numUpDownPortionsNumber);
            this.Controls.Add(this.lblPortionsNumber);
            this.Controls.Add(this.txtCookingTime);
            this.Controls.Add(this.lblCookingTime);
            this.Controls.Add(this.lblminutes);
            this.Controls.Add(this.txtIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddRecipe);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreateRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateRecipe";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPortionsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLogo;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblSelectDifficulty;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblSelectCookingTime;
        private System.Windows.Forms.Label lblServings;
        private System.Windows.Forms.Label lblSelectIngredients;
        private System.Windows.Forms.Label lblSelectDescription;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Label lblSelectName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblportions;
        private System.Windows.Forms.NumericUpDown numUpDownPortionsNumber;
        private System.Windows.Forms.Label lblPortionsNumber;
        private System.Windows.Forms.TextBox txtCookingTime;
        private System.Windows.Forms.Label lblCookingTime;
        private System.Windows.Forms.Label lblminutes;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddRecipe;
    }
}