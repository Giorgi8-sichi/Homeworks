namespace Week10Hm1;

public interface FinanceOperations
{
    public decimal CalculateLoanPercent(int month, decimal amountPerMonth);
    public void CheckUserHistory(int month , decimal amountPerMonth);
}