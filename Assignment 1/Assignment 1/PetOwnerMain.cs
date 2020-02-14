///Anton Brottare 13/9-2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApplication
{
    class PetOwnerMain
    {
        /// Startup method for the program.
        static void Main(string[] args)
        {
            Pet petObj = new Pet();

            petObj.start();
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

        }
    }

    
}
