using System;
using System.Collections.Generic;
using System.Text;

namespace _09建造者模式
{
    class PersonDirector
    {
        private PersonBuilder pd;
        public PersonDirector(PersonBuilder pd)
        {
            this.pd = pd;
        }
        public void CreatePerson()
        {
            pd.BuildHead();
            pd.BuildBody();
            pd.ArmLeft();
            pd.ArmRight();
            pd.LegLeft();
            pd.LegRight();
        }
    }
}
