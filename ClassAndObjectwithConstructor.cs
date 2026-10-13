using System;

namespace ClassAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating the object with constructor
            Person john = new Person("John", 30);
            john.address = "Ozamiz City";


            Console.WriteLine(john.name + "\n" + john.age + "\n" + john.address);
            john.DisplayDetails();
            john.GoWork();
            john.GoPlay("mobile legends");
            Console.WriteLine(john.IsEmployed(false));
            john.ChangeAddress("Butuan");
            john.DisplayDetails();

            //another object using the same class
            Person ian = new Person("Ian", 40);
            ian.address = "Davao";
            ian.DisplayDetails();
            ian.GoWork();
            ian.GoPlay("Valorant");
            ian.ChangeAddress("Manila");
            ian.DisplayDetails();

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
