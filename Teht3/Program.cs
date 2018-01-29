using System;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            radio.Volume = 0;
            radio.Frequency = 2000.0;

            bool go = true;
            while (go)
            {
                Console.WriteLine("Volume: {0}\nFrequency: {1}", radio.Volume, radio.Frequency);
                Console.WriteLine("[1] Set volume\n[2] Set frequency\n[Q] Quit");
                string input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "1":
                        int volume;
                        Console.WriteLine("Set new volume (0-9)\n> ");
                        int.TryParse(Console.ReadLine(), out volume);
                        radio.Volume = volume;
                        break;
                    case "2":
                        double frequency;
                        Console.WriteLine("Set new frequency (2000.0-26000.0\n> ");
                        double.TryParse(Console.ReadLine(), out frequency);
                        radio.Frequency = frequency;
                        break;
                    case "q":
                    case "Q":
                        go = false;
                        break;
                }
            }
        }
    }
}
