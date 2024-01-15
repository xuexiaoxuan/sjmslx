using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24访问者模式
{
    public class ObjectStructure
    {
        private IList<Element> elements=new List<Element>();

        public void Attach(Element element)
        {
            elements.Add(element);
        }

        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (var item in elements)
            {
                item.Accept(visitor);
            }
        }
    }
}