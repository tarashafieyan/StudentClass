using Student_Class;
using System;
using System.Collections.Generic;
public class main()
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        Console.WriteLine("enter the count of student");
        int StudentCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < StudentCount; i++)
        {
            //we are get the information from user:

            Console.WriteLine($"student {i + 1}");
            Console.WriteLine("name : ");
            string name = Console.ReadLine();
            Console.WriteLine("family : ");
            string family = Console.ReadLine();
            Console.WriteLine("id : ");
            string id = Console.ReadLine();
            Console.WriteLine("age : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("major : ");
            string major = Console.ReadLine();

            //now we want to ask about lessons:
            Student s = new Student(name, family, id, age, major);
            Console.WriteLine("how mush lesson we have to had for this student");
            int CourseCount = int.Parse(Console.ReadLine());
            for(int j = 0;j< CourseCount;j++)
            {
                Console.WriteLine($"name of lesson {j+1} : ");
                string CourseName = Console.ReadLine();
                Console.WriteLine($"grade {j+1} : ");
                float grade = float.Parse(Console.ReadLine());
                s.AddCourse(CourseName, grade);

            }
            students.Add(s);

            //we will show the information of student now 

            Console.WriteLine("\n student information : ");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} {student.LastName} - Major: {student.Major}");
                foreach (var c in student.Courses)
                {
                    Console.WriteLine($"  {c.LessonName}: {c.Grade}");
                }
                Console.WriteLine($"  GPA: {student.CalculateGPA()}\n");
            }
        }
    }
}
