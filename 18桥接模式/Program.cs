// See https://aka.ms/new-console-template for more information
using _18桥接模式;

HandsetBrand ab;
ab = new HandsetBrandN();
ab.SetHandsetSoft(new HandsetGame());
ab.Run();
ab.SetHandsetSoft(new HandsetAddressList());
ab.Run();
ab = new HandsetBrandM();
ab.SetHandsetSoft(new HandsetGame());
ab.Run();
ab.SetHandsetSoft(new HandsetAddressList());
ab.Run();
Console.WriteLine("Hello, World!");
