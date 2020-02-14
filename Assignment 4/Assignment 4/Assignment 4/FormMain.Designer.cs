namespace Assignment_4
{
    partial class FormMain
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
            this.AddNewRecipeBox = new System.Windows.Forms.GroupBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.nameOfRecipeBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addRecipeButton = new System.Windows.Forms.Button();
            this.recipeListbox = new System.Windows.Forms.ListBox();
            this.nameLabelListbox = new System.Windows.Forms.Label();
            this.numberOfIngredientsLabelListbox = new System.Windows.Forms.Label();
            this.categoryLabelListbox = new System.Windows.Forms.Label();
            this.descriptionLabelListbox = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.AddNewRecipeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewRecipeBox
            // 
            this.AddNewRecipeBox.Controls.Add(this.descriptionBox);
            this.AddNewRecipeBox.Controls.Add(this.addIngredientButton);
            this.AddNewRecipeBox.Controls.Add(this.categoryCombo);
            this.AddNewRecipeBox.Controls.Add(this.categoryLabel);
            this.AddNewRecipeBox.Controls.Add(this.nameOfRecipeBox);
            this.AddNewRecipeBox.Controls.Add(this.nameLabel);
            this.AddNewRecipeBox.Location = new System.Drawing.Point(12, 70);
            this.AddNewRecipeBox.Name = "AddNewRecipeBox";
            this.AddNewRecipeBox.Size = new System.Drawing.Size(593, 540);
            this.AddNewRecipeBox.TabIndex = 0;
            this.AddNewRecipeBox.TabStop = false;
            this.AddNewRecipeBox.Text = "Name of recipe";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(21, 179);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(549, 338);
            this.descriptionBox.TabIndex = 5;
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Location = new System.Drawing.Point(401, 108);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(169, 43);
            this.addIngredientButton.TabIndex = 3;
            this.addIngredientButton.Text = "Add ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // categoryCombo
            // 
            this.categoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(190, 114);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(177, 33);
            this.categoryCombo.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(16, 123);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(99, 25);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // nameOfRecipeBox
            // 
            this.nameOfRecipeBox.Location = new System.Drawing.Point(190, 57);
            this.nameOfRecipeBox.Name = "nameOfRecipeBox";
            this.nameOfRecipeBox.Size = new System.Drawing.Size(380, 31);
            this.nameOfRecipeBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(16, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(157, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name of recipe";
            // 
            // addRecipeButton
            // 
            this.addRecipeButton.Location = new System.Drawing.Point(116, 636);
            this.addRecipeButton.Name = "addRecipeButton";
            this.addRecipeButton.Size = new System.Drawing.Size(408, 47);
            this.addRecipeButton.TabIndex = 1;
            this.addRecipeButton.Text = "Add recipe";
            this.addRecipeButton.UseVisualStyleBackColor = true;
            this.addRecipeButton.Click += new System.EventHandler(this.addRecipeButton_Click);
            // 
            // recipeListbox
            // 
            this.recipeListbox.FormattingEnabled = true;
            this.recipeListbox.ItemHeight = 25;
            this.recipeListbox.Location = new System.Drawing.Point(633, 127);
            this.recipeListbox.Name = "recipeListbox";
            this.recipeListbox.Size = new System.Drawing.Size(765, 479);
            this.recipeListbox.TabIndex = 2;
            // 
            // nameLabelListbox
            // 
            this.nameLabelListbox.AutoSize = true;
            this.nameLabelListbox.Location = new System.Drawing.Point(661, 96);
            this.nameLabelListbox.Name = "nameLabelListbox";
            this.nameLabelListbox.Size = new System.Drawing.Size(68, 25);
            this.nameLabelListbox.TabIndex = 3;
            this.nameLabelListbox.Tag = "";
            this.nameLabelListbox.Text = "Name";
            // 
            // numberOfIngredientsLabelListbox
            // 
            this.numberOfIngredientsLabelListbox.AutoSize = true;
            this.numberOfIngredientsLabelListbox.Location = new System.Drawing.Point(933, 70);
            this.numberOfIngredientsLabelListbox.Name = "numberOfIngredientsLabelListbox";
            this.numberOfIngredientsLabelListbox.Size = new System.Drawing.Size(118, 50);
            this.numberOfIngredientsLabelListbox.TabIndex = 4;
            this.numberOfIngredientsLabelListbox.Tag = "";
            this.numberOfIngredientsLabelListbox.Text = "No. of \r\ningredients";
            // 
            // categoryLabelListbox
            // 
            this.categoryLabelListbox.AutoSize = true;
            this.categoryLabelListbox.Location = new System.Drawing.Point(1106, 95);
            this.categoryLabelListbox.Name = "categoryLabelListbox";
            this.categoryLabelListbox.Size = new System.Drawing.Size(99, 25);
            this.categoryLabelListbox.TabIndex = 5;
            this.categoryLabelListbox.Tag = "";
            this.categoryLabelListbox.Text = "Category";
            // 
            // descriptionLabelListbox
            // 
            this.descriptionLabelListbox.AutoSize = true;
            this.descriptionLabelListbox.Location = new System.Drawing.Point(1255, 96);
            this.descriptionLabelListbox.Name = "descriptionLabelListbox";
            this.descriptionLabelListbox.Size = new System.Drawing.Size(120, 25);
            this.descriptionLabelListbox.TabIndex = 6;
            this.descriptionLabelListbox.Tag = "";
            this.descriptionLabelListbox.Text = "Description";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(743, 636);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(189, 47);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1035, 636);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(189, 47);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 695);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.descriptionLabelListbox);
            this.Controls.Add(this.categoryLabelListbox);
            this.Controls.Add(this.numberOfIngredientsLabelListbox);
            this.Controls.Add(this.nameLabelListbox);
            this.Controls.Add(this.recipeListbox);
            this.Controls.Add(this.addRecipeButton);
            this.Controls.Add(this.AddNewRecipeBox);
            this.Name = "FormMain";
            this.Text = "Apu\'s Cook Book";
            this.AddNewRecipeBox.ResumeLayout(false);
            this.AddNewRecipeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AddNewRecipeBox;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox nameOfRecipeBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.Button addRecipeButton;
        private System.Windows.Forms.ListBox recipeListbox;
        private System.Windows.Forms.Label nameLabelListbox;
        private System.Windows.Forms.Label numberOfIngredientsLabelListbox;
        private System.Windows.Forms.Label categoryLabelListbox;
        private System.Windows.Forms.Label descriptionLabelListbox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

