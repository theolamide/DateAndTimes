using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime  myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());

            Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            Console.WriteLine(myValue.AddDays(-3).ToLongDateString()); //Past 3 days

            Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1969, 12, 7);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("04/02/1991");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.Write(myAge.TotalDays);
            Console.Write(" Days");
            Console.ReadLine();
        }
    }
}
