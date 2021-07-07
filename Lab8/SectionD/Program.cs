namespace SectionD
{
    using CommonData;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ashraf", "Abouelnaga", new DateTime(1977, 8, 1), "3001 Carling Str.", "Ottawa", "Canada");
            Student student = new Student("Youssef", "Ashraf", new DateTime(2000, 8, 1), "3002 Carling Str.",
                "Toronto", "Canada", 1001, new int[] { 15,14,13,10});
            Employee employee = new Employee("Sara", "John", new DateTime(1999, 8, 1), "3003 Carling Str.",
                "Toronto", "Canada", 3001, "Programmer", 5000.00);

            Console.WriteLine("Person Info");
            person.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Student Info");
            student.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Employee Info");
            employee.DisplayInfo();
            Console.WriteLine();

            person = student;

            Console.WriteLine("Person Info after assigning Student Object");
            person.DisplayInfo();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
