using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._2
{
    public class CalorieFacade
    {
        private BmrCalculator _bmrCalc;
        private ActivityCalculator _activityCalc;

        public CalorieFacade()
        {
            _bmrCalc = new BmrCalculator();
            _activityCalc = new ActivityCalculator();
        }

        public double CalculateDailyCalories(double weight, double height, int age, string gender, string activity, IBodyType bodyType)
        {
            double bmr = _bmrCalc.CalculateBase(weight, height, age, gender);

            double activityMult = _activityCalc.GetActivityMultiplier(activity);

            double bodyMult = bodyType.GetMultiplier();

            return bmr * activityMult * bodyMult;
        }
    }
}
