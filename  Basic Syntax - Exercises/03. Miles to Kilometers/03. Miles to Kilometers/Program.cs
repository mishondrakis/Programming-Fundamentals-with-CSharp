using System;

namespace _03._Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            var kmResult = 1.60934 * miles;



            Console.WriteLine("{0:f2}", kmResult);
        }
    }
}
