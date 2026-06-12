namespace Week9Hm2;

public class Teacher
{
    public string _name { get; set; }
    public bool _status { get; set; }



    public void ReturnKnowledge(string subject)
    {
        if (subject == "Math")
        {
            var random = new Random();
            var number1 = random.Next(1, 100);
            var number2 = random.Next(1, 100);
            var sumOfRandomNumbers = number1 + number2;
            Console.WriteLine($"Sum: {sumOfRandomNumbers}");
        }else if (subject == "Chemistry")
        {
            Console.WriteLine("H2O");
        }else if (subject == "English")
        {
            Console.WriteLine($"Hello I am {_name}");
        }
        else
        {
            Console.WriteLine($"Dont know about anything about {subject}");
        }
    }
    
    
    
}