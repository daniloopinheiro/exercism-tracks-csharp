using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practices.Exercises
{
    public class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            
            if (speed == 0) return 0.0;
            if (speed >= 1 && speed <= 4) return 1.0;
            if (speed >= 5 && speed <= 8) return 0.9;
            if (speed == 9) return 0.8;
            if (speed == 10) return 0.77;
            return 0.0;
            throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
        }

        public static double ProductionRatePerHour(int speed)
        {
            // Implement the (static) AssemblyLine.ProductionRatePerHour() method to calculate the assembly line's production rate per hour, taking into account its success rate: AssemblyLine.ProductionRatePerHour(6) // => 1193.4
            return speed * 221 * SuccessRate(speed);

            throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
        }

        public static int WorkingItemsPerMinute(int speed)
        {
            // Implement the (static) AssemblyLine.WorkingItemsPerMinute() method to calculate how many working cars are produced per minute: AssemblyLine.WorkingItemsPerMinute(6) // => 19
            double productionRatePerHour = ProductionRatePerHour(speed);
            int workingItemsPerMinute = (int)(productionRatePerHour / 60); // Convert hourly rate to per minute
            return workingItemsPerMinute;

            throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
        }
    }
}