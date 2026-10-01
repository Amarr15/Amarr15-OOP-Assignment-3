namespace RefactoringLab;

public class ShippingCostCalculator
{
    public decimal Calculate(IShippingCarrier carrier, decimal weightKg)
    {
        return carrier.CalculateCost(weightKg);
    }
}

public interface IShippingCarrier
{
    decimal CalculateCost(decimal weightKg);
}

public class AramexShipping : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 12m;
    }
}

public class FedExShipping : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 15m;
    }
}

public class DHLShipping : IShippingCarrier
{
    public decimal CalculateCost(decimal weightKg)
    {
        return weightKg * 18m;
    }
}