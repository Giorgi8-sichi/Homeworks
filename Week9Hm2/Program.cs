namespace Week9Hm2;

class Program
{
    static void Main(string[] args)
    {
        /*
        #region EmployeeCompany
        var empoyee = new Employee("Giorgi", "Sichinava", 18, "Manager", [8, 8, 8, 8, 8, 2, 3]);
        var amount = empoyee.GetSalary();
        Console.WriteLine($"Employee total selary: {amount}");
        var company = new Company("LoCal", amount);
        var tax = company.CalculateTax();
        Console.WriteLine($"This is tax: {tax}");
        #endregion
        */

        /*
        #region StudentTeacher
        var student = new Student("Giorgi", 18, 2025);
        var randomSubject = student.GetRandomSubject();
        student.HowManyYearsLeft();
        var teacher = new Teacher
        {
            _name = "Aleko",
            _status = true,
        };
        teacher.ReturnKnowledge(randomSubject);
        #endregion
        */

        #region ClassRooom

        var student1 = new Student1
        {
            _name = "Giorgi"
        };
        var student2 = new GoodStudent()
        {
            _name = "Shotiko"
        };
        var student3 = new LazyStudent()
        {
            _name = "Aleko"
        };
        
        var classRoom = new ClassRoom(student1, student2,student3);
        classRoom.ShowAllStudentsMethods();
        #endregion
    }
}