namespace Week9Hm2;

public class Student
{
    private string _name { get; }
    private int _age { get; }
    private int _yearOfAdmission { get; }

    internal Student(string name, int age , int yearOfAdmission)
    {
        _name = name;
        _age = age;
        _yearOfAdmission = yearOfAdmission;
    }

    public string GetRandomSubject()
    {
        var subjects = new string[]
        {
            "Math",
            "Chemistry",
            "English",
            "Biology",
            "Sport",
        };
        var random = new Random();
        var randomIndex = random.Next(subjects.Length);
        var randomSubject = subjects[randomIndex];
        return randomSubject;
    }

    public void HowManyYearsLeft()
    {
        var currentYear = DateTime.Now.Year;
        var totalYear = 4;
        var calculateLeftYears = totalYear - (currentYear - _yearOfAdmission);
        
        Console.WriteLine($"You left {calculateLeftYears} year");
    }
    
    
    
}