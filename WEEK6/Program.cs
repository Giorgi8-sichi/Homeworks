namespace WEEK6;

class Program
{
    #region Ex3

    enum Contacts
    {
        Delete,
        Add,
        Update,
    }
    
    #endregion
    static void Main(string[] args)
    {
        /*
        #region Ex1
        Console.WriteLine("Enter your word: ");
        var input = Console.ReadLine();
        var letterCount = input.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        foreach (var letter in letterCount)
        {
            Console.WriteLine($"{letter.Key} - {letter.Value}");
        }
        #endregion
        */

        /*
        #region Ex2
        string[] cities =
        {
            "Tbilisi",
            "Telavi",
            "Batumi",
            "Borjomi",
            "Kutaisi",
            "Khashuri"
        };
        string[] citiesLower = cities.Select(x => x.ToLower()).ToArray();
        Console.WriteLine("Enter 2 char: ");
        var input = Console.ReadLine().ToLower();
        var splitted = input.Split();
        var city = citiesLower.Where(x => x.StartsWith(splitted[0]) && x.EndsWith(splitted[1])).ToArray();
        foreach (var c in city)
        {
            Console.WriteLine(c);
        }
        #endregion
        */

        /*
        #region Ex3
        Console.WriteLine("Enter n: ");
        var n = int.Parse(Console.ReadLine());
        var numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter number {i + 1}: ");
            var x = int.Parse(Console.ReadLine());
            numbers[i] = x;
        }
        var evens = numbers.Where(x => x % 2 == 0).ToArray();
        var odds = numbers.Where(x => x % 2 != 0).ToArray();
        Console.Write("Evens: ");
        Console.WriteLine(string.Join(" ", evens));
        Console.Write("Ods: ");
        Console.WriteLine(string.Join(" ", odds));
        // foreach (var even in evens)
        // {
        //     Console.WriteLine($"Evens: {even}");
        // }
        //
        // foreach (var odd in odds)
        // {
        //     Console.WriteLine($"Odds: {odd}");
        // }
        #endregion
        */

        /*
        #region Ex4

        var contacts = new Dictionary<string, int>()
        {
            { "Giorgi", 599112233 },
            { "Shota",   555445566 },
            { "Lekso",   577889900 },
            { "Elene", 591223344 },
            { "Maro",    593556677 }
        };

        #region Ex4.1
        Console.WriteLine("Enter your operation(Delete/Add/Update)---> ");
        var operation = Console.ReadLine();
        Console.WriteLine("Enter person name: ");
        var per = Console.ReadLine();
        var inContact = contacts.Any(x => x.Key == per);
        
        
        Contacts person;
        if (inContact)
        {
            switch (operation)
            {
                case "Delete" :
                    contacts.Remove(per);
                    break;
                case "Add":
                    Console.WriteLine("Enter person name: ");
                    var personName = Console.ReadLine();
                    Console.WriteLine("Enter Phone: ");
                    var phone = int.Parse(Console.ReadLine());
                    contacts.Add(personName,phone);
                    break;
                case "Update":
                    Console.WriteLine("Enter updated info: ");
                    var updatedInfo = int.Parse(Console.ReadLine());
                    contacts[per] = updatedInfo;
                    break;
            }
            
        }
        #endregion
        
        
        Console.WriteLine("Enter your operation(Delete/Add/Update)---> ");
        var operation = Console.ReadLine();

        if (operation == "Delete")
        {
            Console.WriteLine("Enter person name: ");
            var per = Console.ReadLine();
            contacts.Remove(per);
        }else if (operation == "Add")
        {
            Console.WriteLine("Enter person name: ");
            var personName = Console.ReadLine();
            Console.WriteLine("Enter Person number: ");
            var personNumber = int.Parse(Console.ReadLine());
            contacts.Add(personName, personNumber);
            
        }else if (operation == "Update")
        {
            
            Console.WriteLine("Enter person name: ");
            var personName = Console.ReadLine();
            if (contacts.ContainsKey(personName))
            {
                Console.WriteLine("Enter number: ");
                var number = int.Parse(Console.ReadLine());
                contacts[personName] = number;
            }
            else
            {
                Console.WriteLine("This person doesn't exsist :(");
            }
        }
        foreach (var pers in contacts)
        {
            Console.WriteLine($"{pers.Key}--{pers.Value}");
        }
        
        #endregion
        */

        /*
        #region Ex5
        Console.WriteLine("Enter n: ");
        var n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter number {i + 1}");
            var number = int.Parse(Console.ReadLine());
            numbers[i] = number;
        }
        var sameNumbs = numbers.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        int sum = 0;
        foreach (var i in sameNumbs)
        {
            sum = i.Key * i.Value;
            Console.WriteLine($"{i.Key} appears {i.Value} times sum {sum}");
        }
        #endregion
        */

        /*
        #region Ex6
        Console.WriteLine("Enter top n: ");
        var n = int.Parse(Console.ReadLine());
        var scores = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };
        var topn = scores.OrderByDescending(x => x).Take(n).ToList();
        foreach (var i in topn)
        {
            Console.WriteLine(i);
        }
        #endregion
        */
        
    }
}