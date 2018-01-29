namespace Teht3
{
    class Radio
    {
        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 9)
                    volume = value;
            }
        }
        private double frequency;
        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (value >= 2000.0 && value <= 26000.0)
                    frequency = value;
            }
        }
    }
}
