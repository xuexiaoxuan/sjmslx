using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlServerUser();
        }
    }
}
