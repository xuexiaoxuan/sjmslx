using System;

namespace _06原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "XX公司");
            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006","YY企业");
            Resume c = (Resume)a.Clone();
            c.SetWorkExperience("1998-2003", "ZZ企业");
            a.Display();
            b.Display();
            c.Display();
            Console.Read();
        }
    }
}
