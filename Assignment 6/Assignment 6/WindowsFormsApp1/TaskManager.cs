// Anton Brottare 2018-01-03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
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
        //property returning amount of tasks in the list
        public int Count
        {
            get
            {
                int amountTasks = taskList.Count;
                return amountTasks;
            }
        }

        public bool Add(Task itemIn)
        {
            bool ok = false;
            if (itemIn != null)
            {
                taskList.Add(itemIn);
                ok = true;
            }
            return ok;
        }
        public string[] GetTasks()
        {
            string[] stringInfoString = new string[taskList.Count];
            int i = 0;
            foreach (Task Itemobj in taskList)
            {
                stringInfoString[i++] = Itemobj.ToString();
            }
            return stringInfoString;
        }

        public void ClearAll()
        {
            taskList.Clear();
        }


    }
}
