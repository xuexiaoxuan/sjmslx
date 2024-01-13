// See https://aka.ms/new-console-template for more information

using _21中介者模式;

var mediator = new ConcreteMediator();
var c1 = new ConcreteColleague1(mediator);
var c2 = new ConcreteColleague2(mediator);
mediator.Colleague1 = c1;
mediator.Colleague2 = c2;
c1.Send("你好");
c2.Send("你好");
Console.WriteLine("Hello, World!");
