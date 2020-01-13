using System;
using System.Data;

namespace Puzzles.Day_One
{
    public class Module
    {
        private const double DIVISOR = 3;
        private const double SUBTRAHEND = 2;
        private const int MINIMUM_FUEL = 0;

        public int Mass { get; }

        public Module(int mass)
        {
            if (mass < 0)
            {
                throw new ConstraintException("The mass of a module can't be negative.");
            }

            this.Mass = mass;
        }

        public int CalculateFuel()
        {
            int fuel = (int)(Math.Floor(this.Mass / DIVISOR) - SUBTRAHEND);
            return fuel >= MINIMUM_FUEL ? fuel : MINIMUM_FUEL;
        }
    }
}
