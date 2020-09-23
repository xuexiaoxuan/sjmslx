using System;
using System.Drawing;

namespace _09建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen p = new Pen(Color.Yellow);
            PersonThinBuilder personThinBuilder = new PersonThinBuilder(new Graphics(), p);
            PersonDirector pd = new PersonDirector(personThinBuilder);
            pd.CreatePerson();
        }
    }
}
