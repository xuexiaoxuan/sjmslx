using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _09建造者模式
{
    abstract class PersonBuilder
    {
        protected Graphics g;
        protected Pen p;
        public PersonBuilder(Graphics g, Pen p)
        {
            this.g = g;
            this.p = p;
        }
        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void ArmLeft();
        public abstract void ArmRight();
        public abstract void LegLeft();
        public abstract void LegRight();

    }
}
