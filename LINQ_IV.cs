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
                new Student(){Name = "Jessa", Course = "Information Technology", YearLevel = 5, Grade = 81},
                 new Student(){Name = "Henry", Course = "Nursing", YearLevel = 4, Grade = 80},
                  new Student(){Name = "Sammy", Course = "Nursing", YearLevel = 2, Grade = 85},
                   new Student(){Name = "Xavier", Course = "Nursing", YearLevel = 1, Grade = 78},
                new Student(){Name = "Callum", Course = "Nursing", YearLevel = 3, Grade = 91}
            };

            //1st Query

            var studentNames = from s in studentList
                               orderby s.Name descending
                               where s.Course == "Information Technology"
                               where s.YearLevel > 3
                               select s;

            //Method
            var studentnamelist = studentList
                .Where(s => s.Course == "Information Technology" && s.YearLevel > 3);              

                                
     
            foreach (var s in studentnamelist)
            {
                Console.WriteLine($"{s.Name} - {s.Course} - {s.YearLevel}");
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
            set
            {
                if (String.IsNullOrEmpty(value))
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
            set
            {
                course = value;
            }
        }

        public int YearLevel
        {
            get { return yearLevel; }
            set
            {
                yearLevel = value;

            }
        }
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

    }


}
