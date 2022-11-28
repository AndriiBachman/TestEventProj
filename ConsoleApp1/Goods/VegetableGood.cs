namespace ConsoleApp1.Goods;

public class VegetableGood
{
    public VegetableGood(int price, string name)
    {
        Price = price;
        Name = name;
    }

    public int Price { get; set; }
    public string Name { get; set; }
}
