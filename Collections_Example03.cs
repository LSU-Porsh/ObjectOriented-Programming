using System;
using System.Collections.Generic;

namespace Collection2026
{



    internal class Program
    {

        static void DisplayList(List<string> nameList)
        {
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
        }

        static void Displaystack(Stack<string> nameList)
        {
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
        }


        static void DisplayQueue(Queue<string> nameList)
        {
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {


            int[,] multi = new int[3, 2] { {5,1 },
                                            {4,2 },
                                            {3,3 } };


            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine($" i = {row}, j = {col} : {multi[row, col]}");
                }
            }


            //DEclaration of LIST
            List<string> nameList = new List<string> { "Juan", "Carlos", "Mark", "Veronica" };
            nameList.Add("Kirk");

            Console.WriteLine("====Adding to List");
            DisplayList(nameList);


            string[] tempnames = new string[2] { "Leroy", "Lilo" };
            nameList.AddRange(tempnames);

            Console.WriteLine("====Adding to List using AddRange");
            DisplayList(nameList);


            Console.WriteLine("====Adding to List using Insert");
            nameList.Insert(5, "Jorence");
            DisplayList(nameList);

            Console.WriteLine("====Removing to List ");
            nameList.Remove("Leroy");
            DisplayList(nameList);

            Console.WriteLine("====Removing a value in List using RemoveAt ");
            nameList.RemoveAt(2);
            DisplayList(nameList);

            Console.WriteLine("====Counting the values inside nameList ");
            Console.WriteLine(nameList.Count);

            Console.WriteLine("====Finding Lilo using Contains");
            Console.WriteLine("is Lilo in the List?:" + (nameList.Contains("Lilo") ? "Yes" : "No"));



            Stack<string> colors = new Stack<string>();
            colors.Push("Magenta");
            colors.Push("Blue");
            colors.Push("Purple");

            Console.WriteLine("====Inside Stacks");
            Displaystack(colors);

            Console.WriteLine("====Peek in Stacks");
            Console.WriteLine(colors.Peek());


            Console.WriteLine("====Remove item in Stacks");
            Console.WriteLine("Removing this color: " + colors.Pop());
            Displaystack(colors);

            Console.WriteLine("====Number of items in Stacks");
            Console.WriteLine("Removing this color: " + colors.Contains("Pink"));

            Queue<string> customers = new Queue<string>();

            customers.Enqueue("Mark");
            customers.Enqueue("Maria");
            customers.Enqueue("Vincent");
            customers.Enqueue("Christian");
            Console.WriteLine("====Current Queue");
            DisplayQueue(customers);
            Console.WriteLine("====Current Serving Customer");
            Console.WriteLine(customers.Peek());
            Console.WriteLine("====Customer Served:");
            Console.WriteLine(customers.Dequeue());
            Console.WriteLine("====Current Queue");
            DisplayQueue(customers);



        }
    }
}
