using System;

namespace Spider
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunTest();
            Console.WriteLine("Preparing crevice...");
            Crevice crevice = new Crevice(8);
            Console.WriteLine("Creating bugs...");
            crevice.addBug(new Spider("brown recluse spider", "deadly necrotoxin", 3));
            crevice.addBug(new Spider("black widow spider", "deadly neurotoxin", 3));
            crevice.addBug(new Spider("giant spider", "2d4 poison damage", 1000000));
            crevice.addBug(new Spider("giant cave spider", "paralytic venom", 10000000));
            crevice.addBug(new Spider("Australian funnel-web spider", "nasty mix of atracotoxins", 10));
            crevice.addBug(new Wasp("ordinary wasp", "alkaline venom", 4));
            crevice.addBug(new Wasp("Asian giant hornet", "alkali and neurotoxins", 8));
            crevice.addBug(new Wasp("dire wasp", "its living parasitic larvae", 40));
            Console.WriteLine("Ready!");
            MainLoop(crevice);
        }

        private static void MainLoop(Crevice crevice)
        {
            bool keepGoing = true;
            bool haveSpider = false;
            Bug spider = null;

            while (keepGoing)
            {
                Console.WriteLine();
                if (!haveSpider)
                {
                    Console.WriteLine("You see here a crevice.");
                    Console.WriteLine("[1] Poke at it");
                    Console.WriteLine("[2] Retrieve a bug");
                    Console.WriteLine("[q] Quit");
                }
                else
                {
                    Console.WriteLine("You see here a crevice, and a " + spider.name + ".");
                    Console.WriteLine("[1] Poke at the crevice");
                    Console.WriteLine("[2] Retrieve a new bug");
                    Console.WriteLine("[3] Pull a limb off");
                    Console.WriteLine("[4] Count limbs");
                    Console.WriteLine("[5] Discard bug");
                    Console.WriteLine("[q] Quit");
                }
                Console.Write("> ");
                String input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //poke
                        Console.WriteLine(crevice.Poke());
                        break;
                    case "2":
                        //new bug
                        Bug newSpider;
                        try
                        {
                            newSpider = crevice.getBug();
                            crevice.RemoveBug(newSpider);
                        }
                        catch (Crevice.OutOfBugsException e)
                        {
                            Console.WriteLine("ERROR: " + e.Message);
                            break;
                        }

                        if (haveSpider)
                        {
                            Console.WriteLine("You toss away your previous bug, and retrieve a shiny new " + newSpider.name + "!");
                        }
                        else
                        {
                            Console.WriteLine("You root around in the crevice, and pull out a " + newSpider.name + ".");
                            haveSpider = true;
                        }
                        Console.WriteLine(newSpider.Bite());
                        spider = newSpider;

                        break;
                    case "3":
                        //pull leg
                        if (!haveSpider) goto default; //considered harmful :^)
                        Console.WriteLine(spider.Tear());
                        break;
                    case "4":
                        //count legs
                        if (!haveSpider) goto default;
                        Console.WriteLine("{0} has {1} {2}s remaining.", spider.name, spider.CountLegs(), spider.limbName);
                        break;
                    case "5":
                        //discard
                        if (!haveSpider) goto default;
                        Console.WriteLine("You drop the {0}, and quickly lose track of it.", spider.name);
                        spider = null;
                        haveSpider = false;
                        Console.WriteLine("But with non-deterministic garbage collection, can you ever be sure the bug is really gone?");
                        break;
                    case "q":
                    case "Q":
                        //quit
                        keepGoing = false;
                        Console.WriteLine("Exiting . . .");
                        break;
                    default:
                        Console.WriteLine("Unable to parse input: " + input);
                        break;
                }
            }
        }

        private static void RunTest()
        {
            Spider Charlotte = new Spider();
            Spider Shelob = new Spider("brown recluse spider", "deadly necrotoxin", 3);
            Console.WriteLine("Current spiders: {0} and {1}", Charlotte.name, Shelob.name);

            Charlotte.Tear();
            Charlotte.Tear();

            Console.WriteLine(Charlotte.Bite());
            Console.WriteLine(Shelob.Bite());
            Console.WriteLine("{0} has {1} legs remaining and {2} has {3}.", Charlotte.name, Charlotte.CountLegs(), Shelob.name, Shelob.CountLegs());

            Crevice crevice = new Crevice(5);
            Console.WriteLine(crevice.Poke());
            crevice.addBug(Shelob);
            crevice.addBug(Charlotte);
            crevice.addBug((Spider)new Spider("black widow spider", "deadly neurotoxin", 3));
            crevice.addBug((Spider)new Spider("giant spider", "2d4 poison damage", 1000000));
            crevice.addBug((Spider)new Spider("giant cave spider", "paralytic venom", 10000000));
            crevice.addBug((Spider)new Spider());
            Console.WriteLine(crevice.Poke());
            Console.WriteLine(crevice.Poke());
            Console.WriteLine(crevice.Poke());
        }
    }
}
