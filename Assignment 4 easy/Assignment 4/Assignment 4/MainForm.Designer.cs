namespace Assignment_4
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
            this.partyBox = new System.Windows.Forms.GroupBox();
            this.createListBtn = new System.Windows.Forms.Button();
            this.costPerPersonTextBox = new System.Windows.Forms.TextBox();
            this.numGuestsTextBox = new System.Windows.Forms.TextBox();
            this.costPerPersonLabel = new System.Windows.Forms.Label();
            this.totNumGuestsLabel = new System.Windows.Forms.Label();
            this.invGuestsLabel = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.totCostLabel = new System.Windows.Forms.Label();
            this.numGuestsLabel = new System.Windows.Forms.Label();
            this.guestListLabel = new System.Windows.Forms.Label();
            this.totalCostDisplayLabel = new System.Windows.Forms.Label();
            this.totalGuestsDisplayLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.guestList = new System.Windows.Forms.ListBox();
            this.partyBox.SuspendLayout();
            this.invGuestsLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // partyBox
            // 
            this.partyBox.Controls.Add(this.createListBtn);
            this.partyBox.Controls.Add(this.costPerPersonTextBox);
            this.partyBox.Controls.Add(this.numGuestsTextBox);
            this.partyBox.Controls.Add(this.costPerPersonLabel);
            this.partyBox.Controls.Add(this.totNumGuestsLabel);
            this.partyBox.Location = new System.Drawing.Point(34, 58);
            this.partyBox.Name = "partyBox";
            this.partyBox.Size = new System.Drawing.Size(402, 211);
            this.partyBox.TabIndex = 0;
            this.partyBox.TabStop = false;
            this.partyBox.Text = "New Party";
            // 
            // createListBtn
            // 
            this.createListBtn.Location = new System.Drawing.Point(90, 150);
            this.createListBtn.Name = "createListBtn";
            this.createListBtn.Size = new System.Drawing.Size(165, 46);
            this.createListBtn.TabIndex = 4;
            this.createListBtn.Text = "Create List";
            this.createListBtn.UseVisualStyleBackColor = true;
            this.createListBtn.Click += new System.EventHandler(this.createListBtn_Click);
            // 
            // costPerPersonTextBox
            // 
            this.costPerPersonTextBox.Location = new System.Drawing.Point(243, 97);
            this.costPerPersonTextBox.Name = "costPerPersonTextBox";
            this.costPerPersonTextBox.Size = new System.Drawing.Size(152, 31);
            this.costPerPersonTextBox.TabIndex = 3;
            // 
            // numGuestsTextBox
            // 
            this.numGuestsTextBox.Location = new System.Drawing.Point(243, 46);
            this.numGuestsTextBox.Name = "numGuestsTextBox";
            this.numGuestsTextBox.Size = new System.Drawing.Size(152, 31);
            this.numGuestsTextBox.TabIndex = 2;
            // 
            // costPerPersonLabel
            // 
            this.costPerPersonLabel.AutoSize = true;
            this.costPerPersonLabel.Location = new System.Drawing.Point(7, 103);
            this.costPerPersonLabel.Name = "costPerPersonLabel";
            this.costPerPersonLabel.Size = new System.Drawing.Size(165, 25);
            this.costPerPersonLabel.TabIndex = 1;
            this.costPerPersonLabel.Text = "Cost per person";
            // 
            // totNumGuestsLabel
            // 
            this.totNumGuestsLabel.AutoSize = true;
            this.totNumGuestsLabel.Location = new System.Drawing.Point(7, 52);
            this.totNumGuestsLabel.Name = "totNumGuestsLabel";
            this.totNumGuestsLabel.Size = new System.Drawing.Size(232, 25);
            this.totNumGuestsLabel.TabIndex = 0;
            this.totNumGuestsLabel.Text = "Total number of guests";
            // 
            // invGuestsLabel
            // 
            this.invGuestsLabel.Controls.Add(this.addBtn);
            this.invGuestsLabel.Controls.Add(this.lNameTextBox);
            this.invGuestsLabel.Controls.Add(this.fNameTextBox);
            this.invGuestsLabel.Controls.Add(this.lNameLabel);
            this.invGuestsLabel.Controls.Add(this.fNameLabel);
            this.invGuestsLabel.Location = new System.Drawing.Point(34, 356);
            this.invGuestsLabel.Name = "invGuestsLabel";
            this.invGuestsLabel.Size = new System.Drawing.Size(402, 263);
            this.invGuestsLabel.TabIndex = 1;
            this.invGuestsLabel.TabStop = false;
            this.invGuestsLabel.Text = "Invite Guests";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(171, 181);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(165, 46);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(143, 103);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(233, 31);
            this.lNameTextBox.TabIndex = 5;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(143, 54);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(233, 31);
            this.fNameTextBox.TabIndex = 4;
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Location = new System.Drawing.Point(7, 109);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lNameLabel.TabIndex = 3;
            this.lNameLabel.Text = "Last Name";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(7, 60);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(116, 25);
            this.fNameLabel.TabIndex = 2;
            this.fNameLabel.Text = "First Name";
            // 
            // totCostLabel
            // 
            this.totCostLabel.AutoSize = true;
            this.totCostLabel.Location = new System.Drawing.Point(48, 661);
            this.totCostLabel.Name = "totCostLabel";
            this.totCostLabel.Size = new System.Drawing.Size(110, 25);
            this.totCostLabel.TabIndex = 4;
            this.totCostLabel.Text = "Total Cost";
            // 
            // numGuestsLabel
            // 
            this.numGuestsLabel.AutoSize = true;
            this.numGuestsLabel.Location = new System.Drawing.Point(48, 710);
            this.numGuestsLabel.Name = "numGuestsLabel";
            this.numGuestsLabel.Size = new System.Drawing.Size(181, 25);
            this.numGuestsLabel.TabIndex = 5;
            this.numGuestsLabel.Text = "Number of guests";
            // 
            // guestListLabel
            // 
            this.guestListLabel.AutoSize = true;
            this.guestListLabel.Location = new System.Drawing.Point(609, 32);
            this.guestListLabel.Name = "guestListLabel";
            this.guestListLabel.Size = new System.Drawing.Size(109, 25);
            this.guestListLabel.TabIndex = 6;
            this.guestListLabel.Text = "Guest List";
            // 
            // totalCostDisplayLabel
            // 
            this.totalCostDisplayLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.totalCostDisplayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalCostDisplayLabel.Location = new System.Drawing.Point(272, 661);
            this.totalCostDisplayLabel.Name = "totalCostDisplayLabel";
            this.totalCostDisplayLabel.Size = new System.Drawing.Size(100, 25);
            this.totalCostDisplayLabel.TabIndex = 7;
            this.totalCostDisplayLabel.Text = "label8";
            this.totalCostDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalGuestsDisplayLabel
            // 
            this.totalGuestsDisplayLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.totalGuestsDisplayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalGuestsDisplayLabel.Location = new System.Drawing.Point(272, 710);
            this.totalGuestsDisplayLabel.Name = "totalGuestsDisplayLabel";
            this.totalGuestsDisplayLabel.Size = new System.Drawing.Size(100, 25);
            this.totalGuestsDisplayLabel.TabIndex = 8;
            this.totalGuestsDisplayLabel.Text = "label9";
            this.totalGuestsDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(678, 689);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(165, 46);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // guestList
            // 
            this.guestList.FormattingEnabled = true;
            this.guestList.ItemHeight = 25;
            this.guestList.Location = new System.Drawing.Point(481, 70);
            this.guestList.Name = "guestList";
            this.guestList.Size = new System.Drawing.Size(383, 604);
            this.guestList.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 789);
            this.Controls.Add(this.guestList);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.totalGuestsDisplayLabel);
            this.Controls.Add(this.totalCostDisplayLabel);
            this.Controls.Add(this.guestListLabel);
            this.Controls.Add(this.numGuestsLabel);
            this.Controls.Add(this.totCostLabel);
            this.Controls.Add(this.invGuestsLabel);
            this.Controls.Add(this.partyBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.partyBox.ResumeLayout(false);
            this.partyBox.PerformLayout();
            this.invGuestsLabel.ResumeLayout(false);
            this.invGuestsLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox partyBox;
        private System.Windows.Forms.Button createListBtn;
        private System.Windows.Forms.TextBox costPerPersonTextBox;
        private System.Windows.Forms.TextBox numGuestsTextBox;
        private System.Windows.Forms.Label costPerPersonLabel;
        private System.Windows.Forms.Label totNumGuestsLabel;
        private System.Windows.Forms.GroupBox invGuestsLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label totCostLabel;
        private System.Windows.Forms.Label numGuestsLabel;
        private System.Windows.Forms.Label guestListLabel;
        private System.Windows.Forms.Label totalCostDisplayLabel;
        private System.Windows.Forms.Label totalGuestsDisplayLabel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox guestList;
    }
}

