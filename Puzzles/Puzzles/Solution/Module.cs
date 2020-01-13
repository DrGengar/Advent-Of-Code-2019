using System;
using System.Data;

namespace Puzzles.Solution
{
    public class Module
    {
        public int Mass { get; }

        public Module(int mass)
        {
            if (mass < 0)
            {
                throw new ConstraintException("The mass of a module can't be negative.");
            }

            this.Mass = mass;
        }
    }
}
