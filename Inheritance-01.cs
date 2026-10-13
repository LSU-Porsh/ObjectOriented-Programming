using System;

namespace Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.brand = "Mustang";
            car.GoStart();
            car.GoStop();
            car.color = "Red";
            car.changeColor("Black");


            EV ev = new EV();
            ev.color = "Yellow";
            ev.brand = "Tesla";
            ev.changeColor("RED");
        }
    }
    class Vehicle
    {
        public string model;
        public string brand;
        public void GoStart()
        {
            Console.WriteLine($"{brand}-{model} is start to run.");
        }
        public void GoStop()
        {
            Console.WriteLine($"{brand}-{model} has stopped.");
        }
    }
    class Car : Vehicle
    {
        public string color;
        public virtual void changeColor(string color)
        {
            Console.WriteLine($"{brand} has changed  from {this.color} to {color}");
            this.color = color;

        }

    }
    class EV : Car
    {
        public string power;
        public override void changeColor(string color)
        {
            Console.WriteLine($"Basta change ang color. Then mas mahal ang bill");
            base.changeColor(color);
        }

    }


}
