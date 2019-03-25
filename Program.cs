using System;

namespace CSClassesMethodsObjectsLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            Band band = new Band();
            band.Name = Console.ReadLine();
            band.Announce();
            band.AddMusician();
//            AnnounceBand(name);
        }

//        private static void AnnounceBand(string bandName)
//        {
//            Console.WriteLine("Welcome " + bandName + " to the stage!");
//        }
    }
}