using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23解释器模式
{
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Content content)
        {
            Console.WriteLine("终端解释器");
        }
    }
}