using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03装饰模式
{
    class Finery:Person
    {
        protected Person commpontent;
        public void Decorate(Person component)
        {
            this.commpontent = component;
        }
        public override void Show()
        {
            if (commpontent != null)
            {
                commpontent.Show();
            }
        }
    }
}
