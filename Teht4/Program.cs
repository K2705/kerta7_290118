using System;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Room myRoom = new Room();
            myRoom.AddItem(new Phone("Samsung"));
            myRoom.AddItem(new Book("MAOL"));
            myRoom.AddItem(new LaptopComputer("Eee PC"));
            myRoom.AddItem(new PocketCalculator("Casio"));
            myRoom.AddItem(new Magazine("Aku Ankka"));
            myRoom.AddItem(new CDisc("Pirated music"));
            myRoom.AddItem(new DesktopComputer("Toaster"));
            myRoom.AddItem(new LaptopComputer("ThinkPad"));

            Console.WriteLine("Room contains:");
            myRoom.PrintContents();
            Console.WriteLine();
            Console.WriteLine("Let's clean the room.");
            myRoom.Clean();
            Console.WriteLine("Now the room contains:");
            myRoom.PrintContents(); //There nothing here.
        }
    }
}
