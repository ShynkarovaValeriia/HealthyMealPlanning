namespace HealthyMealPlanning
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            this.pnlPreviewRecipe = new System.Windows.Forms.Panel();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnAddPlan = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblPortionsNumber = new System.Windows.Forms.Label();
            this.lblCookingTime = new System.Windows.Forms.Label();
            this.lblNameRecipe = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.pbRecipeImage = new System.Windows.Forms.PictureBox();
            this.pnlAverageRatings = new System.Windows.Forms.Panel();
            this.pbStar1 = new System.Windows.Forms.PictureBox();
            this.pbStar2 = new System.Windows.Forms.PictureBox();
            this.pbStar3 = new System.Windows.Forms.PictureBox();
            this.pbStar4 = new System.Windows.Forms.PictureBox();
            this.pbStar5 = new System.Windows.Forms.PictureBox();
            this.pnlIngredients = new System.Windows.Forms.Panel();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnlReviews = new System.Windows.Forms.Panel();
            this.btnCreateReview = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogo = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.lblReviews = new System.Windows.Forms.Label();
            this.pnlPreviewRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipeImage)).BeginInit();
            this.pnlAverageRatings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
            this.pnlIngredients.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPreviewRecipe
            // 
            this.pnlPreviewRecipe.Controls.Add(this.btnFavorite);
            this.pnlPreviewRecipe.Controls.Add(this.btnAddPlan);
            this.pnlPreviewRecipe.Controls.Add(this.btnSave);
            this.pnlPreviewRecipe.Controls.Add(this.lblCategory);
            this.pnlPreviewRecipe.Controls.Add(this.lblDifficulty);
            this.pnlPreviewRecipe.Controls.Add(this.lblPortionsNumber);
            this.pnlPreviewRecipe.Controls.Add(this.lblCookingTime);
            this.pnlPreviewRecipe.Controls.Add(this.lblNameRecipe);
            this.pnlPreviewRecipe.Controls.Add(this.lblAuthor);
            this.pnlPreviewRecipe.Controls.Add(this.pbRecipeImage);
            this.pnlPreviewRecipe.Controls.Add(this.pnlAverageRatings);
            this.pnlPreviewRecipe.Location = new System.Drawing.Point(12, 34);
            this.pnlPreviewRecipe.Name = "pnlPreviewRecipe";
            this.pnlPreviewRecipe.Size = new System.Drawing.Size(1376, 354);
            this.pnlPreviewRecipe.TabIndex = 0;
            // 
            // btnFavorite
            // 
            this.btnFavorite.Image = global::HealthyMealPlanning.Properties.Resources.favorite_empty;
            this.btnFavorite.Location = new System.Drawing.Point(223, 300);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(37, 39);
            this.btnFavorite.TabIndex = 10;
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.Image = global::HealthyMealPlanning.Properties.Resources.addplan;
            this.btnAddPlan.Location = new System.Drawing.Point(266, 300);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(44, 39);
            this.btnAddPlan.TabIndex = 9;
            this.btnAddPlan.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::HealthyMealPlanning.Properties.Resources.save_empty;
            this.btnSave.Location = new System.Drawing.Point(316, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(413, 137);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 16);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(413, 226);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(59, 16);
            this.lblDifficulty.TabIndex = 5;
            this.lblDifficulty.Text = "Difficulty:";
            // 
            // lblPortionsNumber
            // 
            this.lblPortionsNumber.AutoSize = true;
            this.lblPortionsNumber.Location = new System.Drawing.Point(413, 300);
            this.lblPortionsNumber.Name = "lblPortionsNumber";
            this.lblPortionsNumber.Size = new System.Drawing.Size(107, 16);
            this.lblPortionsNumber.TabIndex = 4;
            this.lblPortionsNumber.Text = "Portions number:";
            // 
            // lblCookingTime
            // 
            this.lblCookingTime.AutoSize = true;
            this.lblCookingTime.Location = new System.Drawing.Point(413, 263);
            this.lblCookingTime.Name = "lblCookingTime";
            this.lblCookingTime.Size = new System.Drawing.Size(88, 16);
            this.lblCookingTime.TabIndex = 3;
            this.lblCookingTime.Text = "Cooking time:";
            // 
            // lblNameRecipe
            // 
            this.lblNameRecipe.AutoSize = true;
            this.lblNameRecipe.Location = new System.Drawing.Point(413, 98);
            this.lblNameRecipe.Name = "lblNameRecipe";
            this.lblNameRecipe.Size = new System.Drawing.Size(85, 16);
            this.lblNameRecipe.TabIndex = 2;
            this.lblNameRecipe.Text = "Name recipe";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(413, 54);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(63, 16);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "By author";
            // 
            // pbRecipeImage
            // 
            this.pbRecipeImage.Location = new System.Drawing.Point(19, 21);
            this.pbRecipeImage.Name = "pbRecipeImage";
            this.pbRecipeImage.Size = new System.Drawing.Size(337, 266);
            this.pbRecipeImage.TabIndex = 0;
            this.pbRecipeImage.TabStop = false;
            // 
            // pnlAverageRatings
            // 
            this.pnlAverageRatings.Controls.Add(this.pbStar1);
            this.pnlAverageRatings.Controls.Add(this.pbStar2);
            this.pnlAverageRatings.Controls.Add(this.pbStar3);
            this.pnlAverageRatings.Controls.Add(this.pbStar4);
            this.pnlAverageRatings.Controls.Add(this.pbStar5);
            this.pnlAverageRatings.Location = new System.Drawing.Point(19, 293);
            this.pnlAverageRatings.Name = "pnlAverageRatings";
            this.pnlAverageRatings.Size = new System.Drawing.Size(184, 46);
            this.pnlAverageRatings.TabIndex = 11;
            // 
            // pbStar1
            // 
            this.pbStar1.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar1.Location = new System.Drawing.Point(9, 10);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(29, 30);
            this.pbStar1.TabIndex = 16;
            this.pbStar1.TabStop = false;
            // 
            // pbStar2
            // 
            this.pbStar2.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar2.Location = new System.Drawing.Point(44, 10);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(30, 30);
            this.pbStar2.TabIndex = 13;
            this.pbStar2.TabStop = false;
            // 
            // pbStar3
            // 
            this.pbStar3.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar3.Location = new System.Drawing.Point(79, 10);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(29, 30);
            this.pbStar3.TabIndex = 12;
            this.pbStar3.TabStop = false;
            // 
            // pbStar4
            // 
            this.pbStar4.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar4.Location = new System.Drawing.Point(114, 10);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(27, 30);
            this.pbStar4.TabIndex = 15;
            this.pbStar4.TabStop = false;
            // 
            // pbStar5
            // 
            this.pbStar5.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar5.Location = new System.Drawing.Point(147, 10);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(28, 30);
            this.pbStar5.TabIndex = 14;
            this.pbStar5.TabStop = false;
            // 
            // pnlIngredients
            // 
            this.pnlIngredients.AutoScroll = true;
            this.pnlIngredients.Controls.Add(this.lblIngredients);
            this.pnlIngredients.Location = new System.Drawing.Point(12, 394);
            this.pnlIngredients.Name = "pnlIngredients";
            this.pnlIngredients.Size = new System.Drawing.Size(356, 444);
            this.pnlIngredients.TabIndex = 1;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(29, 26);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(73, 16);
            this.lblIngredients.TabIndex = 0;
            this.lblIngredients.Text = "Ingredients";
            // 
            // pnlDescription
            // 
            this.pnlDescription.AutoScroll = true;
            this.pnlDescription.Controls.Add(this.lblInstructions);
            this.pnlDescription.Location = new System.Drawing.Point(374, 394);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(1014, 444);
            this.pnlDescription.TabIndex = 2;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(51, 26);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(73, 16);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Instructions";
            // 
            // pnlReviews
            // 
            this.pnlReviews.AutoScroll = true;
            this.pnlReviews.Location = new System.Drawing.Point(12, 910);
            this.pnlReviews.Name = "pnlReviews";
            this.pnlReviews.Size = new System.Drawing.Size(1376, 319);
            this.pnlReviews.TabIndex = 3;
            // 
            // btnCreateReview
            // 
            this.btnCreateReview.Location = new System.Drawing.Point(1146, 855);
            this.btnCreateReview.Name = "btnCreateReview";
            this.btnCreateReview.Size = new System.Drawing.Size(190, 41);
            this.btnCreateReview.TabIndex = 1;
            this.btnCreateReview.Text = "Create review";
            this.btnCreateReview.UseVisualStyleBackColor = true;
            this.btnCreateReview.Click += new System.EventHandler(this.btnCreateReview_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogo,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1400, 27);
            this.toolStrip1.TabIndex = 4;
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
            this.btnClose.Text = "toolStripButton1";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblReviews
            // 
            this.lblReviews.AutoSize = true;
            this.lblReviews.Location = new System.Drawing.Point(52, 867);
            this.lblReviews.Name = "lblReviews";
            this.lblReviews.Size = new System.Drawing.Size(62, 16);
            this.lblReviews.TabIndex = 5;
            this.lblReviews.Text = "Reviews:";
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 1241);
            this.Controls.Add(this.btnCreateReview);
            this.Controls.Add(this.lblReviews);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlReviews);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.pnlIngredients);
            this.Controls.Add(this.pnlPreviewRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecipe";
            this.Load += new System.EventHandler(this.frmRecipe_Load);
            this.pnlPreviewRecipe.ResumeLayout(false);
            this.pnlPreviewRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipeImage)).EndInit();
            this.pnlAverageRatings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
            this.pnlIngredients.ResumeLayout(false);
            this.pnlIngredients.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPreviewRecipe;
        private System.Windows.Forms.Label lblCookingTime;
        private System.Windows.Forms.Label lblNameRecipe;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.PictureBox pbRecipeImage;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblPortionsNumber;
        private System.Windows.Forms.Panel pnlIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Panel pnlReviews;
        private System.Windows.Forms.Button btnCreateReview;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnAddPlan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnLogo;
        private System.Windows.Forms.Label lblReviews;
        private System.Windows.Forms.Panel pnlAverageRatings;
        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.PictureBox pbStar2;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar5;
    }
}