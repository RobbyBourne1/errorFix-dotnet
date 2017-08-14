using System;

namespace errorFix
{
    class Program
    {

        public static void Main(string[] args)
        {
            int numStudents;

            numStudents = 403;
            var numTeachers = 62;
            var averageGPA = 2.98;
            var name = "Grady High School";
            Console.WriteLine("School: " + name);
            Console.WriteLine("Teachers: ", numTeachers);

            if (numStudents >= 10)
            {
                Console.WriteLine("We have at least 10 students");
            }
            if (numTeachers >= 5)
            {
                Console.WriteLine("We have at least 5 teachers");
            }
            function(averageGPA, name);
            function(numStudents, averageGPA);
        }
        public static double function(double x, double y)
        {
            return x + y;
        }

        public static void function(double averageGPA, string name) => Console.WriteLine($"The average GPA of students at {name} was {averageGPA}.");
    }
}