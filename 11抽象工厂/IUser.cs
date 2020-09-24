using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }
}
