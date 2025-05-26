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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnChangeSave = new System.Windows.Forms.Button();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.txtChangeEmail = new System.Windows.Forms.TextBox();
            this.lblChangeEmail = new System.Windows.Forms.Label();
            this.txtChangeFullname = new System.Windows.Forms.TextBox();
            this.lblChangeFullname = new System.Windows.Forms.Label();
            this.txtChangeUsername = new System.Windows.Forms.TextBox();
            this.lblChangeUsername = new System.Windows.Forms.Label();
            this.lblChangePicture = new System.Windows.Forms.Label();
            this.lblFavoriteRecipes = new System.Windows.Forms.Label();
            this.lblSavedRecipes = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblRecentlyViewed = new System.Windows.Forms.Label();
            this.pnlFavoriteRecipes = new System.Windows.Forms.Panel();
            this.pnlSavedRecipes = new System.Windows.Forms.Panel();
            this.pnlReview = new System.Windows.Forms.Panel();
            this.pnlRecentlyViewed = new System.Windows.Forms.Panel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbChangePicture = new System.Windows.Forms.PictureBox();
            this.btnAddOwnRecipe = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(175, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
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
            this.tabPage1.Controls.Add(this.lblRecentlyViewed);
            this.tabPage1.Controls.Add(this.lblReview);
            this.tabPage1.Controls.Add(this.lblSavedRecipes);
            this.tabPage1.Controls.Add(this.lblFavoriteRecipes);
            this.tabPage1.Controls.Add(this.pnlFavoriteRecipes);
            this.tabPage1.Controls.Add(this.pnlSavedRecipes);
            this.tabPage1.Controls.Add(this.pnlReview);
            this.tabPage1.Controls.Add(this.pnlRecentlyViewed);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Activity";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddOwnRecipe);
            this.tabPage3.Controls.Add(this.flowLayoutPanelRecipes);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(958, 684);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View own recipes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelRecipes
            // 
            this.flowLayoutPanelRecipes.Location = new System.Drawing.Point(6, 85);
            this.flowLayoutPanelRecipes.Name = "flowLayoutPanelRecipes";
            this.flowLayoutPanelRecipes.Size = new System.Drawing.Size(946, 593);
            this.flowLayoutPanelRecipes.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnChangeSave);
            this.tabPage4.Controls.Add(this.txtChangePassword);
            this.tabPage4.Controls.Add(this.lblChangePassword);
            this.tabPage4.Controls.Add(this.txtChangeEmail);
            this.tabPage4.Controls.Add(this.lblChangeEmail);
            this.tabPage4.Controls.Add(this.txtChangeFullname);
            this.tabPage4.Controls.Add(this.lblChangeFullname);
            this.tabPage4.Controls.Add(this.txtChangeUsername);
            this.tabPage4.Controls.Add(this.lblChangeUsername);
            this.tabPage4.Controls.Add(this.lblChangePicture);
            this.tabPage4.Controls.Add(this.pbChangePicture);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(958, 684);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Manage profile";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnChangeSave
            // 
            this.btnChangeSave.Location = new System.Drawing.Point(57, 413);
            this.btnChangeSave.Name = "btnChangeSave";
            this.btnChangeSave.Size = new System.Drawing.Size(211, 50);
            this.btnChangeSave.TabIndex = 10;
            this.btnChangeSave.Text = "Save";
            this.btnChangeSave.UseVisualStyleBackColor = true;
            this.btnChangeSave.Click += new System.EventHandler(this.btnChangeSave_Click);
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.Location = new System.Drawing.Point(26, 364);
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(100, 22);
            this.txtChangePassword.TabIndex = 9;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Location = new System.Drawing.Point(33, 345);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(67, 16);
            this.lblChangePassword.TabIndex = 8;
            this.lblChangePassword.Text = "Password";
            // 
            // txtChangeEmail
            // 
            this.txtChangeEmail.Location = new System.Drawing.Point(26, 297);
            this.txtChangeEmail.Name = "txtChangeEmail";
            this.txtChangeEmail.Size = new System.Drawing.Size(100, 22);
            this.txtChangeEmail.TabIndex = 7;
            // 
            // lblChangeEmail
            // 
            this.lblChangeEmail.AutoSize = true;
            this.lblChangeEmail.Location = new System.Drawing.Point(29, 278);
            this.lblChangeEmail.Name = "lblChangeEmail";
            this.lblChangeEmail.Size = new System.Drawing.Size(41, 16);
            this.lblChangeEmail.TabIndex = 6;
            this.lblChangeEmail.Text = "Email";
            // 
            // txtChangeFullname
            // 
            this.txtChangeFullname.Location = new System.Drawing.Point(26, 234);
            this.txtChangeFullname.Name = "txtChangeFullname";
            this.txtChangeFullname.Size = new System.Drawing.Size(100, 22);
            this.txtChangeFullname.TabIndex = 5;
            // 
            // lblChangeFullname
            // 
            this.lblChangeFullname.AutoSize = true;
            this.lblChangeFullname.Location = new System.Drawing.Point(29, 215);
            this.lblChangeFullname.Name = "lblChangeFullname";
            this.lblChangeFullname.Size = new System.Drawing.Size(65, 16);
            this.lblChangeFullname.TabIndex = 4;
            this.lblChangeFullname.Text = "Full name";
            // 
            // txtChangeUsername
            // 
            this.txtChangeUsername.Location = new System.Drawing.Point(26, 171);
            this.txtChangeUsername.Name = "txtChangeUsername";
            this.txtChangeUsername.Size = new System.Drawing.Size(100, 22);
            this.txtChangeUsername.TabIndex = 3;
            // 
            // lblChangeUsername
            // 
            this.lblChangeUsername.AutoSize = true;
            this.lblChangeUsername.Location = new System.Drawing.Point(23, 152);
            this.lblChangeUsername.Name = "lblChangeUsername";
            this.lblChangeUsername.Size = new System.Drawing.Size(70, 16);
            this.lblChangeUsername.TabIndex = 2;
            this.lblChangeUsername.Text = "Username";
            // 
            // lblChangePicture
            // 
            this.lblChangePicture.AutoSize = true;
            this.lblChangePicture.Location = new System.Drawing.Point(23, 89);
            this.lblChangePicture.Name = "lblChangePicture";
            this.lblChangePicture.Size = new System.Drawing.Size(97, 16);
            this.lblChangePicture.TabIndex = 1;
            this.lblChangePicture.Text = "Change picture";
            // 
            // lblFavoriteRecipes
            // 
            this.lblFavoriteRecipes.AutoSize = true;
            this.lblFavoriteRecipes.Location = new System.Drawing.Point(17, 16);
            this.lblFavoriteRecipes.Name = "lblFavoriteRecipes";
            this.lblFavoriteRecipes.Size = new System.Drawing.Size(104, 16);
            this.lblFavoriteRecipes.TabIndex = 0;
            this.lblFavoriteRecipes.Text = "Favorite recipes";
            // 
            // lblSavedRecipes
            // 
            this.lblSavedRecipes.AutoSize = true;
            this.lblSavedRecipes.Location = new System.Drawing.Point(24, 141);
            this.lblSavedRecipes.Name = "lblSavedRecipes";
            this.lblSavedRecipes.Size = new System.Drawing.Size(95, 16);
            this.lblSavedRecipes.TabIndex = 1;
            this.lblSavedRecipes.Text = "Saved recipes";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Location = new System.Drawing.Point(24, 272);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(52, 16);
            this.lblReview.TabIndex = 2;
            this.lblReview.Text = "Review";
            // 
            // lblRecentlyViewed
            // 
            this.lblRecentlyViewed.AutoSize = true;
            this.lblRecentlyViewed.Location = new System.Drawing.Point(24, 446);
            this.lblRecentlyViewed.Name = "lblRecentlyViewed";
            this.lblRecentlyViewed.Size = new System.Drawing.Size(106, 16);
            this.lblRecentlyViewed.TabIndex = 3;
            this.lblRecentlyViewed.Text = "Recently viewed";
            // 
            // pnlFavoriteRecipes
            // 
            this.pnlFavoriteRecipes.AutoScroll = true;
            this.pnlFavoriteRecipes.Location = new System.Drawing.Point(6, 35);
            this.pnlFavoriteRecipes.Name = "pnlFavoriteRecipes";
            this.pnlFavoriteRecipes.Size = new System.Drawing.Size(946, 95);
            this.pnlFavoriteRecipes.TabIndex = 4;
            // 
            // pnlSavedRecipes
            // 
            this.pnlSavedRecipes.AutoScroll = true;
            this.pnlSavedRecipes.Location = new System.Drawing.Point(6, 160);
            this.pnlSavedRecipes.Name = "pnlSavedRecipes";
            this.pnlSavedRecipes.Size = new System.Drawing.Size(946, 99);
            this.pnlSavedRecipes.TabIndex = 5;
            // 
            // pnlReview
            // 
            this.pnlReview.AutoScroll = true;
            this.pnlReview.Location = new System.Drawing.Point(6, 291);
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.Size = new System.Drawing.Size(946, 135);
            this.pnlReview.TabIndex = 6;
            // 
            // pnlRecentlyViewed
            // 
            this.pnlRecentlyViewed.AutoScroll = true;
            this.pnlRecentlyViewed.Location = new System.Drawing.Point(6, 432);
            this.pnlRecentlyViewed.Name = "pnlRecentlyViewed";
            this.pnlRecentlyViewed.Size = new System.Drawing.Size(946, 233);
            this.pnlRecentlyViewed.TabIndex = 7;
            // 
            // pbPicture
            // 
            this.pbPicture.ErrorImage = global::HealthyMealPlanning.Properties.Resources.placeholder;
            this.pbPicture.InitialImage = global::HealthyMealPlanning.Properties.Resources.profile;
            this.pbPicture.Location = new System.Drawing.Point(51, 3);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(100, 50);
            this.pbPicture.TabIndex = 4;
            this.pbPicture.TabStop = false;
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
            // pbChangePicture
            // 
            this.pbChangePicture.Location = new System.Drawing.Point(26, 26);
            this.pbChangePicture.Name = "pbChangePicture";
            this.pbChangePicture.Size = new System.Drawing.Size(100, 50);
            this.pbChangePicture.TabIndex = 0;
            this.pbChangePicture.TabStop = false;
            // 
            // btnAddOwnRecipe
            // 
            this.btnAddOwnRecipe.Location = new System.Drawing.Point(281, 15);
            this.btnAddOwnRecipe.Name = "btnAddOwnRecipe";
            this.btnAddOwnRecipe.Size = new System.Drawing.Size(326, 48);
            this.btnAddOwnRecipe.TabIndex = 1;
            this.btnAddOwnRecipe.Text = "Add own recipe";
            this.btnAddOwnRecipe.UseVisualStyleBackColor = true;
            this.btnAddOwnRecipe.Click += new System.EventHandler(this.btnAddOwnRecipe_Click);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblUsername);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(966, 786);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecipes;
        private System.Windows.Forms.Label lblChangePicture;
        private System.Windows.Forms.PictureBox pbChangePicture;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblChangeUsername;
        private System.Windows.Forms.TextBox txtChangeEmail;
        private System.Windows.Forms.Label lblChangeEmail;
        private System.Windows.Forms.TextBox txtChangeFullname;
        private System.Windows.Forms.Label lblChangeFullname;
        private System.Windows.Forms.TextBox txtChangeUsername;
        private System.Windows.Forms.Button btnChangeSave;
        private System.Windows.Forms.TextBox txtChangePassword;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Label lblSavedRecipes;
        private System.Windows.Forms.Label lblFavoriteRecipes;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblRecentlyViewed;
        private System.Windows.Forms.Panel pnlFavoriteRecipes;
        private System.Windows.Forms.Panel pnlSavedRecipes;
        private System.Windows.Forms.Panel pnlReview;
        private System.Windows.Forms.Panel pnlRecentlyViewed;
        private System.Windows.Forms.Button btnAddOwnRecipe;
    }
}
