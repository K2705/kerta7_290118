using System;
using System.Collections.Generic;

namespace Teht4
{
    class Room
    {
        private List<Thing> Contents = new List<Thing>();

        public void AddItem(Thing item)
        {
            Contents.Add(item);
        }

        public void Clean()
        {
            Contents = new List<Thing>();
        }

        public void PrintContents()
        {
            foreach (Thing thing in Contents)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
