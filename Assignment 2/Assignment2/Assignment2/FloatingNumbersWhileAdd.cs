/// Anton Brottare 6/10-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class FloatingNumbersWhileAdd
    {
        private double sum;

        /// <summary>
        /// Startmethod that starts other methods and takes input from the user.
        /// </summary>
        public void Start()
        {
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowResults();
        }

        /// <summary>
        /// Shows the user info on how to use the program.
        /// </summary>
        private void WriteProgramInfo()
        {
            Console.WriteLine("\n\n ++++++++ Summation of numbers with decimals++++++++");
            Console.WriteLine("                            Using a while statement\n");
            Console.WriteLine("Write 0 to finish input!");
            Console.WriteLine("Make sure to use correct decimal character!");
            Console.WriteLine("---------------------------------------------");
           



        }

        /// <summary>
        /// Reads input and sums the numbers until a 0 is entered.
        /// </summary>
        private void ReadInputAndSumNumbers()
        {
            bool done = false;

            while (!done)
            {
                double num = ReadInput();
               if (num == 0)
                    done = true;

               else
                    sum = sum + num;
            }
        }

        /// <summary>
        /// Reads the input with the help of the Input.ReadDoubleConsole() method to ensure correct data is entered
        /// </summary>
        private double ReadInput()
        {
            Console.Write("Write an amount to sum or zero to finish: ");
            double num = Input.ReadDoubleConsole();
            return num;
        }

        /// <summary>
        /// Displays the results of the summing
        /// </summary>
        private void ShowResults()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("The sum is {0}", sum);
        }

    }
}
