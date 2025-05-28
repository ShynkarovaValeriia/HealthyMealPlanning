namespace HealthyMealPlanning
{
    partial class frmAddToMealPlan
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
            this.pictureBoxRecipe = new System.Windows.Forms.PictureBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.rbBreakfast = new System.Windows.Forms.RadioButton();
            this.rbLunch = new System.Windows.Forms.RadioButton();
            this.rbSnacks = new System.Windows.Forms.RadioButton();
            this.rbDinner = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogo = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRecipe
            // 
            this.pictureBoxRecipe.Location = new System.Drawing.Point(415, 49);
            this.pictureBoxRecipe.Name = "pictureBoxRecipe";
            this.pictureBoxRecipe.Size = new System.Drawing.Size(599, 257);
            this.pictureBoxRecipe.TabIndex = 0;
            this.pictureBoxRecipe.TabStop = false;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(621, 325);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(219, 40);
            this.lblRecipeName.TabIndex = 1;
            this.lblRecipeName.Text = "Назва рецепту";
            // 
            // rbBreakfast
            // 
            this.rbBreakfast.AutoSize = true;
            this.rbBreakfast.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBreakfast.Location = new System.Drawing.Point(415, 406);
            this.rbBreakfast.Name = "rbBreakfast";
            this.rbBreakfast.Size = new System.Drawing.Size(166, 44);
            this.rbBreakfast.TabIndex = 2;
            this.rbBreakfast.TabStop = true;
            this.rbBreakfast.Text = "Сніданок";
            this.rbBreakfast.UseVisualStyleBackColor = true;
            // 
            // rbLunch
            // 
            this.rbLunch.AutoSize = true;
            this.rbLunch.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLunch.Location = new System.Drawing.Point(415, 486);
            this.rbLunch.Name = "rbLunch";
            this.rbLunch.Size = new System.Drawing.Size(104, 44);
            this.rbLunch.TabIndex = 3;
            this.rbLunch.TabStop = true;
            this.rbLunch.Text = "Обід";
            this.rbLunch.UseVisualStyleBackColor = true;
            // 
            // rbSnacks
            // 
            this.rbSnacks.AutoSize = true;
            this.rbSnacks.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSnacks.Location = new System.Drawing.Point(415, 566);
            this.rbSnacks.Name = "rbSnacks";
            this.rbSnacks.Size = new System.Drawing.Size(147, 44);
            this.rbSnacks.TabIndex = 4;
            this.rbSnacks.TabStop = true;
            this.rbSnacks.Text = "Закуски";
            this.rbSnacks.UseVisualStyleBackColor = true;
            // 
            // rbDinner
            // 
            this.rbDinner.AutoSize = true;
            this.rbDinner.BackColor = System.Drawing.SystemColors.Control;
            this.rbDinner.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDinner.Location = new System.Drawing.Point(415, 646);
            this.rbDinner.Name = "rbDinner";
            this.rbDinner.Size = new System.Drawing.Size(136, 44);
            this.rbDinner.TabIndex = 5;
            this.rbDinner.TabStop = true;
            this.rbDinner.Text = "Вечеря";
            this.rbDinner.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(270, 738);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(405, 83);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(776, 738);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(405, 83);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogo,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1500, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btnClose.Text = "Скасувати";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddToMealPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rbDinner);
            this.Controls.Add(this.rbSnacks);
            this.Controls.Add(this.rbLunch);
            this.Controls.Add(this.rbBreakfast);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.pictureBoxRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddToMealPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddToMealPlan";
            this.Load += new System.EventHandler(this.frmAddToMealPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRecipe;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.RadioButton rbBreakfast;
        private System.Windows.Forms.RadioButton rbLunch;
        private System.Windows.Forms.RadioButton rbSnacks;
        private System.Windows.Forms.RadioButton rbDinner;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLogo;
        private System.Windows.Forms.ToolStripButton btnClose;
    }
}