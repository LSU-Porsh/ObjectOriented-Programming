using System;
using System.Collections.Generic;
namespace Dictionary_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Declare the dictionary
            Dictionary<int, string> records = new Dictionary<int, string>();
            //adding item to the dictionary
            records.Add(101, "Jane");
            records.Add(102, "John");
            records.Add(103, "James");

            foreach (var student in records)
            {
                Console.WriteLine($"ID: {student.Key},  Name: {student.Value}");
            }

            records.Remove(103);
            foreach (var student in records)
            {
                Console.WriteLine($"ID: {student.Key},  Name: {student.Value}");
            }

            bool isValue = records.ContainsValue("John");
            bool isKey = records.ContainsKey(103);

            Console.WriteLine($"John in the Dictionary: {isValue}, 103 in the Dictionary : {isKey}");
            Console.WriteLine("Items in the Dictionary: " + records.Count);


            Dictionary<string, List<string>> college = new Dictionary<string, List<string>>();

            //1st method

            college["CCSEA"] = new List<string> { "Computer Science", "Civil Engineering" };

            //2nd method

            college.Add("CBA", new List<string> { "Accountancy", "Business Administration" });

            //Display the items in the Dictionary
            foreach (var depart in college)
            {
                Console.WriteLine(depart.Key);
                foreach (string program in depart.Value)
                {
                    Console.WriteLine("  |" + program);
                }
            }

          
            //removing a item inside the List
            bool removed = college["CBA"].Remove("Accountancy");
            //checking if Computer Science exists inside CCSEA
            bool isExist = college["CCSEA"].Contains("Computer Science");

            foreach (var depart in college)
            {
                Console.WriteLine(depart.Key);
                foreach (string program in depart.Value)
                {
                    Console.WriteLine("  |" + program);
                }
            }

            Console.WriteLine("ComSci exist?:" + isExist);
        }
    }
}
