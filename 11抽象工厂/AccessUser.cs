using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    class AccessUser: IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在Access 中获取一条User数据");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在Access 中插入一条User数据");
        }
    }
}
