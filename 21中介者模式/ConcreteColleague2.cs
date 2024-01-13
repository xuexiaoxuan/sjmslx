using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21中介者模式
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("2得到消息" + message);
        }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
}