using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    class Task
    {
        public string description;
        public PriorityType priority;
        public DateTime date;

        public Task(string description, DateTime date, PriorityType priority)
        {
            this.description = description;
            this.date = date;
            this.priority = priority;
        }
        //Default constructor
        public Task()
        {
            //set default values
            date = DateTime.Now;
            description = string.Empty;
            priority = PriorityType.Normal;
        }
      /*  public Task(string description, DateTime date, PriorityType priority) : this("Unknown", DateTime.Now, PriorityType.Normal)
        {

        }
        public Task(string description): this(description, DateTime.Now, PriorityType.Normal)
        {

        }*/

        public string GetTimeString()
        {
            string time = date.ToShortTimeString();
            return time; 
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }
        public PriorityType Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string ToString()
        {
            return $"{date.ToShortDateString(),-12}" +
                $"{GetTimeString(),-7}" +
                $"{priority, -16}" +
                $"{description}";
        }
    }
}
