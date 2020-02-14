using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    class TaskManager
    {
        //Declares a list object 
        private List<Task> taskList;

        public TaskManager()
        {
            //creates the list object
            taskList = new List<Task>();
        }
        //Check so the given index is not out of range
        private bool CheckIndex(int index)
        {
            return (index >= 0) && (index < taskList.Count);
        }
        //property returning amount of items in the list
        public int Count
        {
            get
            {
                int amountItems = taskList.Count;
                return amountItems;
            }
        }
        //Method for adding item to list
        //Checks so the itemIn has been created (not null)
        public bool AddItem(Task itemIn)
        {
            bool ok = false;
            if (itemIn != null)
            {
                taskList.Add(itemIn);
                ok = true;
            }
            return ok;
        }
        public string[] GetItemsInfoString()
        {
            string[] stringInfoString = new string[taskList.Count];
            int i = 0;
            foreach (Task Itemobj in taskList)
            {
                stringInfoString[i++] = Itemobj.ToString();
            }
            return stringInfoString;
        }
    }
}
