using System;

namespace _04_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var kalories = volume * energy / 100.0;
            var sugar = volume * sugarContent / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kalories}kcal, {sugar}g sugars");
        }
    }
}
