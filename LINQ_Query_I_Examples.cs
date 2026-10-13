using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data Source
            List<Student> studentList = new List<Student>
            {
                new Student(){Name = "Stella", Course = "Information Technology", YearLevel = 1, Grade = 85},
                new Student(){Name = "Kurt", Course = "Civil Engineering", YearLevel = 2,  Grade = 84},
                new Student(){Name = "James", Course = "Nursing", YearLevel = 4, Grade = 75},
                new Student(){Name = "Lance", Course = "Accounting", YearLevel = 5, Grade = 90},
                new Student(){Name = "Mark", Course = "Information Technology", YearLevel = 3, Grade = 79},
                new Student(){Name = "Penelope", Course = "Computer Science", YearLevel = 3, Grade = 86},
                new Student(){Name = "Kenyster", Course = "Information Technology", YearLevel = 2, Grade = 76},
                new Student(){Name = "Jessa", Course = "Information Technology", YearLevel = 5, Grade = 81}
            };

            //

            //IEnumerable<Student> seniorStudents = from student in studentList
            //                                   where student.YearLevel > 3
            //                                   select student;

            var itStudents = from s in studentList where
                             s.Course == "Information Technology"
                             orderby s.Name descending
                             select s.Name;

            var studentGrade = from s in studentList where s.Course.Contains("Information Technology") 
                               select new
                                {
                                    Name = s.Name,
                                    FinalGrade = s.Grade * 1.2
                                };


            var studentByCourse = from s in studentList
                                  group s by s.Course into CourseGroup
                                  select new
                                  {
                                      Course = CourseGroup.Key,
                                      StudentList = CourseGroup.ToList()
                                  };

            foreach (var s in studentByCourse)
            {
                Console.WriteLine($"Course: {s.Course}");
                foreach(var person in s.StudentList)
                {
                    Console.WriteLine($"{person.Name}");
                }
                
            }


            var studentByYear = from s in studentList
                                orderby s.YearLevel
                                group s by s.YearLevel into YearGroup
                                select new
                                {
                                    Level =  YearGroup.Key,
                                    List = YearGroup.ToList(),
                                    StudentCount = YearGroup.ToList().Count
                                };

            foreach (var s in studentByYear)
            {
                Console.WriteLine($"Year Level: {s.Level}");
                Console.WriteLine($"Student Count: {s.StudentCount}");
                foreach(var p in s.List)
                {
                    Console.WriteLine(" |" + p.Name);
                }
            }
        }
    }


    class Student
    {
        private string name;
        private string course;
        private int yearLevel;
        private int grade;


        public string Name
        {
            get { return name; }
            set {
                if(String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("No name was entered!");
                }
                else
                {
                    name = value;
                }
                 }
        }

        public string Course
        {
            get { return course; }
            sets
            {
                course = value;
            }
        }

        public int YearLevel
        {
            get { return yearLevel; }
            set
            {    yearLevel = value;

            }
        }
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

    }

   
}
