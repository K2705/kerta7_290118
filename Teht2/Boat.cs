using System.Drawing;

namespace Teht2
{
    class Boat : Vehicle
    {
        public string BoatType;
        public int Seats;

        public Boat(string name, string model, int year, Color color, string boatType, int seats)
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;
            BoatType = boatType;
            Seats = seats;
        }

        public override string ToString()
        {
            return base.ToString() + "   Boat type: " + BoatType + "   Seats: " + Seats;
        }
    }
}
