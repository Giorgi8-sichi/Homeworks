namespace Week9Hm2;

public class Company
{
    private string whereIsCompany { get; set; }
    private int amount { get; }

    public Company(string whereIsCompany, int amount)
    {
        this.whereIsCompany = whereIsCompany;
        this.amount = amount;
    }

    public int CalculateTax()
    {
        var tax = 0;
        if (whereIsCompany.ToLower() == "local")
        {
            tax = (amount * 18) / 100;
        }
        else if (whereIsCompany.ToLower() == "foreign")
        {
            tax = (amount * 5) / 100; 
        }
        else
        {
            Console.WriteLine("Bad request, try again! ");
        }
        return tax;
    }
    



}