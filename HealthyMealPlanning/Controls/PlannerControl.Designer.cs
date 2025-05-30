namespace HealthyMealPlanning
{
    partial class PlannerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlannerControl));
            this.lblMealPlan = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.pnlMonday = new System.Windows.Forms.Panel();
            this.pnlTuesday = new System.Windows.Forms.Panel();
            this.pnlWednesday = new System.Windows.Forms.Panel();
            this.pnlThursday = new System.Windows.Forms.Panel();
            this.pnlFriday = new System.Windows.Forms.Panel();
            this.pnlSaturday = new System.Windows.Forms.Panel();
            this.pnlSunday = new System.Windows.Forms.Panel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.contextMenuAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSunday = new System.Windows.Forms.Button();
            this.btnAddSaturday = new System.Windows.Forms.Button();
            this.btnAddFriday = new System.Windows.Forms.Button();
            this.btnAddThursday = new System.Windows.Forms.Button();
            this.btnAddWednesday = new System.Windows.Forms.Button();
            this.btnAddTuesday = new System.Windows.Forms.Button();
            this.btnAddMonday = new System.Windows.Forms.Button();
            this.contextMenuAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMealPlan
            // 
            resources.ApplyResources(this.lblMealPlan, "lblMealPlan");
            this.lblMealPlan.Name = "lblMealPlan";
            // 
            // lblMonday
            // 
            resources.ApplyResources(this.lblMonday, "lblMonday");
            this.lblMonday.Name = "lblMonday";
            // 
            // lblTuesday
            // 
            resources.ApplyResources(this.lblTuesday, "lblTuesday");
            this.lblTuesday.Name = "lblTuesday";
            // 
            // lblWednesday
            // 
            resources.ApplyResources(this.lblWednesday, "lblWednesday");
            this.lblWednesday.Name = "lblWednesday";
            // 
            // lblThursday
            // 
            resources.ApplyResources(this.lblThursday, "lblThursday");
            this.lblThursday.Name = "lblThursday";
            // 
            // lblFriday
            // 
            resources.ApplyResources(this.lblFriday, "lblFriday");
            this.lblFriday.Name = "lblFriday";
            // 
            // lblSaturday
            // 
            resources.ApplyResources(this.lblSaturday, "lblSaturday");
            this.lblSaturday.Name = "lblSaturday";
            // 
            // lblSunday
            // 
            resources.ApplyResources(this.lblSunday, "lblSunday");
            this.lblSunday.Name = "lblSunday";
            // 
            // pnlMonday
            // 
            resources.ApplyResources(this.pnlMonday, "pnlMonday");
            this.pnlMonday.Name = "pnlMonday";
            // 
            // pnlTuesday
            // 
            resources.ApplyResources(this.pnlTuesday, "pnlTuesday");
            this.pnlTuesday.Name = "pnlTuesday";
            // 
            // pnlWednesday
            // 
            resources.ApplyResources(this.pnlWednesday, "pnlWednesday");
            this.pnlWednesday.Name = "pnlWednesday";
            // 
            // pnlThursday
            // 
            resources.ApplyResources(this.pnlThursday, "pnlThursday");
            this.pnlThursday.Name = "pnlThursday";
            // 
            // pnlFriday
            // 
            resources.ApplyResources(this.pnlFriday, "pnlFriday");
            this.pnlFriday.Name = "pnlFriday";
            // 
            // pnlSaturday
            // 
            resources.ApplyResources(this.pnlSaturday, "pnlSaturday");
            this.pnlSaturday.Name = "pnlSaturday";
            // 
            // pnlSunday
            // 
            resources.ApplyResources(this.pnlSunday, "pnlSunday");
            this.pnlSunday.Name = "pnlSunday";
            // 
            // calendar
            // 
            resources.ApplyResources(this.calendar, "calendar");
            this.calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.ShowTodayCircle = false;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // contextMenuAdd
            // 
            resources.ApplyResources(this.contextMenuAdd, "contextMenuAdd");
            this.contextMenuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecipeToolStripMenuItem});
            this.contextMenuAdd.Name = "contextMenuAdd";
            // 
            // addRecipeToolStripMenuItem
            // 
            resources.ApplyResources(this.addRecipeToolStripMenuItem, "addRecipeToolStripMenuItem");
            this.addRecipeToolStripMenuItem.Name = "addRecipeToolStripMenuItem";
            this.addRecipeToolStripMenuItem.Click += new System.EventHandler(this.addRecipeToolStripMenuItem_Click);
            // 
            // btnAddSunday
            // 
            resources.ApplyResources(this.btnAddSunday, "btnAddSunday");
            this.btnAddSunday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSunday.Image = global::HealthyMealPlanning.Properties.Resources.add;
            this.btnAddSunday.Name = "btnAddSunday";
            this.btnAddSunday.UseVisualStyleBackColor = true;
            this.btnAddSunday.Click += new System.EventHandler(this.btnAddSunday_Click);
            // 
            // btnAddSaturday
            // 
            resources.ApplyResources(this.btnAddSaturday, "btnAddSaturday");
            this.btnAddSaturday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSaturday.Image = global::HealthyMealPlanning.Properties.Resources.add;
            this.btnAddSaturday.Name = "btnAddSaturday";
            this.btnAddSaturday.UseVisualStyleBackColor = true;
            this.btnAddSaturday.Click += new System.EventHandler(this.btnAddSaturday_Click);
            // 
            // btnAddFriday
            // 
            resources.ApplyResources(this.btnAddFriday, "btnAddFriday");
            this.btnAddFriday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFriday.Image = global::HealthyMealPlanning.Properties.Resources.add;
            this.btnAddFriday.Name = "btnAddFriday";
            this.btnAddFriday.UseVisualStyleBackColor = true;
            this.btnAddFriday.Click += new System.EventHandler(this.btnAddFriday_Click);
            // 
            // btnAddThursday
            // 
            resources.ApplyResources(this.btnAddThursday, "btnAddThursday");
            this.btnAddThursday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddThursday.Image = global::HealthyMealPlanning.Properties.Resources.add;
            this.btnAddThursday.Name = "btnAddThursday";
            this.btnAddThursday.UseVisualStyleBackColor = true;
            this.btnAddThursday.Click += new System.EventHandler(this.btnAddThursday_Click);
            // 
            // btnAddWednesday
            // 
            resources.ApplyResources(this.btnAddWednesday, "btnAddWednesday");
            this.btnAddWednesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWednesday.Image = global::HealthyMealPlanning.Properties.Resources.add;
            this.btnAddWednesday.Name = "btnAddWednesday";
            this.btnAddWednesday.UseVisualStyleBackColor = true;
            this.btnAddWednesday.Click += new System.EventHandler(this.btnAddWednesday_Click);
            // 
            // btnAddTuesday
            // 
            resources.ApplyResources(this.btnAddTuesday, "btnAddTuesday");
            this.btnAddTuesday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTuesday.Image = global::HealthyMealPlanning.Properties.Resources.add;
            this.btnAddTuesday.Name = "btnAddTuesday";
            this.btnAddTuesday.UseVisualStyleBackColor = true;
            this.btnAddTuesday.Click += new System.EventHandler(this.btnAddTuesday_Click);
            // 
            // btnAddMonday
            // 
            resources.ApplyResources(this.btnAddMonday, "btnAddMonday");
            this.btnAddMonday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMonday.Image = global::HealthyMealPlanning.Properties.Resources.add;
            this.btnAddMonday.Name = "btnAddMonday";
            this.btnAddMonday.UseVisualStyleBackColor = true;
            this.btnAddMonday.Click += new System.EventHandler(this.btnAddMonday_Click);
            // 
            // PlannerControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlSaturday);
            this.Controls.Add(this.btnAddSunday);
            this.Controls.Add(this.btnAddSaturday);
            this.Controls.Add(this.lblSunday);
            this.Controls.Add(this.btnAddFriday);
            this.Controls.Add(this.lblSaturday);
            this.Controls.Add(this.btnAddThursday);
            this.Controls.Add(this.lblFriday);
            this.Controls.Add(this.btnAddWednesday);
            this.Controls.Add(this.lblThursday);
            this.Controls.Add(this.btnAddTuesday);
            this.Controls.Add(this.lblWednesday);
            this.Controls.Add(this.btnAddMonday);
            this.Controls.Add(this.lblTuesday);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.lblMealPlan);
            this.Controls.Add(this.pnlMonday);
            this.Controls.Add(this.pnlTuesday);
            this.Controls.Add(this.pnlWednesday);
            this.Controls.Add(this.pnlThursday);
            this.Controls.Add(this.pnlFriday);
            this.Controls.Add(this.pnlSunday);
            this.Name = "PlannerControl";
            this.Load += new System.EventHandler(this.PlannerControl_Load);
            this.contextMenuAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMealPlan;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Panel pnlMonday;
        private System.Windows.Forms.Panel pnlTuesday;
        private System.Windows.Forms.Panel pnlWednesday;
        private System.Windows.Forms.Panel pnlThursday;
        private System.Windows.Forms.Panel pnlFriday;
        private System.Windows.Forms.Panel pnlSaturday;
        private System.Windows.Forms.Panel pnlSunday;
        private System.Windows.Forms.Button btnAddMonday;
        private System.Windows.Forms.Button btnAddTuesday;
        private System.Windows.Forms.Button btnAddWednesday;
        private System.Windows.Forms.Button btnAddThursday;
        private System.Windows.Forms.Button btnAddFriday;
        private System.Windows.Forms.Button btnAddSaturday;
        private System.Windows.Forms.Button btnAddSunday;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ContextMenuStrip contextMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem addRecipeToolStripMenuItem;
    }
}
