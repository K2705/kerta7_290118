using System.Drawing;

namespace Teht2
{
    class Vehicle
    {
        public string Name;
        public string Model;
        public int Year;
        public Color Color;

        public Vehicle(string name, string model, int year, Color color)
        {
            this.Name = name;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        public Vehicle() : this("","",0,Color.Black)
        {
        }

        public override string ToString()
        {
            return "Name: " + Name + "   Model: " + Model + "   Year: " + Year + "   Color: " + Color;
        }
    }
}
