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
        }

        public override string Bite()
        {
            throw new NotImplementedException();
        }



        public override string Tear()
        {
            throw new NotImplementedException();
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
