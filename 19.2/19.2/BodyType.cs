using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._2
{
    public class Asthenic : IBodyType
    {
        public double GetMultiplier() => 1.05;
    }

    public class Normosthenic : IBodyType
    {
        public double GetMultiplier() => 1.00;
    }

    public class Hypersthenic : IBodyType
    {
        public double GetMultiplier() => 0.95;
    }
}
