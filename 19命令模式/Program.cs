// See https://aka.ms/new-console-template for more information
using _19命令模式;

Receiver r=new Receiver();
Command c = new ConncreteCommand(r);
Invoker i = new Invoker();
i.SetCommand(c);
i.ExecuteCommand();
Console.WriteLine("Hello, World!");
