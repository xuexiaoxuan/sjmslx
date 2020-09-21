﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05工厂方法
{
    class AddFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new AddOperation();
        }
    }
}
