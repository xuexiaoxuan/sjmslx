using System;

namespace _03装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person { Name= "小菜" };
            BigTrouser kk = new BigTrouser();
            TShirts dtx = new TShirts();
            kk.Decorate(xc);
            dtx.Decorate(kk);
            dtx.Show();
        }
    }
}
