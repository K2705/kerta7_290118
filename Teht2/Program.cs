using System;
using System.Drawing;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike jopo = new Bike("Jopo", "Street", 2016, Color.Blue);
            Bike tunturi = new Bike("Tunturi", "Street", 2010, Color.Black, "Shimano");
            Boat suvi = new Boat("Suvi", "S900", 1990, Color.White, "Rowboat", 3);
            Boat yamaha = new Boat("Yamaha", "1000", 2010, Color.Yellow, "Motorboat", 5);

            Console.WriteLine(jopo);
            Console.WriteLine(tunturi);
            Console.WriteLine(suvi);
            Console.WriteLine(yamaha);
        }
    }
}
