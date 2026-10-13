namespace CollectionSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====LIST OUTPUT SAMPLE===");
//Declaring and Initializing a List
List<string> nameList = new List<string> { "Maria", "Jane", "Joshua" };

foreach (string name in nameList)
{
    Console.WriteLine(name + ", ");
}

//Adding element to the List
nameList.Add("Mark");
foreach (string name in nameList)
{
    Console.WriteLine(name + ", ");
}

//Accessing an element
Console.WriteLine(nameList[1]);

//Removing using element value
nameList.Remove("Maria");
foreach (string name in nameList)
{
    Console.WriteLine(name + ", ");
}

//Removing value using index
Console.WriteLine("============================");
nameList.RemoveAt(2);
foreach (string name in nameList)
{
    Console.WriteLine(name + ", ");
}
string[] newNames = { "James", "Margaret", "Vincent" };
nameList.AddRange(newNames);

//adding multiple values to the List
Console.WriteLine("============");
foreach (string name in nameList)
{
    Console.WriteLine(name + ", ");
}

//clearing the list
Console.WriteLine("=============");
nameList.Clear();
foreach (string name in nameList)
{
    Console.WriteLine(name + ", ");
}

//
string[] arrayName = nameList.ToArray();

Console.WriteLine("=====STACK OUTPUT SAMPLE===");


Stack<string> nameStack = new Stack<string>();
nameStack.Push("Juan");
nameStack.Push("Tuesday");
nameStack.Push("Vincent");

foreach (string name in nameStack)
{
    Console.WriteLine(name + ", ");
}

Console.WriteLine("Using Peek Method: " + nameStack.Peek());
Console.WriteLine("Popping the Last In value:" + nameStack.Pop());
foreach (string name in nameStack)
{
    Console.WriteLine(name + ", ");
}

Console.WriteLine("Is Juan inside the stack?:" + (nameStack.Contains("Juan") ? "Yes" : "No"));
Console.WriteLine("Number of Items inside the Stack:" + nameStack.Count);


Console.WriteLine("=====QUEUE OUTPUT SAMPLE===");

Queue<string> customer = new Queue<string>();
//adding names to the customer queue
customer.Enqueue("One");
customer.Enqueue("Two");
customer.Enqueue("Three");
customer.Enqueue("Four");

foreach (string name in customer)
{
    Console.Write(name + ", ");
}
// Peeking at the first value added
Console.WriteLine("\nCustomer Currently Serving:" + customer.Peek());
//Removing the first value added
Console.WriteLine("Customer Served:" + customer.Dequeue());
Console.WriteLine("Current Queue:");

foreach (string name in customer)
{
    Console.Write(name + ", ");
}

            //DICTIONARY

            Dictionary<int, string> data = new Dictionary<int, string>();

            data.Add(1, "Forcia");
            data.Add(2, "John");
            data.Add(3, "James");


            foreach (var item in data)
            {
               Console.WriteLine(item.Key + "  -" + item.Value);
            }

                //Reversing the word HELLO
            string word = "hello";
            Stack<char> stack = new Stack<char>();

            foreach (char c in word)
            {
               stack.Push(c);
            }

            Console.Write("Reversed word: ");
            while (stack.Count > 0)
            {
               Console.Write(stack.Pop());
            }







        }
    }
}


