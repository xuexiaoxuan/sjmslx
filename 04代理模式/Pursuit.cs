using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04代理模式
{
    class Pursuit : IGiveGift
    {
        SchooGirl mm;
        public Pursuit(SchooGirl mm)
        {
            this.mm = mm;
        }
        public void GiveChocolate()
        {
            Console.WriteLine("{0}送你洋娃娃", mm.Name);
        }

        public void GiveDolls()
        {
            Console.WriteLine("{0}送你巧克力", mm.Name);
        }

        public void GiveFlowers()
        {
            Console.WriteLine("{0}送你鲜花", mm.Name);

        }
    }
}
