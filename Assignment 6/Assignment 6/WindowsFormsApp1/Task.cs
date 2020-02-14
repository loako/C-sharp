// Anton Brottare 2018-01-03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment6
{
    class Task
    {
        public string description;
        public Priorities priority;
        public DateTime time;

        public Task(string description, DateTime time, Priorities priority)
        {
            this.description = description;
            this.time = time;
            this.priority = priority;
        }
        //Default constructor
        public Task()
        {
            //set default values
            time = DateTime.Now;
            description = string.Empty;
            priority = Priorities.Medium;
        }
  

        public string GetTimeString()
        {
            string selectTime = time.ToShortTimeString();
            return selectTime;
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
        public Priorities Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public DateTime Date
        {
            get { return time; }
            set { time = value; }
        }

        new public string ToString()
        {
            return $"{time.ToShortDateString(),-12}" +
                $"{GetTimeString(),-7}" +
                $"{priority,-16}" +
                $"{description}";
        }
    }
}

