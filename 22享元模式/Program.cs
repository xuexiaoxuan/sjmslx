// See https://aka.ms/new-console-template for more information
using _22享元模式;

int extrinsicstate = 22;
FlyweightFactory f=new FlyweightFactory();
Flyweight fx = f.GetFlyweight("X");
fx.Operation(--extrinsicstate);
Flyweight fy = f.GetFlyweight("Y");
fy.Operation(--extrinsicstate);
Flyweight fz = f.GetFlyweight("Z");
fz.Operation(--extrinsicstate);
Flyweight uf =new UnsharedConcreteFlyweight();
uf.Operation(--extrinsicstate);
Console.WriteLine("Hello, World!");
