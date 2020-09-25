using System;
using System.Collections.Generic;
using System.Text;

namespace _13适配器模式
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求");
        } 
    }
}
