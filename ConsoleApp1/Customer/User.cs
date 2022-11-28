using ConsoleApp1.Goods;

namespace ConsoleApp1.Customer;

public class User
{
    public string Name { get; set; }
    public int bankAccount { get; set; }
    private List<VegetableGood> _legoGoods;

    public User()
    {
        _legoGoods = new List<VegetableGood>();
    }
    internal void AddGood(VegetableGood nameOfGood)
    {
        _legoGoods.Add(nameOfGood);
    }
}
