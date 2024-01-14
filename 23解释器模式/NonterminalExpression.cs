using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23解释器模式
{
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Content content)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}