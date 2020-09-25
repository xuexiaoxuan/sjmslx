using System;
using System.Collections.Generic;
using System.Text;

namespace _13适配器模式
{
    class Adaptee
    {
        public void SpecifcRequest()
        {
            Console.WriteLine("特殊请求");
        }
    }
}
