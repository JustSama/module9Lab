using System;

public interface IBeverage
{
    double GetCost();
    string GetDescription();
}

public class Coffee : IBeverage
{
    public double GetCost() => 50.0;
    public string GetDescription() => "Coffee";
}

public abstract class BeverageDecorator : IBeverage
{
    protected IBeverage _beverage;
    public BeverageDecorator(IBeverage beverage) => _beverage = beverage;
    public virtual double GetCost() => _beverage.GetCost();
    public virtual string GetDescription() => _beverage.GetDescription();
}

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage beverage) : base(beverage) { }
    public override double GetCost() => base.GetCost() + 10.0;
    public override string GetDescription() => base.GetDescription() + ", Milk";
}

public class SugarDecorator : BeverageDecorator
{
    public SugarDecorator(IBeverage beverage) : base(beverage) { }
    public override double GetCost() => base.GetCost() + 5.0;
    public override string GetDescription() => base.GetDescription() + ", Sugar";
}

public class ChocolateDecorator : BeverageDecorator
{
    public ChocolateDecorator(IBeverage beverage) : base(beverage) { }
    public override double GetCost() => base.GetCost() + 15.0;
    public override string GetDescription() => base.GetDescription() + ", Chocolate";
}

public class VanillaDecorator : BeverageDecorator
{
    public VanillaDecorator(IBeverage beverage) : base(beverage) { }
    public override double GetCost() => base.GetCost() + 12.0;
    public override string GetDescription() => base.GetDescription() + ", Vanilla";
}

public class CinnamonDecorator : BeverageDecorator
{
    public CinnamonDecorator(IBeverage beverage) : base(beverage) { }
    public override double GetCost() => base.GetCost() + 8.0;
    public override string GetDescription() => base.GetDescription() + ", Cinnamon";
}

class Program
{
    static void Main(string[] args)
    {
        IBeverage beverage = new Coffee();
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");

        beverage = new MilkDecorator(beverage);
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");

        beverage = new SugarDecorator(beverage);
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");

        beverage = new ChocolateDecorator(beverage);
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");

        beverage = new VanillaDecorator(beverage);
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");

        beverage = new CinnamonDecorator(beverage);
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");
    }
}
