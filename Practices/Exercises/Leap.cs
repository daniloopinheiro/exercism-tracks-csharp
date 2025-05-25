using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practices.Exercises
{
    public class Leap
    {
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));
            
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}