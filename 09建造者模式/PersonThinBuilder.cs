using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _09建造者模式
{
    class PersonThinBuilder : PersonBuilder
    {
        public PersonThinBuilder(Graphics g,Pen p):base(g,p)
        {

        }
        public override void ArmLeft()
        {
            g.DrawEllipse(p, 60, 100, 45, 150);
        }

        public override void ArmRight()
        {
            g.DrawEllipse(p, 70, 50, 90, 100);
        }

        public override void BuildBody()
        {
            g.DrawEllipse(p, 60, 50, 10, 50);
        }

        public override void BuildHead()
        {
            g.DrawEllipse(p, 50, 20, 30, 30);
        }

        public override void LegLeft()
        {
            g.DrawEllipse(p, 60, 50, 40, 100);
        }

        public override void LegRight()
        {
            g.DrawEllipse(p, 70, 100, 85, 150);
        }
    }
}
