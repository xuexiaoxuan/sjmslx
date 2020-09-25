using System;
using System.Collections.Generic;
using System.Text;

namespace _14备忘录模式
{
    class Memento
    {
        private string state;
        public Memento(string state)
        {
            this.state = state;
        }
        public string State
        {
            get { return state; }
        }
    }
}
