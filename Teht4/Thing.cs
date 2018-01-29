namespace Teht4
{
    abstract class Thing
    {
        public string Name;

        public Thing(string Name)
        {
            this.Name = Name;
        }


        public override string ToString()
        {
            return Name;
        }
    }
}