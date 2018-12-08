using System;

namespace _02._AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}
