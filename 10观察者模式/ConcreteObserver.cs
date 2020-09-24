using System;
using System.Collections.Generic;
using System.Text;

namespace _10观察者模式
{
    class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;
        public ConcreteObserver(ConcreteSubject subject,string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者{0}新状态是{1}", name, observerState);
        }
        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
