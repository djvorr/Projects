namespace Bartender
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksAndRecipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScenarioPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMenuItems = new System.Windows.Forms.ListBox();
            this.lbInstructions = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lMenuItems = new System.Windows.Forms.Label();
            this.lPreview = new System.Windows.Forms.Label();
            this.lInstructions = new System.Windows.Forms.Label();
            this.pbViewer = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(612, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItemToolStripMenuItem,
            this.editMenuItemToolStripMenuItem,
            this.deleteMenuItemToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.openScenarioPlayerToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenuItemToolStripMenuItem
            // 
            this.newMenuItemToolStripMenuItem.Name = "newMenuItemToolStripMenuItem";
            this.newMenuItemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newMenuItemToolStripMenuItem.Text = "New Menu Item";
            // 
            // editMenuItemToolStripMenuItem
            // 
            this.editMenuItemToolStripMenuItem.Name = "editMenuItemToolStripMenuItem";
            this.editMenuItemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editMenuItemToolStripMenuItem.Text = "Edit Menu Item";
            // 
            // deleteMenuItemToolStripMenuItem
            // 
            this.deleteMenuItemToolStripMenuItem.Name = "deleteMenuItemToolStripMenuItem";
            this.deleteMenuItemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteMenuItemToolStripMenuItem.Text = "Delete Menu Item";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.drinksOnlyToolStripMenuItem,
            this.recipesOnlyToolStripMenuItem,
            this.drinksAndRecipesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // drinksOnlyToolStripMenuItem
            // 
            this.drinksOnlyToolStripMenuItem.Name = "drinksOnlyToolStripMenuItem";
            this.drinksOnlyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.drinksOnlyToolStripMenuItem.Text = "Drinks Only";
            // 
            // recipesOnlyToolStripMenuItem
            // 
            this.recipesOnlyToolStripMenuItem.Name = "recipesOnlyToolStripMenuItem";
            this.recipesOnlyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.recipesOnlyToolStripMenuItem.Text = "Recipes Only";
            // 
            // drinksAndRecipesToolStripMenuItem
            // 
            this.drinksAndRecipesToolStripMenuItem.Name = "drinksAndRecipesToolStripMenuItem";
            this.drinksAndRecipesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.drinksAndRecipesToolStripMenuItem.Text = "Drinks and Recipes";
            // 
            // openScenarioPlayerToolStripMenuItem
            // 
            this.openScenarioPlayerToolStripMenuItem.Name = "openScenarioPlayerToolStripMenuItem";
            this.openScenarioPlayerToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openScenarioPlayerToolStripMenuItem.Text = "Open Scenario Player";
            // 
            // lbMenuItems
            // 
            this.lbMenuItems.FormattingEnabled = true;
            this.lbMenuItems.Location = new System.Drawing.Point(13, 43);
            this.lbMenuItems.Name = "lbMenuItems";
            this.lbMenuItems.Size = new System.Drawing.Size(332, 186);
            this.lbMenuItems.TabIndex = 1;
            // 
            // lbInstructions
            // 
            this.lbInstructions.FormattingEnabled = true;
            this.lbInstructions.Location = new System.Drawing.Point(13, 258);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(587, 212);
            this.lbInstructions.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lMenuItems
            // 
            this.lMenuItems.AutoSize = true;
            this.lMenuItems.Location = new System.Drawing.Point(13, 24);
            this.lMenuItems.Name = "lMenuItems";
            this.lMenuItems.Size = new System.Drawing.Size(65, 13);
            this.lMenuItems.TabIndex = 5;
            this.lMenuItems.Text = "Menu Items:";
            // 
            // lPreview
            // 
            this.lPreview.AutoSize = true;
            this.lPreview.Location = new System.Drawing.Point(351, 24);
            this.lPreview.Name = "lPreview";
            this.lPreview.Size = new System.Drawing.Size(48, 13);
            this.lPreview.TabIndex = 6;
            this.lPreview.Text = "Preview:";
            // 
            // lInstructions
            // 
            this.lInstructions.AutoSize = true;
            this.lInstructions.Location = new System.Drawing.Point(13, 242);
            this.lInstructions.Name = "lInstructions";
            this.lInstructions.Size = new System.Drawing.Size(64, 13);
            this.lInstructions.TabIndex = 7;
            this.lInstructions.Text = "Instructions:";
            // 
            // pbViewer
            // 
            this.pbViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbViewer.Image = global::Bartender.Properties.Resources.no_image_available;
            this.pbViewer.Location = new System.Drawing.Point(354, 43);
            this.pbViewer.Name = "pbViewer";
            this.pbViewer.Size = new System.Drawing.Size(240, 186);
            this.pbViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbViewer.TabIndex = 4;
            this.pbViewer.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 529);
            this.Controls.Add(this.lInstructions);
            this.Controls.Add(this.lPreview);
            this.Controls.Add(this.lMenuItems);
            this.Controls.Add(this.pbViewer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.lbMenuItems);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Bartender";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem newMenuItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinksOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinksAndRecipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScenarioPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ListBox lbMenuItems;
        private System.Windows.Forms.ListBox lbInstructions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbViewer;
        private System.Windows.Forms.Label lMenuItems;
        private System.Windows.Forms.Label lPreview;
        private System.Windows.Forms.Label lInstructions;
    }
}

