using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18桥接模式
{
    abstract class HandsetBrand
    {
        protected HandsetSoft soft;
        public void SetHandsetSoft(HandsetSoft soft)
        {
            this.soft= soft;
        }
        public abstract void Run();
    }
}
