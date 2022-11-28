// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Bank;
using ConsoleApp1.Customer;
using ConsoleApp1.Shop;

var legoShop = new LegoShop();

var bank = new PrivatBank(legoShop);

var user = new User() { Name = "Valentin"};

bank.Register(user);

legoShop.Start(user);

Console.ReadKey();
