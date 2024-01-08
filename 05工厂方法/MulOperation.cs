using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05工厂方法
{
    class MulOperation : Operation
    {
        public override int GetResult(int a, int b)
        {
            return a * b;
        }
    }
}
