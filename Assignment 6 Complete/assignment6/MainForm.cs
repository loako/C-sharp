using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class cmbPriority : Form
    {
        TaskManager taskManager = new TaskManager();
        public cmbPriority()
        {
            InitializeComponent();
            InitializeGui();
        }

        public void InitializeGui()
        {
            this.Text = "To do reminder " + "Your name ";
            txtBxToDo.Text = string.Empty;

            lstBxToDo.Items.Clear();
            cmbBxPrio.Items.Clear();

            string[] priority = Enum.GetNames(typeof(PriorityType));
            foreach (var item in priority) cmbBxPrio.Items.Add(item.Replace("_", " "));
            cmbBxPrio.SelectedIndex = (int)PriorityType.Normal;

            lblTime.Text = DateTime.Now.ToLongTimeString();


            toolTipDate.SetToolTip(dateTimePicker, "Click to open calendar for date, write in time here.");
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";

            menuFileOpen.Enabled = false;
            menuFileSave.Enabled = false;
        }

        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGui();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog(this);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           bool ok = false;
            Task task = ReadInput(out ok);
            if (ok)
            {
                taskManager.AddItem(task);
                UpdateGUI();
            }
        }

        private Task ReadInput(out bool ok)
        {
            ok = false;
            Task task = new Task();

            //Read description
            task.Description = ReadDescription(out ok);
            if (!ok)
            {
                return null;
            }
            //Read amount
            task.priority = ReadPriority(out ok);
            if (!ok)
            {
                return null;
            }
            //Read unit, no need to chek ok
            task.date = ReadDate(out ok);
            return task;
        }
        private void GiveMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private string ReadDescription(out bool ok)
        {
            string text = txtBxToDo.Text;
            ok = false;
            if (string.IsNullOrEmpty(txtBxToDo.Text))
            {
                GiveMessage("Please enter a description!");
                txtBxToDo.Focus();
                txtBxToDo.SelectionStart = 0;
                txtBxToDo.SelectionLength = txtBxToDo.TextLength;
            }
            else
            {
                ok = true;
            }
            return text;
        }
        private PriorityType ReadPriority(out bool ok)
        {
            PriorityType type = (PriorityType)cmbBxPrio.SelectedIndex;
            ok = true;
            return type;
        }
        private DateTime ReadDate(out bool ok)
        {
            DateTime time = dateTimePicker.Value;
            ok = true;
            return time;
        }
        private void UpdateGUI()
        {
            lstBxToDo.Items.Clear();
            string[] items = taskManager.GetItemsInfoString();

            if (items != null)
            {
                for (int i = 0; i < taskManager.Count; i++)
                {
                    string str = $"  {i + 1,4}  {items[i],-20}  ";
                    lstBxToDo.Items.Add(str);
                }
            }
        }
    }
}
