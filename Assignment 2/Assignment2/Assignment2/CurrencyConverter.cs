/// Anton Brottare 6/10-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CurrencyConverter
    {
        private double sum;
        private string ForeignCurrency;
        private double ConvertedCurrency;
        private double rate;


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
        /// Displays information about how to use the program for the user.
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

            do
            {
                double num = ReadInput();
                if (num == 0)
                {
                    done = true;
                    Console.Write("Name of the foreign currency: ");
                    ForeignCurrency = Console.ReadLine();
                    Console.Write("Exchange rate: ");
                    rate = Input.ReadDoubleConsole();
                    ConvertedCurrency = sum / rate;
                    ConvertedCurrency = Math.Round(ConvertedCurrency, 2);
                }



                else
                    sum = sum + num;
            } while (!done);
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
        /// Displays the sum, Converted currency and rate for the user.
        /// </summary>
        private void ShowResults()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("The sum is {0}", sum);
            Console.WriteLine();
            Console.WriteLine("{0} kr is converted to {1} {2} at the rate {3}kr/{2}", sum, ConvertedCurrency,ForeignCurrency, rate );
        }

    }
}
