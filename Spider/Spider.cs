using System;

namespace Spider
{
    /// <summary>
    /// It is a spider!
    /// </summary>
    class Spider : Bug
    {

        public Spider(String name, String venom, int size)
        {
            this.name = name;
            this.venom = venom;
            this.intactLimbs = 8;
            this.size = size;
        }

        public Spider() : this("default spider", "nothing", 1)
        {
        }

        public override string Bite()
        {
            return "The " + name + " bites you, injecting you with " + venom + "!";
        }
        /// <summary>
        /// Pull a leg off the spider (if legs remain)
        /// </summary>
        public override string Tear()
        {
            if (intactLimbs <= 0)
            {
                return "The spider has no legs left.";
            }
            else
            {
                intactLimbs--;
                return "You pull a leg off the " + name + ". You monster. " + intactLimbs + " legs remain.";
            }
        }

        public int CountLegs()
        {
            return intactLimbs;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false; //It's not even a spider.
            Spider otherSpider = (Spider)obj;
            if (otherSpider.name != this.name
                || otherSpider.venom != this.venom
                || otherSpider.intactLimbs != this.intactLimbs
                || otherSpider.size != this.size)
                return false;

            return true;
        }
    }
}
