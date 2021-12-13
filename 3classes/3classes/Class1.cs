using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClasses
{
    public class Class1
    {
        public delegate void ShowHandler(bool x);

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
