namespace WindowsFormsApp1
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
            this.inputGrpBox = new System.Windows.Forms.GroupBox();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.unitCombo = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.listItems = new System.Windows.Forms.ListBox();
            this.inputGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGrpBox
            // 
            this.inputGrpBox.Controls.Add(this.amountTxt);
            this.inputGrpBox.Controls.Add(this.descTxt);
            this.inputGrpBox.Controls.Add(this.unitCombo);
            this.inputGrpBox.Controls.Add(this.amountLabel);
            this.inputGrpBox.Controls.Add(this.descLabel);
            this.inputGrpBox.Location = new System.Drawing.Point(12, 74);
            this.inputGrpBox.Name = "inputGrpBox";
            this.inputGrpBox.Size = new System.Drawing.Size(576, 221);
            this.inputGrpBox.TabIndex = 0;
            this.inputGrpBox.TabStop = false;
            this.inputGrpBox.Text = "Input";
            // 
            // amountTxt
            // 
            this.amountTxt.Location = new System.Drawing.Point(212, 117);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(188, 31);
            this.amountTxt.TabIndex = 4;
            // 
            // descTxt
            // 
            this.descTxt.Location = new System.Drawing.Point(212, 66);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(303, 31);
            this.descTxt.TabIndex = 3;
            // 
            // unitCombo
            // 
            this.unitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitCombo.FormattingEnabled = true;
            this.unitCombo.Location = new System.Drawing.Point(406, 115);
            this.unitCombo.Name = "unitCombo";
            this.unitCombo.Size = new System.Drawing.Size(109, 33);
            this.unitCombo.TabIndex = 2;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(21, 126);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(85, 25);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(21, 66);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(120, 25);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "Description";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(642, 162);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(165, 84);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listItems
            // 
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 25;
            this.listItems.Location = new System.Drawing.Point(12, 362);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(841, 354);
            this.listItems.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 772);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.inputGrpBox);
            this.Name = "MainForm";
            this.Text = "Shopping list";
            this.inputGrpBox.ResumeLayout(false);
            this.inputGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGrpBox;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.ComboBox unitCombo;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox listItems;
    }
}

