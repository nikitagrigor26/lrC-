using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._2
{
    class BmrCalculator
    {
        public double CalculateBase(double weight, double height, int age, string gender)
        {
            double baseBmr = (10 * weight) + (6.25 * height) - (5 * age);

            if (gender.ToLower() == "м")
                return baseBmr + 5;
            else
                return baseBmr - 161;
        }
    }

    class ActivityCalculator
    {
        public double GetActivityMultiplier(string activityLevel)
        {
            switch (activityLevel.ToLower())
            {
                case "низкая": return 1.2;
                case "средняя": return 1.55;
                case "высокая": return 1.9;
                default: return 1.2;
            }
        }
    }
}
