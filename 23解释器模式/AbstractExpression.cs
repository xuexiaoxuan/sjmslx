using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23解释器模式
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Content content);
    }
}