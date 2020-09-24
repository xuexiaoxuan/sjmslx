using System;

namespace _12状态模式
{
    public class Context
    {
        private State state;
        public Context(State state)
        {
            this.state = state;
        }
        public State State
        {
            get => state;
            set
            {
                state = value;
                Console.WriteLine("当前状态：" + state.GetType().Name);
            }
        }
        public void Request()
        {
            state.Handle(this);
        }
    }
}