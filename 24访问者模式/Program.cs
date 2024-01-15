// See https://aka.ms/new-console-template for more information
using _24访问者模式;

ObjectStructure o = new ObjectStructure();
o.Attach(new ConcreteElementA());
o.Attach(new ConcreteElementB());
Visitor v1 = new ConcreteVisitor1();
Visitor v2 = new ConcreteVisitor2();
o.Accept(v1);
o.Accept(v2);
Console.WriteLine("Hello, World!");
