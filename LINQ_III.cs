using System;
using System.Collections.Generic;
using System.Configuration;
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
                new Student(){StudentID= 1, Name = "Stella", Course = "Information Technology", YearLevel = 1, Grade = 85},
                new Student(){StudentID= 2, Name = "Kurt", Course = "Civil Engineering", YearLevel = 2,  Grade = 84},
                new Student(){StudentID= 3, Name = "James", Course = "Nursing", YearLevel = 4, Grade = 75},
                new Student(){StudentID= 4, Name = "Lance", Course = "Accounting", YearLevel = 5, Grade = 90},
                new Student(){StudentID= 5, Name = "Mark", Course = "Information Technology", YearLevel = 3, Grade = 79},
                new Student(){StudentID=7 , Name = "Kenyster", Course = "Information Technology", YearLevel = 2, Grade = 76},
                new Student(){StudentID= 8, Name = "Jessa", Course = "Information Technology", YearLevel = 5, Grade = 81},
              
            };

            List<Scores> studentRecord = new List<Scores>
            {
                new Scores(){StudentID= 1, Score =100 },
                 new Scores(){StudentID= 2, Score =75 },
                  new Scores(){StudentID= 3, Score =55 },
                   new Scores(){StudentID= 4, Score =35 },
                    new Scores(){StudentID= 2, Score =88 },
                     new Scores(){StudentID= 2, Score =95 },
                      new Scores(){StudentID= 5, Score =55 },
                       new Scores(){StudentID= 6, Score =95 },
                        new Scores(){StudentID= 7, Score =98 },
            };


            //Join Query

            var getStudentScores = from sc in studentRecord
                                   join s in studentList on sc.StudentID equals s.StudentID
                                   orderby s.Name 
                                   select new
                                   {
                                       Name = s.Name,
                                       Course = s.Course,
                                       Scores = sc.Score

                                   };

            foreach (var s in getStudentScores)
            {
                Console.WriteLine($"Name:{s.Name} - Scores {s.Scores}");
               
            }
                                    

        }
    }


    class Student
    {
        private string name;
        private string course;
        private int yearLevel;
        private int grade;
        private int studentid;
        public int StudentID
        {
            get { return studentid; }
            set { studentid = value; }
        }

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
            set
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


    class Scores
    {
        private int studentID;
        private int score;

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

    }

}
