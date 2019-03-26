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
//            var musician = new Musician();
            Console.WriteLine("What is the name of the musician to be added?");
//            musician.Name = Console.ReadLine();
            var name = Console.ReadLine();
//            Console.WriteLine("What instrument does " + musician.Name + " play?");
            Console.WriteLine("What instrument does " + name + " play?");
//            musician.Instrument = Console.ReadLine();
            var instrument = Console.ReadLine();
            AddMusician(name, instrument);
        }

        public void AddMusician(string name, string instrument)
        {
            var musician = new Musician();
            musician.Name = name;
            musician.Instrument = instrument;
            Musicians.Add(musician);
        }

        public void Announce()
        {
            Console.WriteLine("Welcome " + Name + " to the stage!");
            foreach (var musician in Musicians)
            {
                musician.Announce();
            }
        }
    }
}