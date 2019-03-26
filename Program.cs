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

            Console.WriteLine("Type 'Add' to add a musician");
            Console.WriteLine("Type 'Announce' to announce the band.");
            Console.WriteLine("Type 'Quit' to quit the application");
            var repeat = true;
            while (repeat)
            {
                Console.WriteLine("Add, Announce, or Quit?");
                var action = Console.ReadLine().ToLower().Trim();
                if (action == "add")
                {
                    band.AddMusician();
                }
                else if (action.StartsWith("add"))
                {
                    var arguments = action.Split(' ');
                    if (arguments.Length == 3)
                    {
                        band.AddMusician(arguments[1].Substring(0, 1).ToUpper() + arguments[1].Substring(1),
                            arguments[2]);
                    }
                    else
                    {
                        band.AddMusician();
                    }
                }
                else if (action == "announce")
                {
                    band.Announce();
                }
                else if (action == "quit")
                {
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Invalid option, try again.");
                }
            }

//            AnnounceBand(name);
        }

//        private static void AnnounceBand(string bandName)
//        {
//            Console.WriteLine("Welcome " + bandName + " to the stage!");
//        }
    }
}