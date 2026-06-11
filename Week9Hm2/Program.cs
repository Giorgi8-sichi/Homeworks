namespace Week9Hm2;

class Program
{
    static void Main(string[] args)
    {
        var empoyee = new Employee("Giorgi", "Sichinava", 18, "Manager", [8, 8, 8, 8, 8, 2, 3]);
        var amount = empoyee.GetSalary();
        Console.WriteLine($"Employee total selary: {amount}");
        var company = new Company("LoCal", amount);
        var tax = company.CalculateTax();
        Console.WriteLine($"This is tax: {tax}");
        
        
    }
}