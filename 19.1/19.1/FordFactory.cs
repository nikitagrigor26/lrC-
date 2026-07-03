using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1
{
    public class FordFactory : ICarFactory
    {
        public ISedan CreateSedan() => new FordSedan();
        public ISUV CreateSUV() => new FordSUV();
    }
}
