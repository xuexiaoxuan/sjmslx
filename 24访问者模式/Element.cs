﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24访问者模式
{
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}