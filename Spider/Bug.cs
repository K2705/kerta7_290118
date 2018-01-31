using System;

namespace Spider
{
    /// <summary>
    /// Some kind of stinging bug
    /// </summary>
    abstract class Bug
    {
        public string name { get; protected set; }
        protected string venom;
        protected int intactLimbs;
        public int size;
        public string limbName { get; protected set; }

        public abstract string Bite();

        public abstract string Tear();

        public abstract int CountLegs();

        public abstract override bool Equals(object obj);

    }
}