using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21中介者模式
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}