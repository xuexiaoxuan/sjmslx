using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    class AccessFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }

        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}
