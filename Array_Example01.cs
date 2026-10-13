using System;
using System.Collections.Generic;

namespace ExampleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            //Initializing and Declaring an Array
            int[] intArray1 = new int[5];// Array Size 5 but no assign value
            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };//Array size 5 with assign value
            int[] intArray3 = { 1, 2, 3, 4, 5 }; //No array size but with assign value
                                                 // So the array automatically get the size based on the number of values

            // Declaring an Array
            string[] sArray1, sArray2;

            //Initializing an Array
            sArray1 = new string[5] { "Element 0", "Element 1", "Element2", "Element3", "Element4" };


            //Accessing an array element
            intArray1[0] = 1;
            intArray2[0] = 1;
            Console.WriteLine("{0},{1}", intArray1[0], intArray2[0]);
            intArray1[1] = 2;
            intArray2[1] = 2;
            Console.WriteLine("{0},{1}", intArray1[1], intArray2[1]);

            //accessing element through loop

            Console.Write("Using For Loop:");

            for (int i = 0; i < intArray3.Length; i++)
            {
                Console.Write(" " + intArray3[i]);
            }

            Console.Write("\n");


            Console.WriteLine("LIST");
            //Declaring a LIST
            List<int> randomlist = new List<int>();

            //Adding elements to the randomlist
            randomlist.Add(1);//index 0
            randomlist.Add(2); //index 1
            randomlist.Add(3);//index 2
            randomlist.Add(4);//index 3
            randomlist.Add(56);//index 4
            randomlist.Add(9385034);//index 5

            int[] rArray = { 1, 2, 3 };


            randomlist.AddRange(rArray);

            Console.WriteLine(randomlist.Count);
            Console.WriteLine("Before Removing");
            foreach (int i in randomlist)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Deleting Elements");

            randomlist.Remove(9385034);
            foreach (int i in randomlist)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Inserting Elements");
            randomlist.Insert(5, 50);
            foreach (int i in randomlist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Looking for Element 25");

            Console.WriteLine(randomlist.Contains(25));//return index 

            Console.WriteLine("Clearing Elements");
            randomlist.Clear();
            foreach (int i in randomlist)
            {
                Console.WriteLine(i);
            }



            List<string> names = new List<string> { "Jane", "David", "Edward" };
            names.Sort();
            names.ForEach(a => Console.WriteLine(a));



            /*Console.WriteLine("\n List Input");

            List<int> userInputList = new List<int>();

            int userput;

            for (int x = 0; x < 5; x++)
            {
                userput = Convert.ToInt32(Console.ReadLine());
                userInputList.Add(userput);
            }


            foreach (int x in userInputList)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("List Remove based on UserInput");

            Console.Read();*/



            Console.ReadKey();
        }
    }
}
