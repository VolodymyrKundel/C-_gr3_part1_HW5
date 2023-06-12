namespace C__gr3_part1_HW5
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string City;

        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public Student (string firstName, string lastName, int age) : this(firstName, lastName, age, "NoCity") { }

        public Student (string firstName, string lastName) : this(firstName, lastName, -1) { }

        public Student (string firstName) : this(firstName, "NoLastName") { }

        public Student () : this("NoFirstName") { }

        public void Print ()
        {
            Console.WriteLine("First Name is: " + FirstName);
            Console.WriteLine("Last Name is: " + LastName);
            Console.WriteLine("Age is: " + Age);
            Console.WriteLine("City is: " + City);
        }
    }
}
