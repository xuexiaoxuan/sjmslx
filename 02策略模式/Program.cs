using System;

namespace _02策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Context contexta = new Context(new ConcreteStrategyA());
            contexta.ContextInterface();
            Context contextb = new Context(new ConcreteStrategyB());
            contextb.ContextInterface();
            Context contextc = new Context(new ConcreteStrategyC());
            contextc.ContextInterface();
        }
    }
}
