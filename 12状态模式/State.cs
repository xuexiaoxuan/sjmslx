using System;
using System.Collections.Generic;
using System.Text;

namespace _12状态模式
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
