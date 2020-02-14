///Anton Brottare 13/9-2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApplication
{
    class Pet
    {
        /// Declaring the variables that will be used
        
        private string name;
        private int age;
        private bool isFemale;
        
        /// Start method + greeting
        public void start()
        {
            Console.WriteLine();
            Console.WriteLine("Greetings from a pet Object!");
            Console.WriteLine();
            ReadAndSavePetData();
            DisplayPetInfo();
        }

        /// Method for input
        public void ReadAndSavePetData()
        {
            Console.Write("What is the name of your pet?   ");
            name = Console.ReadLine();
            Console.Write("How old is " + name + "?   ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Is " + name + " female (y/n)?   ");
            char response = char.Parse(Console.ReadLine());
            /// The if statement determines the gender of the 
            /// pet depending on the input from the user.

            if ((response == 'y' || response == 'Y'))

                isFemale = true;


            else
                isFemale = false;
        }
        /// Method for displaying the information back to the user.
        public void DisplayPetInfo()
        {
            Console.WriteLine();
            string textOut;
            /// The message gets modified with depending on the gender.
            if (isFemale == true)
                textOut = "Name: " + name + "\nAge: " + age +
                    "\nGender: Female";
            else
                textOut = "Name: " + name + "\nAge: " + age +
                    "\nGender: Male";

            Console.WriteLine(textOut);
        }
    }
}
