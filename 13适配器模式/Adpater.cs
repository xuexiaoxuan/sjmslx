using System;
using System.Collections.Generic;
using System.Text;

namespace _13适配器模式
{
    class Adpater: Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            adaptee.SpecifcRequest();
        }
    }
}
