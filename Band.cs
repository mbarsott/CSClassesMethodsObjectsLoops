using System;
using System.Collections.Generic;

namespace CSClassesMethodsObjectsLoops
{
    public class Band
    {
        public string Name;
        public List<Musician> Musicians = new List<Musician>();

        public void AddMusician()
        {
            var musician = new Musician();
            Console.WriteLine("What is the name of the musician to be added?");
            musician.Name = Console.ReadLine();
            Console.WriteLine("What instrument does " + musician.Name + " play?");
            musician.Instrument = Console.ReadLine();
            Musicians.Add(musician);
        }

        public void Announce()
        {
            Console.WriteLine("Welcome " + Name + " to the stage!");
        }
    }
}