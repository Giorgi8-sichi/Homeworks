namespace Week10Hm1;

public class Bank: FinanceOperations
{
    
    public decimal CalculateLoanPercent(int month, decimal amountPerMonth)
    {
        var totalAmount = month * amountPerMonth;
        var percentAmount =  totalAmount * 0.05m;
        return percentAmount;
    }
    
    public void CheckUserHistory(int month , decimal amountPerMonth)
    {
        var random = new Random();
        var isTrue = random.Next(0, 2);

        if (isTrue == 1)
        {
            Console.WriteLine("Bank---You passed! ");
            var maxPercent = CalculateLoanPercent(month, amountPerMonth);
            Console.WriteLine($"Bank---Your monthly fee if : {maxPercent}");
            
        }
        else
        {
            Console.WriteLine("Bank---Sorry, we can not give you loan!");
        }
    }

    
    
}