using System;
using System.Collections.Generic;
using System.Text;

namespace _11抽象工厂
{
    class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access 中获取一条Department数据");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在Access 中插入一条Department数据");
        }
    }
}
