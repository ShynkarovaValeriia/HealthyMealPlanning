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
            this.lblReview = new System.Windows.Forms.Label();
            this.lblSavedRecipes = new System.Windows.Forms.Label();
            this.lblFavoriteRecipes = new System.Windows.Forms.Label();
            this.pnlFavoriteRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlReview = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSavedRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddOwnRecipe = new System.Windows.Forms.Button();
            this.flowLayoutPanelRecipes = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnChangeSave = new System.Windows.Forms.Button();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.txtChangeEmail = new System.Windows.Forms.TextBox();
            this.lblChangeEmail = new System.Windows.Forms.Label();
            this.txtChangeFullname = new System.Windows.Forms.TextBox();
            this.lblChangeFullname = new System.Windows.Forms.Label();
            this.txtChangeUsername = new System.Windows.Forms.TextBox();
            this.lblChangeUsername = new System.Windows.Forms.Label();
            this.tabAdminPanel = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabAdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(108, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(249, 40);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Ім\'я користувача";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabAdminPanel);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 221);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1500, 679);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.lblReview);
            this.tabPage1.Controls.Add(this.lblSavedRecipes);
            this.tabPage1.Controls.Add(this.lblFavoriteRecipes);
            this.tabPage1.Controls.Add(this.pnlFavoriteRecipes);
            this.tabPage1.Controls.Add(this.pnlReview);
            this.tabPage1.Controls.Add(this.pnlSavedRecipes);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1492, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Активність";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(6, 601);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(120, 40);
            this.lblReview.TabIndex = 2;
            this.lblReview.Text = "Відгуки";
            // 
            // lblSavedRecipes
            // 
            this.lblSavedRecipes.AutoSize = true;
            this.lblSavedRecipes.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedRecipes.Location = new System.Drawing.Point(6, 300);
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
            // pnlFavoriteRecipes
            // 
            this.pnlFavoriteRecipes.AutoScroll = true;
            this.pnlFavoriteRecipes.AutoSize = true;
            this.pnlFavoriteRecipes.Location = new System.Drawing.Point(6, 65);
            this.pnlFavoriteRecipes.MaximumSize = new System.Drawing.Size(1460, 1460);
            this.pnlFavoriteRecipes.Name = "pnlFavoriteRecipes";
            this.pnlFavoriteRecipes.Size = new System.Drawing.Size(1460, 200);
            this.pnlFavoriteRecipes.TabIndex = 7;
            // 
            // pnlReview
            // 
            this.pnlReview.AutoScroll = true;
            this.pnlReview.AutoSize = true;
            this.pnlReview.Location = new System.Drawing.Point(6, 656);
            this.pnlReview.MaximumSize = new System.Drawing.Size(1460, 1460);
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.Size = new System.Drawing.Size(1460, 200);
            this.pnlReview.TabIndex = 0;
            // 
            // pnlSavedRecipes
            // 
            this.pnlSavedRecipes.AutoScroll = true;
            this.pnlSavedRecipes.AutoSize = true;
            this.pnlSavedRecipes.Location = new System.Drawing.Point(6, 356);
            this.pnlSavedRecipes.MaximumSize = new System.Drawing.Size(1460, 1460);
            this.pnlSavedRecipes.Name = "pnlSavedRecipes";
            this.pnlSavedRecipes.Size = new System.Drawing.Size(1460, 200);
            this.pnlSavedRecipes.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.btnAddOwnRecipe);
            this.tabPage2.Controls.Add(this.flowLayoutPanelRecipes);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1492, 633);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Власні рецепти";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddOwnRecipe
            // 
            this.btnAddOwnRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btnAddOwnRecipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOwnRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOwnRecipe.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOwnRecipe.ForeColor = System.Drawing.Color.White;
            this.btnAddOwnRecipe.Location = new System.Drawing.Point(522, 30);
            this.btnAddOwnRecipe.Name = "btnAddOwnRecipe";
            this.btnAddOwnRecipe.Size = new System.Drawing.Size(457, 80);
            this.btnAddOwnRecipe.TabIndex = 1;
            this.btnAddOwnRecipe.Text = "Додати власний рецепт";
            this.btnAddOwnRecipe.UseVisualStyleBackColor = false;
            this.btnAddOwnRecipe.Click += new System.EventHandler(this.btnAddOwnRecipe_Click);
            // 
            // flowLayoutPanelRecipes
            // 
            this.flowLayoutPanelRecipes.AutoScroll = true;
            this.flowLayoutPanelRecipes.Location = new System.Drawing.Point(6, 116);
            this.flowLayoutPanelRecipes.Name = "flowLayoutPanelRecipes";
            this.flowLayoutPanelRecipes.Size = new System.Drawing.Size(1460, 509);
            this.flowLayoutPanelRecipes.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnChangeSave);
            this.tabPage3.Controls.Add(this.txtChangePassword);
            this.tabPage3.Controls.Add(this.lblChangePassword);
            this.tabPage3.Controls.Add(this.txtChangeEmail);
            this.tabPage3.Controls.Add(this.lblChangeEmail);
            this.tabPage3.Controls.Add(this.txtChangeFullname);
            this.tabPage3.Controls.Add(this.lblChangeFullname);
            this.tabPage3.Controls.Add(this.txtChangeUsername);
            this.tabPage3.Controls.Add(this.lblChangeUsername);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1492, 633);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Налаштування профілю";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnChangeSave
            // 
            this.btnChangeSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btnChangeSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeSave.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSave.ForeColor = System.Drawing.Color.White;
            this.btnChangeSave.Location = new System.Drawing.Point(498, 524);
            this.btnChangeSave.Name = "btnChangeSave";
            this.btnChangeSave.Size = new System.Drawing.Size(504, 73);
            this.btnChangeSave.TabIndex = 10;
            this.btnChangeSave.Text = "Зберегти";
            this.btnChangeSave.UseVisualStyleBackColor = false;
            this.btnChangeSave.Click += new System.EventHandler(this.btnChangeSave_Click);
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangePassword.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangePassword.Location = new System.Drawing.Point(558, 443);
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(384, 48);
            this.txtChangePassword.TabIndex = 9;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.Location = new System.Drawing.Point(558, 400);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(120, 40);
            this.lblChangePassword.TabIndex = 8;
            this.lblChangePassword.Text = "Пароль";
            // 
            // txtChangeEmail
            // 
            this.txtChangeEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangeEmail.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeEmail.Location = new System.Drawing.Point(558, 319);
            this.txtChangeEmail.Name = "txtChangeEmail";
            this.txtChangeEmail.Size = new System.Drawing.Size(384, 48);
            this.txtChangeEmail.TabIndex = 7;
            // 
            // lblChangeEmail
            // 
            this.lblChangeEmail.AutoSize = true;
            this.lblChangeEmail.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeEmail.Location = new System.Drawing.Point(558, 276);
            this.lblChangeEmail.Name = "lblChangeEmail";
            this.lblChangeEmail.Size = new System.Drawing.Size(274, 40);
            this.lblChangeEmail.TabIndex = 6;
            this.lblChangeEmail.Text = "Електронна пошта";
            // 
            // txtChangeFullname
            // 
            this.txtChangeFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangeFullname.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeFullname.Location = new System.Drawing.Point(558, 195);
            this.txtChangeFullname.Name = "txtChangeFullname";
            this.txtChangeFullname.Size = new System.Drawing.Size(384, 48);
            this.txtChangeFullname.TabIndex = 5;
            // 
            // lblChangeFullname
            // 
            this.lblChangeFullname.AutoSize = true;
            this.lblChangeFullname.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeFullname.Location = new System.Drawing.Point(558, 152);
            this.lblChangeFullname.Name = "lblChangeFullname";
            this.lblChangeFullname.Size = new System.Drawing.Size(165, 40);
            this.lblChangeFullname.TabIndex = 4;
            this.lblChangeFullname.Text = "Повне ім\'я";
            // 
            // txtChangeUsername
            // 
            this.txtChangeUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChangeUsername.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeUsername.Location = new System.Drawing.Point(558, 71);
            this.txtChangeUsername.Name = "txtChangeUsername";
            this.txtChangeUsername.Size = new System.Drawing.Size(384, 48);
            this.txtChangeUsername.TabIndex = 3;
            // 
            // lblChangeUsername
            // 
            this.lblChangeUsername.AutoSize = true;
            this.lblChangeUsername.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeUsername.Location = new System.Drawing.Point(558, 28);
            this.lblChangeUsername.Name = "lblChangeUsername";
            this.lblChangeUsername.Size = new System.Drawing.Size(249, 40);
            this.lblChangeUsername.TabIndex = 2;
            this.lblChangeUsername.Text = "Ім\'я користувача";
            // 
            // tabAdminPanel
            // 
            this.tabAdminPanel.Controls.Add(this.btnDelete);
            this.tabAdminPanel.Controls.Add(this.btnEdit);
            this.tabAdminPanel.Controls.Add(this.btnAdd);
            this.tabAdminPanel.Controls.Add(this.btnLoadTable);
            this.tabAdminPanel.Controls.Add(this.cmbTables);
            this.tabAdminPanel.Controls.Add(this.dataGridViewAdmin);
            this.tabAdminPanel.Location = new System.Drawing.Point(4, 42);
            this.tabAdminPanel.Name = "tabAdminPanel";
            this.tabAdminPanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminPanel.Size = new System.Drawing.Size(1492, 633);
            this.tabAdminPanel.TabIndex = 4;
            this.tabAdminPanel.Text = "Панель адміністратора";
            this.tabAdminPanel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(17, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 65);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Видалити";
            this.toolTip4.SetToolTip(this.btnDelete, "Видалити запис");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(17, 341);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(267, 65);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редагувати";
            this.toolTip3.SetToolTip(this.btnEdit, "Редагувати запис");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(17, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(267, 65);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Додати";
            this.toolTip2.SetToolTip(this.btnAdd, "Додати запис");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btnLoadTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTable.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTable.ForeColor = System.Drawing.Color.White;
            this.btnLoadTable.Location = new System.Drawing.Point(17, 99);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(267, 65);
            this.btnLoadTable.TabIndex = 2;
            this.btnLoadTable.Text = "Завантажити";
            this.btnLoadTable.UseVisualStyleBackColor = false;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
            // 
            // cmbTables
            // 
            this.cmbTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTables.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(17, 18);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(267, 48);
            this.cmbTables.TabIndex = 1;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(305, 18);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersWidth = 51;
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(1171, 599);
            this.dataGridViewAdmin.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::HealthyMealPlanning.Properties.Resources.logout;
            this.btnLogout.Location = new System.Drawing.Point(1424, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnLogout, "Вийти з облікового запису");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.ErrorImage = global::HealthyMealPlanning.Properties.Resources.placeholder;
            this.pbPicture.Image = global::HealthyMealPlanning.Properties.Resources.account_circle;
            this.pbPicture.InitialImage = global::HealthyMealPlanning.Properties.Resources.profile;
            this.pbPicture.Location = new System.Drawing.Point(53, 16);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(45, 45);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 4;
            this.pbPicture.TabStop = false;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabAdminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.Button btnAddOwnRecipe;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel pnlFavoriteRecipes;
        private System.Windows.Forms.FlowLayoutPanel pnlReview;
        private System.Windows.Forms.FlowLayoutPanel pnlSavedRecipes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRecipes;
        private System.Windows.Forms.TabPage tabAdminPanel;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}
