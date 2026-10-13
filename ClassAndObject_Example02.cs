using System;

namespace ClassAndObjects03
{
    public class Arithmetic
    {
        public int num1;
        public int num2;

        public Arithmetic()
        {

        }
        public Arithmetic(int x, int y)
        {
            num1 = x;
            num2 = y;
        }

        //method with parameters but no return value
        public void Add(int n1, int n2)
        {
            Console.WriteLine($"Result: {n1 + n2}");
        }

        //method with parameters and return value
        public int Minus(int n1, int n2)
        {
            return n1 - n2;
        }

        //method without parameters but return an int value
        public int Multiply()
        {
            return num1 * num2;
        }

        //2 methods with the same method name but different parameters
        public void Divide()
        {
            Console.WriteLine($"1st Divide Method Result: {num1 / num2}");
        }
        public void Divide(int x, int y)
        {
            Console.WriteLine($"2nd Divide Method Result: {x / y}");
        }
    }
}
