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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogo = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.lblYourOpinion = new System.Windows.Forms.Label();
            this.lblReviewFor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
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
            this.toolStrip1.Size = new System.Drawing.Size(1500, 27);
            this.toolStrip1.TabIndex = 0;
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
            this.btnLogo.ToolTipText = "На головне меню";
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
            this.btnClose.ToolTipText = "Скасувати";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblYourOpinion
            // 
            this.lblYourOpinion.AutoSize = true;
            this.lblYourOpinion.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourOpinion.Location = new System.Drawing.Point(501, 51);
            this.lblYourOpinion.Name = "lblYourOpinion";
            this.lblYourOpinion.Size = new System.Drawing.Size(484, 49);
            this.lblYourOpinion.TabIndex = 1;
            this.lblYourOpinion.Text = "Поділіться своєю думкою!";
            // 
            // lblReviewFor
            // 
            this.lblReviewFor.AutoSize = true;
            this.lblReviewFor.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewFor.Location = new System.Drawing.Point(416, 142);
            this.lblReviewFor.Name = "lblReviewFor";
            this.lblReviewFor.Size = new System.Drawing.Size(167, 40);
            this.lblReviewFor.TabIndex = 2;
            this.lblReviewFor.Text = "Огляд для:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(416, 359);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 40);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Опис:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(416, 434);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(655, 242);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "Поділіться своїм досвідом. Чи є якісь поради щодо покращення цього рецепту?";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(416, 742);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(655, 83);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlRatings
            // 
            this.pnlRatings.Controls.Add(this.pbStar5);
            this.pnlRatings.Controls.Add(this.pbStar4);
            this.pnlRatings.Controls.Add(this.pbStar3);
            this.pnlRatings.Controls.Add(this.pbStar2);
            this.pnlRatings.Controls.Add(this.pbStar1);
            this.pnlRatings.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRatings.Location = new System.Drawing.Point(416, 214);
            this.pnlRatings.Name = "pnlRatings";
            this.pnlRatings.Size = new System.Drawing.Size(655, 98);
            this.pnlRatings.TabIndex = 8;
            // 
            // pbStar5
            // 
            this.pbStar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbStar5.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar5.Location = new System.Drawing.Point(514, 19);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(60, 60);
            this.pbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar5.TabIndex = 11;
            this.pbStar5.TabStop = false;
            // 
            // pbStar4
            // 
            this.pbStar4.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar4.Location = new System.Drawing.Point(406, 19);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(60, 60);
            this.pbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar4.TabIndex = 10;
            this.pbStar4.TabStop = false;
            // 
            // pbStar3
            // 
            this.pbStar3.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar3.Location = new System.Drawing.Point(298, 19);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(60, 60);
            this.pbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar3.TabIndex = 9;
            this.pbStar3.TabStop = false;
            // 
            // pbStar2
            // 
            this.pbStar2.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar2.Location = new System.Drawing.Point(190, 19);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(60, 60);
            this.pbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar2.TabIndex = 8;
            this.pbStar2.TabStop = false;
            // 
            // pbStar1
            // 
            this.pbStar1.Image = global::HealthyMealPlanning.Properties.Resources.star_empty;
            this.pbStar1.Location = new System.Drawing.Point(82, 19);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(60, 60);
            this.pbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStar1.TabIndex = 7;
            this.pbStar1.TabStop = false;
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.pnlRatings);
            this.Controls.Add(this.btnSave);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmReview_MouseDown);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.Panel pnlRatings;
        private System.Windows.Forms.PictureBox pbStar5;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar2;
    }
}