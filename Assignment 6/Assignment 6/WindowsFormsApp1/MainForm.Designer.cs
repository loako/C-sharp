namespace Assignment6
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newCtrlNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateAndTimeLabel = new System.Windows.Forms.Label();
            this.dateTimePick = new System.Windows.Forms.DateTimePicker();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.prioCombo = new System.Windows.Forms.ComboBox();
            this.toDoTxt = new System.Windows.Forms.TextBox();
            this.toDoLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.toDoList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.prioLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCtrlNToolStripMenuItem,
            this.exitAltF4ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 36);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newCtrlNToolStripMenuItem
            // 
            this.newCtrlNToolStripMenuItem.Name = "newCtrlNToolStripMenuItem";
            this.newCtrlNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newCtrlNToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.newCtrlNToolStripMenuItem.Text = "New";
            this.newCtrlNToolStripMenuItem.Click += new System.EventHandler(this.newCtrlNToolStripMenuItem_Click);
            // 
            // exitAltF4ToolStripMenuItem
            // 
            this.exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            this.exitAltF4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitAltF4ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.exitAltF4ToolStripMenuItem.Text = "Exit";
            this.exitAltF4ToolStripMenuItem.Click += new System.EventHandler(this.exitAltF4ToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.omToolStripMenuItem.Text = "Om...";
            this.omToolStripMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // dateAndTimeLabel
            // 
            this.dateAndTimeLabel.AutoSize = true;
            this.dateAndTimeLabel.Location = new System.Drawing.Point(43, 82);
            this.dateAndTimeLabel.Name = "dateAndTimeLabel";
            this.dateAndTimeLabel.Size = new System.Drawing.Size(145, 25);
            this.dateAndTimeLabel.TabIndex = 1;
            this.dateAndTimeLabel.Text = "Date and time";
            // 
            // dateTimePick
            // 
            this.dateTimePick.CustomFormat = "";
            this.dateTimePick.Location = new System.Drawing.Point(243, 82);
            this.dateTimePick.Name = "dateTimePick";
            this.dateTimePick.Size = new System.Drawing.Size(481, 31);
            this.dateTimePick.TabIndex = 2;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(730, 82);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(79, 25);
            this.priorityLabel.TabIndex = 3;
            this.priorityLabel.Text = "Priority";
            // 
            // prioCombo
            // 
            this.prioCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prioCombo.FormattingEnabled = true;
            this.prioCombo.Location = new System.Drawing.Point(834, 82);
            this.prioCombo.Name = "prioCombo";
            this.prioCombo.Size = new System.Drawing.Size(121, 33);
            this.prioCombo.TabIndex = 4;
            // 
            // toDoTxt
            // 
            this.toDoTxt.Location = new System.Drawing.Point(186, 141);
            this.toDoTxt.Name = "toDoTxt";
            this.toDoTxt.Size = new System.Drawing.Size(769, 31);
            this.toDoTxt.TabIndex = 5;
            // 
            // toDoLabel
            // 
            this.toDoLabel.AutoSize = true;
            this.toDoLabel.Location = new System.Drawing.Point(43, 144);
            this.toDoLabel.Name = "toDoLabel";
            this.toDoLabel.Size = new System.Drawing.Size(67, 25);
            this.toDoLabel.TabIndex = 6;
            this.toDoLabel.Text = "To do";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(245, 194);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(132, 43);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descriptionLabel);
            this.groupBox1.Controls.Add(this.prioLabel);
            this.groupBox1.Controls.Add(this.hourLabel);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.toDoList);
            this.groupBox1.ForeColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 521);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To do";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.timeLabel.ForeColor = System.Drawing.Color.Blue;
            this.timeLabel.Location = new System.Drawing.Point(822, 490);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(86, 31);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "label1";
            // 
            // toDoList
            // 
            this.toDoList.FormattingEnabled = true;
            this.toDoList.ItemHeight = 25;
            this.toDoList.Location = new System.Drawing.Point(6, 56);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(960, 404);
            this.toDoList.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(6, 28);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(57, 25);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.ForeColor = System.Drawing.Color.Black;
            this.hourLabel.Location = new System.Drawing.Point(228, 28);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(58, 25);
            this.hourLabel.TabIndex = 12;
            this.hourLabel.Text = "Hour";
            // 
            // prioLabel
            // 
            this.prioLabel.AutoSize = true;
            this.prioLabel.ForeColor = System.Drawing.Color.Black;
            this.prioLabel.Location = new System.Drawing.Point(352, 28);
            this.prioLabel.Name = "prioLabel";
            this.prioLabel.Size = new System.Drawing.Size(79, 25);
            this.prioLabel.TabIndex = 13;
            this.prioLabel.Text = "Priority";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(687, 28);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(120, 25);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Description";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 796);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.toDoLabel);
            this.Controls.Add(this.toDoTxt);
            this.Controls.Add(this.prioCombo);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.dateTimePick);
            this.Controls.Add(this.dateAndTimeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "To Do Reminder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newCtrlNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.Label dateAndTimeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePick;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox prioCombo;
        private System.Windows.Forms.TextBox toDoTxt;
        private System.Windows.Forms.Label toDoLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox toDoList;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label prioLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}

