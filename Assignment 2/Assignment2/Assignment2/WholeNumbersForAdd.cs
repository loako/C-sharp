/// Anton Brottare 6/10-2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    
        public class WholeNumbersForAdd
        {
            private int numOfInput;
            private int sum;

        /// <summary>
        /// Startmethod that starts other methods and takes input from the user.
        /// </summary>
        public void Start()
            {
                WriteProgramInfo();
                ReadInput();
                SumNumbers();
                ShowResults();
            }
            /// <summary>
            /// Asks the user for how many numbers to summarize (so we know when to stop the forLoop)
            /// </summary>
            private void ReadInput()
            {
                Console.Write("Number of values to sum? ");
                numOfInput = Input.ReadIntegerConsole();
                Console.WriteLine();
            }
            /// <summary>
            /// Displays information about the program
            /// </summary>
            private void WriteProgramInfo()
            {
                Console.WriteLine("\n\n ++++++++ Summation of whole numbers ++++++++");
                Console.WriteLine("                            Using a for statement\n");

            }
        /// <summary>
        /// reads input with the help of Input.ReadIntegerConsole to ensure correct data is entered and sums the entered data.
        /// </summary>
            private void SumNumbers()
            {
                int index;
                
                for (index = 0; index < numOfInput; index++)
                {
                Console.WriteLine("Write number " + (index + 1) + ": ");
                sum = sum+ Input.ReadIntegerConsole();
            }
            }
        /// <summary>
        /// Displays the final sum for the user
        /// </summary>
            private void ShowResults()
            {
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("The sum is \t{0}", sum);
            }
        }
 }
