using System;

namespace ClassAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating the object
            Person john = new Person();
            //Setting values to the Attributes
            john.name = "John";
            john.address = "Ozamiz City";
            john.age = 30;

            Console.WriteLine(john.name + "\n" + john.age + "\n" + john.address);
            john.DisplayDetails();
            john.GoWork();
            john.GoPlay("mobile legends");
            Console.WriteLine(john.IsEmployed(false));
            john.ChangeAddress("Butuan");
            john.DisplayDetails();

            //another object using the same class
            Person ian = new Person();
            ian.name = "Ian";
            ian.address = "Davao";
            ian.age = 40;
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
