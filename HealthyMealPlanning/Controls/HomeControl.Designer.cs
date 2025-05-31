using System.Windows.Forms;

namespace HealthyMealPlanning
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.lblDiscoverRecipes = new System.Windows.Forms.Label();
            this.lblRecipeCategories = new System.Windows.Forms.Label();
            this.lblPopularCreators = new System.Windows.Forms.Label();
            this.pnlRecipeCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPopularCreators = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDiscoverRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDesserts = new System.Windows.Forms.Panel();
            this.lblDesserts = new System.Windows.Forms.Label();
            this.pnlFruits = new System.Windows.Forms.Panel();
            this.lblFruits = new System.Windows.Forms.Label();
            this.pnlMaindish = new System.Windows.Forms.Panel();
            this.lblMaindish = new System.Windows.Forms.Label();
            this.pnlSalads = new System.Windows.Forms.Panel();
            this.lblSalads = new System.Windows.Forms.Label();
            this.pnlSoups = new System.Windows.Forms.Panel();
            this.lblSoups = new System.Windows.Forms.Label();
            this.pnlVegetables = new System.Windows.Forms.Panel();
            this.lblVegetables = new System.Windows.Forms.Label();
            this.pbDesserts = new System.Windows.Forms.PictureBox();
            this.pbFruits = new System.Windows.Forms.PictureBox();
            this.pbMaindish = new System.Windows.Forms.PictureBox();
            this.pbSalads = new System.Windows.Forms.PictureBox();
            this.pbSoups = new System.Windows.Forms.PictureBox();
            this.pbVegetables = new System.Windows.Forms.PictureBox();
            this.pnlRecipeCategories.SuspendLayout();
            this.pnlDesserts.SuspendLayout();
            this.pnlFruits.SuspendLayout();
            this.pnlMaindish.SuspendLayout();
            this.pnlSalads.SuspendLayout();
            this.pnlSoups.SuspendLayout();
            this.pnlVegetables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesserts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaindish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVegetables)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiscoverRecipes
            // 
            this.lblDiscoverRecipes.AutoSize = true;
            this.lblDiscoverRecipes.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscoverRecipes.Location = new System.Drawing.Point(51, 794);
            this.lblDiscoverRecipes.Name = "lblDiscoverRecipes";
            this.lblDiscoverRecipes.Size = new System.Drawing.Size(422, 40);
            this.lblDiscoverRecipes.TabIndex = 0;
            this.lblDiscoverRecipes.Text = "Відкрийте для себе рецепти";
            // 
            // lblRecipeCategories
            // 
            this.lblRecipeCategories.AutoSize = true;
            this.lblRecipeCategories.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeCategories.Location = new System.Drawing.Point(48, 23);
            this.lblRecipeCategories.Name = "lblRecipeCategories";
            this.lblRecipeCategories.Size = new System.Drawing.Size(279, 40);
            this.lblRecipeCategories.TabIndex = 3;
            this.lblRecipeCategories.Text = "Категорії рецептів";
            // 
            // lblPopularCreators
            // 
            this.lblPopularCreators.AutoSize = true;
            this.lblPopularCreators.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularCreators.Location = new System.Drawing.Point(51, 344);
            this.lblPopularCreators.Name = "lblPopularCreators";
            this.lblPopularCreators.Size = new System.Drawing.Size(265, 40);
            this.lblPopularCreators.TabIndex = 4;
            this.lblPopularCreators.Text = "Популярні творці";
            // 
            // pnlRecipeCategories
            // 
            this.pnlRecipeCategories.AutoScroll = true;
            this.pnlRecipeCategories.AutoSize = true;
            this.pnlRecipeCategories.Controls.Add(this.pnlDesserts);
            this.pnlRecipeCategories.Controls.Add(this.pnlFruits);
            this.pnlRecipeCategories.Controls.Add(this.pnlMaindish);
            this.pnlRecipeCategories.Controls.Add(this.pnlSalads);
            this.pnlRecipeCategories.Controls.Add(this.pnlSoups);
            this.pnlRecipeCategories.Controls.Add(this.pnlVegetables);
            this.pnlRecipeCategories.Location = new System.Drawing.Point(26, 78);
            this.pnlRecipeCategories.MaximumSize = new System.Drawing.Size(1398, 1358);
            this.pnlRecipeCategories.Name = "pnlRecipeCategories";
            this.pnlRecipeCategories.Size = new System.Drawing.Size(1398, 238);
            this.pnlRecipeCategories.TabIndex = 12;
            // 
            // pnlPopularCreators
            // 
            this.pnlPopularCreators.AutoScroll = true;
            this.pnlPopularCreators.AutoSize = true;
            this.pnlPopularCreators.Location = new System.Drawing.Point(29, 399);
            this.pnlPopularCreators.MaximumSize = new System.Drawing.Size(1358, 1358);
            this.pnlPopularCreators.Name = "pnlPopularCreators";
            this.pnlPopularCreators.Size = new System.Drawing.Size(1358, 150);
            this.pnlPopularCreators.TabIndex = 13;
            // 
            // pnlDiscoverRecipes
            // 
            this.pnlDiscoverRecipes.AutoScroll = true;
            this.pnlDiscoverRecipes.AutoSize = true;
            this.pnlDiscoverRecipes.Location = new System.Drawing.Point(50, 848);
            this.pnlDiscoverRecipes.MaximumSize = new System.Drawing.Size(1358, 1358);
            this.pnlDiscoverRecipes.Name = "pnlDiscoverRecipes";
            this.pnlDiscoverRecipes.Size = new System.Drawing.Size(1358, 150);
            this.pnlDiscoverRecipes.TabIndex = 14;
            // 
            // pnlDesserts
            // 
            this.pnlDesserts.Controls.Add(this.lblDesserts);
            this.pnlDesserts.Controls.Add(this.pbDesserts);
            this.pnlDesserts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDesserts.Location = new System.Drawing.Point(3, 3);
            this.pnlDesserts.Name = "pnlDesserts";
            this.pnlDesserts.Size = new System.Drawing.Size(226, 199);
            this.pnlDesserts.TabIndex = 15;
            this.pnlDesserts.Click += new System.EventHandler(this.pnlDesserts_Click);
            // 
            // lblDesserts
            // 
            this.lblDesserts.AutoSize = true;
            this.lblDesserts.BackColor = System.Drawing.Color.Transparent;
            this.lblDesserts.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesserts.ForeColor = System.Drawing.Color.Black;
            this.lblDesserts.Location = new System.Drawing.Point(52, 149);
            this.lblDesserts.Name = "lblDesserts";
            this.lblDesserts.Size = new System.Drawing.Size(123, 37);
            this.lblDesserts.TabIndex = 1;
            this.lblDesserts.Text = "Десерти";
            this.lblDesserts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDesserts.Click += new System.EventHandler(this.pnlDesserts_Click);
            // 
            // pnlFruits
            // 
            this.pnlFruits.Controls.Add(this.lblFruits);
            this.pnlFruits.Controls.Add(this.pbFruits);
            this.pnlFruits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFruits.Location = new System.Drawing.Point(235, 3);
            this.pnlFruits.Name = "pnlFruits";
            this.pnlFruits.Size = new System.Drawing.Size(226, 199);
            this.pnlFruits.TabIndex = 16;
            this.pnlFruits.Click += new System.EventHandler(this.pnlFruits_Click);
            // 
            // lblFruits
            // 
            this.lblFruits.AutoSize = true;
            this.lblFruits.BackColor = System.Drawing.Color.Transparent;
            this.lblFruits.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFruits.ForeColor = System.Drawing.Color.Black;
            this.lblFruits.Location = new System.Drawing.Point(58, 149);
            this.lblFruits.Name = "lblFruits";
            this.lblFruits.Size = new System.Drawing.Size(110, 37);
            this.lblFruits.TabIndex = 1;
            this.lblFruits.Text = "Фрукти";
            this.lblFruits.Click += new System.EventHandler(this.pnlFruits_Click);
            // 
            // pnlMaindish
            // 
            this.pnlMaindish.Controls.Add(this.lblMaindish);
            this.pnlMaindish.Controls.Add(this.pbMaindish);
            this.pnlMaindish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMaindish.Location = new System.Drawing.Point(467, 3);
            this.pnlMaindish.Name = "pnlMaindish";
            this.pnlMaindish.Size = new System.Drawing.Size(226, 232);
            this.pnlMaindish.TabIndex = 17;
            this.pnlMaindish.Click += new System.EventHandler(this.pnlMaindish_Click);
            // 
            // lblMaindish
            // 
            this.lblMaindish.AutoSize = true;
            this.lblMaindish.BackColor = System.Drawing.Color.Transparent;
            this.lblMaindish.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaindish.ForeColor = System.Drawing.Color.Black;
            this.lblMaindish.Location = new System.Drawing.Point(51, 149);
            this.lblMaindish.Name = "lblMaindish";
            this.lblMaindish.Size = new System.Drawing.Size(126, 74);
            this.lblMaindish.TabIndex = 1;
            this.lblMaindish.Text = "Основна\r\nстрава";
            this.lblMaindish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMaindish.Click += new System.EventHandler(this.pnlMaindish_Click);
            // 
            // pnlSalads
            // 
            this.pnlSalads.Controls.Add(this.lblSalads);
            this.pnlSalads.Controls.Add(this.pbSalads);
            this.pnlSalads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSalads.Location = new System.Drawing.Point(699, 3);
            this.pnlSalads.Name = "pnlSalads";
            this.pnlSalads.Size = new System.Drawing.Size(226, 199);
            this.pnlSalads.TabIndex = 18;
            this.pnlSalads.Click += new System.EventHandler(this.pnlSalads_Click);
            // 
            // lblSalads
            // 
            this.lblSalads.AutoSize = true;
            this.lblSalads.BackColor = System.Drawing.Color.Transparent;
            this.lblSalads.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalads.ForeColor = System.Drawing.Color.Black;
            this.lblSalads.Location = new System.Drawing.Point(61, 149);
            this.lblSalads.Name = "lblSalads";
            this.lblSalads.Size = new System.Drawing.Size(104, 37);
            this.lblSalads.TabIndex = 1;
            this.lblSalads.Text = "Салати";
            this.lblSalads.Click += new System.EventHandler(this.pnlSalads_Click);
            // 
            // pnlSoups
            // 
            this.pnlSoups.Controls.Add(this.lblSoups);
            this.pnlSoups.Controls.Add(this.pbSoups);
            this.pnlSoups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSoups.Location = new System.Drawing.Point(931, 3);
            this.pnlSoups.Name = "pnlSoups";
            this.pnlSoups.Size = new System.Drawing.Size(226, 199);
            this.pnlSoups.TabIndex = 19;
            this.pnlSoups.Click += new System.EventHandler(this.pnlSoups_Click);
            // 
            // lblSoups
            // 
            this.lblSoups.AutoSize = true;
            this.lblSoups.BackColor = System.Drawing.Color.Transparent;
            this.lblSoups.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoups.ForeColor = System.Drawing.Color.Black;
            this.lblSoups.Location = new System.Drawing.Point(74, 149);
            this.lblSoups.Name = "lblSoups";
            this.lblSoups.Size = new System.Drawing.Size(79, 37);
            this.lblSoups.TabIndex = 1;
            this.lblSoups.Text = "Супи";
            this.lblSoups.Click += new System.EventHandler(this.pnlSoups_Click);
            // 
            // pnlVegetables
            // 
            this.pnlVegetables.Controls.Add(this.lblVegetables);
            this.pnlVegetables.Controls.Add(this.pbVegetables);
            this.pnlVegetables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVegetables.Location = new System.Drawing.Point(1163, 3);
            this.pnlVegetables.Name = "pnlVegetables";
            this.pnlVegetables.Size = new System.Drawing.Size(226, 199);
            this.pnlVegetables.TabIndex = 16;
            this.pnlVegetables.Click += new System.EventHandler(this.pnlVegetables_Click);
            // 
            // lblVegetables
            // 
            this.lblVegetables.AutoSize = true;
            this.lblVegetables.BackColor = System.Drawing.Color.Transparent;
            this.lblVegetables.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVegetables.ForeColor = System.Drawing.Color.Black;
            this.lblVegetables.Location = new System.Drawing.Point(69, 149);
            this.lblVegetables.Name = "lblVegetables";
            this.lblVegetables.Size = new System.Drawing.Size(88, 37);
            this.lblVegetables.TabIndex = 1;
            this.lblVegetables.Text = "Овочі";
            this.lblVegetables.Click += new System.EventHandler(this.pnlVegetables_Click);
            // 
            // pbDesserts
            // 
            this.pbDesserts.Image = ((System.Drawing.Image)(resources.GetObject("pbDesserts.Image")));
            this.pbDesserts.Location = new System.Drawing.Point(0, 0);
            this.pbDesserts.Name = "pbDesserts";
            this.pbDesserts.Size = new System.Drawing.Size(226, 146);
            this.pbDesserts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDesserts.TabIndex = 0;
            this.pbDesserts.TabStop = false;
            this.pbDesserts.Click += new System.EventHandler(this.pnlDesserts_Click);
            // 
            // pbFruits
            // 
            this.pbFruits.Image = ((System.Drawing.Image)(resources.GetObject("pbFruits.Image")));
            this.pbFruits.Location = new System.Drawing.Point(0, 0);
            this.pbFruits.Name = "pbFruits";
            this.pbFruits.Size = new System.Drawing.Size(226, 146);
            this.pbFruits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFruits.TabIndex = 0;
            this.pbFruits.TabStop = false;
            this.pbFruits.Click += new System.EventHandler(this.pnlFruits_Click);
            // 
            // pbMaindish
            // 
            this.pbMaindish.Image = ((System.Drawing.Image)(resources.GetObject("pbMaindish.Image")));
            this.pbMaindish.Location = new System.Drawing.Point(3, 0);
            this.pbMaindish.Name = "pbMaindish";
            this.pbMaindish.Size = new System.Drawing.Size(223, 146);
            this.pbMaindish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaindish.TabIndex = 0;
            this.pbMaindish.TabStop = false;
            this.pbMaindish.Click += new System.EventHandler(this.pnlMaindish_Click);
            // 
            // pbSalads
            // 
            this.pbSalads.Image = ((System.Drawing.Image)(resources.GetObject("pbSalads.Image")));
            this.pbSalads.Location = new System.Drawing.Point(0, 0);
            this.pbSalads.Name = "pbSalads";
            this.pbSalads.Size = new System.Drawing.Size(226, 146);
            this.pbSalads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSalads.TabIndex = 0;
            this.pbSalads.TabStop = false;
            this.pbSalads.Click += new System.EventHandler(this.pnlSalads_Click);
            // 
            // pbSoups
            // 
            this.pbSoups.Image = ((System.Drawing.Image)(resources.GetObject("pbSoups.Image")));
            this.pbSoups.Location = new System.Drawing.Point(0, 0);
            this.pbSoups.Name = "pbSoups";
            this.pbSoups.Size = new System.Drawing.Size(226, 146);
            this.pbSoups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSoups.TabIndex = 0;
            this.pbSoups.TabStop = false;
            this.pbSoups.Click += new System.EventHandler(this.pnlSoups_Click);
            // 
            // pbVegetables
            // 
            this.pbVegetables.Image = ((System.Drawing.Image)(resources.GetObject("pbVegetables.Image")));
            this.pbVegetables.Location = new System.Drawing.Point(0, 0);
            this.pbVegetables.Name = "pbVegetables";
            this.pbVegetables.Size = new System.Drawing.Size(226, 146);
            this.pbVegetables.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVegetables.TabIndex = 0;
            this.pbVegetables.TabStop = false;
            this.pbVegetables.Click += new System.EventHandler(this.pnlVegetables_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPopularCreators);
            this.Controls.Add(this.lblRecipeCategories);
            this.Controls.Add(this.lblDiscoverRecipes);
            this.Controls.Add(this.pnlDiscoverRecipes);
            this.Controls.Add(this.pnlPopularCreators);
            this.Controls.Add(this.pnlRecipeCategories);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1332, 795);
            this.pnlRecipeCategories.ResumeLayout(false);
            this.pnlDesserts.ResumeLayout(false);
            this.pnlDesserts.PerformLayout();
            this.pnlFruits.ResumeLayout(false);
            this.pnlFruits.PerformLayout();
            this.pnlMaindish.ResumeLayout(false);
            this.pnlMaindish.PerformLayout();
            this.pnlSalads.ResumeLayout(false);
            this.pnlSalads.PerformLayout();
            this.pnlSoups.ResumeLayout(false);
            this.pnlSoups.PerformLayout();
            this.pnlVegetables.ResumeLayout(false);
            this.pnlVegetables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesserts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaindish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVegetables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiscoverRecipes;
        private System.Windows.Forms.Label lblRecipeCategories;
        private System.Windows.Forms.Label lblPopularCreators;
        private System.Windows.Forms.FlowLayoutPanel pnlRecipeCategories;
        private System.Windows.Forms.FlowLayoutPanel pnlPopularCreators;
        private System.Windows.Forms.FlowLayoutPanel pnlDiscoverRecipes;
        private System.Windows.Forms.Panel pnlDesserts;
        private System.Windows.Forms.Label lblDesserts;
        private System.Windows.Forms.PictureBox pbDesserts;
        private Panel pnlFruits;
        private Label lblFruits;
        private PictureBox pbFruits;
        private Panel pnlMaindish;
        private Label lblMaindish;
        private PictureBox pbMaindish;
        private Panel pnlSalads;
        private Label lblSalads;
        private PictureBox pbSalads;
        private Panel pnlSoups;
        private Label lblSoups;
        private PictureBox pbSoups;
        private Panel pnlVegetables;
        private Label lblVegetables;
        private PictureBox pbVegetables;
    }
}
