using ConsoleApp1.Customer;
using ConsoleApp1.Goods;
using ConsoleApp1.Shop;

namespace ConsoleApp1.Bank;

public class PrivatBank
{
    private Dictionary<int, int> _bankAccount;

	public PrivatBank(LegoShop legoShop1)
	{
        _bankAccount = new Dictionary<int, int>();

        legoShop1.UserBoughtGood += LegoShop1_UserBoughtGood;
    }
    private void LegoShop1_UserBoughtGood(User user, VegetableGood good)
    {
        _bankAccount.TryGetValue(user.bankAccount, out var money);

        if(money >= good.Price)
        {
            _bankAccount[user.bankAccount] = money - good.Price;
            user.AddGood(good);
            Console.WriteLine($"{good.Name} was added, remainder is {_bankAccount[user.bankAccount]}");
            return;
        }

        Console.WriteLine($"{good.Name} wasn't added, because remainder is {_bankAccount[user.bankAccount]}");
    }

    public bool Register(User user)
    {
        var usersMoney = 2000;
        var isAdded = _bankAccount.TryAdd(user.bankAccount, usersMoney);

        return isAdded;
    }
}
