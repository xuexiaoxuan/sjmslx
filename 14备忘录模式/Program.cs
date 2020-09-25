using System;

namespace _14备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "On";
            Caretaker caretaker = new Caretaker();
            caretaker.memento = originator.CreateMemento();
            originator.State = "Off";
            originator.Show();
            originator.SetMemento(caretaker.memento);
            originator.Show();
            Console.Read();
        }
    }
}
