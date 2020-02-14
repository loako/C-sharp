using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class WorkingSchedule
    {

        private int index = 0;
        private int increment = 0;
        private int everyThird = 0;

        /// <summary>
        /// Startmethod that starts other methods and takes input from the user.
        /// </summary>
        public void Start()
        {
            int choice = -1;
            while (choice != 0)
            {
                DisplayMenu();
                choice = Input.ReadIntegerConsole();
                
                switch (choice)
                {
                    case (1):
                        {
                            index = 1;
                            increment = 3;
                            DisplayWorkDays();
                            break;
                        }
                    case (2):
                        {
                            index = 6;
                            increment = 5;
                            DisplayWorkDays();
                            break;
                        }

                }
            }

            
        }

        /// <summary>
        /// Displays the menu for the user
        /// </summary>
        private void DisplayMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                Work Menu                ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Show a list of the weekends to work:    1");
            Console.WriteLine("Show a list of the nights to work:      2");
            Console.WriteLine("Back To Main Menu:                      0");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Your Choice: ");


        }

        /// <summary>
        /// Displays the possible workdays for the user.
        /// </summary>
        private void DisplayWorkDays()
        {
            /// The motivation behind using a for loop is that we know both when to end and can determine how much to increment it each time to produce the desired results.
            for (int i = index; i <= 52; i = i + increment)
            {
                
                if (i.ToString().Length<2)
                {
                    Console.Write("Week  " + i + "  ");
                }
                else
                {
                    Console.Write("Week " + i + "  ");
                }
                everyThird++;
                if (everyThird==3)
                {
                    Console.WriteLine("");
                    everyThird = 0;
                    
                }

            }
        }

    }

}
