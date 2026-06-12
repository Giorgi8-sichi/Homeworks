namespace Week9Hm2;

public class ClassRoom
{
        public List<Student1> _listOfStudents = new List<Student1>();


        public ClassRoom(params Student1[] students)
        {
                foreach (var student in students)
                {
                        _listOfStudents.Add(student);
                }
        }

        public void ShowAllStudentsMethods()
        {
                foreach (var student in _listOfStudents)
                {
                        Console.WriteLine($"{student._name}");
                        student.Read();
                        student.Relax();
                        student.Study();
                        student.Write();
                }
        }
}


