using System;

namespace ClassAndObjects02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creating an instance of Student Class in other words an object
            Student studentOne = new Student();

            //Setting values to the properties/attributes
            studentOne.Name = "Jane";
            studentOne.Id = 1;
            studentOne.grade = 85;
            studentOne.course = "Nursing";

            //creating an instance that has a contrustor value

            Student StudentTwo = new Student(2, "John Doe", 80, "Information Technology");

            //Calling a Method
            studentOne.DisplayStudentInfo();
            studentOne.TakingABreak("KINITTING");
            StudentTwo.DisplayStudentInfo();
            StudentTwo.TakingExam();

            Console.ReadKey();

        }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int grade;
        public string course;



        //constructor with  no paramaeters and no code to execute.
        public Student()
        {

        }

        public Student(int id, string name, int grade, string course)
        {
            //getting the given value to this class' id, name, grade, and course
            this.Id = id;
            this.Name = name;
            this.grade = grade;
            this.course = course;
        }

        //you add multiple constructors with different parameters 


        //Method Syntax :  access_modifier return_type method_name(parameter1, parameter2...){code to execute}

        public void DisplayStudentInfo()
        {

            Console.WriteLine($"Student Id : {Id} \n Student Name: {Name} \n Student GDP: {grade}");
        }

        public void TakingExam()
        {
            Console.WriteLine($"Student {Name} is having his/her exam.");
        }

        public void TakingABreak(string hobby)

        {

            //you add parameters to the method
            Console.WriteLine($"Student {Name} is taking a study beak by doing {hobby}");

        }

        public void ChoosingCourse()
        {
            Console.WriteLine($"Student {Name} is enrolling to {course}");
        }

    }

}
