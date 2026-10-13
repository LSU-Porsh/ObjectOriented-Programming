namespace ClassAndObjects
{
    class Rectangle
    {
        double length;
        double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public string GetArea()
        {
            string area = $"The area of {length} and {width} is {length * width}";
            return area;
        }

        public string GetParameter()
        {
            string parameter = $"The perimeter of {length} and {width} is {2 * length + 2 * width}";
            return parameter;
        }
    }
}



Enter your astronaut name: Luna

Enter a tool to collect: Wrench
Luna collected Wrench.

Enter a tool to collect: Oxygen Tank
Luna collected Oxygen Tank.

Enter a tool to collect: none

Toolkit:
- Wrench
- Oxygen Tank

The spaceship is damaged! Do you want to repair it? (yes/no): yes
Luna attempts to repair the ship...

Choose a tool to use: Wrench
Luna uses Wrench to fix the spaceship!
Mission continues successfully!



Enter your astronaut name: Luna
Enter a tool to collect: none
Toolkit is empty.

The spaceship is damaged! Do you want to repair it? (yes/no): yes
Luna attempts to repair the ship...

Luna has no tools to repair with.
Failure... The mission ends here.


