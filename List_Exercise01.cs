using System;
using System.Collections.Generic;
namespace ListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            string user;
            List<string> names = new List<string>();

            do//starting of do-while loop
            {
                //prints out the options
                Console.WriteLine("Select an option:");
                Console.WriteLine("A-Add Name \nB-Delete Name " +
                    "\nC-Check Name\nD-Display Names\n");
                Console.WriteLine("Enter a letter:");
                //asks for user input
                user = Console.ReadLine();

                //Will end the program if the user enter the word "exit"
                if (user == "Exit" || user == "exit")
                {
                    exit = true;
                    break;
                }

                switch (user)
                {
                    case "a":
                    case "A":
                        Console.WriteLine("\nEnter a name:");
                        //Adding Name
                        names.Add(Console.ReadLine());
                        Console.WriteLine("\nNAME LIST:");
                        names.ForEach(i => Console.WriteLine("- " + i));
                        break;
                    //Deleting a name
                    case "b":
                    case "B":
                        Console.WriteLine("Enter a name:");
                        string tempName = Console.ReadLine();
                        bool temp = names.Contains(tempName);
                        //Checking if a name exist before deleting
                        if (temp == false)
                        {
                            Console.WriteLine("---NAME DOES NOT EXIST--");

                        }
                        else
                        {
                            names.Remove(tempName);
                            Console.WriteLine("\n---NAME IS DELETED IN THE LIST---\n");
                        }

                        break;
                    //Checking if a name exist
                    case "c":
                    case "C":
                        Console.WriteLine("Enter a name:");
                        bool n = names.Contains(Console.ReadLine());
                        if (n == false)
                        {
                            Console.WriteLine("\n---NAME DOES NOT EXIST--");
                        }
                        else
                        {
                            Console.WriteLine("\n---NAME IS IN THE LIST---");
                        }
                        break;
                    //Sort the names alphabetically
                    case "d":
                    case "D":
                        names.Sort();
                        Console.WriteLine("List Of Names\n");
                        names.ForEach(i => Console.WriteLine("- " + i));
                        break;

                }
                Console.WriteLine("----------------------------");

            } while (!exit);



        }
    }
}
