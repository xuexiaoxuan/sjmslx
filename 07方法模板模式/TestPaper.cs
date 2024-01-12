using System;
using System.Collections.Generic;
using System.Text;

namespace _07方法模板模式
{
    class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("TestQuestion1");
            Console.WriteLine(Answer1());
        }
        public void TestQuestion2()
        {
            Console.WriteLine("TestQuestion2");
            Console.WriteLine(Answer1());
        }
        public void TestQuestion3()
        {
            Console.WriteLine("TestQuestion3");
            Console.WriteLine(Answer1());
        }
        protected virtual string Answer1()
        {
            return "";
        }
    }
}
