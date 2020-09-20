using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01简单工厂
{
    public class OpreationSub : Iopreation
    {
        public int GetResult(int a, int b)
        {
            return a - b;
        }
    }
}
