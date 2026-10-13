using System;

namespace Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.brand = "Porsche";
            car.model = "Basta";
            car.license = "something";
            car.Go();
            car.GoStop();

            ATV atv = new ATV();
            atv.GoStop();
        }
    }
    class Vehicle
    {
        public string model;
        public string brand;
        public string license;

        public void Go()
        {
            Console.WriteLine($"{brand}-{model} is running");
        }
        public virtual void GoStop()
        {
            Console.WriteLine($"{brand}-{model} has stopped");
        }
    }

    class Car : Vehicle
    {
        public int numofWheels;
        public void InfoDisplay()
        {
            Console.WriteLine($"{brand}-{model} has {numofWheels}");
        }
    }

    class ATV : Car
    {
        public override void GoStop()
        {
            Console.WriteLine($"Running in terrain");
            base.GoStop();
        }
    }

}

