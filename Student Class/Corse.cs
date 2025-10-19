using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class
{
    public class Course
    {
        public string LessonName { get; set; }
        public float Grade { get; set; }
        public Course(string lessonname,float grade)
        {
            LessonName = lessonname;
            Grade = grade;
        }

    }
}
