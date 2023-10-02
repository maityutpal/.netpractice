// See https://aka.ms/new-console-template for more information
using MembershipManagement;
using MembershipManagement.Views;

Console.WriteLine("Hello, World!");

IView mainview=Factory.GetMainViewObject();
mainview.RunView();
Console.ReadKey();
