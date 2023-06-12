namespace C__gr3_part1_HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("V");
            Course course = new Course() { TeacherName = "Kris"};

            student.Print();
            Console.WriteLine();
            course.Print();

            course.NumberOfStudents++;

            Console.WriteLine();
            course.Print();
        }
    }
}