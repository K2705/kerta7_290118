namespace Teht4
{
    abstract class PaperThing : Thing
    {
        public PaperThing(string Name) : base(Name)
        {
        }
    }

    class Book : PaperThing
    {
        public Book(string Name) : base(Name)
        {
        }
    }

    class Magazine : PaperThing
    {
        public Magazine(string Name) : base(Name)
        {
        }
    }

}
