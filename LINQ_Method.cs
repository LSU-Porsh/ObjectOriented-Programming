using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>

            {   
                //atleast 2 < 75
                // atleast 2> 90
                //atleast 2 > 80
                //atleast 2 > 75
                new Student(){Id=1, Name="Henry", Age=22, Subject ="Art", Grade = 88},
                new Student(){Id=2, Name="Penelope", Age=23, Subject ="English", Grade = 85},
                new Student(){Id=3, Name="Anna", Age=18, Subject ="Science", Grade = 75},
                new Student(){Id=4, Name="Hannah", Age=15, Subject ="Art", Grade = 92},
                new Student(){Id=5, Name="Yumi", Age=20, Subject ="PE", Grade = 90},
                new Student(){Id=6, Name="Sam", Age=22, Subject ="Art", Grade = 88},
                new Student(){Id=7, Name="Leo", Age=24, Subject ="English", Grade = 86},
                new Student(){Id=8, Name="Mari", Age=19, Subject ="Math", Grade = 78},
                new Student(){Id=9, Name="Karena", Age=28, Subject ="Art", Grade = 95},
                new Student(){Id=10, Name="Paul", Age=16, Subject ="Science", Grade = 74}
            };
            //Method Syntax

            //Where

            var studentLegal = students
                                .Where(s => s.Age > 18)
                                .OrderByDescending(s => s.Name)
                                .Select(s => $"Student: {s.Name} Age : {s.Age}");

                    

            foreach(var s in studentLegal)
            {
                Console.WriteLine($"{s}");
            }


            var highestScore = students.Max(s => s.Grade);
            Console.WriteLine($"The highest score: {highestScore}");
            var lowestScore = students.Min(s => s.Grade);
            Console.WriteLine($"The lowest score: {lowestScore}");
            var averageScore = students.Average(s => s.Grade);
            var averageAge = students.Average(s => s.Age);
            Console.WriteLine($"The average score: {averageScore}");
            Console.WriteLine($"The average age: {averageAge}");
            var sumGrade = students.Sum(s => s.Grade);
            Console.WriteLine($"The sum of grade: {sumGrade}");
            //Contains

            var is18 = students
                .Select(s => s.Age)
                .Contains(18);


            Console.WriteLine($"is there an 18 yrs old student: {is18}");
            //take
            var first3Students = students.Take(3);
               
            foreach (var s in first3Students)
            {
                Console.WriteLine($"{s.Name}");
            }
            //last

            var skip2students = students.Skip(2);

            foreach (var s in skip2students)
            {
                Console.WriteLine($"{s.Name}");
            }

            

            //Quantifier
            var alllegal = students.All(s => s.Age > 18);
            Console.WriteLine(alllegal);

            var anyminors = students.Any(s => s.Age < 18);
            Console.WriteLine(anyminors);

            //grouping by subject

            var subjectgroup = students.GroupBy(s => s.Subject);

            foreach(var s in subjectgroup)
            {
                Console.WriteLine("-" + s.Key);
                foreach (var x in s) {
                    Console.WriteLine($" {x.Name}");
                        }
            }
        }
    }





}

    class Student
    {
        private int id;
        private string name;
        private int age;
        private string subject;
        private int grade;


        public int Id {
            get { return id; }
            set { id = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
        public string Subject {
            get { return subject; }
            set { subject = value; }
        }
        public int Grade {
            get { return grade; }
            set { grade = value; }
        }
    }


 



