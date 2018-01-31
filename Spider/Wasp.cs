using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider
{
    class Wasp : Bug
    {
        public Wasp(String name, String venom, int size)
        {
            this.name = name;
            this.venom = venom;
            this.intactLimbs = 2;
            this.size = size;
            this.limbName = "wing";
        }

        public override string Bite()
        {
            return "The " + name + " stings you, injecting you with " + venom + "!";
        }



        public override string Tear()
        {
            if (intactLimbs <= 0)
            {
                return "The wasp has no " + limbName + "s left.";
            }
            else
            {
                intactLimbs--;
                return "You pull a " + limbName + " off the " + name + ". You monster. " + intactLimbs + " " + limbName + "s remain.";
            }
        }

        public override int CountLegs()
        {
            return intactLimbs;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false; //It's not even a wasp.
            Wasp otherWasp = (Wasp)obj;
            if (otherWasp.name != this.name
                || otherWasp.venom != this.venom
                || otherWasp.intactLimbs != this.intactLimbs
                || otherWasp.size != this.size)
                return false;

            return true;
        }


    }
}
