using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClasses
{
    public class Class2
    {
        public int ResultOfPow { get; private set; }
        public Predicate<int> Calc(Func<int, int, int> powHandler, int x, int y)
        {
            ResultOfPow = powHandler(x, y);
            Predicate<int> resultHandler = Result;
            return resultHandler;
        }

        public bool Result(int z)
        {
            return ResultOfPow % z == 0;
        }
    }
}
