///Anton Brottare 13/9-2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class TvMain
    {
        /// Startup method for the program.

        static void Main(string[] args)
        {
            Tv TvObj = new Tv();

            TvObj.start();
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();

        }
    }


}
