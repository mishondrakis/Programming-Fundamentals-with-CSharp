using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameHeroes = Console.ReadLine();

            int health = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());

            int energy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            string currentHealth = "|" + new string('|', health) + new string('.', maximumHealth - health) + "|";
            string currentEnergy = "|" + new string('|', energy) + new string('.', maximumEnergy - energy) + "|";

            Console.WriteLine($"Name: {nameHeroes} \r\n Health: {currentHealth} \r\n Energy: {currentEnergy}");
        }
    }
}
