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
            this.components = new System.ComponentModel.Container();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlFavoriteRecipes = new System.Windows.Forms.Panel();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblSavedRecipes = new System.Windows.Forms.Label();
            this.lblFavoriteRecipes = new System.Windows.Forms.Label();
            this.pnlSavedRecipes = new System.Windows.Forms.Panel();
            this.pnlReview = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddOwnRecipe = new System.Windows.Forms.Button();
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
            this.pbChangePicture = new System.Windows.Forms.PictureBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(250, 69);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(249, 40);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Ім\'я користувача";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1500, 730);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlFavoriteRecipes);
            this.tabPage1.Controls.Add(this.lblReview);
            this.tabPage1.Controls.Add(this.lblSavedRecipes);
            this.tabPage1.Controls.Add(this.lblFavoriteRecipes);
            this.tabPage1.Controls.Add(this.pnlSavedRecipes);
            this.tabPage1.Controls.Add(this.pnlReview);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1492, 684);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Активність";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlFavoriteRecipes
            // 
            this.pnlFavoriteRecipes.AutoScroll = true;
            this.pnlFavoriteRecipes.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFavoriteRecipes.Location = new System.Drawing.Point(6, 65);
            this.pnlFavoriteRecipes.Name = "pnlFavoriteRecipes";
            this.pnlFavoriteRecipes.Size = new System.Drawing.Size(1480, 150);
            this.pnlFavoriteRecipes.TabIndex = 4;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(6, 473);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(120, 40);
            this.lblReview.TabIndex = 2;
            this.lblReview.Text = "Відгуки";
            // 
            // lblSavedRecipes
            // 
            this.lblSavedRecipes.AutoSize = true;
            this.lblSavedRecipes.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedRecipes.Location = new System.Drawing.Point(6, 241);
            this.lblSavedRecipes.Name = "lblSavedRecipes";
            this.lblSavedRecipes.Size = new System.Drawing.Size(287, 40);
            this.lblSavedRecipes.TabIndex = 1;
            this.lblSavedRecipes.Text = "Збережені рецепти";
            // 
            // lblFavoriteRecipes
            // 
            this.lblFavoriteRecipes.AutoSize = true;
            this.lblFavoriteRecipes.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoriteRecipes.Location = new System.Drawing.Point(6, 12);
            this.lblFavoriteRecipes.Name = "lblFavoriteRecipes";
            this.lblFavoriteRecipes.Size = new System.Drawing.Size(270, 40);
            this.lblFavoriteRecipes.TabIndex = 0;
            this.lblFavoriteRecipes.Text = "Улюблені рецепти";
            // 
            // pnlSavedRecipes
            // 
            this.pnlSavedRecipes.AutoScroll = true;
            this.pnlSavedRecipes.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSavedRecipes.Location = new System.Drawing.Point(6, 297);
            this.pnlSavedRecipes.Name = "pnlSavedRecipes";
            this.pnlSavedRecipes.Size = new System.Drawing.Size(1480, 150);
            this.pnlSavedRecipes.TabIndex = 5;
            // 
            // pnlReview
            // 
            this.pnlReview.AutoScroll = true;
            this.pnlReview.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReview.Location = new System.Drawing.Point(6, 528);
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.Size = new System.Drawing.Size(1480, 150);
            this.pnlReview.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddOwnRecipe);
            this.tabPage3.Controls.Add(this.flowLayoutPanelRecipes);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1492, 684);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Власні рецепти";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddOwnRecipe
            // 
            this.btnAddOwnRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btnAddOwnRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOwnRecipe.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOwnRecipe.ForeColor = System.Drawing.Color.White;
            this.btnAddOwnRecipe.Location = new System.Drawing.Point(536, 30);
            this.btnAddOwnRecipe.Name = "btnAddOwnRecipe";
            this.btnAddOwnRecipe.Size = new System.Drawing.Size(429, 80);
            this.btnAddOwnRecipe.TabIndex = 1;
            this.btnAddOwnRecipe.Text = "Додати власний рецепт";
            this.btnAddOwnRecipe.UseVisualStyleBackColor = false;
            this.btnAddOwnRecipe.Click += new System.EventHandler(this.btnAddOwnRecipe_Click);
            // 
            // flowLayoutPanelRecipes
            // 
            this.flowLayoutPanelRecipes.AutoScroll = true;
            this.flowLayoutPanelRecipes.Location = new System.Drawing.Point(6, 139);
            this.flowLayoutPanelRecipes.Name = "flowLayoutPanelRecipes";
            this.flowLayoutPanelRecipes.Size = new System.Drawing.Size(1480, 539);
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
            this.tabPage4.Location = new System.Drawing.Point(4, 42);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1492, 684);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Налаштування профілю";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnChangeSave
            // 
            this.btnChangeSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btnChangeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSave.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSave.ForeColor = System.Drawing.Color.White;
            this.btnChangeSave.Location = new System.Drawing.Point(588, 550);
            this.btnChangeSave.Name = "btnChangeSave";
            this.btnChangeSave.Size = new System.Drawing.Size(325, 90);
            this.btnChangeSave.TabIndex = 10;
            this.btnChangeSave.Text = "Зберегти";
            this.btnChangeSave.UseVisualStyleBackColor = false;
            this.btnChangeSave.Click += new System.EventHandler(this.btnChangeSave_Click);
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangePassword.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangePassword.Location = new System.Drawing.Point(821, 445);
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(347, 48);
            this.txtChangePassword.TabIndex = 9;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.Location = new System.Drawing.Point(814, 393);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(120, 40);
            this.lblChangePassword.TabIndex = 8;
            this.lblChangePassword.Text = "Пароль";
            // 
            // txtChangeEmail
            // 
            this.txtChangeEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangeEmail.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeEmail.Location = new System.Drawing.Point(821, 317);
            this.txtChangeEmail.Name = "txtChangeEmail";
            this.txtChangeEmail.Size = new System.Drawing.Size(347, 48);
            this.txtChangeEmail.TabIndex = 7;
            // 
            // lblChangeEmail
            // 
            this.lblChangeEmail.AutoSize = true;
            this.lblChangeEmail.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeEmail.Location = new System.Drawing.Point(814, 265);
            this.lblChangeEmail.Name = "lblChangeEmail";
            this.lblChangeEmail.Size = new System.Drawing.Size(274, 40);
            this.lblChangeEmail.TabIndex = 6;
            this.lblChangeEmail.Text = "Електронна пошта";
            // 
            // txtChangeFullname
            // 
            this.txtChangeFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangeFullname.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeFullname.Location = new System.Drawing.Point(329, 445);
            this.txtChangeFullname.Name = "txtChangeFullname";
            this.txtChangeFullname.Size = new System.Drawing.Size(347, 48);
            this.txtChangeFullname.TabIndex = 5;
            // 
            // lblChangeFullname
            // 
            this.lblChangeFullname.AutoSize = true;
            this.lblChangeFullname.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeFullname.Location = new System.Drawing.Point(322, 393);
            this.lblChangeFullname.Name = "lblChangeFullname";
            this.lblChangeFullname.Size = new System.Drawing.Size(165, 40);
            this.lblChangeFullname.TabIndex = 4;
            this.lblChangeFullname.Text = "Повне ім\'я";
            // 
            // txtChangeUsername
            // 
            this.txtChangeUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangeUsername.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeUsername.Location = new System.Drawing.Point(329, 317);
            this.txtChangeUsername.Name = "txtChangeUsername";
            this.txtChangeUsername.Size = new System.Drawing.Size(347, 48);
            this.txtChangeUsername.TabIndex = 3;
            // 
            // lblChangeUsername
            // 
            this.lblChangeUsername.AutoSize = true;
            this.lblChangeUsername.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeUsername.Location = new System.Drawing.Point(322, 265);
            this.lblChangeUsername.Name = "lblChangeUsername";
            this.lblChangeUsername.Size = new System.Drawing.Size(249, 40);
            this.lblChangeUsername.TabIndex = 2;
            this.lblChangeUsername.Text = "Ім\'я користувача";
            // 
            // lblChangePicture
            // 
            this.lblChangePicture.AutoSize = true;
            this.lblChangePicture.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePicture.Location = new System.Drawing.Point(322, 176);
            this.lblChangePicture.Name = "lblChangePicture";
            this.lblChangePicture.Size = new System.Drawing.Size(310, 40);
            this.lblChangePicture.TabIndex = 1;
            this.lblChangePicture.Text = "Змінити зображення";
            // 
            // pbChangePicture
            // 
            this.pbChangePicture.Location = new System.Drawing.Point(329, 42);
            this.pbChangePicture.Name = "pbChangePicture";
            this.pbChangePicture.Size = new System.Drawing.Size(122, 122);
            this.pbChangePicture.TabIndex = 0;
            this.pbChangePicture.TabStop = false;
            // 
            // pbPicture
            // 
            this.pbPicture.ErrorImage = global::HealthyMealPlanning.Properties.Resources.placeholder;
            this.pbPicture.InitialImage = global::HealthyMealPlanning.Properties.Resources.profile;
            this.pbPicture.Location = new System.Drawing.Point(86, 28);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(122, 122);
            this.pbPicture.TabIndex = 4;
            this.pbPicture.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Вийти з облікового запису";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::HealthyMealPlanning.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(1424, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.Size = new System.Drawing.Size(1500, 900);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.Panel pnlFavoriteRecipes;
        private System.Windows.Forms.Panel pnlSavedRecipes;
        private System.Windows.Forms.Panel pnlReview;
        private System.Windows.Forms.Button btnAddOwnRecipe;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLogout;
    }
}
