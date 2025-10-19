using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string StudentId { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public Student(string name,string lastName, string studentId, int age, string major)
        {
            Name = name;
            LastName = lastName;
            StudentId = studentId;
            Age = age;
            Major = major;
        }

        public void AddCourse(string lessonanme,float grade)
        {
            Courses.Add(new Course(lessonanme,grade));
        }
        public float CalculateGPA()
        {
            if (Courses.Count == 0) return 0f;
                float total = 0;
                foreach (var c in Courses)
                    total += c.Grade;
                return total / Courses.Count;
        }
    }
}
