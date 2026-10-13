using System;
using System.Collections.Generic;

namespace StackSample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Stack<int> mystack = new Stack<int>(5);

            //Console.WriteLine("Checking if the stack is empy.....");
            //if (mystack.Count == 5)
            //{
            //    Console.WriteLine("Stack is  full...");

            //    Environment.Exit(0);
            //}

            //Console.WriteLine("Insert Elements to the stack: ");
            //for (int i = 0; i < 5; i++)
            //{
            //    int element = Convert.ToInt32(Console.ReadLine());
            //    mystack.Push(element);
            //}

            //Console.WriteLine("Top Element: ", mystack.Peek());




            Dictionary<string, string> chores = new Dictionary<string, string>();

            chores.Add("Laundry", "Sam");
            chores.Add("Dishes", "John");
            chores.Add("Mop", "Daniel");

            foreach (var kvp in chores)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }


            if (chores.TryGetValue("Mop", out string result))
            {
                Console.WriteLine("Who is assign to Mop: " + result);
            }


            Dictionary<string, List<string>> family = new Dictionary<string, List<string>>();

            family.Add("Gomez", new List<string>() { "Wednesday", "Pudsley" });
            family.Add("Batoctoy", new List<string>() { "forcia", "Lorenze" });

            foreach (var kvp in family)
            {
                Console.WriteLine($"{kvp.Key}'s family:");
                foreach (var members in kvp.Value)
                {
                    Console.WriteLine(members);
                }
            }




            Console.ReadKey();









        }
    }
}
