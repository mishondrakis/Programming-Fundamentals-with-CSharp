using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameDrink = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContentPer100 = int.Parse(Console.ReadLine());
            var sugarContentPer100 = int.Parse(Console.ReadLine());


            double energyTotal = 1.0 * energyContentPer100 * volume / 100;
            double sugartotal = 1.0 * sugarContentPer100 * volume / 100;




            Console.WriteLine("{0}ml {1}:\r\n{2}kcal, {3}g sugars", volume, nameDrink, energyTotal, sugartotal);
        }
    }
}
