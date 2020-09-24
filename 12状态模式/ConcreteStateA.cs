using System;
using System.Collections.Generic;
using System.Text;

namespace _12状态模式
{
    class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
