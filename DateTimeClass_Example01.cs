using System;

namespace DateTimeClass_Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DateTime mydate = new DateTime(2024, 9, 27, 15, 20, 52);
            Console.WriteLine(mydate.ToString());

            Console.WriteLine(mydate.Year);
            Console.WriteLine(mydate.Month);
            Console.WriteLine(mydate.Day);
            Console.WriteLine(mydate.Hour);
            Console.WriteLine(mydate.Minute);
            Console.WriteLine(mydate.Second);
            Console.WriteLine(mydate.Millisecond);

            Console.WriteLine(DateTime.Now);
            DateTime mydatenow = DateTime.Now;
            Console.WriteLine(mydatenow.ToString());
            Console.WriteLine("ToLongDate Method: " + mydatenow.ToLongDateString());
            Console.WriteLine("ToShortDate Method :" + mydatenow.ToShortDateString());
            Console.WriteLine("ToLongTime Method: " + mydatenow.ToLongTimeString());
            Console.WriteLine("ToShortTime Method: " + mydatenow.ToShortTimeString());

            Console.WriteLine(mydate.ToString("MMMM dddd yyyy HH:mm:ss:f"));

            DateTime upDate = mydatenow.AddDays(12);
            Console.WriteLine(upDate);
            upDate = mydatenow.AddMonths(10);
            Console.WriteLine(upDate);
            upDate = mydatenow.AddYears(5);
            Console.WriteLine(upDate);





            //DateTime date1 = new DateTime(2023, 3, 11, 10, 30, 0);
            //Console.WriteLine(date1);
            //Console.WriteLine(date1.Day);
            //Console.WriteLine(date1.Hour);
            //Console.WriteLine(date1.Minute);

            ////default value when no value is given to the object
            //DateTime defaultTime = new DateTime();
            //Console.WriteLine(defaultTime);


            ////Dateformat default/fixed
            //Console.WriteLine(date1.ToLongDateString());
            //Console.WriteLine(date1.ToShortDateString());
            //Console.WriteLine(date1.ToLongTimeString());
            //Console.WriteLine(date1.ToShortTimeString());

            ////Custom Formats

            ////The data type is DateTime, the variable name is "now"
            //DateTime now = DateTime.Now; //getting the Current time of the computer
            //Console.WriteLine(now.ToString("MMMM dd yyyy hh:mm"));

            ////assigns default value 01/01/0001 00:00:00
            //DateTime dt1 = new DateTime();
            //Console.WriteLine(dt1.ToString("MMMM dd yyyy hh:mm"));

            ////assigns year, month, day
            //DateTime dt2 = new DateTime(2015, 12, 31);
            //Console.WriteLine(dt2.ToString("MMMM dd yyyy"));

            ////assigns year, month, day, hour, min, seconds
            //DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            //Console.WriteLine(dt3.ToString("MMMM dd yyyy hh:mm:ss"));
            //Console.WriteLine(dt3.ToString("MMM dddd yyyy hhhh:mmmm:ssss"));


            //DateTime mycurrent = DateTime.Now;
            //Console.WriteLine($"My local time is {mycurrent.ToString()}");
            //Console.WriteLine("\"d\" -> {0}", mycurrent.ToString("d"));

            //Console.WriteLine("\"d/M/yy\" -> {0}", mycurrent.ToString("d/M/yy"));
            //Console.WriteLine("\"dd\" -> {0}", mycurrent.ToString("dd"));
            //Console.WriteLine("\"ddd\" -> {0}", mycurrent.ToString("ddd"));
            //Console.WriteLine("\"dddd\" -> {0}", mycurrent.ToString("dddd"));

            ////AM/PM
            //Console.WriteLine("\"hh:mm t\" -> {0}", mycurrent.ToString("hh:mm t"));
            //Console.WriteLine("\"hh:mm tt\" -> {0}", mycurrent.ToString("hh:mm tt"));
            ////timezone formats
            //Console.WriteLine("\"mm/dd/yy K\" -> {0}", mycurrent.ToString("MM/dd/yy K"));
            //Console.WriteLine("\"mm/dd/yy z\" -> {0}", mycurrent.ToString("MM/dd/yy z"));
            //Console.WriteLine("\"zz\" -> {0}", mycurrent.ToString("zz"));
            //Console.WriteLine("\"zzz\" -> {0}", mycurrent.ToString("zzz"));


            ////DateTime Methods
            //Console.WriteLine("is LeapYear?" + DateTime.IsLeapYear(2025));
            //Console.WriteLine(mycurrent.AddYears(2));


            Console.ReadKey();
        }
    }
}

