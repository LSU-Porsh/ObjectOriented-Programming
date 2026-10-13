using System;

namespace StringExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime mydate = new DateTime(2025, 9, 25, 18, 38, 45);
            DateTime nowdate = DateTime.Now;
            Console.WriteLine(mydate.ToString());
            Console.WriteLine(nowdate.ToString());
            Console.WriteLine(nowdate.Year);
            Console.WriteLine(nowdate.Month);
            Console.WriteLine(nowdate.Day);
            Console.WriteLine(nowdate.Hour);
            Console.WriteLine(nowdate.Minute);
            Console.WriteLine(nowdate.Second);
            Console.WriteLine(nowdate.Millisecond);

            Console.WriteLine(mydate.ToLongDateString());
            Console.WriteLine(mydate.ToLongTimeString());
            Console.WriteLine(mydate.ToShortDateString());
            Console.WriteLine(mydate.ToShortTimeString());

            Console.WriteLine("Custom Date Format: " + mydate.ToString("MM/dd/yyyy"));
            Console.WriteLine("Custom Date Format: " + mydate.ToString("ddd, MM,dd,yy HH:mm:ss tt "));

            //adding days, months and years
            Console.WriteLine("Date for tomorrow: " + nowdate.AddDays(1).ToString("MM/dd/yyyy"));
            Console.WriteLine("Date after 20 days: " + nowdate.AddDays(20).ToString("MM/dd/yyyy"));
            Console.WriteLine("Date for a month: " + nowdate.AddMonths(1).ToString("MM/dd/yyyy"));
            Console.WriteLine("Date after 10 months: " + nowdate.AddMonths(10).ToString("MM/dd/yyyy"));
            Console.WriteLine("Date for a year: " + nowdate.AddYears(1).ToString("MM/dd/yyyy"));
            Console.WriteLine("Date after 100 years: " + nowdate.AddYears(100).ToString("MM/dd/yyyy"));

            //Subtraction
            //Timespan = days, hours, minutes

            DateTime bday = new DateTime(1999, 6, 25);
            TimeSpan age = nowdate.Subtract(bday);
            Console.WriteLine(age.Days + " " + age.Hours + " " + age.Minutes);

            //Getting the number of days of a month
            int daysInMonth = System.DateTime.DaysInMonth(2022, 2);
            Console.WriteLine("Number of Days in February: " + daysInMonth);

            //DateTime.Parse
            //string userDate = Console.ReadLine();
            //DateTime parsedDate = DateTime.Parse(userDate);
            //Console.WriteLine(parsedDate.ToString("MMMM dd, yyyy : dddd"));

            bool isLeap = DateTime.IsLeapYear(2022);
            Console.WriteLine("Is 2022 a leap year? " + isLeap);

            DateTime newdate = new DateTime(2025, 9, 22);
            var day = newdate.DayOfWeek;
            Console.WriteLine(day.ToString());

            DateTime date1 = new DateTime(2025, 12, 1);
            DateTime date2 = new DateTime(2025, 1, 5);

            int result = date1.CompareTo(date2);

            if (result < 0)
            {
                Console.WriteLine("Date1 is earlier than Date2");
            }
            else if (result == 0)
            {
                Console.WriteLine("Date1 and Date2 are the same");
            }
            else
            {
                Console.WriteLine("Date2 is earlier than Date1");
            }


            Console.ReadKey();

        }
    }
}
