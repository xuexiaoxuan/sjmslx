using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21中介者模式
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public abstract void Send(string message);
        public abstract void Notify(string message);
    }
}