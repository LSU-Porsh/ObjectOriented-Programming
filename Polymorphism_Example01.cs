using System;

namespace ClassResponsibility
{
    public class Sum
    {
        public int a;
        public int b;
        public void Add()
        {
            Console.WriteLine($"1st Method:Sum 0f {a} + {b} = {a + b}");
        }
        public void Add(int a, int b)
        {
            Console.WriteLine($"2nd Method:Sum 0f {a} + {b} = {a + b}");
        }

        public void Add(double a, double b)
        {
            Console.WriteLine($"3rd Method:Sum 0f {a} + {b}= {a + b} ");
        }

        public void Add(float a, float b)
        {
            Console.WriteLine($"4th Method:Sum 0f {a} + {b} = {a + b}");
        }

        public void Add(string a, string b)
        {
            Console.WriteLine($"5th Method:Sum 0f {a} + {b} =  {a + b}");
        }
    }
}



Code

Enter Player Name:
Enter Monster Name:
Start Encounter? (yes/no):

---------------------------------------------
Encounter begins! Smaug the Dragon appears!

Choose an action:
1. Attack
2. Cast Spell
3. Retreat
Enter:

Aria attacks with Staff! Smaug loses 15 HP.
Smaug roars menacingly!
Smaug attacks Aria! Aria loses 20 HP.

Current Stats
Player: Aria, HP = 80
Monster: Smaug, HP = 85




