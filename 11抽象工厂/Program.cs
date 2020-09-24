using System;

namespace _11抽象工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory afactory = new AccessFactory();
            IUser auser = afactory.CreateUser();
            auser.Insert(new User {  Id=1, Name="dd"});
            auser.GetUser(1);
            IDepartment adepartment = afactory.CreateDepartment();
            adepartment.Insert(new Department());
            adepartment.GetDepartment(1);
            IFactory sfactory = new SqlServerFactory();
            IUser suser = sfactory.CreateUser();
            suser.Insert(new User { Id = 1, Name = "dd" });
            suser.GetUser(1);
            IDepartment sdepartment = afactory.CreateDepartment();
            sdepartment.Insert(new Department());
            sdepartment.GetDepartment(1);
        }
    }
}
