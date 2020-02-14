///Anton Brottare 13/9-2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class Tv
    {
        /// Declaring the variables that will be used

        private string make;
        private int size;
        private bool isWallmounted;

        /// Start method + Greeting
        public void start()
        {
            Console.WriteLine("Greetings from the TV application!");
            Console.WriteLine();
            readInput();
            displayTv();
        }
        /// Method for taking the users input.
        public void readInput()
        {
            Console.Write("What is the make of your TV?  ");
            make = Console.ReadLine();
            Console.Write("How many inches are your TV?  ");
            size = int.Parse(Console.ReadLine());
            Console.Write("Is your TV wallmounted (y/n)?  ");
            char response = char.Parse(Console.ReadLine());
            /// The if statement determines if the tv is wallmounted or not
            /// Depending on the users response.
            if ((response == 'y' || response == 'Y'))

                isWallmounted = true;

            else
                isWallmounted = false;

        }
        /// Method for displaying the information back to the user.
        public void displayTv()
        {

            Console.WriteLine();
            /// The message gets modified depending on if the TV is wallmounted.
            string textOut;
            if (isWallmounted == true)
                textOut = "Wicked! Your " + size + "\" " + make + " looks sweet on that wall!";
            else
                textOut = "Sweet! Your "+ size + "\" " + make + " looks good!";

            Console.WriteLine(textOut);
        }
    }
   
}
