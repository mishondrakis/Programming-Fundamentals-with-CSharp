using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal weight = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());


            var sum = weight * height;

            Console.WriteLine("{0:f2}", sum);
        }
    }
}
