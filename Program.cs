using System;

namespace errorFix
{ 
    class Program
    {
 
 public static void main(string[] args) {
        int numStudents;
        int NumberOfTeachersInTheSchool;
        double average_gpa;

        string n;
        string CityInWhichTheSchoolResides;
        bool IS_PUBLIC;

        numStudents = 403;
    var city = "Atlanta, GA";
    var numTeachers = 62;
    var averageGPA = 2.98;
    var name = "Grady High School";
    var isPublic = true;

        Console.WriteLine("School: " + name);
        Console.WriteLine("Teachers: ", numTeachers);

        function(averageGPA, city);

        if (numStudents >= 10) 
        {
            Console.WriteLine("We have at least 10 students");
        }
        if (numTeachers >= 5) 
        {
            Console.WriteLine("We have at least 5 teachers");
        }
    }

public static void Main(double x, string y) {
    Console.WriteLine(x + ", " + y);
    }
    } 
}
