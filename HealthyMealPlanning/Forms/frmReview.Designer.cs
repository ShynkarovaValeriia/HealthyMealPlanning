namespace HealthyMealPlanning
{
    partial class frmReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReview));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogo = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.lblYourOpinion = new System.Windows.Forms.Label();
            this.lblReviewFor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblYourExperience = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlRatings = new System.Windows.Forms.Panel();
            this.pbStar5 = new System.Windows.Forms.PictureBox();
            this.pbStar4 = new System.Windows.Forms.PictureBox();
            this.pbStar3 = new System.Windows.Forms.PictureBox();
            this.pbStar2 = new System.Windows.Forms.PictureBox();
            this.pbStar1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.pnlRatings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1037, 27);
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
            this.btnClose.Text = "toolStripButton1";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblYourOpinion
            // 
            this.lblYourOpinion.AutoSize = true;
            this.lblYourOpinion.Location = new System.Drawing.Point(35, 64);
            this.lblYourOpinion.Name = "lblYourOpinion";
            this.lblYourOpinion.Size = new System.Drawing.Size(131, 16);
            this.lblYourOpinion.TabIndex = 1;
            this.lblYourOpinion.Text = "Give us your opinion!";
            // 
            // lblReviewFor
            // 
            this.lblReviewFor.AutoSize = true;
            this.lblReviewFor.Location = new System.Drawing.Point(35, 114);
            this.lblReviewFor.Name = "lblReviewFor";
            this.lblReviewFor.Size = new System.Drawing.Size(73, 16);
            this.lblReviewFor.TabIndex = 2;
            this.lblReviewFor.Text = "Review for:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(42, 241);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(78, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(46, 281);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // lblYourExperience
            // 
            this.lblYourExperience.AutoSize = true;
            this.lblYourExperience.Location = new System.Drawing.Point(49, 328);
            this.lblYourExperience.Name = "lblYourExperience";
            this.lblYourExperience.Size = new System.Drawing.Size(417, 16);
            this.lblYourExperience.TabIndex = 5;
            this.lblYourExperience.Text = "Share more about your experience. Any tips for improving this recipe?";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(52, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(335, 65);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlRatings
            // 
            this.pnlRatings.Controls.Add(this.pbStar5);
            this.pnlRatings.Controls.Add(this.pbStar4);
            this.pnlRatings.Controls.Add(this.pbStar3);
            this.pnlRatings.Controls.Add(this.pbStar2);
            this.pnlRatings.Controls.Add(this.pbStar1);
            this.pnlRatings.Location = new System.Drawing.Point(38, 157);
            this.pnlRatings.Name = "pnlRatings";
            this.pnlRatings.Size = new System.Drawing.Size(310, 68);
            this.pnlRatings.TabIndex = 8;
            // 
            // pbStar5
            // 
            this.pbStar5.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar5.Location = new System.Drawing.Point(256, 19);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(44, 30);
            this.pbStar5.TabIndex = 11;
            this.pbStar5.TabStop = false;
            // 
            // pbStar4
            // 
            this.pbStar4.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar4.Location = new System.Drawing.Point(193, 19);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(44, 30);
            this.pbStar4.TabIndex = 10;
            this.pbStar4.TabStop = false;
            // 
            // pbStar3
            // 
            this.pbStar3.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar3.Location = new System.Drawing.Point(128, 19);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(44, 30);
            this.pbStar3.TabIndex = 9;
            this.pbStar3.TabStop = false;
            // 
            // pbStar2
            // 
            this.pbStar2.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar2.Location = new System.Drawing.Point(64, 19);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(44, 30);
            this.pbStar2.TabIndex = 8;
            this.pbStar2.TabStop = false;
            // 
            // pbStar1
            // 
            this.pbStar1.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar1.Location = new System.Drawing.Point(8, 19);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(44, 30);
            this.pbStar1.TabIndex = 7;
            this.pbStar1.TabStop = false;
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 663);
            this.Controls.Add(this.pnlRatings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblYourExperience);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblReviewFor);
            this.Controls.Add(this.lblYourOpinion);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReview";
            this.Load += new System.EventHandler(this.frmReview_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlRatings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLogo;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.Label lblYourOpinion;
        private System.Windows.Forms.Label lblReviewFor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblYourExperience;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.Panel pnlRatings;
        private System.Windows.Forms.PictureBox pbStar5;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar2;
    }
}