using ConsoleApp1.Customer;
using ConsoleApp1.Goods;
using System.Reflection.Metadata;

namespace ConsoleApp1.Shop;

public class LegoShop
{
    public event Action<User, VegetableGood> UserBoughtGood = delegate { };

    private List<VegetableGood> _goods;

    public LegoShop()
    {
        _goods= new List<VegetableGood>() {new VegetableGood(100,"Orange") ,
        new VegetableGood(50,"Tomato"),
        new VegetableGood(500,"Peach")};
    }

    public void Start(User user)
    {
        for (int i = 0; i < _goods.Count; i++)
        {
            Console.WriteLine($"{i + 1}) {_goods[i].Name}");
        }

        Console.WriteLine();
        Console.WriteLine("What do you prefer?");

        var isCanParse = int.TryParse(Console.ReadLine(), out var userChoise);

        UserBoughtGood(user, _goods[userChoise - 1]); // Кидаем ивент с пользователеи и его выбором

    }
}
