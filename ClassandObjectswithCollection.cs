using System;
using System.Collections.Generic;

namespace ClassAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Person> grocery = new Queue<Person>();

            grocery.Enqueue(new Person("Jane", 50));
            grocery.Enqueue(new Person("Kirk", 18));

            foreach (Person customer in grocery)
            {
                Console.WriteLine($"Current Queue: {customer.name} ({customer.age})");
            }
        }
    }

    class Person
    {
        //Attributes or Fields
        public string name;
        public int age;
        public string address;

        //Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //Methods
        public void GoWork()
        {
            Console.WriteLine($"{name} is working.");
        }
        public void GoPlay(string game)
        {
            Console.WriteLine($"{name} is playing {game}");
        }
        public string IsEmployed(bool isemployed)
        {
            return isemployed ? $"{name} is employed" : $"{name} is not employed";
        }

        public void ChangeAddress(string newAdd)
        {
            address = newAdd;
            Console.WriteLine($"\n{name} is moving to {address}\n");
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name:{name} Address:{address} Age:{age}");
        }
    }
}
