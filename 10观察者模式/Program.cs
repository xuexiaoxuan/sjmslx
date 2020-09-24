using System;

namespace _10观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            s.SubjectState = "ABC";
            s.Notify();


        }
    }
}
