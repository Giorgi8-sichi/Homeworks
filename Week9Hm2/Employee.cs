namespace Week9Hm2;

public class Employee
{
    
    public string FName { get; set; }
    public string LName { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public int[] WorkedHours { get; set; }

    public Employee(string fName, string lName, int age, string position, int[] workedHours)
    {
        FName = fName;
        LName = lName;
        Age = age;
        Position = position;
        WorkedHours = workedHours;
    }

    public int GetSalary()
    {
        int totalSalary = 0;
        int hourlyRate = 0;

        
        switch (Position.ToLower())
        {
            case "manager":
                hourlyRate = 40;
                break;
            case "developer":
                hourlyRate = 30;
                break;
            case "tester":
                hourlyRate = 20;
                break;
            default:
                hourlyRate = 10;
                break;
        }

        
        for (int i = 0; i < WorkedHours.Length; i++)
        {
            var hours = WorkedHours[i];
            var dailySalary = 0;

            if (hours <= 8)
            {
                dailySalary = hours * hourlyRate;
            }
            else
            {
                
                var regularPay = 8 * hourlyRate;
                var extraHours = hours - 8;
                var overtimePay = extraHours * (hourlyRate + 5); 
                
                dailySalary = regularPay + overtimePay;
            }

            
            if (i == 5 || i == 6)
            {
                dailySalary = dailySalary * 2;
            }
            
            totalSalary += dailySalary;
        }
        
        
        if (WorkedHours.Sum() > 50)
        {
            var bonus = (totalSalary * 20) / 100;
            totalSalary += bonus;
        }
        return totalSalary;
    }
}