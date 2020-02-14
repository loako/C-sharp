/// Anton Brottare 6/10-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TemperatureConverter
    {
        /// <summary>
        /// toCelsius is a variable that gets filled with the converted F->C value
        /// toFarenheit is a variable that gets filled with the converted C->F value
        /// TempChoice keeps track of which temperature conversion is being displayed so DisplayInfo can show the correct information.
        /// </summary>
        private double toCelsius = 0;
        private double toFarenheit = 0;
        private int TempChoice = 0;

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
                            TempChoice = 1;
                            DisplayInfo();
                            CelsiusToFarenheit();
                            break;
                        }
                    case (2):
                        {
                            TempChoice = 2;
                            DisplayInfo();
                            FarenheitToCelsius();

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
            Console.WriteLine("                Temperature Tables       ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Show Celcius (C) to Farenheit (F):      1");
            Console.WriteLine("Show Farenheit (F) to Celsius (C):      2");
            Console.WriteLine("Back To Main Menu:                      0");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Your Choice: ");
        }

        /// <summary>
        /// Converts Celsius to Farenheit and displays a table with the values.
        /// </summary>
        private void CelsiusToFarenheit()
        {
            for (double i= 0.00; i <= 100.00; i +=4.00)
            {
                toCelsius = Math.Round(5.0 / 9.0 * (i - 32),2);
                Console.WriteLine("          {0} F = {1} C",i,toCelsius);
            }
        }
        
        /// <summary>
        /// Converts Farenheit to Celsius and displays a table with the values.
        /// </summary>
        private void FarenheitToCelsius()
        {
            for (double i = 0.00; i <= 100.00; i += 4.00)
            {
                toFarenheit = Math.Round(9.0 / 5.0 * (i + 32), 2);
                Console.WriteLine("          {0} C = {1} F", i, toFarenheit);
            }
        }

        /// <summary>
        /// DisplayInfo shows the user information about which type of conversion is being displayed F->C or C-<F.
        /// </summary>
        private void DisplayInfo()
        {
            ///If the user chose C->F TempChoice gets assigned 1 and the corresponding info gets displayed
            if (TempChoice == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("                Temperature Table        ");
                Console.WriteLine("  Changing Celcius (C) to Farenheit (F)  ");
                Console.WriteLine("-----------------------------------------");

            }
            ///If the user chose F->C TempChoice gets assigned 2 and the corresponding info gets displayed
            if (TempChoice == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("                Temperature Table        ");
                Console.WriteLine("  Changing Farenheit (F) to Celcius (C)  ");
                Console.WriteLine("-----------------------------------------");

            }
        }
    }
}
