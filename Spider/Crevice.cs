using System;

namespace Spider
{
    /// <summary>
    /// A crevice where bugs dwell
    /// </summary>
    class Crevice
    {
        private int maxBugs;
        private int bugcount;
        private Bug[] bugs;

        public Crevice(int max)
        {
            this.maxBugs = max;
            this.bugcount = 0;
            this.bugs = new Bug[maxBugs];
        }

        /// <summary>
        /// Get a random bug from the crevice
        /// Throws OutOfBugsException if the crevice has no bugs
        /// </summary>
        /// <returns>a Bug</returns>
        public Bug getBug()
        {
            if (bugcount == 0)
            {
                throw new OutOfBugsException("This crevice has zero bugs inside it!");
            }
            else
            {
                return bugs[new Random().Next(0, bugcount)];
            }
        }

        /// <summary>
        /// Add a new bug into the crevice
        /// </summary>
        /// <param name="bug">Bug to be added</param>
        public void addBug(Bug bug)
        {
            if (bugcount < maxBugs)
            {
                bugs[bugcount] = bug;
                bugcount++;
                //Bug added successfully
            }
            else
            {
                Console.WriteLine("Unable to add bug (crevice full).");
            }
        }

        /// <summary>
        /// Stick your finger into the crevice.
        /// </summary>
        /// <returns></returns>
        public String Poke()
        {
            if (bugcount > 0)
            {
                Bug bug = getBug();
                return "You poke at the crevice, and discover a " + bug.name + ". " + bug.Bite();
            }
            else
            {
                return "You poke at the crevice, but it seems to be empty.";
            }
        }

        /// <summary>
        /// Checks if the crevice contains a given bug. If yes, removes the bug.
        /// </summary>
        /// <param name="bug">the bug to remove</param>
        /// <returns>true if successful, false if failed</returns>
        public bool RemoveBug(Bug bug)
        {
            for (int i = 0; i < bugcount; i++)
            {
                if (bug.Equals(bugs[i]))
                {
                    //Remove bug, shift other bugs back in the array
                    bugs[i] = null;
                    for (int j = i + 1; j < bugcount; j++)
                    {
                        bugs[j - 1] = bugs[j];
                    }
                    bugcount--;
                    return true;
                }
            }
            //bug not found
            return false;
        }




        public class OutOfBugsException : Exception
        {
            public OutOfBugsException() { }
            public OutOfBugsException(string message) : base(message) { }
            public OutOfBugsException(string message, Exception inner) : base(message, inner) { }
            protected OutOfBugsException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }


    }
}