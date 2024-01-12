using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20职责链模式
{
    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);
    }
}