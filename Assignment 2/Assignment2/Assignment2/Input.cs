/// Anton Brottare 6/10-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Input
    {
        /// <summary>
        /// Reads integers and displays an error whenevevr another type of input is entered
        /// </summary>
      
        public static int ReadIntegerConsole()
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("Wrong input. Please try again: ");
            return ReadIntegerConsole();
        }
        /// <summary>
        /// Reads doubles and displays an error whenevevr another type of input is entered
        /// </summary>
        public static double ReadDoubleConsole()
        {
            double input;
            if (double.TryParse(Console.ReadLine(), out input))
                return input;
            else
                Console.Write("Wrong input. Please try again: ");
            return ReadDoubleConsole();
        }
    }
}
