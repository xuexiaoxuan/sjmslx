using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    class SqlServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在sqlserver 中获取一条User数据");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在sqlserver 中插入一条User数据");
        }
    }
}
