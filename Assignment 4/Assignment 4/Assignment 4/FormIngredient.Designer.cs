namespace Assignment_4
{
    partial class FormIngredient
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
            this.numOfIngredientsLabel = new System.Windows.Forms.Label();
            this.numOfIngredientsCounterLabel = new System.Windows.Forms.Label();
            this.ingredientGroupbox = new System.Windows.Forms.GroupBox();
            this.deleteIngredientButton = new System.Windows.Forms.Button();
            this.editIngedientButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.ingredientTextbox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ingredientGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numOfIngredientsLabel
            // 
            this.numOfIngredientsLabel.AutoSize = true;
            this.numOfIngredientsLabel.Location = new System.Drawing.Point(27, 53);
            this.numOfIngredientsLabel.Name = "numOfIngredientsLabel";
            this.numOfIngredientsLabel.Size = new System.Drawing.Size(223, 25);
            this.numOfIngredientsLabel.TabIndex = 0;
            this.numOfIngredientsLabel.Text = "Number of ingredients";
            // 
            // numOfIngredientsCounterLabel
            // 
            this.numOfIngredientsCounterLabel.AutoSize = true;
            this.numOfIngredientsCounterLabel.Location = new System.Drawing.Point(582, 53);
            this.numOfIngredientsCounterLabel.Name = "numOfIngredientsCounterLabel";
            this.numOfIngredientsCounterLabel.Size = new System.Drawing.Size(0, 25);
            this.numOfIngredientsCounterLabel.TabIndex = 1;
            // 
            // ingredientGroupbox
            // 
            this.ingredientGroupbox.Controls.Add(this.deleteIngredientButton);
            this.ingredientGroupbox.Controls.Add(this.editIngedientButton);
            this.ingredientGroupbox.Controls.Add(this.listBox1);
            this.ingredientGroupbox.Controls.Add(this.addButton);
            this.ingredientGroupbox.Controls.Add(this.ingredientTextbox);
            this.ingredientGroupbox.Location = new System.Drawing.Point(32, 92);
            this.ingredientGroupbox.Name = "ingredientGroupbox";
            this.ingredientGroupbox.Size = new System.Drawing.Size(623, 558);
            this.ingredientGroupbox.TabIndex = 2;
            this.ingredientGroupbox.TabStop = false;
            this.ingredientGroupbox.Text = "Ingredient";
            // 
            // deleteIngredientButton
            // 
            this.deleteIngredientButton.Enabled = false;
            this.deleteIngredientButton.Location = new System.Drawing.Point(493, 206);
            this.deleteIngredientButton.Name = "deleteIngredientButton";
            this.deleteIngredientButton.Size = new System.Drawing.Size(104, 42);
            this.deleteIngredientButton.TabIndex = 5;
            this.deleteIngredientButton.Text = "Delete";
            this.deleteIngredientButton.UseVisualStyleBackColor = true;
            // 
            // editIngedientButton
            // 
            this.editIngedientButton.Enabled = false;
            this.editIngedientButton.Location = new System.Drawing.Point(493, 139);
            this.editIngedientButton.Name = "editIngedientButton";
            this.editIngedientButton.Size = new System.Drawing.Size(104, 42);
            this.editIngedientButton.TabIndex = 4;
            this.editIngedientButton.Text = "Edit";
            this.editIngedientButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(25, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 454);
            this.listBox1.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(493, 25);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ingredientTextbox
            // 
            this.ingredientTextbox.Location = new System.Drawing.Point(25, 31);
            this.ingredientTextbox.Name = "ingredientTextbox";
            this.ingredientTextbox.Size = new System.Drawing.Size(426, 31);
            this.ingredientTextbox.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(84, 693);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(173, 43);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(386, 693);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(173, 43);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // FormIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 788);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ingredientGroupbox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.numOfIngredientsCounterLabel);
            this.Controls.Add(this.numOfIngredientsLabel);
            this.Name = "FormIngredient";
            this.Text = "FormIngredient";
            this.ingredientGroupbox.ResumeLayout(false);
            this.ingredientGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfIngredientsLabel;
        private System.Windows.Forms.Label numOfIngredientsCounterLabel;
        private System.Windows.Forms.GroupBox ingredientGroupbox;
        private System.Windows.Forms.Button deleteIngredientButton;
        private System.Windows.Forms.Button editIngedientButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox ingredientTextbox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}