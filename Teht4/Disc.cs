namespace Teht4
{
    abstract class Disc : Thing
    {
        public Disc(string Name) : base(Name)
        {
        }
    }

    class CDisc : Disc
    {
        public CDisc(string Name) : base(Name)
        {
        }
    }

    class DVDisc : Disc
    {
        public DVDisc(string Name) : base(Name)
        {
        }
    }

    class BluDisc : Disc
    {
        public BluDisc(string Name) : base(Name)
        {
        }
    }
}
