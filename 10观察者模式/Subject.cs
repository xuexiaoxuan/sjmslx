using System;
using System.Collections.Generic;
using System.Text;

namespace _10观察者模式
{
    abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach(var obj in observers)
            {
                obj.Update();
            }
        }
    }
}
