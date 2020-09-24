using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    class SqlServerDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在sqlserver 中获取一条Department数据");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在sqlserver 中插入一条Department数据");
        }
    }
}
