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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRecipe
            // 
            this.pictureBoxRecipe.Location = new System.Drawing.Point(201, 48);
            this.pictureBoxRecipe.Name = "pictureBoxRecipe";
            this.pictureBoxRecipe.Size = new System.Drawing.Size(479, 173);
            this.pictureBoxRecipe.TabIndex = 0;
            this.pictureBoxRecipe.TabStop = false;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(394, 243);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(88, 16);
            this.lblRecipeName.TabIndex = 1;
            this.lblRecipeName.Text = "Recipe name";
            // 
            // rbBreakfast
            // 
            this.rbBreakfast.AutoSize = true;
            this.rbBreakfast.Location = new System.Drawing.Point(221, 290);
            this.rbBreakfast.Name = "rbBreakfast";
            this.rbBreakfast.Size = new System.Drawing.Size(85, 20);
            this.rbBreakfast.TabIndex = 2;
            this.rbBreakfast.TabStop = true;
            this.rbBreakfast.Text = "Breakfast";
            this.rbBreakfast.UseVisualStyleBackColor = true;
            // 
            // rbLunch
            // 
            this.rbLunch.AutoSize = true;
            this.rbLunch.Location = new System.Drawing.Point(221, 334);
            this.rbLunch.Name = "rbLunch";
            this.rbLunch.Size = new System.Drawing.Size(63, 20);
            this.rbLunch.TabIndex = 3;
            this.rbLunch.TabStop = true;
            this.rbLunch.Text = "Lunch";
            this.rbLunch.UseVisualStyleBackColor = true;
            // 
            // rbSnacks
            // 
            this.rbSnacks.AutoSize = true;
            this.rbSnacks.Location = new System.Drawing.Point(221, 382);
            this.rbSnacks.Name = "rbSnacks";
            this.rbSnacks.Size = new System.Drawing.Size(73, 20);
            this.rbSnacks.TabIndex = 4;
            this.rbSnacks.TabStop = true;
            this.rbSnacks.Text = "Snacks";
            this.rbSnacks.UseVisualStyleBackColor = true;
            // 
            // rbDinner
            // 
            this.rbDinner.AutoSize = true;
            this.rbDinner.Location = new System.Drawing.Point(221, 428);
            this.rbDinner.Name = "rbDinner";
            this.rbDinner.Size = new System.Drawing.Size(67, 20);
            this.rbDinner.TabIndex = 5;
            this.rbDinner.TabStop = true;
            this.rbDinner.Text = "Dinner";
            this.rbDinner.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(217, 65);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(463, 493);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 65);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddToMealPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 638);
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
    }
}