using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1
{
    public class ToyotaFactory : ICarFactory
    {
        public ISedan CreateSedan() => new ToyotaSedan();
        public ISUV CreateSUV() => new ToyotaSUV();
    }
}
