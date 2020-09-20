using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03装饰模式
{
    class TShirts:Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
}
