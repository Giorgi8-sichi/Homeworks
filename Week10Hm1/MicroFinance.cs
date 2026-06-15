namespace Week10Hm1;

public class MicroFinance: FinanceOperations
{
    public decimal CalculateLoanPercent(int month, decimal amountPerMonth)
    {
        var tranFee = month * 4;
        var totalAmountWithoutPercent = month * amountPerMonth;
        var amountPercent = totalAmountWithoutPercent * 0.1m;
        var totalAmount = totalAmountWithoutPercent + amountPercent + tranFee;
        
        
        return totalAmount;
    }

    public void CheckUserHistory(int month, decimal amountPerMonth)
    {
        var totalAmount = CalculateLoanPercent(month, amountPerMonth);
        Console.WriteLine($"Micro Finance----This is your total amount: {totalAmount}");
    }
}