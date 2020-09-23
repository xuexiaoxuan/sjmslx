using System;
using System.Collections.Generic;
using System.Text;

namespace _08外观模式
{
    class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
        }
        public void MothodA()
        {
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
