using System;

namespace Challenges.Source
{
    public class FuelCalculator
    {
        private const double DIVISOR = 3;
        private const double SUBTRAHEND = 2;
        private const int MINIMUM_FUEL = 0;

        public long CalculateForMass(Module moduleToCarry)
        {
            if (moduleToCarry != null)
            {
                int resultFuel = (int)(Math.Floor(moduleToCarry.Mass / DIVISOR) - SUBTRAHEND);
                return resultFuel >= MINIMUM_FUEL ? resultFuel : MINIMUM_FUEL;
            }

            return MINIMUM_FUEL;
        }

        public long CalculateForFuel(long fuelToCarry)
        {
            long resultFuel = MINIMUM_FUEL;
            while (fuelToCarry > MINIMUM_FUEL)
            {
                int extraFuel = (int)(Math.Floor(fuelToCarry / DIVISOR) - SUBTRAHEND);
                resultFuel += extraFuel < MINIMUM_FUEL ? MINIMUM_FUEL : extraFuel;
                fuelToCarry = extraFuel;
            }

            return resultFuel;
        }
    }
}
