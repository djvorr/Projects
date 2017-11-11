namespace Bartender
{
    partial class SearchForm
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
            this.rBRecipe = new System.Windows.Forms.RadioButton();
            this.rBDrink = new System.Windows.Forms.RadioButton();
            this.rBBoth = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIngredients = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bViewAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rBRecipe
            // 
            this.rBRecipe.AutoSize = true;
            this.rBRecipe.Location = new System.Drawing.Point(30, 53);
            this.rBRecipe.Name = "rBRecipe";
            this.rBRecipe.Size = new System.Drawing.Size(59, 17);
            this.rBRecipe.TabIndex = 0;
            this.rBRecipe.TabStop = true;
            this.rBRecipe.Text = "Recipe";
            this.rBRecipe.UseVisualStyleBackColor = true;
            this.rBRecipe.CheckedChanged += new System.EventHandler(this.rBRecipe_CheckedChanged);
            // 
            // rBDrink
            // 
            this.rBDrink.AutoSize = true;
            this.rBDrink.Location = new System.Drawing.Point(30, 76);
            this.rBDrink.Name = "rBDrink";
            this.rBDrink.Size = new System.Drawing.Size(50, 17);
            this.rBDrink.TabIndex = 1;
            this.rBDrink.TabStop = true;
            this.rBDrink.Text = "Drink";
            this.rBDrink.UseVisualStyleBackColor = true;
            this.rBDrink.CheckedChanged += new System.EventHandler(this.rBDrink_CheckedChanged);
            // 
            // rBBoth
            // 
            this.rBBoth.AutoSize = true;
            this.rBBoth.Location = new System.Drawing.Point(30, 99);
            this.rBBoth.Name = "rBBoth";
            this.rBBoth.Size = new System.Drawing.Size(47, 17);
            this.rBBoth.TabIndex = 2;
            this.rBBoth.TabStop = true;
            this.rBBoth.Text = "Both";
            this.rBBoth.UseVisualStyleBackColor = true;
            this.rBBoth.CheckedChanged += new System.EventHandler(this.rBBoth_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search For:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(119, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(333, 20);
            this.tbName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "By Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "By Tags:";
            // 
            // tbTags
            // 
            this.tbTags.Location = new System.Drawing.Point(119, 78);
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(333, 20);
            this.tbTags.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "By Ingredients:";
            // 
            // tbIngredients
            // 
            this.tbIngredients.Location = new System.Drawing.Point(119, 129);
            this.tbIngredients.Name = "tbIngredients";
            this.tbIngredients.Size = new System.Drawing.Size(333, 20);
            this.tbIngredients.TabIndex = 8;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(377, 174);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 10;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bViewAll
            // 
            this.bViewAll.Location = new System.Drawing.Point(285, 174);
            this.bViewAll.Name = "bViewAll";
            this.bViewAll.Size = new System.Drawing.Size(75, 23);
            this.bViewAll.TabIndex = 11;
            this.bViewAll.Text = "View All";
            this.bViewAll.UseVisualStyleBackColor = true;
            this.bViewAll.Click += new System.EventHandler(this.bViewAll_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 208);
            this.Controls.Add(this.bViewAll);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIngredients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBBoth);
            this.Controls.Add(this.rBDrink);
            this.Controls.Add(this.rBRecipe);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBRecipe;
        private System.Windows.Forms.RadioButton rBDrink;
        private System.Windows.Forms.RadioButton rBBoth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIngredients;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bViewAll;
    }
}