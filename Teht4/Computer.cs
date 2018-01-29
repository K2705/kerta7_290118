namespace Teht4
{
    abstract class Computer : Thing
    {
        public Computer(string Name) : base(Name)
        {
        }
    }

    class DesktopComputer : Computer
    {
        public DesktopComputer(string Name) : base(Name)
        {
        }
    }

    class Phone : Computer
    {
        public Phone(string Name) : base(Name)
        {
        }
    }

    class LaptopComputer : Computer
    {
        public LaptopComputer(string Name) : base(Name)
        {
        }
    }

    class PocketCalculator : Computer
    {
        public PocketCalculator(string Name) : base(Name)
        {
        }
    }

    class Tablet : Computer
    {
        public Tablet(string Name) : base(Name)
        {
        }
    }
}
