using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01简单工厂
{
    public class OpreationFactory
    {
        public static Iopreation CreateOpreation(string Opreation) => Opreation switch
        {
            "+" => new OpreationAdd(),
            "-" => new OpreationSub(),
            _ => throw new NotImplementedException(),
        };
            
    }
}
