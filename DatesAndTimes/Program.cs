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

            Console.ReadLine();

        }
    }
}
