using System;

namespace Module1_Activities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Apple = 100;
            int Grape = 0;
            int quantity = 0;


            for (int x = 0; x <= quantity; x++)
            {
                //display the current inventory of the fruits
                Console.WriteLine("Current Inventory:");
                string prompt = $"Apples: {Apple} \n " +
                                $"Grape: {Grape}\n \n";
                Console.WriteLine(prompt);

                //Display the selection of fruits and it corressponding number
                Console.WriteLine("Select Fruit: 1 - Apple, 2- Grape");
                //User-defined fruit selection
                int choice = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Input the recieve quantity or negative number to end transaction:");
                quantity = Convert.ToInt32(Console.ReadLine());
                //Conditional statement based on the selection of the fruit
                switch (choice)
                {
                    //statement for Apple
                    case 1:
                        Apple += quantity;
                        break;

                    case 2:
                        Grape += quantity;
                        break;
                }

                Console.WriteLine("\n\n");


            }



        }
    }
}
