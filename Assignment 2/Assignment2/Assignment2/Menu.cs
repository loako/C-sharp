/// Anton Brottare 6/10-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Menu
    {
        /// <summary>
        /// Startmethod that starts other methods and takes input from the user.
        /// </summary>
        public void Start()
        {
            int choice = -1;

            while (choice != 0)
            {
                WriteMenuText();
                
                choice = Input.ReadIntegerConsole();

                switch(choice)
                {

                    case 1:
                        {
                            WholeNumbersForAdd sumObj = new WholeNumbersForAdd();
                            sumObj.Start();
                            

                            break;
                            
                        }
                    case 2:
                        {
                            FloatingNumbersWhileAdd sumObj = new FloatingNumbersWhileAdd();
                            sumObj.Start();
                            break;
                        }
                    case 3:
                        {
                            CurrencyConverter sumObj = new CurrencyConverter();
                            sumObj.Start();
                            break;
                        }
                    case 4:
                        {
                            WorkingSchedule WorkObj = new WorkingSchedule();
                            WorkObj.Start();
                            break;
                        }
                    case 5:
                        {
                            TemperatureConverter TempObj = new TemperatureConverter();
                            TempObj.Start();
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Displays the menu for the user
        /// </summary>
        private void WriteMenuText()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("                Main Menu                ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Whole Numbers With For:                 1");
            Console.WriteLine("Floating Point Numbers With While:      2");
            Console.WriteLine("Currency Converter With Do While Loop:  3");
            Console.WriteLine("Work Schedule:                          4");
            Console.WriteLine("Temperature table:                      5");
            Console.WriteLine("Exit The Program:                       0");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Your Choice: ");


        }

    }
}
