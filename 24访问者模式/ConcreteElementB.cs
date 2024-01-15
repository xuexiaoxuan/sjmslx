using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24访问者模式
{
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
    }
}