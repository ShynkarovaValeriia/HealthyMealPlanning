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
            this.components = new System.ComponentModel.Container();
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
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnlReviews = new System.Windows.Forms.Panel();
            this.btnCreateReview = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogo = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.lblReviews = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlIngredients = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDescription = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPreviewRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipeImage)).BeginInit();
            this.pnlAverageRatings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
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
            this.pnlPreviewRecipe.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPreviewRecipe.Location = new System.Drawing.Point(12, 34);
            this.pnlPreviewRecipe.Name = "pnlPreviewRecipe";
            this.pnlPreviewRecipe.Size = new System.Drawing.Size(1464, 354);
            this.pnlPreviewRecipe.TabIndex = 0;
            // 
            // btnFavorite
            // 
            this.btnFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Image = global::HealthyMealPlanning.Properties.Resources.favorite_empty;
            this.btnFavorite.Location = new System.Drawing.Point(1222, 13);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(50, 50);
            this.btnFavorite.TabIndex = 10;
            this.toolTip3.SetToolTip(this.btnFavorite, "Сподобалось");
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlan.Image = global::HealthyMealPlanning.Properties.Resources.addplan;
            this.btnAddPlan.Location = new System.Drawing.Point(1290, 13);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(50, 50);
            this.btnAddPlan.TabIndex = 9;
            this.toolTip2.SetToolTip(this.btnAddPlan, "Додати до плану");
            this.btnAddPlan.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::HealthyMealPlanning.Properties.Resources.save_empty;
            this.btnSave.Location = new System.Drawing.Point(1358, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnSave, "Зберегти");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(411, 123);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(145, 37);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Категорія:";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(412, 200);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(163, 37);
            this.lblDifficulty.TabIndex = 5;
            this.lblDifficulty.Text = "Складність:";
            // 
            // lblPortionsNumber
            // 
            this.lblPortionsNumber.AutoSize = true;
            this.lblPortionsNumber.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortionsNumber.Location = new System.Drawing.Point(412, 299);
            this.lblPortionsNumber.Name = "lblPortionsNumber";
            this.lblPortionsNumber.Size = new System.Drawing.Size(231, 37);
            this.lblPortionsNumber.TabIndex = 4;
            this.lblPortionsNumber.Text = "Кількість порцій:";
            // 
            // lblCookingTime
            // 
            this.lblCookingTime.AutoSize = true;
            this.lblCookingTime.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookingTime.Location = new System.Drawing.Point(412, 251);
            this.lblCookingTime.Name = "lblCookingTime";
            this.lblCookingTime.Size = new System.Drawing.Size(250, 37);
            this.lblCookingTime.TabIndex = 3;
            this.lblCookingTime.Text = "Час приготування:";
            // 
            // lblNameRecipe
            // 
            this.lblNameRecipe.AutoSize = true;
            this.lblNameRecipe.Location = new System.Drawing.Point(411, 68);
            this.lblNameRecipe.Name = "lblNameRecipe";
            this.lblNameRecipe.Size = new System.Drawing.Size(219, 40);
            this.lblNameRecipe.TabIndex = 2;
            this.lblNameRecipe.Text = "Назва рецепту";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(412, 19);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(100, 37);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Автор:";
            // 
            // pbRecipeImage
            // 
            this.pbRecipeImage.Location = new System.Drawing.Point(19, 5);
            this.pbRecipeImage.Name = "pbRecipeImage";
            this.pbRecipeImage.Size = new System.Drawing.Size(369, 290);
            this.pbRecipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.pnlAverageRatings.Location = new System.Drawing.Point(19, 299);
            this.pnlAverageRatings.Name = "pnlAverageRatings";
            this.pnlAverageRatings.Size = new System.Drawing.Size(369, 41);
            this.pnlAverageRatings.TabIndex = 11;
            // 
            // pbStar1
            // 
            this.pbStar1.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar1.Location = new System.Drawing.Point(40, 0);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(40, 40);
            this.pbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar1.TabIndex = 16;
            this.pbStar1.TabStop = false;
            // 
            // pbStar2
            // 
            this.pbStar2.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar2.Location = new System.Drawing.Point(102, 0);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(40, 40);
            this.pbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar2.TabIndex = 13;
            this.pbStar2.TabStop = false;
            // 
            // pbStar3
            // 
            this.pbStar3.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar3.Location = new System.Drawing.Point(164, 0);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(40, 40);
            this.pbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar3.TabIndex = 12;
            this.pbStar3.TabStop = false;
            // 
            // pbStar4
            // 
            this.pbStar4.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar4.Location = new System.Drawing.Point(226, 0);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(40, 40);
            this.pbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar4.TabIndex = 15;
            this.pbStar4.TabStop = false;
            // 
            // pbStar5
            // 
            this.pbStar5.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar5.Location = new System.Drawing.Point(288, 0);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(40, 40);
            this.pbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar5.TabIndex = 14;
            this.pbStar5.TabStop = false;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(64, 399);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(183, 41);
            this.lblIngredients.TabIndex = 0;
            this.lblIngredients.Text = "Інгредієнти";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(424, 399);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(155, 41);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Інструкції";
            // 
            // pnlReviews
            // 
            this.pnlReviews.AutoScroll = true;
            this.pnlReviews.AutoSize = true;
            this.pnlReviews.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReviews.Location = new System.Drawing.Point(31, 742);
            this.pnlReviews.MaximumSize = new System.Drawing.Size(1464, 1464);
            this.pnlReviews.Name = "pnlReviews";
            this.pnlReviews.Size = new System.Drawing.Size(1445, 206);
            this.pnlReviews.TabIndex = 3;
            // 
            // btnCreateReview
            // 
            this.btnCreateReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btnCreateReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReview.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReview.ForeColor = System.Drawing.Color.White;
            this.btnCreateReview.Location = new System.Drawing.Point(1068, 664);
            this.btnCreateReview.Name = "btnCreateReview";
            this.btnCreateReview.Size = new System.Drawing.Size(364, 65);
            this.btnCreateReview.TabIndex = 1;
            this.btnCreateReview.Text = "Написати відгук";
            this.btnCreateReview.UseVisualStyleBackColor = false;
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
            this.toolStrip1.Size = new System.Drawing.Size(1479, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // btnLogo
            // 
            this.btnLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogo.Image = global::HealthyMealPlanning.Properties.Resources.HealthyMealPlanningIcon;
            this.btnLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(29, 24);
            this.btnLogo.Text = "На головне меню";
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::HealthyMealPlanning.Properties.Resources.close;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 24);
            this.btnClose.Text = "Закрити";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblReviews
            // 
            this.lblReviews.AutoSize = true;
            this.lblReviews.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviews.Location = new System.Drawing.Point(64, 676);
            this.lblReviews.Name = "lblReviews";
            this.lblReviews.Size = new System.Drawing.Size(129, 40);
            this.lblReviews.TabIndex = 5;
            this.lblReviews.Text = "Відгуки:";
            // 
            // pnlIngredients
            // 
            this.pnlIngredients.AutoScroll = true;
            this.pnlIngredients.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlIngredients.Location = new System.Drawing.Point(31, 443);
            this.pnlIngredients.Name = "pnlIngredients";
            this.pnlIngredients.Size = new System.Drawing.Size(348, 135);
            this.pnlIngredients.TabIndex = 6;
            this.pnlIngredients.WrapContents = false;
            // 
            // pnlDescription
            // 
            this.pnlDescription.AutoScroll = true;
            this.pnlDescription.AutoSize = true;
            this.pnlDescription.Location = new System.Drawing.Point(406, 443);
            this.pnlDescription.MaximumSize = new System.Drawing.Size(1082, 388);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(1070, 135);
            this.pnlDescription.TabIndex = 7;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.pnlIngredients);
            this.Controls.Add(this.btnCreateReview);
            this.Controls.Add(this.lblReviews);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlReviews);
            this.Controls.Add(this.pnlPreviewRecipe);
            this.Controls.Add(this.pnlDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecipe";
            this.Load += new System.EventHandler(this.frmRecipe_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRecipe_MouseDown);
            this.pnlPreviewRecipe.ResumeLayout(false);
            this.pnlPreviewRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecipeImage)).EndInit();
            this.pnlAverageRatings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
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
        private System.Windows.Forms.Label lblIngredients;
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.FlowLayoutPanel pnlIngredients;
        private System.Windows.Forms.FlowLayoutPanel pnlDescription;
    }
}