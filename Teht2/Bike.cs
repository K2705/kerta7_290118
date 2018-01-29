using System.Drawing;

namespace Teht2
{
    class Bike : Vehicle
    {
        public bool HasGears;
        public string GearName;

        public Bike(string name, string model, int year, Color color, string gearName)
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;
            HasGears = true;
            GearName = gearName;
        }

        public Bike(string name, string model, int year, Color color)
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;
            HasGears = false;
            GearName = "";
        }

        public Bike() : this("","",0,Color.Black)
        {

        }

        public override string ToString()
        {
            string gears = HasGears ? "   Gears: " + GearName : "";
            return base.ToString() + gears ;
        }
    }
}
