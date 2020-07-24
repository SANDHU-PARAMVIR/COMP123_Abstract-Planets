using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_Abstract_Planets
{
    // Param Sandhu
    // July 24 2020
    // Abstract Planets
    //Main class where objects are instantiated and methods are used
    public class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 116.464, 5.6836, "Ice");
            Console.WriteLine(giantPlanet);
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12.742, 5.972, true);
            Console.WriteLine(terrestrialPlanet);
            Program.waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}