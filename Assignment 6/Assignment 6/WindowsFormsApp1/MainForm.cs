// Anton Brottare 2018-01-03

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        static System.Windows.Forms.Timer timeTimer = new System.Windows.Forms.Timer();

        TaskManager taskManager = new TaskManager();


        public MainForm()
        {
            InitializeComponent();
            initializeGUI();
        }

        public void initializeGUI()
        {
            this.Text = "To do reminder " + Environment.UserName;
            dateTimePick.Format = DateTimePickerFormat.Custom;
            dateTimePick.CustomFormat = "yyyy-MM-dd  HH:mm";
            dateTimePick.Value = DateTime.Now;
            toDoList.Items.Clear();
            toDoTxt.Text = String.Empty;
            ///Creates and starts the timer
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            timeTimer.Tick += new EventHandler(TimeKeeper);
            timeTimer.Interval = 1000;
            timeTimer.Start();
            ///Makes sure the listbox/combobox don't get populated twice
            prioCombo.Items.Clear();
            toDoList.Items.Clear();
            
           //Cleans and adds the priorities to the combobox
            string[] priority = Enum.GetNames(typeof(Priorities));
            foreach (var item in priority) prioCombo.Items.Add(item.Replace("_", " "));
            prioCombo.SelectedIndex = (int)Priorities.Medium;

            toolTip.SetToolTip(dateTimePick, "Click to open calendar for date, write in time here.");
            taskManager.ClearAll();
        }

        private void TimeKeeper(Object myObject, EventArgs myEventArgs)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.ShowDialog();
        }
    

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            initializeGUI();
            
        }

        private void exitAltF4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }

        public static bool CloseCancel()
        {
            string message = "Are you sure that you would like to close the program?";
            string caption = "Close program";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.OK)
                return true;
            else
                return false;
        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            if (dateTimePick.Value > DateTime.Now)
            {
                bool success = false;

                Task newTask = ReadInput(out success);
                if (success)
                {
                   taskManager.Add(newTask);
                   UpdateGUI();
                }
            }
            else
            {
                MessageBox.Show("Wrong date, you cannot set reminders for the past","Error");
            }
        }

        private Task ReadInput(out bool success)
        {
            success = false;

            Task task = new Task();

            task.Description = ReadToDo(out success); 
            if (!success)
            {
                return null;
            }

            task.Priority = ReadPrio(out success);
            if (!success)
            {
                return null;
            }

            task.time = ReadTime(out success);
            return task;

        }

        private string ReadToDo(out bool success)
        {
            string toDo = toDoTxt.Text;
            success = false;
            if (string.IsNullOrEmpty(toDoTxt.Text))
            {
                GiveMessage("Empty ToDo!");
                toDoTxt.Focus();
                toDoTxt.SelectionStart = 0;
                toDoTxt.SelectionLength = toDoTxt.TextLength;
            }
            else
            {
                success = true;
            }
            return toDo;
        }

        private DateTime ReadTime(out bool success)
        {
            DateTime time = dateTimePick.Value;
            success = true;
            return time;
        }

        private Priorities ReadPrio(out bool success)
        {
            Priorities prio = (Priorities)prioCombo.SelectedIndex;
            success = true;
            return prio;
        }

        private void UpdateGUI()
        {
            toDoList.Items.Clear();
            string[] listOfToDos = taskManager.GetTasks();
            if(listOfToDos != null)
            {
                for(int i =0; i < taskManager.Count; i++)
                {
                    string FORMAT = "{0,10}";
                    string str = string.Format(FORMAT, listOfToDos[i]);
                   // string str = $"{""+1,4},  {listOfToDos[i],-20}";
                    toDoList.Items.Add(str);
                }
            }
        }


        private void GiveMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




    }
}
