using System;
using System.Collections.Generic;
using System.Text;

namespace _12状态模式
{
    class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
